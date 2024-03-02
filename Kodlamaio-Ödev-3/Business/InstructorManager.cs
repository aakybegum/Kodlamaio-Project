using Kodlamaio_Ödev_3.DataAccess.Abstracts;
using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.Business;

public class InstructorManager
{
	private readonly IInstructorDal _instructorDal;

	public InstructorManager(IInstructorDal instructorDal)
	{
		_instructorDal = instructorDal;
	}

	public List<Instructor> GetAll() { return _instructorDal.GetAll();}
}
