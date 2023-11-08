using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBtest.Models
{
    [Table(nameof(MalContext.BookProds))]
    public class BookProd
    {
        [Key]
        public int Prod_Id { get; set; }
        
        public int Book_Id { get; set; }

        public Prod Prod { get; set; }
        public Book Book { get; set; }
    }
}
