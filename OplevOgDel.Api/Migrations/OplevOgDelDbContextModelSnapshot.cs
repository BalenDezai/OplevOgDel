﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OplevOgDel.Api.Data;

namespace OplevOgDel.Api.Migrations
{
    [DbContext(typeof(OplevOgDelDbContext))]
    partial class OplevOgDelDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Administrator", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrator");

                    b.HasData(
                        new
                        {
                            Id = new Guid("85416f64-0f0e-4b8d-8687-4f3b9cc6b40f"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "admin@admin.dk",
                            IsDeleted = false,
                            Password = "password",
                            Username = "admin"
                        });
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.ExpCategory", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("199b5113-ae3b-47ce-adee-dcbac4935f88"),
                            Name = "Mad"
                        },
                        new
                        {
                            Id = new Guid("45671c48-b7a2-4663-b826-044aeefd59ff"),
                            Name = "Natur"
                        },
                        new
                        {
                            Id = new Guid("21015075-67a0-4f6e-8db7-b9eefd4361a8"),
                            Name = "Musik"
                        },
                        new
                        {
                            Id = new Guid("af09b6cc-e3f0-4eae-bb89-ef36affd27d7"),
                            Name = "Action"
                        },
                        new
                        {
                            Id = new Guid("b6f3f639-1450-4334-a123-2b1fb8c68808"),
                            Name = "Kultur"
                        },
                        new
                        {
                            Id = new Guid("037d26c3-66c4-4017-9c54-ca8e72ae56fa"),
                            Name = "Historie"
                        });
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Experience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExpCategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExpCategoryId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Experiences");

                    b.HasData(
                        new
                        {
                            Id = new Guid("bd345b81-462b-4ba9-999f-48ff44fad5e8"),
                            Address = "Nyhavn 2",
                            City = "København",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Apollo Bar er en simpel restaurant beliggende i baggården ved Charlottenborg Kunsthal. Apollo Bar tilbyder morgenmad, frokost og middag.",
                            ExpCategoryId = new Guid("199b5113-ae3b-47ce-adee-dcbac4935f88"),
                            IsDeleted = false,
                            Name = "Apollo Bar",
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205")
                        },
                        new
                        {
                            Id = new Guid("82a5a437-35b3-44b8-b10a-01d13577b7f1"),
                            Address = "Bagerstræde 7",
                            City = "København",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Akustikken er en guitarbutik, der både sælger og reparerer musikudstyr.",
                            ExpCategoryId = new Guid("21015075-67a0-4f6e-8db7-b9eefd4361a8"),
                            IsDeleted = false,
                            Name = "Akustikken",
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205")
                        },
                        new
                        {
                            Id = new Guid("a030b459-a8b5-4bba-bcbd-b9a30176f7e4"),
                            Address = "Vindmøllevej 6",
                            City = "København",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Amager Bakke er en kunstig skibakke, der ligger på toppen af det nye forbrændingsanlæg, Amager Ressource Center (ARC).",
                            ExpCategoryId = new Guid("af09b6cc-e3f0-4eae-bb89-ef36affd27d7"),
                            IsDeleted = false,
                            Name = "Amager Bakke",
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205")
                        },
                        new
                        {
                            Id = new Guid("c3965bec-3a76-40a9-b435-546d4cd2ad2f"),
                            Address = "Roskildevej 32",
                            City = "Frederiksberg",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Med sine godt 160 år på bagen er Zoologisk Have København en af Europas ældste zoologiske haver. Mere end 3000 dyr, fordelt på over 200 arter, har deres daglige gang i København Zoo.",
                            ExpCategoryId = new Guid("b6f3f639-1450-4334-a123-2b1fb8c68808"),
                            IsDeleted = false,
                            Name = "Zoologisk Have",
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205")
                        },
                        new
                        {
                            Id = new Guid("a11d3b85-04d9-4665-bea8-91ac47f6a2d8"),
                            Address = "Kronborg 2 C",
                            City = "Helsingør",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Kronborg er et af Danmarks mest betydningsfulde slotte og fuld af Danmarkshistorie.",
                            ExpCategoryId = new Guid("037d26c3-66c4-4017-9c54-ca8e72ae56fa"),
                            IsDeleted = false,
                            Name = "Kronborg Slot",
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205")
                        },
                        new
                        {
                            Id = new Guid("f574dea5-088b-4ecf-a0ba-439381cdfabf"),
                            Address = "København",
                            City = "Gammel kongevej 10",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "I Planetarium kan du opleve stjernehimlen, galakser og planeter helt tæt på - både i deres udstilling, på rumrejser i Kuppelsalen og til foredrag om astronomi og rumfart.",
                            ExpCategoryId = new Guid("b6f3f639-1450-4334-a123-2b1fb8c68808"),
                            IsDeleted = false,
                            Name = "Planetarium",
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205")
                        },
                        new
                        {
                            Id = new Guid("ce9ba768-c6d0-4c1d-842e-2027eb3542d1"),
                            Address = "Gl. Strandvej 13",
                            City = "Humlebæk",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Louisiana Museum of Modern Art er et museum beliggende i en stor gammel park ved Nordsjællands kyst i Humlebæk.",
                            ExpCategoryId = new Guid("b6f3f639-1450-4334-a123-2b1fb8c68808"),
                            IsDeleted = false,
                            Name = "Louisiana",
                            ProfileId = new Guid("62357886-d888-44f2-a929-c015a4b31dad")
                        },
                        new
                        {
                            Id = new Guid("173bf385-9aba-408a-a7ea-8bfe892e91b3"),
                            Address = "Dyrehaven",
                            City = "Klampenborg",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Dyrehaven er en stor naturpark, der ligger nord for København. Dyrehaven rummer skovområder, små søer og åbne sletter, hvor mere end 2000 vilde hjorte har deres daglige gang.",
                            ExpCategoryId = new Guid("45671c48-b7a2-4663-b826-044aeefd59ff"),
                            IsDeleted = false,
                            Name = "Dyrehaven",
                            ProfileId = new Guid("62357886-d888-44f2-a929-c015a4b31dad")
                        });
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.ListOfExps", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.ToTable("ListOfExperiences");
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.ListOfExpsExperience", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ExperienceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ListOfExpsId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ListOfExpsId");

                    b.ToTable("ListOfExpsExperience");
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Profile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)")
                        .HasMaxLength(250);

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(150)")
                        .HasMaxLength(150);

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Profiles");

                    b.HasData(
                        new
                        {
                            Id = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205"),
                            Age = 28,
                            Birthday = new DateTime(1992, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "København",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Jens",
                            Gender = 0,
                            IsDeleted = false,
                            LastName = "Olesen",
                            UserId = new Guid("5376bf6f-3b8c-443c-8c17-28071e8fd1ed")
                        },
                        new
                        {
                            Id = new Guid("62357886-d888-44f2-a929-c015a4b31dad"),
                            Age = 22,
                            Birthday = new DateTime(1998, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Humlebæk",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Annita",
                            Gender = 1,
                            IsDeleted = false,
                            LastName = "Bech Jensen",
                            UserId = new Guid("fa303d07-af85-41c7-8455-29fd9ae6bc9e")
                        },
                        new
                        {
                            Id = new Guid("229f7d4f-ffcc-437d-b3ab-82a0096f9c43"),
                            Age = 25,
                            Birthday = new DateTime(1995, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Ballerup",
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            FirstName = "Frederik",
                            Gender = 0,
                            IsDeleted = false,
                            LastName = "Skov Laursen",
                            UserId = new Guid("53e881e9-1b7a-461f-a286-48476deb343d")
                        });
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Rating", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ExperienceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("RatingCount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Ratings");

                    b.HasData(
                        new
                        {
                            Id = new Guid("fe2f716e-65b3-484a-8a52-42a275f03e7d"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ExperienceId = new Guid("bd345b81-462b-4ba9-999f-48ff44fad5e8"),
                            IsDeleted = false,
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205"),
                            RatingCount = 4
                        },
                        new
                        {
                            Id = new Guid("959ec261-0361-405a-86ef-84a33092ae4a"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            ExperienceId = new Guid("bd345b81-462b-4ba9-999f-48ff44fad5e8"),
                            IsDeleted = false,
                            ProfileId = new Guid("62357886-d888-44f2-a929-c015a4b31dad"),
                            RatingCount = 5
                        });
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Report", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ReviewId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ProfileId");

                    b.HasIndex("ReviewId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Review", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ExperienceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<Guid>("ProfileId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("ExperienceId");

                    b.HasIndex("ProfileId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = new Guid("e7c89ea8-7d68-4d37-b592-fefd69277684"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Er en god oplevelse!",
                            ExperienceId = new Guid("bd345b81-462b-4ba9-999f-48ff44fad5e8"),
                            IsDeleted = false,
                            ProfileId = new Guid("9600bf95-bf37-4e6d-aeed-53d84a96a205")
                        },
                        new
                        {
                            Id = new Guid("fb68f42a-09a0-45db-9216-7570f68219a4"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Description = "Elsker maden",
                            ExperienceId = new Guid("bd345b81-462b-4ba9-999f-48ff44fad5e8"),
                            IsDeleted = false,
                            ProfileId = new Guid("62357886-d888-44f2-a929-c015a4b31dad")
                        });
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTimeOffset>("CreatedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<DateTimeOffset?>("DeletedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("ModifiedOn")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AdminUsers");

                    b.HasData(
                        new
                        {
                            Id = new Guid("5376bf6f-3b8c-443c-8c17-28071e8fd1ed"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "user1@user.dk",
                            IsDeleted = false,
                            Password = "password",
                            Username = "user1"
                        },
                        new
                        {
                            Id = new Guid("fa303d07-af85-41c7-8455-29fd9ae6bc9e"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "user2@user.dk",
                            IsDeleted = false,
                            Password = "password",
                            Username = "user2"
                        },
                        new
                        {
                            Id = new Guid("53e881e9-1b7a-461f-a286-48476deb343d"),
                            CreatedOn = new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)),
                            Email = "user3@user.dk",
                            IsDeleted = false,
                            Password = "password",
                            Username = "user3"
                        });
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Experience", b =>
                {
                    b.HasOne("OplevOgDel.Api.Data.Models.ExpCategory", "Category")
                        .WithMany()
                        .HasForeignKey("ExpCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OplevOgDel.Api.Data.Models.Profile", "Creator")
                        .WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.ListOfExps", b =>
                {
                    b.HasOne("OplevOgDel.Api.Data.Models.Profile", "Creator")
                        .WithMany("ListOfExps")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.ListOfExpsExperience", b =>
                {
                    b.HasOne("OplevOgDel.Api.Data.Models.Experience", "Experience")
                        .WithMany("ListOfExpsExperiences")
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OplevOgDel.Api.Data.Models.ListOfExps", "ListOfExps")
                        .WithMany("ListOfExpsExperiences")
                        .HasForeignKey("ListOfExpsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Profile", b =>
                {
                    b.HasOne("OplevOgDel.Api.Data.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Rating", b =>
                {
                    b.HasOne("OplevOgDel.Api.Data.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OplevOgDel.Api.Data.Models.Profile", "Creator")
                        .WithMany("Ratings")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Report", b =>
                {
                    b.HasOne("OplevOgDel.Api.Data.Models.Profile", "Creator")
                        .WithMany("Reports")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("OplevOgDel.Api.Data.Models.Review", "Review")
                        .WithMany()
                        .HasForeignKey("ReviewId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OplevOgDel.Api.Data.Models.Review", b =>
                {
                    b.HasOne("OplevOgDel.Api.Data.Models.Experience", "Experience")
                        .WithMany()
                        .HasForeignKey("ExperienceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OplevOgDel.Api.Data.Models.Profile", "Creator")
                        .WithMany("Reviews")
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
