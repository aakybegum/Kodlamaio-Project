using Kodlamaio_Ödev_3.DataAccess.Abstracts;
using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.DataAccess.Concretes;

public class InstructorDal : IInstructorDal
{
	List<Instructor> instructors;

	public InstructorDal()
	{
		Instructor instructor1 = new Instructor();
		instructor1.Id = 1;
		instructor1.FirstName = "Engin";
		instructor1.LastName = "Demiroğ";

		Instructor instructor2 = new Instructor();
		instructor2.Id = 2;
		instructor2.FirstName = "Halit Enes";
		instructor2.LastName = "Kalaycı";

		instructors = new List<Instructor>() { instructor1,instructor2};
	}

	public void Add(Instructor instructor)
	{
		instructors.Add(instructor);
	}

	public List<Instructor> GetAll()
	{
		return instructors;
	}

	public void Remove(Instructor instructor)
	{
		instructors.Remove(instructor);
	}

	public void Update(Instructor updatedInstructor)
	{
		foreach (Instructor instructor in instructors)
		{
			if (instructor.Id == updatedInstructor.Id)
			{
				instructor.FirstName = updatedInstructor.FirstName;
				instructor.LastName = updatedInstructor.LastName;
				
				break;
			}
		}
	}

}
