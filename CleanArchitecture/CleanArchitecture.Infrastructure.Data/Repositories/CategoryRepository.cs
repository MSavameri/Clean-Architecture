﻿using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Domain.Interfaces;
using CleanArchitecture.Infrastructure.Data.Context;
using System.Collections.Generic;

namespace CleanArchitecture.Infrastructure.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BookStoreDBContext _context;

        public CategoryRepository(BookStoreDBContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> GetCategories() => _context.Categories;
    }
}
