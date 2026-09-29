using Microsoft.AspNetCore.Mvc;
using q7.Models;

namespace q7.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id = 1,
                    Name = "Anil",
                    Address = "Lalitpur",
                    College = "Himalaya College"
                },

                new Student
                {
                    Id = 2,
                    Name = "Nelson",
                    Address = "Kathmandu",
                    College = "Himalaya College"
                },

                new Student
                {
                    Id = 3,
                    Name = "Prajwal",
                    Address = "Bhaktapur",
                    College = "Himalaya College"
                },

                new Student
                {
                    Id = 4,
                    Name = "Ramesh",
                    Address = "Lalitpur",
                    College = "KCT"
                },

                new Student
                {
                    Id = 5,
                    Name = "Nisha",
                    Address = "Kathmandu",
                    College = "KCT"
                }
            };

            return View(students);
        }
    }
}
