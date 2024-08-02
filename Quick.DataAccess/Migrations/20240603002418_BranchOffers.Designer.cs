﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Quick.DataAccess.Data;

#nullable disable

namespace Quick.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240603002418_BranchOffers")]
    partial class BranchOffers
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("nvarchar(21)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Quick.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("CategoryId");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            DisplayOrder = 1,
                            Name = "Starters"
                        },
                        new
                        {
                            CategoryId = 2,
                            DisplayOrder = 2,
                            Name = "Salads"
                        },
                        new
                        {
                            CategoryId = 3,
                            DisplayOrder = 3,
                            Name = "Sandwiches"
                        },
                        new
                        {
                            CategoryId = 4,
                            DisplayOrder = 4,
                            Name = "Burgers"
                        },
                        new
                        {
                            CategoryId = 5,
                            DisplayOrder = 5,
                            Name = "Pasta"
                        },
                        new
                        {
                            CategoryId = 6,
                            DisplayOrder = 6,
                            Name = "Dessert"
                        },
                        new
                        {
                            CategoryId = 7,
                            DisplayOrder = 7,
                            Name = "Beverages"
                        });
                });

            modelBuilder.Entity("Quick.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CategoryId = 1,
                            Description = "A basket of our original unpeeled French fries, crisped to golden perfection.",
                            ImageUrl = "",
                            Name = "IMPORTED SKIN-ON FRIES",
                            Price = 5.0
                        },
                        new
                        {
                            ProductId = 2,
                            CategoryId = 1,
                            Description = "A basket of fresh crunchy fries. With a twist.",
                            ImageUrl = "",
                            Name = "CURLY FRIES",
                            Price = 6.0
                        },
                        new
                        {
                            ProductId = 3,
                            CategoryId = 1,
                            Description = "Our original unpeeled French fries, topped with melted cheese and served with sour cream on the side.",
                            ImageUrl = "",
                            Name = "FRIES ‘N’ CHEDDAR",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 4,
                            CategoryId = 1,
                            Description = "Our signature lightly breaded chicken strips that you know and love, served with our famous honey mustard dip.",
                            ImageUrl = "",
                            Name = "CHICKEN STRIPS",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 5,
                            CategoryId = 1,
                            Description = "Crispy flour tortilla rolls filled with melted cheese, parsley and garlic, served with salsa fresca on the side.",
                            ImageUrl = "",
                            Name = "CHEESE GARLIC ROLLS",
                            Price = 5.0
                        },
                        new
                        {
                            ProductId = 6,
                            CategoryId = 1,
                            Description = "A soft tortilla shell, grilled to perfection and flavored with our exclusive marinade. Filled with grilled chicken, grilled onions and bell peppers, Edam cheese, crisp Lollo Verde lettuce and our fresh guacamole sauce. Served with sour cream on the side.",
                            ImageUrl = "",
                            Name = "CHICKEN TACOS",
                            Price = 7.0
                        },
                        new
                        {
                            ProductId = 7,
                            CategoryId = 1,
                            Description = "A mouthwatering mix of our buffalo wings, mozzarella sticks, ranch chicken rolls, chicken strips and signature skin-on fries, served with our famous honey mustard and Thousand Island dips.",
                            ImageUrl = "",
                            Name = "SUPER SAMPLER",
                            Price = 15.0
                        },
                        new
                        {
                            ProductId = 8,
                            CategoryId = 1,
                            Description = "Our signature chicken wings, glazed in spicy Buffalo sauce.",
                            ImageUrl = "",
                            Name = "BUFFALO WINGS",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 9,
                            CategoryId = 1,
                            Description = "Our signature chicken wings, glazed in sweet and sassy BBQ sauce.",
                            ImageUrl = "",
                            Name = "BBQ WINGS",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 10,
                            CategoryId = 1,
                            Description = "Our signature lightly breaded chicken strips that you know and love, served with our famous honey mustard dip.",
                            ImageUrl = "",
                            Name = "CHICKEN STRIPS",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 11,
                            CategoryId = 1,
                            Description = "Our classic melt-in-your-mouth mozzarella sticks, served with Thousand Island dip.",
                            ImageUrl = "",
                            Name = "MOZZARELLA STICKS",
                            Price = 6.0
                        },
                        new
                        {
                            ProductId = 12,
                            CategoryId = 2,
                            Description = "Fresh kale topped with juicy flame-grilled shrimp coated with wasabi, sesame seeds, organic quinoa, crunchy\r\npeanuts and dried cranberries. Tossed with sesame balsamic dressing.",
                            ImageUrl = "",
                            Name = "KALE SHRIMP WASABI",
                            Price = 13.0
                        },
                        new
                        {
                            ProductId = 13,
                            CategoryId = 2,
                            Description = "A colorful mix of fresh Lollo Verde lettuce, rocket leaves, basil, avocado and cherry tomatoes. Sprinkled with chia seeds and tossed in our basil vinaigrette dressing.",
                            ImageUrl = "",
                            Name = "FIELD GREENS AVOCADO",
                            Price = 6.0
                        },
                        new
                        {
                            ProductId = 14,
                            CategoryId = 2,
                            Description = "A mix of crisp romaine lettuce, topped with parmesan slices and herbs croutons. Caesar dressing on the side.",
                            ImageUrl = "",
                            Name = "CLASSIC CAESAR",
                            Price = 6.0
                        },
                        new
                        {
                            ProductId = 15,
                            CategoryId = 2,
                            Description = "A mix of crisp romaine lettuce, topped with grilled chicken breast, shredded parmesan and herb croutons. Caesar dressing on the side.",
                            ImageUrl = "",
                            Name = "CHICKEN CAESAR",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 16,
                            CategoryId = 2,
                            Description = "Crisp iceberg lettuce and rocket leaves topped with tender grilled chicken, avocado, hard-boiled eggs and parmesan shavings.",
                            ImageUrl = "",
                            Name = "CHICKEN AVOCADO",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 17,
                            CategoryId = 2,
                            Description = "Pasta mix topped with cheese, fresh iceberg lettuce, fresh mushrooms and corn.",
                            ImageUrl = "",
                            Name = "PASTA ’N’ CHEESE",
                            Price = 8.0
                        },
                        new
                        {
                            ProductId = 18,
                            CategoryId = 2,
                            Description = "A mix of fresh baby mozzarella, grilled chicken tenders, avocado, cherry tomatoes, basil, fresh lettuce mix and red rocket leaves. Served with basil vinaigrette dressing.",
                            ImageUrl = "",
                            Name = "BABY MOZZARELLA ‘N’ CHICKEN",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 19,
                            CategoryId = 3,
                            Description = "Breaded Shrimp, crisp iceberg lettuce, a refreshing cabbage and carrot mix, avocado, crushed peanuts, a sweet chili and vinegar dressing, served in a freshly baked baguette.",
                            ImageUrl = "",
                            Name = "CRISPY SHRIMP AVOCADO",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 20,
                            CategoryId = 3,
                            Description = "Grilled chicken, crisp rocket leaves, sautéed fresh mushrooms and onions, melted cheddar cheese, mayo and our signature B.B.B. sauce, served in a freshly baked baguette.",
                            ImageUrl = "",
                            Name = "SMOKY CHICKEN",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 21,
                            CategoryId = 3,
                            Description = "Juicy flame-grilled shrimp, Lollo Verde, Texas and guacamole sauce, served in a freshly baked baguette.",
                            ImageUrl = "",
                            Name = "SHRIMP GUACAMOLE",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 22,
                            CategoryId = 3,
                            Description = "Grilled chicken breast, edam cheese, avocado, crisp lettuce and garlic home-style sauce, served in freshly baked whole-wheat baguette.",
                            ImageUrl = "",
                            Name = "CHICKEN SLIDER",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 23,
                            CategoryId = 4,
                            Description = "Breaded chicken breast dipped in a Korean sauce, topped with a crispy Philly cheese patty, lettuce, Asian coleslaw, and our new special honey mustard sauce.",
                            ImageUrl = "",
                            Name = "DOUBLE CRISP",
                            Price = 12.0
                        },
                        new
                        {
                            ProductId = 24,
                            CategoryId = 4,
                            Description = "Breaded chicken breast topped with our special mild chili melted cheddar, tortilla chips, dill pickles, our garlic mayo and Cuban sauce.",
                            ImageUrl = "",
                            Name = "CHEESE ‘N’ CHILI",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 25,
                            CategoryId = 4,
                            Description = "Grilled beef patty topped with sautéed onions, melted cheddar cheese, crisp lettuce, a fresh tomato slice, tangy pickles and our classic sauce.",
                            ImageUrl = "",
                            Name = "CLASSIC",
                            Price = 10.0
                        },
                        new
                        {
                            ProductId = 26,
                            CategoryId = 4,
                            Description = "Your choice of grilled or breaded chicken breast topped with crisp lettuce, a fresh tomato slice, tangy pickles and aioli sauce.",
                            ImageUrl = "",
                            Name = "CHICKEN BURGER",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 27,
                            CategoryId = 4,
                            Description = "Tender grilled chicken breast topped with a breaded mozzarella patty, crisp lettuce, a fresh tomato slice, tangy pickles and aioli sauce.",
                            ImageUrl = "",
                            Name = "MIGHTY CHICKEN",
                            Price = 14.0
                        },
                        new
                        {
                            ProductId = 28,
                            CategoryId = 4,
                            Description = "Grilled beef patty topped with grilled onions and green peppers, jalapeños, melted cheddar cheese, crisp lettuce, a fresh tomato slice and hot Cuban sauce.",
                            ImageUrl = "",
                            Name = "CUBAN",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 29,
                            CategoryId = 4,
                            Description = "Grilled beef patty topped with melted Swiss cheese, sautéed fresh mushrooms, caramelized onions, arugula and truffle aioli sauce.",
                            ImageUrl = "",
                            Name = "SWISS TRUFFLE",
                            Price = 12.0
                        },
                        new
                        {
                            ProductId = 30,
                            CategoryId = 5,
                            Description = "Penne mixed with tomato sauce and roasted vegetables.",
                            ImageUrl = "",
                            Name = "VEGAN PASTA",
                            Price = 9.0
                        },
                        new
                        {
                            ProductId = 31,
                            CategoryId = 5,
                            Description = "Penne mixed with tomato sauce and our selection of cheeses, topped with parmesan sprinkles and fresh basil.",
                            ImageUrl = "",
                            Name = "FOUR CHEESE",
                            Price = 12.0
                        },
                        new
                        {
                            ProductId = 32,
                            CategoryId = 5,
                            Description = "Tagliatelle in a creamy sauce with a twist of garlic, sautéed fresh mushrooms and grilled chicken, topped with parmesan sprinkles.",
                            ImageUrl = "",
                            Name = "CHICKEN PASTA",
                            Price = 11.0
                        },
                        new
                        {
                            ProductId = 33,
                            CategoryId = 5,
                            Description = "Tagliatelle in a creamy sauce with a twist of garlic and a dash of zingy ginger, mixed cheese, sautéed onions and fresh mushrooms and flame-grilled shrimp, topped with parmesan sprinkles and fresh basil.",
                            ImageUrl = "",
                            Name = "SHRIMP PASTA",
                            Price = 12.0
                        },
                        new
                        {
                            ProductId = 34,
                            CategoryId = 7,
                            Description = "",
                            ImageUrl = "",
                            Name = "SOFT DRINKS",
                            Price = 2.0
                        },
                        new
                        {
                            ProductId = 35,
                            CategoryId = 7,
                            Description = "",
                            ImageUrl = "",
                            Name = "MINERAL WATER",
                            Price = 1.0
                        },
                        new
                        {
                            ProductId = 36,
                            CategoryId = 7,
                            Description = "Your choice of chocolate, vanilla or strawberry.",
                            ImageUrl = "",
                            Name = "OLD TIME MILKSHAKE",
                            Price = 6.0
                        },
                        new
                        {
                            ProductId = 37,
                            CategoryId = 7,
                            Description = "",
                            ImageUrl = "",
                            Name = "FRESH ORANGE JUICE",
                            Price = 5.0
                        },
                        new
                        {
                            ProductId = 38,
                            CategoryId = 6,
                            Description = "Super-sized pancakes topped with chocolate, bananas, Lotus spread and Lotus biscuits, drizzled in a rich chocolate sauce.",
                            ImageUrl = "",
                            Name = "LOTUS MADNESS",
                            Price = 5.0
                        },
                        new
                        {
                            ProductId = 39,
                            CategoryId = 6,
                            Description = "Pancakes soaked in an exquisite banana rum marinade, topped with sautéed bananas and salted caramel. Served with vanilla ice cream, and sprinkled with buttery biscuit crumbs.",
                            ImageUrl = "",
                            Name = "BANANA O’ RUM",
                            Price = 6.0
                        },
                        new
                        {
                            ProductId = 40,
                            CategoryId = 6,
                            Description = "Strawberry cheesecake ice cream drizzled with strawberry sauce, topped with fresh strawberries and buttery biscuit crumbs.",
                            ImageUrl = "",
                            Name = "CHEESECAKE SUNDAE EXPLOSION",
                            Price = 8.0
                        },
                        new
                        {
                            ProductId = 41,
                            CategoryId = 6,
                            Description = "A rich chocolate brownie topped with vanilla ice cream and salted caramel sauce.",
                            ImageUrl = "",
                            Name = "BROWNIE TEMPTATION",
                            Price = 5.0
                        },
                        new
                        {
                            ProductId = 42,
                            CategoryId = 6,
                            Description = "White chocolate, brownies, strawberries, bananas and Digestive crispy pie on top.",
                            ImageUrl = "",
                            Name = "CHOCO TACOS",
                            Price = 7.0
                        });
                });

            modelBuilder.Entity("Quick.Models.SpecialOffer", b =>
                {
                    b.Property<int>("SpecialOfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SpecialOfferId"));

                    b.Property<string>("Description")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SpecialOfferId");

                    b.ToTable("SpecialOffers");

                    b.HasData(
                        new
                        {
                            SpecialOfferId = 1,
                            Description = "Get up to 10% off when buying any 3 sandwishes",
                            EndDate = new DateTime(2024, 7, 3, 3, 24, 17, 977, DateTimeKind.Local).AddTicks(7787),
                            Name = "Summer Sale",
                            StartDate = new DateTime(2024, 6, 3, 3, 24, 17, 977, DateTimeKind.Local).AddTicks(7732)
                        },
                        new
                        {
                            SpecialOfferId = 2,
                            Description = "buy 2 sandwishes get beverage free ",
                            EndDate = new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "special offer",
                            StartDate = new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Quick.Models.QuickBites.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Quick.Models.Product", b =>
                {
                    b.HasOne("Quick.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
