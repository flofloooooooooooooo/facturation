# Membres du groupe
- Patrick Lorain
- Boris Thomas
- Quentin Evrar
- Michel Piac
- Damien Mostermans
- Alexis Bariteau
- Damien Perniquoski
- Florian Vassiliadi



# Facturation

**On balance:**

POST /Home/Facturer HTTP/1.1
Host: localhost:40564
Content-Type: application/json
Cache-Control: no-cache
Postman-Token: 669b3e75-982c-355f-7b09-4732334399fd

{"produits":[{"prix":20,"libelle":"pain","TVA":1,"quantite":1},{"prix":20,"libelle":"lait","TVA":10,"quantite":1}]}

**Résultat:**

{
  "commande": {
    "produits": [
      {
        "Libelle": "pain",
        "Prix": 20,
        "TVA": 1,
        "quantite": 1
      },
      {
        "Libelle": "lait",
        "Prix": 20,
        "TVA": 10,
        "quantite": 1
      }
    ]
  },
  "total_TTC": 42.2,
  "total_HT": 40,
  "date_facturation": "/Date(1460546035061)/"
}

