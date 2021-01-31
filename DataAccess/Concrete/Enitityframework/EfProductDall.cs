using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Abtract;
using Entities.Concrete;

namespace DataAccess.Concrete.Enitityframework
{
    public class EfProductDall: IProductDal

    {
        public void Add(Product product)
        {
     
            throw new NotImplementedException();
    
        }
              
    
        public void Delete (Product product)
        {
            throw new NotImplementedException();
        }
        public List<Product> GetAll()
        {
            return new List<Product> { new Product { ProductName = "Tablo" }, new Product { ProductName = "Su" } };
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Product>GetAllVyCategory(int categoryId)
        {
            throw new NotImplementedException();
        }
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }   
}
