using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.mocks
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> Categories
        {
            get
            {
                return new List<Category>
            {
                new Category{CategoryName = "Alcoholic",Description="All alcoholic drinks"},
                new Category { CategoryName= "Non Alcoholic", Description="All non alcoholic drinks"}
            };
            }
        }
    }
}
