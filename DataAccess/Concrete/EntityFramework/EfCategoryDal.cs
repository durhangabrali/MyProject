﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
        //Önce aşağıdaki kodlar yazılmıştı, EfEntityRepositoryBase<Category, NorthwindContext>
        //Eklendikten sonra silindi
        //------------------------------------------------------------------------------------

        //public void Add(Category entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(Category entity)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        //{
        //    throw new NotImplementedException();
        //}

        //public Category Get(Expression<Func<Category, bool>> filter)
        //{
        //    throw new NotImplementedException();
        //}

        //public void Update(Category entity)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
