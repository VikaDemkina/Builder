// Класс заказа на кофе
class CoffeeOrder
{
    public string Size { get; set; }
    public string Type { get; set; }
    public bool Milk { get; set; }
    public bool Sugar { get; set; }

    public void Display()
    {
        Console.WriteLine("Размер: " + Size);
        Console.WriteLine("Тип: " + Type);
        Console.WriteLine("Молоко: " + (Milk ? "Да" : "Нет"));
        Console.WriteLine("Сахар: " + (Sugar ? "Да" : "Нет"));
    }
}
