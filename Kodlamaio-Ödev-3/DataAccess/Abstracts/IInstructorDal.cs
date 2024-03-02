using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.DataAccess.Abstracts
{
	public interface IInstructorDal
	{
		List<Instructor> GetAll();
		public void Add(Instructor instructor);
		public void Remove(Instructor instructor);
		public void Update(Instructor updatedInstructor);
	}
}
