namespace GPostulant.Models
#nullable disable
{
    public class Postulant
    {
        public int Id {get; set;}

        public string Nom {get; set;} = string.Empty;

        public string Prenom {get; set;} = string.Empty;

        public string Sexe {get; set;} = string.Empty;

        public string Classe {get; set;} = string.Empty;
    }
}