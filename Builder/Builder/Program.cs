class Program
{
    static void Main(string[] args)
    {
        Barista barista = new Barista();
        CoffeeOrderBuilder smallCoffeeOrderBuilder = new SmallCoffeeOrderBuilder();
        barista.SetCoffeeOrderBuilder(smallCoffeeOrderBuilder);
        barista.TakeOrder();
        CoffeeOrder smallCoffeeOrder = barista.GetCoffeeOrder();
        smallCoffeeOrder.Display();

        barista = new Barista();
        CoffeeOrderBuilder largeCoffeeOrderBuilder = new LargeCoffeeOrderBuilder();
        barista.SetCoffeeOrderBuilder(largeCoffeeOrderBuilder);
        barista.TakeOrder();
        CoffeeOrder largeCoffeeOrder = barista.GetCoffeeOrder();
        largeCoffeeOrder.Display();
    }
}
