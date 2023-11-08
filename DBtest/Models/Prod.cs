
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DBtest.Models
{
    [Table(nameof(MalContext.Prods))]
    public class Prod
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Prod_Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }    
        public string Cost { get; set;}
        public string Image { get; set;}
        public ICollection<BookProd> BookProds { get; set; }
    }
}
