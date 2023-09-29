﻿using System;

namespace AppCRUDMVC.Database
{
    public class ProductEntity : BaseEntity
    {

        public string Name { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }

    }
}
