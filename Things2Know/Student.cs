using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Things2Know
{
    public class Student
    {
        private string name;
        public string Name { get { return name; } set { if (!string.IsNullOrEmpty(value)) name = value; } }


        public string LastName { get; protected set; } = "Kuku";  
    }

    public class  Train<Z>
    {
        Z[] passangers;
        public int count { get; set; } = 0;
    }
}
