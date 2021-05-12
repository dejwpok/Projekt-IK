using System.ComponentModel.DataAnnotations;

namespace Projekt_IK
{
    public class PojemnoscSilnika
    {
        [Key]
        public int PojemoscSilnikaID { get; set; }
        public double Pojemnosc { get; set; }
    }
}