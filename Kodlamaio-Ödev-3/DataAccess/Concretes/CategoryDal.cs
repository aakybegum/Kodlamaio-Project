using Kodlamaio_Ödev_3.DataAccess.Abstracts;
using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
	List<Category> categories;

	public CategoryDal()
	{
		Category category1 = new Category();
		category1.Id = 1;
		category1.CategoryName = "Programlama";

		Category category2 = new Category();
		category2.Id = 2;
		category2.CategoryName = "Tümü";

		categories = new List<Category>() { category1,category2};
	}

	public void Add(Category category)
	{
		categories.Add(category);
	}

	public List<Category> GetAll()
	{
		return categories;
	}

	public void Remove(Category category)
	{
		categories.Remove(category);
	}

	public void Update(Category updatedCategory)
	{
		foreach (Category category in categories)
		{
			if (category.Id == updatedCategory.Id)
			{
				category.CategoryName = updatedCategory.CategoryName;
				break;
			}
		}
	}
}
