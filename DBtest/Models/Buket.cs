using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBtest.Models
{
    [Table(nameof(MalContext.Bukets))]
    public class Buket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Bulet_Id { get; set; }
        public string Bulet_Name { get; set;}
        public string Bulet_Image { get; set;}
    }
}
