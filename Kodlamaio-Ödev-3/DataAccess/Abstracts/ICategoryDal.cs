using Kodlamaio_Ödev_3.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio_Ödev_3.DataAccess.Abstracts;

public interface ICategoryDal
{
	List<Category> GetAll();
	public void Add(Category category);
	public void Remove(Category category);
	public void Update(Category updatedCategory);
}
