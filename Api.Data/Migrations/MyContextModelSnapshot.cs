﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api.Data.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Api.Domain.Entities.AddressEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AddressType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<string>("Complement")
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("ZipCode")
                        .HasMaxLength(8)
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Api.Domain.Entities.ClientEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("Cpf_Cnpj")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Name");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("Api.Domain.Entities.ImagePathEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ImagePath");

                    b.HasIndex("ProductId");

                    b.ToTable("ImagePath");
                });

            modelBuilder.Entity("Api.Domain.Entities.PhoneEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ClientId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("integer");

                    b.Property<string>("PhoneType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SocialPhone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Phone");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsOnSale")
                        .HasColumnType("boolean");

                    b.Property<double>("Price")
                        .HasColumnType("double precision");

                    b.Property<double>("PriceOff")
                        .HasColumnType("double precision");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.Property<Guid>("ProductTypeId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProductCode")
                        .IsUnique();

                    b.HasIndex("ProductName")
                        .IsUnique();

                    b.HasIndex("ProductTypeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductTypeEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ProductType")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("ProductType");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("Api.Domain.Entities.StatesEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasMaxLength(45)
                        .HasColumnType("character varying(45)");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("Sigla");

                    b.ToTable("State");

                    b.HasData(
                        new
                        {
                            Id = new Guid("22ffbd18-cdb9-45cc-97b0-51e97700bf71"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(5930),
                            Sigla = "AC",
                            StateName = "Acre"
                        },
                        new
                        {
                            Id = new Guid("7cc33300-586e-4be8-9a4d-bd9f01ee9ad8"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8570),
                            Sigla = "AL",
                            StateName = "Alagoas"
                        },
                        new
                        {
                            Id = new Guid("cb9e6888-2094-45ee-bc44-37ced33c693a"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8580),
                            Sigla = "AM",
                            StateName = "Amazonas"
                        },
                        new
                        {
                            Id = new Guid("409b9043-88a4-4e86-9cca-ca1fb0d0d35b"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8580),
                            Sigla = "AP",
                            StateName = "Amapá"
                        },
                        new
                        {
                            Id = new Guid("5abca453-d035-4766-a81b-9f73d683a54b"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8590),
                            Sigla = "BA",
                            StateName = "Bahia"
                        },
                        new
                        {
                            Id = new Guid("5ff1b59e-11e7-414d-827e-609dc5f7e333"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8590),
                            Sigla = "CE",
                            StateName = "Ceará"
                        },
                        new
                        {
                            Id = new Guid("bd08208b-bfca-47a4-9cd0-37e4e1fa5006"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8590),
                            Sigla = "DF",
                            StateName = "Distrito Federal"
                        },
                        new
                        {
                            Id = new Guid("c623f804-37d8-4a19-92c1-67fd162862e6"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8590),
                            Sigla = "ES",
                            StateName = "Espírito Santo"
                        },
                        new
                        {
                            Id = new Guid("837a64d3-c649-4172-a4e0-2b20d3c85224"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8600),
                            Sigla = "GO",
                            StateName = "Goiás"
                        },
                        new
                        {
                            Id = new Guid("57a9e9f7-9aea-40fe-a783-65d4feb59fa8"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8600),
                            Sigla = "MA",
                            StateName = "Maranhão"
                        },
                        new
                        {
                            Id = new Guid("27f7a92b-1979-4e1c-be9d-cd3bb73552a8"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8600),
                            Sigla = "MG",
                            StateName = "Minas Gerais"
                        },
                        new
                        {
                            Id = new Guid("3739969c-fd8a-4411-9faa-3f718ca85e70"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8600),
                            Sigla = "MS",
                            StateName = "Mato Grosso do Sul"
                        },
                        new
                        {
                            Id = new Guid("29eec4d3-b061-427d-894f-7f0fecc7f65f"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8610),
                            Sigla = "MT",
                            StateName = "Mato Grosso"
                        },
                        new
                        {
                            Id = new Guid("8411e9bc-d3b2-4a9b-9d15-78633d64fc7c"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8610),
                            Sigla = "PA",
                            StateName = "Pará"
                        },
                        new
                        {
                            Id = new Guid("1109ab04-a3a5-476e-bdce-6c3e2c2badee"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8610),
                            Sigla = "PB",
                            StateName = "Paraíba"
                        },
                        new
                        {
                            Id = new Guid("ad5969bd-82dc-4e23-ace2-d8495935dd2e"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8610),
                            Sigla = "PE",
                            StateName = "Pernambuco"
                        },
                        new
                        {
                            Id = new Guid("f85a6cd0-2237-46b1-a103-d3494ab27774"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8620),
                            Sigla = "PI",
                            StateName = "Piauí"
                        },
                        new
                        {
                            Id = new Guid("1dd25850-6270-48f8-8b77-2f0f079480ab"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8620),
                            Sigla = "PR",
                            StateName = "Paraná"
                        },
                        new
                        {
                            Id = new Guid("43a0f783-a042-4c46-8688-5dd4489d2ec7"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8620),
                            Sigla = "RJ",
                            StateName = "Rio de Janeiro"
                        },
                        new
                        {
                            Id = new Guid("542668d1-50ba-4fca-bbc3-4b27af108ea3"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8620),
                            Sigla = "RN",
                            StateName = "Rio Grande do Norte"
                        },
                        new
                        {
                            Id = new Guid("924e7250-7d39-4e8b-86bf-a8578cbf4002"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8620),
                            Sigla = "RO",
                            StateName = "Rondônia"
                        },
                        new
                        {
                            Id = new Guid("9fd3c97a-dc68-4af5-bc65-694cca0f2869"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8630),
                            Sigla = "RR",
                            StateName = "Roraima"
                        },
                        new
                        {
                            Id = new Guid("88970a32-3a2a-4a95-8a18-2087b65f59d1"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8630),
                            Sigla = "RS",
                            StateName = "Rio Grande do Sul"
                        },
                        new
                        {
                            Id = new Guid("b81f95e0-f226-4afd-9763-290001637ed4"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8630),
                            Sigla = "SC",
                            StateName = "Santa Catarina"
                        },
                        new
                        {
                            Id = new Guid("fe8ca516-034f-4249-bc5a-31c85ef220ea"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8640),
                            Sigla = "SE",
                            StateName = "Sergipe"
                        },
                        new
                        {
                            Id = new Guid("e7e416de-477c-4fa3-a541-b5af5f35ccf6"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8640),
                            Sigla = "SP",
                            StateName = "São Paulo"
                        },
                        new
                        {
                            Id = new Guid("971dcb34-86ea-4f92-989d-064f749e23c9"),
                            CreatedAt = new DateTime(2021, 9, 23, 14, 16, 43, 702, DateTimeKind.Utc).AddTicks(8640),
                            Sigla = "TO",
                            StateName = "Tocantins"
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(90)
                        .HasColumnType("character varying(90)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ce6b5be5-497e-4859-9d34-054466ce11e7"),
                            CreatedAt = new DateTime(2021, 9, 23, 11, 16, 43, 704, DateTimeKind.Local).AddTicks(3810),
                            Email = "junior.saint@gmail.com",
                            IsActive = true,
                            Password = "123456",
                            UpdatedAt = new DateTime(2021, 9, 23, 11, 16, 43, 724, DateTimeKind.Local).AddTicks(1770),
                            UserName = "Junior",
                            UserType = "administrator"
                        });
                });

            modelBuilder.Entity("Api.Domain.Entities.AddressEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.ClientEntity", "Client")
                        .WithMany("Addresses")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Api.Domain.Entities.ImagePathEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.ProductEntity", "Product")
                        .WithMany("ImagePaths")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Api.Domain.Entities.PhoneEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.ClientEntity", "Client")
                        .WithMany("Phones")
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.ProductTypeEntity", "ProductType")
                        .WithMany("Products")
                        .HasForeignKey("ProductTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductType");
                });

            modelBuilder.Entity("Api.Domain.Entities.ClientEntity", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Phones");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductEntity", b =>
                {
                    b.Navigation("ImagePaths");
                });

            modelBuilder.Entity("Api.Domain.Entities.ProductTypeEntity", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}
