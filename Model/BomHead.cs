using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mail;
using Microsoft.EntityFrameworkCore;
namespace NttProject1.Model
{
    public class BomHead
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string BomCode { get; set; }
        [Required]
        [StringLength(20)]
        public string MaterialCode { get; set; }
        [Required]
        public string Description { get; set; }

    }
}
