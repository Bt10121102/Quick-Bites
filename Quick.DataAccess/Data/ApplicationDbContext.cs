
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Quick.DataAccess.Repository.IRepository;
using Quick.Models;
using Quick.Models.QuickBites.Models;
using Quick.Models.ViewModels;



namespace Quick.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Branch> Branches { get; set; }
        public DbSet<SpecialOffer> SpecialOffers { get; set; }













        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            


            modelBuilder.Entity<Category>().HasData(
        new Category { CategoryId = 1, Name = "Starters", DisplayOrder = 1 },
        new Category { CategoryId = 2, Name = "Salads", DisplayOrder = 2 },
        new Category { CategoryId = 3, Name = "Sandwiches", DisplayOrder = 3 },
        new Category { CategoryId = 4, Name = "Burgers", DisplayOrder = 4 },
        new Category { CategoryId = 5, Name = "Pasta", DisplayOrder = 5 },
        new Category { CategoryId = 6, Name = "Dessert", DisplayOrder = 6 },
        new Category { CategoryId = 7, Name = "Beverages", DisplayOrder = 7 });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductId = 1,
                    Name = "IMPORTED SKIN-ON FRIES",
                    Description = "A basket of our original unpeeled French fries, crisped to golden perfection.",
                    CategoryId = 1,
                    Price = 5,
                    ImageUrl = "",




                },
                new Product
                {
                    ProductId = 2,
                    Name = "CURLY FRIES",
                    Description = "A basket of fresh crunchy fries. With a twist.",
                    CategoryId = 1,
                    Price = 6,
                    ImageUrl = "",




                },
                new Product
                {
                    ProductId = 3,
                    Name = "FRIES ‘N’ CHEDDAR",
                    Description = "Our original unpeeled French fries, topped with melted cheese and served with sour cream on the side.",
                    CategoryId = 1,
                    Price = 9,
                    ImageUrl = "",




                },

        new Product
        {
            ProductId = 4,
            Name = "CHICKEN STRIPS",
            Description = "Our signature lightly breaded chicken strips that you know and love, served with our famous honey mustard dip.",
            CategoryId = 1,
            Price = 9,
            ImageUrl = "",




        },

        new Product
        {
            ProductId = 5,
            Name = "CHEESE GARLIC ROLLS",
            Description = "Crispy flour tortilla rolls filled with melted cheese, parsley and garlic, served with salsa fresca on the side.",
            CategoryId = 1,
            Price = 5,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 6,
            Name = "CHICKEN TACOS",
            Description = "A soft tortilla shell, grilled to perfection and flavored with our exclusive marinade. Filled with grilled chicken, grilled onions and bell peppers, Edam cheese, crisp Lollo Verde lettuce and our fresh guacamole sauce. Served with sour cream on the side.",
            CategoryId = 1,
            Price = 7,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 7,
            Name = "SUPER SAMPLER",
            Description = "A mouthwatering mix of our buffalo wings, mozzarella sticks, ranch chicken rolls, chicken strips and signature skin-on fries, served with our famous honey mustard and Thousand Island dips.",
            CategoryId = 1,
            Price = 15,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 8,
            Name = "BUFFALO WINGS",
            Description = "Our signature chicken wings, glazed in spicy Buffalo sauce.",
            CategoryId = 1,
            Price = 10,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 9,
            Name = "BBQ WINGS",
            Description = "Our signature chicken wings, glazed in sweet and sassy BBQ sauce.",
            CategoryId = 1,
            Price = 10,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 10,
            Name = "CHICKEN STRIPS",
            Description = "Our signature lightly breaded chicken strips that you know and love, served with our famous honey mustard dip.",
            CategoryId = 1,
            Price = 9,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 11,
            Name = "MOZZARELLA STICKS",
            Description = "Our classic melt-in-your-mouth mozzarella sticks, served with Thousand Island dip.",
            CategoryId = 1,
            Price = 6,
            ImageUrl = "",




        },

        new Product
        {
            ProductId = 12,
            Name = "KALE SHRIMP WASABI",
            Description = "Fresh kale topped with juicy flame-grilled shrimp coated with wasabi, sesame seeds, organic quinoa, crunchy\r\npeanuts and dried cranberries. Tossed with sesame balsamic dressing.",
            CategoryId = 2,
            Price = 13,
            ImageUrl = "images\\product\\025cd8e9-fd3e-4fad-b931-180f8335b16f.PNG",




        },
        new Product
        {
            ProductId = 13,
            Name = "FIELD GREENS AVOCADO",
            Description = "A colorful mix of fresh Lollo Verde lettuce, rocket leaves, basil, avocado and cherry tomatoes. Sprinkled with chia seeds and tossed in our basil vinaigrette dressing.",
            CategoryId = 2,
            Price = 6,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 14,
            Name = "CLASSIC CAESAR",
            Description = "A mix of crisp romaine lettuce, topped with parmesan slices and herbs croutons. Caesar dressing on the side.",
            CategoryId = 2,
            Price = 6,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 15,
            Name = "CHICKEN CAESAR",
            Description = "A mix of crisp romaine lettuce, topped with grilled chicken breast, shredded parmesan and herb croutons. Caesar dressing on the side.",
            CategoryId = 2,
            Price = 9,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 16,
            Name = "CHICKEN AVOCADO",
            Description = "Crisp iceberg lettuce and rocket leaves topped with tender grilled chicken, avocado, hard-boiled eggs and parmesan shavings.",
            CategoryId = 2,
            Price = 9,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 17,
            Name = "PASTA ’N’ CHEESE",
            Description = "Pasta mix topped with cheese, fresh iceberg lettuce, fresh mushrooms and corn.",
            CategoryId = 2,
            Price = 8,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 18,
            Name = "BABY MOZZARELLA ‘N’ CHICKEN",
            Description = "A mix of fresh baby mozzarella, grilled chicken tenders, avocado, cherry tomatoes, basil, fresh lettuce mix and red rocket leaves. Served with basil vinaigrette dressing.",
            CategoryId = 2,
            Price = 10,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 19,
            Name = "CRISPY SHRIMP AVOCADO",
            Description = "Breaded Shrimp, crisp iceberg lettuce, a refreshing cabbage and carrot mix, avocado, crushed peanuts, a sweet chili and vinegar dressing, served in a freshly baked baguette.",
            CategoryId = 3,
            Price = 9,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 20,
            Name = "SMOKY CHICKEN",
            Description = "Grilled chicken, crisp rocket leaves, sautéed fresh mushrooms and onions, melted cheddar cheese, mayo and our signature B.B.B. sauce, served in a freshly baked baguette.",
            CategoryId = 3,
            Price = 9,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 21,
            Name = "SHRIMP GUACAMOLE",
            Description = "Juicy flame-grilled shrimp, Lollo Verde, Texas and guacamole sauce, served in a freshly baked baguette.",
            CategoryId = 3,
            Price = 10,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 22,
            Name = "CHICKEN SLIDER",
            Description = "Grilled chicken breast, edam cheese, avocado, crisp lettuce and garlic home-style sauce, served in freshly baked whole-wheat baguette.",
            CategoryId = 3,
            Price = 10,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 23,
            Name = "DOUBLE CRISP",
            Description = "Breaded chicken breast dipped in a Korean sauce, topped with a crispy Philly cheese patty, lettuce, Asian coleslaw, and our new special honey mustard sauce.",
            CategoryId = 4,
            Price = 12,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 24,
            Name = "CHEESE ‘N’ CHILI",
            Description = "Breaded chicken breast topped with our special mild chili melted cheddar, tortilla chips, dill pickles, our garlic mayo and Cuban sauce.",
            CategoryId = 4,
            Price = 10,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 25,
            Name = "CLASSIC",
            Description = "Grilled beef patty topped with sautéed onions, melted cheddar cheese, crisp lettuce, a fresh tomato slice, tangy pickles and our classic sauce.",
            CategoryId = 4,
            Price = 10,
            ImageUrl = "",





        },
        new Product
        {
            ProductId = 26,
            Name = "CHICKEN BURGER",
            Description = "Your choice of grilled or breaded chicken breast topped with crisp lettuce, a fresh tomato slice, tangy pickles and aioli sauce.",
            CategoryId = 4,
            Price = 9,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 27,
            Name = "MIGHTY CHICKEN",
            Description = "Tender grilled chicken breast topped with a breaded mozzarella patty, crisp lettuce, a fresh tomato slice, tangy pickles and aioli sauce.",
            CategoryId = 4,
            Price = 14,
            ImageUrl = "",




        },
        new Product
        {
            ProductId = 28,
            Name = "CUBAN",
            Description = "Grilled beef patty topped with grilled onions and green peppers, jalapeños, melted cheddar cheese, crisp lettuce, a fresh tomato slice and hot Cuban sauce.",
            CategoryId = 4,
            Price = 9,
            ImageUrl = "",




        },
         new Product
         {
             ProductId = 29,
             Name = "SWISS TRUFFLE",
             Description = "Grilled beef patty topped with melted Swiss cheese, sautéed fresh mushrooms, caramelized onions, arugula and truffle aioli sauce.",
             CategoryId = 4,
             Price = 12,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 30,
             Name = "VEGAN PASTA",
             Description = "Penne mixed with tomato sauce and roasted vegetables.",
             CategoryId = 5,
             Price = 9,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 31,
             Name = "FOUR CHEESE",
             Description = "Penne mixed with tomato sauce and our selection of cheeses, topped with parmesan sprinkles and fresh basil.",
             CategoryId = 5,
             Price = 12,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 32,
             Name = "CHICKEN PASTA",
             Description = "Tagliatelle in a creamy sauce with a twist of garlic, sautéed fresh mushrooms and grilled chicken, topped with parmesan sprinkles.",
             CategoryId = 5,
             Price = 11,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 33,
             Name = "SHRIMP PASTA",
             Description = "Tagliatelle in a creamy sauce with a twist of garlic and a dash of zingy ginger, mixed cheese, sautéed onions and fresh mushrooms and flame-grilled shrimp, topped with parmesan sprinkles and fresh basil.",
             CategoryId = 5,
             Price = 12,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 34,
             Name = "SOFT DRINKS",
             Description = "",
             CategoryId = 7,
             Price = 2,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 35,
             Name = "MINERAL WATER",
             Description = "",
             CategoryId = 7,
             Price = 1,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 36,
             Name = "OLD TIME MILKSHAKE",
             Description = "Your choice of chocolate, vanilla or strawberry.",
             CategoryId = 7,
             Price = 6,
             ImageUrl = "",




         },

         new Product
         {
             ProductId = 37,
             Name = "FRESH ORANGE JUICE",
             Description = "",
             CategoryId = 7,
             Price = 5,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 38,
             Name = "LOTUS MADNESS",
             Description = "Super-sized pancakes topped with chocolate, bananas, Lotus spread and Lotus biscuits, drizzled in a rich chocolate sauce.",
             CategoryId = 6,
             Price = 5,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 39,
             Name = "BANANA O’ RUM",
             Description = "Pancakes soaked in an exquisite banana rum marinade, topped with sautéed bananas and salted caramel. Served with vanilla ice cream, and sprinkled with buttery biscuit crumbs.",
             CategoryId = 6,
             Price = 6,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 40,
             Name = "CHEESECAKE SUNDAE EXPLOSION",
             Description = "Strawberry cheesecake ice cream drizzled with strawberry sauce, topped with fresh strawberries and buttery biscuit crumbs.",
             CategoryId = 6,
             Price = 8,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 41,
             Name = "BROWNIE TEMPTATION",
             Description = "A rich chocolate brownie topped with vanilla ice cream and salted caramel sauce.",
             CategoryId = 6,
             Price = 5,
             ImageUrl = "",




         },
         new Product
         {
             ProductId = 42,
             Name = "CHOCO TACOS",
             Description = "White chocolate, brownies, strawberries, bananas and Digestive crispy pie on top.",
             CategoryId = 6,
             Price = 7,
             ImageUrl = "",




         });

            modelBuilder.Entity<Branch>().HasData(
                       new Branch { BranchId = 1, Name = "QuickBites", Address = "Backyard Hazmieh", PhoneNumber = "71-422-501", Manager = "Hadi Shweiry" },
                       new Branch { BranchId = 2, Name = "QuickBites", Address = " City Center", PhoneNumber = "71-456-789", Manager = "Jad Sawaya" },
                       new Branch { BranchId = 3, Name = "QuickBites", Address = "ABC Verdun", PhoneNumber = "71-654-321", Manager = "Ali Sbeity" },
                       new Branch { BranchId = 4, Name = "QuickBites", Address = "Le Mall", PhoneNumber = "71-555-555", Manager = "Ilias Zein" }
                   );
        
       
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<SpecialOffer>().HasData(
                new SpecialOffer
                {
                    SpecialOfferId = 1,
                    Name = "Holiday Combo",
                    Description = "Get 25% off any burger combo with side salad and a drink this holiday season!",
                    StartDate = new DateTime(2024, 6, 1),
                    EndDate = new DateTime(2024, 6, 30)
                },
                new SpecialOffer
                {
                    SpecialOfferId = 2,
                    Name = "Summer Special",
                    Description = "Enjoy a 15% discount on all salads this summer!",
                    StartDate = new DateTime(2024, 6, 1),
                    EndDate = new DateTime(2024, 7, 30)
                },
                new SpecialOffer
                {
                    SpecialOfferId = 3,
                    Name = "Monday Brunch",
                    Description = "Brunch with us for a 15% discount  from 11 am till 1 pm every monday!",
                    StartDate = new DateTime(2024, 6, 1),
                    EndDate = new DateTime(2024, 6, 30)
                }
            );
        }

    }
}

















   
