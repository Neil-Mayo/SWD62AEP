using ShoppingCart.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingCart.Application.ViewModels
{

    /// <summary>
    /// This class will be the model that you are going to pass on to whoever is using your classes 
    /// remember: it could be someone whis is paying for the service 
    /// //        it could be some 3rd pary company/developer which is not trustworthy
    /// </summary>
    public class ProductViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        
        public double Price { get; set; }
       
        public string Description { get; set; }
        
        public string ImageUrl { get; set; }

        public CategoryViewModel Category { get; set; }


    }
}
