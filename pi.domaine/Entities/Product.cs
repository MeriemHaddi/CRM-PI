using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
   public class Product
    {


        [Key]
        public int idProduct { get; set; }
      
        [MaxLength(25)]
        public string Product_Name { get; set; }
        public float Price { get; set; }
        public string Picture { get; set; }

       

        public enum Category
        {
            Telephone,
            Pc,
            SmartWatch
        }

        public Product() { }
        public Product(int id) {
            this.idProduct = id;
           }


    }
}
