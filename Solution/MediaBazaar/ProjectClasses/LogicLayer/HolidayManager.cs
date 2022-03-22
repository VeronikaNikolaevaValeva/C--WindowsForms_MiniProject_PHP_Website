using MediaBazaar.UserControls;
using ProjectClasses.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses.LogicLayer
{
    public class HolidayManager
    {
        private List<Holiday> holidays;
        private DBMediatorHoliday dbMediator;
        public HolidayManager(DatabaseType databaseType)
        {
            this.holidays = new List<Holiday>();
            this.dbMediator = new DBMediatorHoliday(databaseType);
        }
        public Holiday[] GetRequestedHolidays()
        {
            return dbMediator.GetRequestedHolidays().ToArray();
        }
        public Holiday[] GetHolidays()
        {
            return dbMediator.GetHolidays().ToArray();
        }
        public Holiday[] GetRequestedHolidaysByRequestedTime()
        {
            return dbMediator.GetRequestedHolidays().OrderBy(x => x.RequestedDate).ToArray();
        }
        public Holiday[] GetRequestedHolidaysByEmployee()
        {
            return dbMediator.GetRequestedHolidays().OrderBy(x => x.EmployeeBsn).ToArray();
        }
        public Holiday[] GetHolidaysByEmployee()
        {
            return dbMediator.GetHolidays().OrderBy(x => x.EmployeeBsn).ToArray();
        }
        public Holiday[] GetHolidaysByStartDate()
        {
            return dbMediator.GetHolidays().OrderBy(x => x.StartDate).ToArray();
        }
        public Holiday GetRequestedHolidayById(int id)
        {
            Holiday foundHoliday=dbMediator.GetRequestedHoliday(id);
            if (foundHoliday != null)
            {
                return foundHoliday;
            }
            throw new NotExistingHolidayException("There is no requested holiday with this ID!");

        }
        public void DenyRequestedHoliday(int id)
        {
            if (dbMediator.RemoveRequestedHoliday(id)== false)
            {
                throw new NotExistingHolidayException("There is no requested holiday with this ID!");
            }

        }
        public void DeleteHoliday(int id)
        {
            if (dbMediator.DeleteHoliday(id) == false)
            {
                throw new NotExistingHolidayException("There is no requested holiday with this ID!");
            }

        }
        public void RegisterNewHoliday(Holiday newHoliday)
        {
            if (dbMediator.RegisterNewHoliday(newHoliday.EmployeeBsn,newHoliday.StartDate,newHoliday.EndDate) == false)
            {
                throw new ExistingHolidayException();
            }
           
        }
    }
}
