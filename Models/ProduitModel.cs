using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace facture.Models
{
    public class ProduitModel
    {
        public ProduitModel() { }
        public String Libelle { get; set; }
        public double Prix { get; set; }
        public double TVA { get; set; }
        public int quantite { get; set; }
    }
}