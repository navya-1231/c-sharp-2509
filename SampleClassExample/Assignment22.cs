using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleClassExample
{
    public class University
    {
        private List<Department> departments = new List<Department>();

        public void AddDepartment(string name)
        {
            departments.Add(new Department(name));
        }

        public void AddCourse(string departmentName, string courseName, string courseCode, int credits)
        {
            var department = departments.Find(d => d.Name == departmentName);
            if (department != null)
            {
                department.Courses.Add(new Course(courseName, courseCode, credits));
            }
        }

        public void DisplayCourseInformation()
        {
            foreach (var department in departments)
            {
                Console.WriteLine("Department: " + department.Name);
                foreach (var course in department.Courses)
                {
                    Console.WriteLine($"  Course: {course.CourseName}, Code: {course.CourseCode}, Credits: {course.Credits}");
                }
            }
        }

        public class Department
        {
            public string Name { get; set; }
            public List<Course> Courses { get; set; }

            public Department(string name)
            {
                Name = name;
                Courses = new List<Course>();
            }
        }

        public class Course
        {
            public string CourseName { get; set; }
            public string CourseCode { get; set; }
            public int Credits { get; set; }

            public Course(string courseName, string courseCode, int credits)
            {
                CourseName = courseName;
                CourseCode = courseCode;
                Credits = credits;
            }
        }
    }

}
