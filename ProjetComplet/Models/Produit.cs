namespace ProjetComplet.Models
{

    public enum CategorieType
    {
        TableauDeBord,
        Siege,
        Moteur,
        Transmission,
        SystemeDeFreinage,
        Eclairage
    }


    public class Produit
    {
        public int IdProduit { get; set; }
        public int IdClient { get; set; }

        public string NomProduit { get; set; } = string.Empty;
        public CategorieType Categorie { get; set; }
        public string FicheTechnique { get; set; } = string.Empty;  // Path to document or binary data
        public string Description { get; set; } = string.Empty;
        public string ImageProduit { get; set; } = string.Empty; // Path to image or binary data
    }
}
