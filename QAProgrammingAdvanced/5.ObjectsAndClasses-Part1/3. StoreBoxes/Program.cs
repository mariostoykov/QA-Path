
using System.Globalization;

public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }
    public decimal PriceForABox
    {
        get
        {
            return Item.Price * ItemQuantity;
        }
    }
}

public class Program
{
    public static void Main()
    {
        List<Box> boxes = new List<Box>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
            {
                break;
            }

            string[] parts = input.Split(' ');
            string serialNumber = parts[0];
            string itemName = parts[1];
            int itemQuantity = int.Parse(parts[2]);
            decimal itemPrice = decimal.Parse(parts[3], CultureInfo.InvariantCulture);

            Item item = new Item
            {
                Name = itemName,
                Price = itemPrice
            };

            Box box = new Box
            {
                SerialNumber = serialNumber,
                Item = item,
                ItemQuantity = itemQuantity
            };

            boxes.Add(box);
        }

        var sortedBoxes = boxes.OrderByDescending(b  => b.PriceForABox);

        foreach (var  box in sortedBoxes)
        {
            Console.WriteLine(box.SerialNumber);
            Console.WriteLine($"-- {box.Item.Name} – ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.PriceForABox:F2}");
        }
    }
}
