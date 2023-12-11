// Конкретные класс строителя заказа на кофе
class SmallCoffeeOrderBuilder : CoffeeOrderBuilder
{
    public override void BuildSize()
    {
        coffeeOrder.Size = "Маленький";
    }

    public override void BuildType()
    {
        coffeeOrder.Type = "Эспрессо";
    }

    public override void AddMilk()
    {
        coffeeOrder.Milk = false;
    }

    public override void AddSugar()
    {
        coffeeOrder.Sugar = true;
    }
}
