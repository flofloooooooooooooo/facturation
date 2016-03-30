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
        //{"produits":[{"prix":20,"libelle":"lait","TVA":10},{"prix":20,"libelle":"lait","TVA":10}]}
        [HttpPost]
        public JsonResult Facturer(CommandeModel commande)
        {
            return Json(commande);
        }
        public FactureModel Calculer(CommandeModel commande)
        {
            FactureModel result = new FactureModel();
            foreach(var produit in commande.produits)
            {

            }
            return result;
        }
       
    }
}