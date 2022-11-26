using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace exemplo_aula_04_api.Models
{
    [Table("Pizza")]
    public class PizzaEntity
    {
        [Key]
        public int Codigo { get; set; }

        public string Descricao { get; set; }

        [Column("Valor")]
        public decimal ValorDaPizza { get; set; }
    }
}
