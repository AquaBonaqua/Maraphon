using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maraphonapp
{
    public partial class Runner
    {    // метод вычисления возраста
        public int getYear
        {
            get
            {   
                //var a = DateOfBirth.ToString();
                //var b = a.Split('.');
                //var c = b[2].Split(' ');
                //return DateTime.Now.AddYears(-Convert.ToInt32(c[0])).Year;
                DateTime now = DateTime.Today;
                int age = now.Year - DateOfBirth.Value.Year;

                return age;
            }
        }
    }

}