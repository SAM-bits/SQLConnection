using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string _firstName;
        public string _lastName;
        public string _phoneNumber;
        public string _email;
        public DateTime HireDate { get; set; }
        public decimal HourlyPay { get; set; }

        //string

        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 2)
                {
                    throw new ArgumentException("Name cannot be empty or lower then 2");
                }
                foreach (char character in value)
                {
                    if (char.IsLetter(character) == false)
                    {
                        throw new ArgumentException("Name can only have Characters");
                    }
                }

                _firstName = value;
            }
        }

        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 1)
                {
                    throw new ArgumentException("Name cannot be empty or lower then 1");
                }
                _lastName = value;
            }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 7)
                {
                    throw new ArgumentException("Phone number cannot be empty or lower then 7");
                }
                foreach (char numbersOnly in value)
                {
                    if (char.IsNumber(numbersOnly) == false && char.IsSymbol(numbersOnly) == false)
                    {
                        throw new ArgumentException("Phone number can only accept Numbers ");
                    }
                }
                _phoneNumber = value;
            }
        }

        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 7 || !value.Contains('@') && !value.Contains('.'))
                {
                    throw new ArgumentException("Email must contain @ and . ");
                }
                _email = value;
            }
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return
                $"Employee Id : {EmployeeId}\n" +
                $"First Name : {FirstName}\n" +
                $"Last Name : {LastName}\n" +
                $"Phone Number: {PhoneNumber}\n" +
                $"Email: {Email}\n" +
                $"Date of hire: {HireDate}\n" +
                $"Hurly pay : {HourlyPay} KR\n";
        }
    }
}