using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01
{
    internal class firstclass
    {
        //attribute / field
        private string devname = "ชื่อตัวเอง";
        private string devstart = "25 ธันวาคม 2566";
        //Property
        public int ID { get; set; }
        public string FullName { get; set; }

        
        //constructor
        public firstclass() 
        {
            FullName = "khwanchai.s";
            ID = 1;
        }

        public firstclass(int id, string fullname)
        {
            FullName = fullname;
            ID = id;
        }




    }
}
