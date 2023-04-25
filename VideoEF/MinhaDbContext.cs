using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoEF
{
    public class MinhaDbContext : DbContext //REFERENCIAR O BANCO DE DADOS PARA PODERMOS INICIALZA-LO
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb;database=TesteEF;Trusted_Connection=true"); //INICIAR O BANCO DE DADOS: SERVER = DB LOCAL; DATABASE = É O NOME DO BANCO; Trusted_Connection = INFORMA QUE A CONEXÃO É DE CONFIANÇA UTILIZANDO O PRÓPRIO USUÁRIO DO COMPUTADOR.
        }

        public DbSet<Cliente> Clientes { get; set; } //INFORMA QUE O MEU DB TEM UMA TABELA CHAMADA CLIENTES
    }
}
