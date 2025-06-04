string[] snacks = { "sushi", "pizza", "schawarma", "chicken nuggets", "indian street food", "pelmens" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"Tonight we are going to eat {snacks[randomIndex]}.");
