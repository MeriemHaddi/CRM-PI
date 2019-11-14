using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
   public class OffrePostpayee:Offre
    {
        public float PrixHorsPack { get; set; }
        public float Total { get; set; }
        public Pack Pack { get; set; }
    }
}
