using System;
using System.Collections.Generic;
using System.Text;

namespace SQLConnection.Model
{
    public class Supervisor
    {
        public int SupervoiserId { get; set; }
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
                if (string.IsNullOrWhiteSpace(value) || value.Trim().Length < 1)
                {
                    throw new ArgumentException("Name cannot be empty or lower then 1");
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

        public Supervisor()
        {

        }

    }
}
