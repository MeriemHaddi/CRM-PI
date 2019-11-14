using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
    public class lignecmd
    {

        //id pk
        public int LignecmdId { get; set; }

        //fk idproduit
        public Product idProduct { get; set; }

        //fk factdev
        public int id_factdev { get; set; }

        //fk iduser
        public int id_user { get; set; }

        public int quantite { get; set; }

        public float prix { get; set; }

        public int etat { get; set; }

    }
}
