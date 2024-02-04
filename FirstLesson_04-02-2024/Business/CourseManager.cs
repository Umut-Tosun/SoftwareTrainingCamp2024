using FirstLesson_04_02_2024.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstLesson_04_02_2024.Business;

public class CourseManager
{
    Course[] courses = new Course[3];
    public CourseManager()
    {

        Course course = new Course();
        course.Id = 1;
        course.Name = "C#";
        course.Description = ".NET 8 Training Camp";
        course.Price = 0;

        Course course2 = new Course();
        course2.Id = 2;
        course2.Name = "Java";
        course2.Description = "Spring Camp";
        course2.Price = 0;

        Course course3 = new Course();
        course3.Id = 3;
        course3.Name = "Python";
        course3.Description = "Python Camp";
        course3.Price = 0;

        courses[0] = course;
        courses[1] = course2;
        courses[2] = course3;

        Console.WriteLine("Başladı ...");
    }
    public Course[] GetAll()
    {
        return courses;
    }
}
