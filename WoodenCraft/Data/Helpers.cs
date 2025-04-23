namespace WoodenCraft;

public class Helper
{
  public static List<Craft> GetCrafts()
  {
    List<Craft> crafts = [];

    Craft craft = new Craft
    {
      Id = 1000,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/1.png"
    };
    crafts.Add(craft);


    craft = new Craft
    {
      Id = 1001,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/2.png"
    };
    crafts.Add(craft);
    
    craft = new Craft
    {
      Id = 1002,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/3.png"
    };
    crafts.Add(craft);
    
    craft = new Craft
    {
      Id = 1003,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/4.png"
    };
    crafts.Add(craft);
    
    craft = new Craft
    {
      Id = 1004,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/5.png"
    };
    crafts.Add(craft);
    
    craft = new Craft
    {
      Id = 1005,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/6.png"
    };
    crafts.Add(craft);
    
    craft = new Craft
    {
      Id = 1006,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/7.png"
    };
    crafts.Add(craft);
    
    craft = new Craft
    {
      Id = 1007,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/8.png"
    };
    crafts.Add(craft);
    
    craft = new Craft
    {
      Id = 1007,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/8.png"
    };
    crafts.Add(craft);
    craft = new Craft
    {
      Id = 1007,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/8.png"
    };
    crafts.Add(craft);
    craft = new Craft
    {
      Id = 1007,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/8.png"
    };
    crafts.Add(craft);
    craft = new Craft
    {
      Id = 1007,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/8.png"
    };
    crafts.Add(craft);
    craft = new Craft
    {
      Id = 1007,
      Name = "Night Light",
      Description = "Made up of wood",
      Size = 48,
      Price = 99.99,
      Url = "images/crafts/8.png"
    };
    crafts.Add(craft);
    
    return crafts;
  }

  public static List<string> GetImages()
  {
    List<string> images = [];

    for (int i = 1; i <= 3; i++)
    {
      images.Add($"images/crafts/{i}.png");
    }
    
    return images;
  }

  
}
