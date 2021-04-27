using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace api_example
{
    public class Entidade
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Valor { get; set; }
    }
}