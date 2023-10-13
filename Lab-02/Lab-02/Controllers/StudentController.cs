using Lab_02.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab_02.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ana", Age = 22},
            new Student { Id = 2, Name = "Bianca", Age = 21},
            new Student { Id = 3, Name = "Carmen", Age = 20},
            new Student { Id = 4, Name = "Daria", Age = 19},
            new Student { Id = 5, Name = "Elena", Age = 18},
        };

        [HttpGet]
        public List<Student> GetAllOrdered()
        {
            return students.OrderBy(s => s.Age).ToList();
        }

        [HttpPost]
        public List<Student> Add(Student student)
        {
            student.Id = students.Count() + 1;
            students.Add(student);
            return students;
        }

        [HttpDelete]
        public List<Student> Delete(Student student)
        {
            var studentIndex = students.FindIndex(s => s.Id == student.Id);
            students.RemoveAt(studentIndex);
            return students;
        }

        [HttpDelete("{id:int}")]
        // nu inteleg inca de ce trebuie sa adaug {id:int}
        // https://stackoverflow.com/a/38968981
        // https://stackoverflow.com/a/59287588

        public List<Student> DeleteById(int id)
        {
            var studentIndex = students.FindIndex(s => s.Id == id);
            students.RemoveAt(studentIndex);
            return students;
        }

        
    }
}
