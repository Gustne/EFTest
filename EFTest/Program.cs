
using EFTest;


VareDbContext db = new VareDbContext();

/*List<Item> items = new List<Item>
        {
            new Item { Name = "Whiskey", Description = "Single malt Scotch whiskey", Stock = 20, Price = 49.99 },
            new Item { Name = "Vodka", Description = "Russian vodka", Stock = 15, Price = 29.99 },
            new Item { Name = "Rum", Description = "Caribbean rum", Stock = 25, Price = 39.99 },
            new Item { Name = "Gin", Description = "London dry gin", Stock = 18, Price = 34.99 },
            new Item { Name = "Tequila", Description = "Mexican tequila", Stock = 12, Price = 44.99 },
            new Item { Name = "Brandy", Description = "French brandy", Stock = 22, Price = 54.99 },
            new Item { Name = "Scotch", Description = "Blended Scotch whiskey", Stock = 17, Price = 47.99 },
            new Item { Name = "Bourbon", Description = "Kentucky bourbon whiskey", Stock = 19, Price = 42.99 },
            new Item { Name = "Sake", Description = "Japanese rice wine", Stock = 14, Price = 37.99 },
            new Item { Name = "Cognac", Description = "French cognac", Stock = 16, Price = 59.99 }
        };

foreach (var item in items)
{
    await db.Items.AddAsync(item);
}

await db.SaveChangesAsync();*/


// her laver vi ændring på 1
Item itemUpdate = db.Items.FirstOrDefault(x => x.Id == 3);

if (itemUpdate != null)
{
    itemUpdate.Price = 232.13;
    itemUpdate.Stock = 1233;
    await db.SaveChangesAsync();
}
// Her sletter vi en

Item itemSlet = db.Items.FirstOrDefault(x => x.Id == 7);

if (itemSlet != null)
{
    db.Items.Remove(itemSlet);
    await db.SaveChangesAsync();
}

// her udskriver vi første og sidste

Item firstItem = db.Items.FirstOrDefault();
Item lastItem = db.Items.OrderByDescending(item => item.Id).First();

Console.WriteLine(firstItem.ToString());
Console.WriteLine(lastItem.ToString());