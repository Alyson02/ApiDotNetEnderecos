using System.ComponentModel.DataAnnotations;

namespace TesteSamuel.Models
{
    public class Endereco
    {
        [Key()]
        public int Id { get; set; } = 0;
        [StringLength(8)]
        public string Cep { get; set; }
        [StringLength(50)]
        public string Rua { get; set; }
    }
}
