using ProjectClasses.LogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class ShiftManager
    {
        private DBMediatorShifts dbMediator;
        public ShiftManager(DatabaseType databaseType)
        {
            dbMediator = new DBMediatorShifts(databaseType);
        }

        //AutomaticSchedule
        public WeekSchedule CreateWeekSchedule(DateTime date,Department department)
        {
            WeekSchedule newSchedule = new WeekSchedule(date,department);
            return newSchedule;
        }
        public WeekSchedule CreateWeekSchedule(DateTime date)
        {
            WeekSchedule newSchedule = new WeekSchedule(date);
            return newSchedule;
        }
        public void SaveGeneratedSchedule(WeekSchedule schedule)
        {
            dbMediator.SaveSchedule(schedule);
        }
        public WeekSchedule GetSchedule(DateTime date,Department department)
        {
            WeekSchedule newSchedule = new WeekSchedule(date, department);
            foreach (Shift shift in newSchedule.GetAllShifts())
            {
                shift.GetAssignedEmployees().Clear();
            }
            return dbMediator.FillSchedule(newSchedule);
        }
        public WeekSchedule GetSchedule(DateTime date)
        {
            WeekSchedule newSchedule = new WeekSchedule(date);
            foreach (Shift shift in newSchedule.GetAllShifts())
            {
                shift.GetAssignedEmployees().Clear();
            }
            return dbMediator.FillScheduleStockWorkers(newSchedule);
        }
    }
}
