using Homework4_Solution.Models;

using var db = new AppDbContext();

db.Database.EnsureDeleted();
db.Database.EnsureCreated();

Product NeuralImplant = new Product { Name = "MindSync", Description = "Neural Implant Device", Price = 1995.99M };
Product AIAssistant = new Product { Name = "Seraphine", Description = "AI Assistant", Price = 200.00M };
Product DeathRay = new Product { Name = "SoulSear", Description = "Military Grade Death Ray", Price = 4300000000M };
Product Mouse = new Product { Name = "PhantomClaw", Description = "High Quality Gaming Mouse", Price = 99.95M };

db.Add(NeuralImplant);
db.Add(AIAssistant);
db.Add(DeathRay);
db.Add(Mouse);
db.SaveChanges();

while (true)
{
    Console.Write($"(A)dd a product, (U)pdate a product, (R)emove a product, (L)ist all products> ");
    string input = Console.ReadLine()!.ToLower();

    if (input == "a")
    {
        Product newProduct = new Product();
        Console.Write("Enter a name for the new product: ");
        newProduct.Name = Console.ReadLine()!;

        Console.Write("Enter a description: ");
        newProduct.Description = Console.ReadLine()!;

        bool invalid = true;
        while (invalid)
        {
            Console.Write("Enter a price: ");
            try
            {
                newProduct.Price = decimal.Parse(Console.ReadLine()!, System.Globalization.NumberStyles.Currency);
                invalid = false;
            } 
            catch
            {
                Console.WriteLine("Invalid input. Try again.");
            }
        } 

        db.Add(newProduct);
        db.SaveChanges();
    }
    else if (input == "u")
    {
        Console.Write("Enter the Product ID to update: ");
        int pk = Convert.ToInt32(Console.ReadLine());
        Product? productToUpdate = db.Products.Find(pk);
        if (productToUpdate != null)
        {
            Console.Write($"Name [{productToUpdate.Name}] (Leave empty for no change): ");
            string? change = Console.ReadLine();
            if (change != null && change != "") productToUpdate.Name = change;

            Console.Write($"Description [{productToUpdate.Description}]: ");
            change = Console.ReadLine();
            if (change != null && change != "") productToUpdate.Description = change;

            Console.Write($"Price [{productToUpdate.Price}]: ");
            change = Console.ReadLine();
            if (change != null && change != "") 
            {
                bool invalid = true;
                while (invalid)
                {
                    try
                    {
                        productToUpdate.Price = decimal.Parse(change, System.Globalization.NumberStyles.Currency);
                        invalid = false;
                    }
                    catch
                    {

                    }
                }
            }
        }
        else
        {
            Console.WriteLine("Product NOT found.");
        }
    }
    else if (input == "r")
    {
        Console.Write("Enter the Product ID to update: ");
        int pk = Convert.ToInt32(Console.ReadLine());
        Product? productToRemove = db.Products.Find(pk);
        if (productToRemove != null)
        {
            Console.Write($"Are you sure you want to remove - {productToRemove} [Y/N]? ");
            string? yesno = Console.ReadLine();
            if (yesno != null && yesno.ToLower() == "y")
            {
                db.Remove(productToRemove);
                db.SaveChanges();
                Console.WriteLine("Product removed.");
            }
            else
            {
                Console.WriteLine("Product NOT removed.");
            }
        }
        else
        {
            Console.WriteLine("Product NOT found.");
        }

    }
    else if (input == "l")
    {
        foreach(Product p in db.Products)
        {
            Console.WriteLine(p);
        }
        Console.WriteLine();
    }
}