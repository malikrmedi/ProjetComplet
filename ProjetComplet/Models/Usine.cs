namespace ProjetComplet.Models
{
    public enum Specialite
    {
        TableauDeBord,
        Siege,
        Moteur,
        Transmission,
        SystemeDeFreinage,
        Eclairage
    }

    public class Usine
    {
        public int IdUsine { get; set; }
        public int IdResponsableUsine { get; set; } 
        public string AdresseUsine { get; set; } = string.Empty;
        public string Pays { get; set; } = string.Empty;
        public string Continent { get; set; } = string.Empty;
        public string NomDeLUsine { get; set; } = string.Empty;

        public Specialite Specialite { get; set; }//a tranformer à un enum
        public List<Commande> ListeDesCommandes { get; set; }
    }
}
