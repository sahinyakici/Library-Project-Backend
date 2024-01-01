﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(PostgreContext))]
    [Migration("20231223195410_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<Guid>("OperationClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("OperationClaimId");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            OperationClaimId = new Guid("53853f74-f441-4eea-b8a0-743d813085a2"),
                            Name = "admin"
                        },
                        new
                        {
                            OperationClaimId = new Guid("394a4242-e7a8-428c-9e40-d6c014d1e0b5"),
                            Name = "user"
                        },
                        new
                        {
                            OperationClaimId = new Guid("fa53fd02-de0b-45d8-a064-9a1b24193665"),
                            Name = "editor"
                        },
                        new
                        {
                            OperationClaimId = new Guid("c1d4484b-84b2-4347-88bf-9c32398c9c1a"),
                            Name = "books.add"
                        },
                        new
                        {
                            OperationClaimId = new Guid("caa202c3-923f-4101-bc3f-c90b3d1a2ed6"),
                            Name = "books.edit"
                        },
                        new
                        {
                            OperationClaimId = new Guid("cf62a764-d48d-451a-b3cc-8b3f1f6e543d"),
                            Name = "books.delete"
                        },
                        new
                        {
                            OperationClaimId = new Guid("4630e128-a18b-4ac5-ac9f-98dad59dad69"),
                            Name = "books.update"
                        },
                        new
                        {
                            OperationClaimId = new Guid("1ddb1f78-9dd6-46c1-93ad-870cfe5b1101"),
                            Name = "authors.add"
                        },
                        new
                        {
                            OperationClaimId = new Guid("cc0b474b-a845-4d83-9950-c818997c41b7"),
                            Name = "authors.edit"
                        },
                        new
                        {
                            OperationClaimId = new Guid("f90454f7-441f-4d6e-add3-5e3ea725aab3"),
                            Name = "authors.delete"
                        },
                        new
                        {
                            OperationClaimId = new Guid("e00dc8a9-b6b3-4735-918c-8a12c08c3e9f"),
                            Name = "authors.update"
                        },
                        new
                        {
                            OperationClaimId = new Guid("983d2f56-bdd2-44a2-83e6-1e11dd13bb07"),
                            Name = "genres.add"
                        },
                        new
                        {
                            OperationClaimId = new Guid("5a0f30b7-fe47-4c78-abbc-a24b5dedb9fb"),
                            Name = "genres.edit"
                        },
                        new
                        {
                            OperationClaimId = new Guid("5237d1db-c5c0-4f93-a20f-01c228c65541"),
                            Name = "genres.delete"
                        },
                        new
                        {
                            OperationClaimId = new Guid("a6d3fb56-4689-4c94-a0ac-640c635d4b22"),
                            Name = "genres.update"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("bytea");

                    b.Property<bool>("Status")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<Guid>("UserOperationClaimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("OperationClaimId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("UserOperationClaimId");

                    b.ToTable("UserOperationClaims");
                });

            modelBuilder.Entity("Entities.Concrete.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Entities.Concrete.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("AuthorId")
                        .HasColumnType("uuid");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("GenreId")
                        .HasColumnType("uuid");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<float>("Money")
                        .HasColumnType("real");

                    b.Property<Guid>("OwnerId")
                        .HasColumnType("uuid");

                    b.Property<int>("PageSize")
                        .HasColumnType("integer");

                    b.Property<bool>("RentStatus")
                        .HasColumnType("boolean");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Entities.Concrete.Genre", b =>
                {
                    b.Property<Guid>("GenreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("GenreId");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            GenreId = new Guid("da489254-540c-4ea6-bdc7-aa2872969352"),
                            GenreName = "Dünya Klasikleri",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("c1a43b50-9f1d-4594-acc3-111b6b7db283"),
                            GenreName = "Aşk",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("82ea624a-ae0d-4be9-a308-9662ade88b57"),
                            GenreName = "Roman",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("511bb5dd-e77d-41c0-a4b0-36f1b8df21fa"),
                            GenreName = "Psikoloji",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("1b3b7ec1-1948-40ff-92ea-cb14d34aa5f7"),
                            GenreName = "Söylev",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("d3faf1f7-6cbf-4a0d-a252-424c2ad88410"),
                            GenreName = "Dini",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("86a2d552-0086-493c-8aaf-ef4d5a12fa92"),
                            GenreName = "Tarihj",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("be587145-e740-481f-84db-286a78b4826f"),
                            GenreName = "Korku-Gerilim",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("6caeccd2-72f3-4dc8-ae52-a56088a7aa4a"),
                            GenreName = "Aksiyon",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("81f17f5d-801c-40af-8c69-403f1f24f021"),
                            GenreName = "Kişisel Gelişim",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("03d5e96a-fa3e-4a64-b032-fe9aeff2fd6b"),
                            GenreName = "Şiir",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("58b08019-24b0-4ff7-a14b-ab7078e1c803"),
                            GenreName = "Macera-Aksiyon",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("b6468550-8269-4667-b1e0-5a4537edd602"),
                            GenreName = "Felsefe-Düşünce",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("fa5d5865-b3c1-4987-a02e-ceb3092b92bd"),
                            GenreName = "Edebiyat",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("ccaf7735-89ec-4145-954a-a944d8937191"),
                            GenreName = "Bilim-Kurgu",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("2640be2d-53ff-4b11-8cea-3a6e326fa1a0"),
                            GenreName = "Hikaye (Öykü)",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("b5a73b73-6bc7-4884-8885-acc4e4ad3bb2"),
                            GenreName = "Sosyoloji",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("6d6c6e0e-ce34-48f8-be00-ec917e7a02e3"),
                            GenreName = "Biyografi",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("394f9039-8152-4657-9949-1111794fe2b1"),
                            GenreName = "Araştırma-İnceleme",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("dea72350-0ca4-47bb-9202-553d8b39093d"),
                            GenreName = "Manga",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("92e0b5f5-492d-4088-bdd6-7bbafbe2fc0d"),
                            GenreName = "Ekonomi-İş Dünyası",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("203b80f5-3d92-4fbf-b239-438ef3c1d910"),
                            GenreName = "Masal",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("600513fd-520e-4f04-a363-d329be47e7e9"),
                            GenreName = "Eğlence-Mizah",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("7302df79-76d1-41a1-9a00-6d2d0f7d5eb0"),
                            GenreName = "Sağlık-Tıp",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("bd5cd2df-8a9f-4f4e-9ad6-063c3055873d"),
                            GenreName = "İnsan ve Toplum",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("5767be66-cb6b-4848-89a9-eff3106650ef"),
                            GenreName = "Çizgi-Roman",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("178da562-69ee-487b-af24-04095f59fe08"),
                            GenreName = "Eğitim",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("36ee2253-94ef-4589-93ad-2e643dce4af9"),
                            GenreName = "Tiyatro",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("43c5d6dc-97c0-4844-8daa-db0235d47cae"),
                            GenreName = "Hukuk",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("8c8ad5af-620e-43ed-8f97-fdb56bb08ef9"),
                            GenreName = "Sanat",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("64db2346-d19d-476d-8b46-a10bb20ff8ae"),
                            GenreName = "Antropoloji-Etnoloji",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("3044729a-4f11-4056-922e-2d5428a91816"),
                            GenreName = "Spor",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("8a4e374c-54f0-4468-91c0-724b950fb052"),
                            GenreName = "Gezi",
                            IsDeleted = false
                        },
                        new
                        {
                            GenreId = new Guid("7a7c0082-92ac-422f-98db-d10a4bc91e16"),
                            GenreName = "Anlatı",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Entities.Concrete.Image", b =>
                {
                    b.Property<Guid>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("Entities.Concrete.Rental", b =>
                {
                    b.Property<Guid>("RentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("BookId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<float?>("RentalPrice")
                        .HasColumnType("real");

                    b.Property<DateTime>("RentalStart")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime?>("RentalStop")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("RentalId");

                    b.ToTable("Rentals");
                });
#pragma warning restore 612, 618
        }
    }
}