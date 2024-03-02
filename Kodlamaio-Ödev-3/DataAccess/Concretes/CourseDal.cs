using Kodlamaio_Ödev_3.DataAccess.Abstracts;
using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
	List<Course> courses;

	public CourseDal()
	{
		Course course1 = new Course();
		course1.Id = 1;
		course1.CourseName = "C# + Angular";
		course1.InstructorName = "Engin Demiroğ";

		Course course2 = new Course();
		course2.Id = 2;
		course2.CourseName = "Python & Selenium";
		course2.InstructorName = "Halit Enes Kalaycı";

		Course course3 = new Course();
		course3.Id = 3;
		course3.CourseName = "Java + React";
		course3.InstructorName = "Engin Demiroğ";

		Course course4 = new Course();
		course4.Id = 4;
		course4.CourseName = "Javascript";
		course4.InstructorName = "Engin Demiroğ";

		courses = new List<Course> { course1, course2, course3 };
	}

	public List<Course> GetAll()
	{
		return courses;
	}

	public void Add(Course course)
	{
		courses.Add(course);
	}

	public void Delete(Course course)
	{
		courses.Remove(course);
	}

	public void Update(Course updatedCourse)
	{
		foreach (Course course in courses)
		{
			if (course.Id == updatedCourse.Id)
			{
				course.CourseName = updatedCourse.CourseName;
				course.InstructorName = updatedCourse.InstructorName;
				break;
			}
		}
	}
}

