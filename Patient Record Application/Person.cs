using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patient_Record_Application
{
    public class Person 
    {
        private String name;
        private string gender;
        private DateTime dob = DateTime.Now;
        private int age;
        private String dept;
        private String ward;
        private String docInCharge;
        private Address workAddress = new Address();

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Gender
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

        public Address WorkAddress
        {
            get
            {
                return workAddress;
            }
            set
            {
                workAddress = value;
            }
        }

        public DateTime Dob
        {
            get
            {
                return dob;
            }
            set
            {
                dob = value;
            }
        }
       
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Dept
        {
            get
            {
                return dept;
            }
            set
            {
                dept = value;
            }
        }

        public string Ward
        {
            get
            {
                return ward;
            }
            set
            {
                ward = value;
            }
        }

        public string DocInCharge
        {
            get
            {
                return docInCharge;
            }
            set
            {
                docInCharge = value;
            }
        }

    }

}
