using System;
using System.Collections.Generic;


namespace BethanyPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories
        {
            get
            {
				return _appDbContext.Categories;
            }
        }
    }
}
