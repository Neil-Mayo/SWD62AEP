﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
using System.Text;

//code first.
namespace ShoppingCart.Domain.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Description { get; set; }
        public string ImageUrl { get; set; }
     
        [Required]
        public Category Category { get; set; }
         
    }
}
