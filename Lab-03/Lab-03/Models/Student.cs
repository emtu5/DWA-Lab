using Lab_03.Models.Base;

namespace Lab_03.Models
{
    public class Student: BaseEntity
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Birthday { get; set;}
    }
}
