namespace ProjetComplet.Models
{


    public enum UserRole
    {
        Admin,
        ResponsableUsine,
        Client
    }

    public class User
    {

        public int IdUser { get; set; }
        public string username { get; set; } = string.Empty;
        public string passwordCrypted { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;
        public string NumeroDeTelephone { get; set; } = string.Empty;


        //enum
        public UserRole Role { get; set; }
    }
}
