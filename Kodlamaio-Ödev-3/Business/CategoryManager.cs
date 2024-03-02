using Kodlamaio_Ödev_3.DataAccess.Abstracts;
using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.Business;

public class CategoryManager
{
	private readonly ICategoryDal _categoryDal;

	public CategoryManager(ICategoryDal categoryDal)
	{
		this._categoryDal = categoryDal;
	}

	public List<Category> GetAll()
	{
		return _categoryDal.GetAll();
	}
}
