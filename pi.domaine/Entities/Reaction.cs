using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
   public class Reaction
    {

        [Key]
        public int ReactionId { get; set; }
        public int nblike { get; set; }
        public int nbdislike { get; set; }
        public int? PostId { get; set; }
        [ForeignKey("PostId")]
        public virtual Post POST { get; set; }
    }
}
