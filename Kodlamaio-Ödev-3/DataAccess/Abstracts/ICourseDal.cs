﻿using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.DataAccess.Abstracts;

public interface ICourseDal
{
	List<Course> GetAll();
	void Add(Course course);
	void Delete(Course course);

	void Update(Course updatedCourse);
}
