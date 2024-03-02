using Kodlamaio_Ödev_3.Business;
using Kodlamaio_Ödev_3.DataAccess.Concretes;
using Kodlamaio_Ödev_3.Entities;

CourseManager courseManager = new(new CourseDal());
List<Course> courses = courseManager.GetAll();


foreach (Course course in courses)
{
	Console.WriteLine(course.CourseName + "-->" + course.InstructorName);
}

Console.WriteLine("---------------------------------------");

InstructorManager instructorManager = new(new InstructorDal());
List<Instructor> instructors = instructorManager.GetAll();

foreach (Instructor instructor in instructors)
{
	Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
}

Console.WriteLine("---------------------------------------");

CategoryManager categoryManager = new(new CategoryDal());
List<Category> categories = categoryManager.GetAll();

foreach (Category category in categories)
{
	Console.WriteLine(category.CategoryName);
}

