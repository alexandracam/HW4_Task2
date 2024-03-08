// Alexandra Camarena
// MIS 3013
// HW4 Task 2

string userChoiceStr;// yes/no
string menuStr = GetMenu();
Console.WriteLine(menuStr);
string outMesStr;
do
{
    outMesStr = "\nWhat do you want to order ? ";
    Console.Write(outMesStr);
    string userItemStr = Console.ReadLine();
    double price = CalculatePrice(userItemStr);

    Console.WriteLine("\nYour Receipt");
    Console.WriteLine(userItemStr);

    ShowReceipt(price);

    Console.WriteLine("\nWould you like to order anything else? (yes / no) ");
    userChoiceStr = Console.ReadLine();
}
while (userChoiceStr == "yes");

Console.WriteLine("\nThank you and Goodbye!");


Console.ReadKey();

double CalculatePrice(string itemName)
{
    if (itemName == "Fresh Coffee")
    {
        return 2.25;
    }
    else if (itemName == "Café au lait")
    {
        return 3.72;
    }
    else if (itemName == "Latte")
    {
        return 4.03;
    }
    else if (itemName == "Hot Chocolate")
    {
        return 3.51;
    }
    else if (itemName == "Pumpkin Spice")
    {
        return 7.30;
    }
    else 
    {
        return 0;
    }
}

void ShowReceipt(double price)
{
    double subtotal = price;
    string outMesStr = string.Format($"Subtotal: {price:C2}");
    Console.WriteLine( outMesStr );

    double tax = price * 8.5 / 100;
    outMesStr = string.Format($"Tax: {price * 8.5/100:C2}");
    Console.WriteLine(outMesStr);

    double total = subtotal + tax;
    outMesStr = string.Format($"Total: {total:C2}");
    Console.WriteLine(outMesStr);

}
string GetMenu()
{
    //string rStr = "Coffee Shop Menu\nFresh Coffee ------ $2.25\nCafé au lait------ $3.72\nLatte------ $4.03\nHot Chocolate ------ $3.51\nPumpkin Spice ------ $7.30";
    //return rStr;
    return "Coffee Shop Menu\nFresh Coffee ------ $2.25\nCafé au lait------ $3.72\nLatte------ $4.03\nHot Chocolate ------ $3.51\nPumpkin Spice ------ $7.30";
}