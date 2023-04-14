using System.ComponentModel.DataAnnotations;

namespace NttProject1.Model
{
    public class BomDetail
    {
        public int Id { get; set; }
        [Required]
        public string ChildMaterialCode { get; set; }
        [Required]
        public string MaterialNum { get; set;}
    }
}
