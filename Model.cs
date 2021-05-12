using System.ComponentModel.DataAnnotations;

namespace Projekt_IK
{
    public class Model
    {
        [Key]
        public int ModelID { get; set; }
        public string NazwaModel { get; set; }
    }
}