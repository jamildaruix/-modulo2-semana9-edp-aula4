using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exemplo_aula_04_api.Models
{
    [Table("PizzaSabor")]
    public class PizzaSaborEntity
    {
        [Key]
        public int Codigo { get; set; }
        public string ExemploColuna { get; set; }

    }
}
