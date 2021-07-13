using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity3BL
{
    public class Customer
    {

        private string address;
        public int currentValueForCustomerId;
        private int customerId;
        private string customerName;
        private DateTime dateOfBirth;
        private string emailId;
        private Gender gender;
        private string password;


        public string Address
        {
            get
            {
               return address;
            }
            set
            {
                address = value;
            }
        }
        public int CustomerId {
            get
            {
                return customerId;
            }

            set
            {
                customerId = value;
            }
             }
        public string CustomerName {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
           }
        public DateTime DateOfBirth
        {
            get
            {
                return dateOfBirth;
            }

            set
            {
                dateOfBirth = value;
                
            }
        }
        public string EmailId
        {
            get
            {
                return emailId;
            }

            set
            {
                emailId = value;
            }
        }
        public Gender Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }
        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        static Customer()
        {

        }

        public Customer()
        {

        }

        public Customer(string CustomerName, string Address, DateTime DateOfBirth, string EmailId, Gender Gender, string Password)
        {

        }
       
    }
}