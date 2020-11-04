using ShoppingCart.Application.ViewModels;
using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShoppingCart.Application.Interfaces
{
    public interface IProductsService
    {
        //to expose directly your class as it was created originally to create your database is not good practice
        //hence we create a replica of that class removing nay properties which may disclose some confidential or 
        //unwanted information
        //typical eg. if you have user class, would you pass on the 
        IQueryable<ProductViewModel> GetProducts();

       //void RateProduct(Guid id, string comment, double rating);
    }
}
