using System;
using Business.Concrete;
using DataAccess.Concrete.Enitityframework;
using DataAccess.Concrete.InMemory;
namespace CoonsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDall());

            foreach (var  product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }




        }
    }
}
