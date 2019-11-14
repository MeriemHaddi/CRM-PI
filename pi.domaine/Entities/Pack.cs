using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
   public class Pack
    {
        [Key]
        public String Id_Pack { get; set; }

        [Required(AllowEmptyStrings = false)]
        [MaxLength(20, ErrorMessage = "error")]
        [DataType(DataType.Text)]
        public String Titre { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.Text)]
        public String Description { get; set; }
        public int Periode_Engagement { get; set; }
        public float Prix { get; set; }

    }
}
