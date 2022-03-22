using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectClasses
{
    public class Employee
    {
        //Instance variables
        private int id;
        private string bsn;
        private string firstName;
        private string lastName;
        private Gender gender;
        private string email;
        private string username;
        private DateTime birthDay;
        private string addrStreet;
        private string addrStreetNumber;
        private string addrZipcode;
        private string addrTown;
        private string addrCountry;
        private DateTime firstWorkingDay;
        private string emergencyPhoneNumber;
        private string iban;
        private double hourlyWage;
        private DateTime contractStartDate;
        private ContractType contract;
        private EmployeeType position;

        //Properties
        public int Id
        {
            get { return this.id; }
            private set
            {
                if (value >= 0)
                { this.id = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string BSN
        {
            get { return this.bsn; }
            private set
            {
                if (value != "")
                { this.bsn = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string Street
        {
            get { return this.addrStreet; }
            private set
            {
                if (value != "")
                { this.addrStreet = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string StreetNumber
        {
            get { return this.addrStreetNumber; }
            private set
            {
                if (value != "")
                { this.addrStreetNumber = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string Zipcode
        {
            get { return this.addrZipcode; }
            private set
            {
                if (value != "")
                { this.addrZipcode = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string Town
        {
            get { return this.addrTown; }
            private set
            {
                if (value != "")
                { this.addrTown = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string Country
        {
            get { return this.addrCountry; }
            private set
            {
                if (value != "")
                { this.addrCountry = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string FirstName
        {
            get { return this.firstName; }
            private set
            {
                if (value != "")
                { this.firstName = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            private set
            {
                if (value != "")
                { this.lastName = value; }
                else
                    throw new ArgumentException();
            }
        }
        public Gender Gender
        {
            get { return this.gender; }

            set { this.gender = value; }
        }
        public string Username
        {
            get { return this.username; }
            private set
            {
                if (value != "")
                { this.username = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string Birthday
        {
            get { return this.birthDay.ToString("yyyy-MM-dd"); }

        }
        public DateTime BirthDay
        {
            set { this.birthDay = value; }
        }
        public string FirstWorkingDay
        {
            get { return this.firstWorkingDay.ToString("yyyy-MM-dd"); }
        }
        public DateTime FirstWorkingday
        {
            set { this.firstWorkingDay = value; }
        }
        public string Email
        {
            get { return this.email; }
            private set
            {
                if (value != "")
                { this.email = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string PhoneNumber
        {
            get { return this.emergencyPhoneNumber; }
            private set
            {
                if (value != "")
                { this.emergencyPhoneNumber = value; }
                else
                    throw new ArgumentException();
            }
        }
        public EmployeeType Position
        {
            get { return this.position; }

            set { this.position = value; }
        }
        public string ContractStartDate
        {
            get { return this.contractStartDate.ToString("yyyy-MM-dd"); }
        }
        public ContractType Contract
        {
            get { return this.contract; }
            set { this.contract = value; }
        }
        public double HourlyWage
        {
            get { return this.hourlyWage; }

            private set
            {
                if (value > 0)
                { this.hourlyWage = value; }
                else
                    throw new ArgumentException();
            }
        }
        public string Iban
        {
            get { return iban; }

            private set
            {
                if (value != "")
                { this.iban = value; }
                else
                    throw new ArgumentException();
            }
        }

        public string GetNames
        {
            get { return $"ID: {this.id} {this.firstName} {this.lastName}"; }
        }
        public string GetAddress
        {
            get { return $"{addrStreet} {addrStreetNumber}; {addrZipcode}; {addrCountry}, {addrTown}"; }
        }
        public string GetEmployeeNames
        {
            get { return $"{this.firstName} {this.lastName}"; }
        }
        public string GetInfo
        {
            get { return $"ID: {this.Id}      {this.firstName} {this.lastName} \t- {this.Position}\t Contract: {this.Contract}"; }
        }

        //Constructor
        public Employee(int id, string bsn, string firstName, string lastName,
                         Gender gender, string email, string username, DateTime birthDay,
                         string addrStreet, string addrStreetNumber, string addrZipcode,
                         string addrTown, string addrCountry, DateTime firstWorkingDay,
                         string emergencyPhoneNumber, string iban, double hourlyWage,
                         DateTime contractStartDate, ContractType contract, EmployeeType position)
        {
            if (firstWorkingDay<birthDay)
            {
                throw new ArgumentException();
            }
            this.Id = id;
            this.BSN = bsn;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.gender = gender;
            this.Street = addrStreet;
            this.StreetNumber = addrStreetNumber;
            this.Zipcode = addrZipcode;
            this.Town = addrTown;
            this.Country = addrCountry;
            this.Email = email;
            this.Username = username;
            this.birthDay = birthDay;
            this.firstWorkingDay = firstWorkingDay;
            this.PhoneNumber = emergencyPhoneNumber;
            this.Iban = iban;
            this.HourlyWage = hourlyWage;
            this.contractStartDate = contractStartDate;
            this.Contract = contract;
            this.Position = position;
        }

        //Method/s
        public override string ToString()
        {
            return $"Id: {id}\t  {firstName} {lastName} - {position}";
        }
        public int GetMaxContractualHours()
        {
            switch (this.Contract)
            {
                case ContractType.FULLTIME:
                    {
                        return 40;
                    }
                case ContractType.EIGHTYPERCENT:
                    {
                        return 32;
                    }
            }
            return -1;
        }
    }
}