using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_01
{
    public class Student
    {
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string CNP { get; set; }
        public string NrMatricol { get; set; }
        public List <Materie> Materii { get; set; }
    }
}
