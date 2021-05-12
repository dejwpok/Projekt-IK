using System.ComponentModel.DataAnnotations;

namespace Projekt_IK
{
    public class RodzajPaliwa
    {
        [Key]
        public int RodzajPaliwaID { get; set; }
        public string Paliwo { get; set; }
    }
}