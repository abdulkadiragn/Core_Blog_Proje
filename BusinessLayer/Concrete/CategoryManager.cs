using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository EfCategoryRepository;
        public CategoryManager()
        {
            EfCategoryRepository = new EfCategoryRepository();
        }
        public void CategoryAdd(Category category)
        {
            EfCategoryRepository.Insert(category);
        }

        public void CategoryDelete(Category category)
        {
            EfCategoryRepository.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            EfCategoryRepository.Update(category);
        }

        public Category GetById(int id)
        {
          return  EfCategoryRepository.GetByID(id);
        }

        public List<Category> GetList()
        {
            return EfCategoryRepository.GetListAll();
        }
    }
}
