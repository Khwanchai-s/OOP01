using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal class Employees
    {
        //field/attribute
        private int _id;
        private string _name="";
        private double _salary; 
        private int _age;       
        private string _email="";

        public int ID 
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Salary 
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


    }
}
