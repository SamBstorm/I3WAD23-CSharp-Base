namespace Exo_15_ListeCourse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> shoppingList = new Dictionary<string, int>();
            string choix;

            do
            {
                Console.Clear();
                foreach (KeyValuePair<string, int> productQuantity in shoppingList)
                {
                    Console.WriteLine($"\t-\t{productQuantity.Key}\tx {productQuantity.Value}");
                }

                if (shoppingList.Count <= 0) { Console.WriteLine("Votre liste est vide ..."); }

                Console.WriteLine(
    @"Veuillez faire un choix :
+ : Pour ajouter un article
- : Pour supprimer un article
m : Pour modifier la quantité
q : Pour quitter l'application");

                do
                {
                    choix = Console.ReadLine().Trim().ToLower();
                } while (choix != "+" && choix != "-" && choix != "m" && choix != "q");

                string product_name;
                int quantity;
                switch (choix)
                {
                    case "+":
                        Console.Write("Quel est le nom du produit ? ");
                        product_name = Console.ReadLine();
                        if(!(product_name is null) && !shoppingList.ContainsKey(product_name))
                        {
                            Console.Write("Combien en faut-il ? ");
                            do { } while (!int.TryParse(Console.ReadLine(), out quantity));
                            if(quantity > 0)
                            {
                                shoppingList.Add(product_name, quantity);
                            }
                            else
                            {
                                Console.WriteLine($"Quantité non-valide : {quantity}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Nom du produit non-valide : {product_name}");
                        }
                        break;
                    case "-":
                        Console.Write("Quel est le nom du produit ? ");
                        product_name = Console.ReadLine();
                        if (!(product_name is null) && shoppingList.ContainsKey(product_name))
                        {
                            shoppingList.Remove(product_name);
                        }
                        else
                        {
                            Console.WriteLine($"Nom du produit non-valide : {product_name}");
                        }
                        break;
                    case "m":
                        Console.Write("Quel est le nom du produit ? ");
                        product_name = Console.ReadLine();
                        if (!(product_name is null) && shoppingList.ContainsKey(product_name))
                        {
                            Console.Write("Combien en faut-il ? ");
                            do { } while (!int.TryParse(Console.ReadLine(), out quantity));
                            if (quantity > 0)
                            {
                                shoppingList[product_name] = quantity;
                            }
                            else
                            {
                                Console.WriteLine($"Quantité non-valide : {quantity}");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Nom du produit non-valide : {product_name}");
                        }
                        break;
                } 
            } while (choix != "q");
        }
    }
}