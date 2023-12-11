class Barista
{
    private CoffeeOrderBuilder coffeeOrderBuilder;

    public void SetCoffeeOrderBuilder(CoffeeOrderBuilder builder)
    {
        coffeeOrderBuilder = builder;
    }

    public CoffeeOrder GetCoffeeOrder()
    {
        return coffeeOrderBuilder.GetCoffeeOrder();
    }

    public void TakeOrder()
    {
        coffeeOrderBuilder.CreateNewCoffeeOrder();
        coffeeOrderBuilder.BuildSize();
        coffeeOrderBuilder.BuildType();
        coffeeOrderBuilder.AddMilk();
        coffeeOrderBuilder.AddSugar();
    }
}

