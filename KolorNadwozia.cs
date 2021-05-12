using System.ComponentModel.DataAnnotations;

namespace Projekt_IK
{
    public class KolorNadwozia
    {
        [Key]
        public int KolorNadwoziaID { get; set; }
        public string Kolor { get; set; }
    }
}