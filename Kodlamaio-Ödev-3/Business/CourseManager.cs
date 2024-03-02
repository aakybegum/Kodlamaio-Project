using Kodlamaio_Ödev_3.DataAccess.Abstracts;
using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.Business;

public class CourseManager
{
	private readonly ICourseDal _courseDal;

	public CourseManager(ICourseDal courseDal)
	{
		this._courseDal = courseDal;
	}

	public List<Course> GetAll()
	{
		return _courseDal.GetAll();
	}
}
