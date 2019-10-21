using Aula2_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Aula2_API.Context
{
    public class Aula2Context : DbContext
    {
        public Aula2Context() { }

        public Aula2Context(DbContextOptions<Aula2Context> options) : base(options)
        {

        }

        public virtual DbSet<UsuarioModel> tbl_usuario{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;DataBase=Aula2_api;Integrated Security=true");
            }

        }





    }



}