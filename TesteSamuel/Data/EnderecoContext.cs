using Microsoft.EntityFrameworkCore;
using TesteSamuel.Models;

namespace TesteSamuel.Data
{
    public class EnderecoContext : DbContext
    {
        public DbSet<Endereco> Endereco { get; set; }

        public EnderecoContext(DbContextOptions<EnderecoContext> opt) : base(opt)  
        {

        }

    }
}
