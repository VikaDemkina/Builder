// Конкретные класс строителя заказа на кофе
class LargeCoffeeOrderBuilder : CoffeeOrderBuilder
{
    public override void BuildSize()
    {
        coffeeOrder.Size = "Большой";
    }

    public override void BuildType()
    {
        coffeeOrder.Type = "Капучино";
    }

    public override void AddMilk()
    {
        coffeeOrder.Milk = true;
    }

    public override void AddSugar()
    {
        coffeeOrder.Sugar = false;
    }
}

