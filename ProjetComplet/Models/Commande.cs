namespace ProjetComplet.Models
{

    public enum EtatCommande
    {
        EnAttente,
        EnCoursDeFabrication,
        EnCoursDeLivraison,
        Livré
    }


    public class Commande
    {

        public int IdCommande { get; set; }
        public int IdUsine { get; set; }
        public int IdClient { get; set; }
        public int IdProduit { get; set; }
        public int Quantite { get; set; }
        public DateTime DateEnvoieDeLaCommande { get; set; }
        public DateTime DeadlineDeLaCommande { get; set; }
        public DateTime DateLivraisonDeLaCommande { get; set; }
        public EtatCommande EtatDeLaCommande { get; set; }

        public string AdresseLivraison { get; set; } = string.Empty;

        //list reclamation sur une commande optionnnelle
    }
}
