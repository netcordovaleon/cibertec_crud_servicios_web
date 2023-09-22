using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AppCRUDMVC.Models
{
    public class ProductListViewModel {
        public List<ProductViewModel> List { get; set; }

        public ProductListViewModel()
        {
            List = new List<ProductViewModel>();
        }
    }

    public class ProductViewModel
    {
        public int Id { get; set; }
        public DateTime DateAdded { get; set; }
        public string Status { get; set; }
        [DisplayName("Nombre")]
        public string Name { get; set; }
        [DisplayName("Precio Unitario")]
        public double? Price { get; set; }
        [DisplayName("Disponibilidad")]
        public int? Stock { get; set; }
    }
}
