using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using facture.Models;

namespace facture.Controllers
{
    public class HomeController : Controller
    {
        //{"produits":[{"prix":20,"libelle":"pain","TVA":1,"quantite":1},{"prix":20,"libelle":"lait","TVA":10,"quantite":1}]}
        [HttpPost]
        public JsonResult Facturer(CommandeModel commande)
        {
            FactureModel result = Calculer(commande);
            return Json(result);
        }
        public FactureModel Calculer(CommandeModel commande)
        {
            FactureModel result = new FactureModel();
            result.commande = commande;
            result.date_facturation = DateTime.Now;
            double totalHT = 0;
            double totalTTC = 0;
            foreach (var produit in commande.produits)
            {
                double pourcent = produit.Prix * (produit.TVA / 100);
                totalTTC += (produit.Prix + pourcent) * produit.quantite;
                totalHT += produit.Prix * produit.quantite;
            }
            result.total_HT = totalHT;
            result.total_TTC = totalTTC;
            return result;
        }

    }
}