using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace facture.Models
{
    public class CommandeModel
    {
        public CommandeModel()
        {
        }
        public List<ProduitModel> produits { get; set; }
    }
}