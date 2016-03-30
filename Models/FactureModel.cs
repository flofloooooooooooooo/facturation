using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace facture.Models
{
    public class FactureModel
    {
        public CommandeModel commande { get; set; }
        public double total_TTC { get; set; }
        public double total_HT { get; set; } 
    }
}