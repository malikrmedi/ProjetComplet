namespace ProjetComplet.Models
{
    public class Client : User
    {

        public string NomDeLaMarque { get; set; }
        public List<Produit> ListeDesProduits { get; set; }

    }
}
