//In
/*
· A string, representing a product - "coffee", "water", "coke", "snacks"
· An integer, representing the quantity of the product
 */
string product = Console.ReadLine();
int productQty=int.Parse(Console.ReadLine());

CalculatedPricePerProduct(product, productQty);


void CalculatedPricePerProduct(string type,int qty)
{
    double price = 0.00;
    switch (type)
    {
        case "coffee":price = qty * 1.50;
           
            break;
        case "water":
            price = qty * 1.00;
            
            break;
        case "coke":
            price = qty * 1.40;
            
            break;

        case "snacks":
            price = qty * 2.00;
           
            break;

    }
    Console.WriteLine($"{price:F2}");
}
/*
· coffee – 1.50
· water – 1.00
· coke – 1.40
· snacks – 2.00
*/

//out
//prints the total price of an order