using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
  public  class Shop
    {
        [Key]
        public int id_Shop { get; set; }
        public string shop_name { get; set; }
        public string Shop_Location { get; set; }
        public TimeSpan Opening_Time { get; set; }
        public TimeSpan closing_Time { get; set; }
        public string Service { get; set; }
        public List<Shop> Sops { get; set; }
        public Shop() { }
    }
}
