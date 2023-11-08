using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBtest.Models
{
    [Table(nameof(MalContext.Prods))]
    public class Prod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prod_Id { get; set; }
        public string Prod_Name { get; set; }
        public string Prod_Description { get; set; }    
        public string Prod_Image { get; set;}
    }
}
