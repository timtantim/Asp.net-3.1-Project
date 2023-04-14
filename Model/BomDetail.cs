using System.ComponentModel.DataAnnotations;

namespace NttProject1.Model
{
    public class BomDetail
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string BomCode { get; set; }
        [Required]
        [StringLength(20)]
        public string ChildMaterialCode { get; set; }
        [Required]
        public int MaterialNum { get; set;}
    }
}
