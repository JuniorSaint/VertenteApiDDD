using System;
using Api.Data.Mapping;
using Api.Data.Seeds;
using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<UserEntity> Users { get; set; }

        public MyContext(DbContextOptions<MyContext> options) : base(options) { }  // Configuração padrão

        protected override void OnModelCreating(ModelBuilder modelBuilder)   // Configuração padrão
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserEntity>(new UserMap().Configure);
            modelBuilder.Entity<ClientEntity>(new ClientMap().Configure);
            modelBuilder.Entity<ProductEntity>(new ProductMap().Configure);
            modelBuilder.Entity<PhoneEntity>(new PhoneMap().Configure);
            modelBuilder.Entity<ImagePathEntity>(new ImagePathMap().Configure);
            modelBuilder.Entity<AddressEntity>(new AddressMap().Configure);
            modelBuilder.Entity<StatesEntity>(new StateMap().Configure);
            modelBuilder.Entity<ProductTypeEntity>(new ProductTypeMap().Configure);
            UfSeeds.Ufs(modelBuilder); //irá criar os estados que estão cadastrado in mock
            modelBuilder.Entity<UserEntity>().HasData( //irá criar um usuário para acessar a aplicação
                new UserEntity
                {
                    Id = Guid.NewGuid(),
                    UserName = "Junior",
                    Email = "junior.saint@gmail.com",
                    Password = "123456",
                    IsActive = true,
                    UserType = "administrator",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                });
        }

    }
}
