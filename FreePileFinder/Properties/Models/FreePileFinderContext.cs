using Microsoft.EntityFrameworkCore;
using System;

namespace FreePileFinder.Models
{
  public class FreePileFinderContext : DbContext
  {
    public FreePileFinderContext(DbContextOptions<FreePileFinderContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
    
      builder.Entity<Pile>()
          .HasData(
              // new Animal { AnimalId = 1, Name = "Matilda", Species = "Woolly Mammoth", Age = 7, Gender = "Female" }
new Pile {	 PileId  = 1,	 UserId  = 4,	CreatedDate = DateTime.Now,	 Title  = "Roommate cleanout",	 Description  = "Entire contents of bedroom",	Availability = true,	 State  = "OR",	 City  = "Portland",	Lat = 45.58868933,	Lng = -122.56404786,	 Zipcode  = "97211"	},
new Pile {	 PileId  = 2,	 UserId  = 3,	CreatedDate = DateTime.Now,	 Title  = "Dog figurine collection",	 Description  = "Looks like 100+ figurines of all types",	Availability = true,	 State  = "WA",	 City  = "Vancouver",	Lat = 45.65467058,	Lng = -122.53756002,	 Zipcode  = "98682"	},
new Pile {	 PileId  = 3,	 UserId  = 3,	CreatedDate = DateTime.Now,	 Title  = "Sports equipment",	 Description  = "Sports equipment",	Availability = true,	 State  = "OR",	 City  = "Portland",	Lat = 45.48192877,	Lng = -122.5580511,	 Zipcode  = "97266"	},
new Pile {	 PileId  = 4,	 UserId  = 2,	CreatedDate = DateTime.Now,	 Title  = "Metal junk",	 Description  = "Metal junk",	Availability = true,	 State  = "WA",	 City  = "Vancouver",	Lat = 45.67403396,	Lng = -122.74122815,	 Zipcode  = "98660"	},
new Pile {	 PileId  = 5,	 UserId  = 1,	CreatedDate = DateTime.Now,	 Title  = "Books",	 Description  = "Books",	Availability = true,	 State  = "OR",	 City  = "Portland",	Lat = 45.57305467,	Lng = -122.64396572,	 Zipcode  = "97211"	},
new Pile {	 PileId  = 6,	 UserId  = 4,	CreatedDate = DateTime.Now,	 Title  = "Clothes dresser",	 Description  = "looks useable",	Availability = true,	 State  = "WA",	 City  = "Vancouver",	Lat = 45.70731546,	Lng = -122.70110881,	 Zipcode  = "98685"	},
new Pile {	 PileId  = 7,	 UserId  = 1,	CreatedDate = DateTime.Now,	 Title  = "Shoes",	 Description  = "4 pairs, size men's 10",	Availability = true,	 State  = "OR",	 City  = "Portland",	Lat = 45.48733436,	Lng = -122.76339164,	 Zipcode  = "97225"	},
new Pile {	 PileId  = 8,	 UserId  = 5,	CreatedDate = DateTime.Now,	 Title  = "Box of women's clothes",	 Description  = "size medium",	Availability = true,	 State  = "OR",	 City  = "Portland",	Lat = 45.34753517,	Lng = -122.66505906,	 Zipcode  = "97068"	},
new Pile {	 PileId  = 9,	 UserId  = 6,	CreatedDate = DateTime.Now,	 Title  = "Garden tools",	 Description  = "2 shovels, 1 hoe, 1 hose",	Availability = true,	 State  = "OR",	 City  = "Portland",	Lat = 45.60441824,	Lng = -122.8296801,	 Zipcode  = "97231"	},
new Pile {	 PileId  = 10,	 UserId  = 2,	CreatedDate = DateTime.Now,	 Title  = "Kids toys",	 Description  = "Looks well loved, but has some more life in them",	Availability = true,	 State  = "OR",	 City  = "Portland",	Lat = 45.57066628,	Lng = -122.59853484,	 Zipcode  = "97218"	}
          );
    }
    public DbSet<Pile> Piles { get; set; }
  }
}  