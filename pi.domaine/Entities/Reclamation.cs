using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pi.domaine.Entities
{
    public class Reclamation
    {

        [Key]
        public int idReclamation { get; set; }
        public User UserId { get; set; }
        public string Titre { get; set; }
        public string contenu { get; set; }
        public string etat { get; set; }
        public enum TypeReclamation { 
       Technique,
       Financiere ,
       Relationnelle 
    }

}



    } 

    

