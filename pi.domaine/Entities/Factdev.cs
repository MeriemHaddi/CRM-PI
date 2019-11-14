using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
    public class factdev
    {
        //id pk
        public int FactdevId { get; set; }
        // fk iduser
        public User UserId { get; set; }

        public int reference { get; set; }

        public int prix { get; set; }

        public DateTime date { get; set; }

        public int etat { get; set; }

    }
}
