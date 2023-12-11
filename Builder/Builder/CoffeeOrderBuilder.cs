// Абстрактный класс строителя заказа на кофе
abstract class CoffeeOrderBuilder
{
    protected CoffeeOrder coffeeOrder;

    public CoffeeOrder GetCoffeeOrder()
    {
        return coffeeOrder;
    }

    public void CreateNewCoffeeOrder()
    {
        coffeeOrder = new CoffeeOrder();
    }

    public abstract void BuildSize();
    public abstract void BuildType();
    public abstract void AddMilk();
    public abstract void AddSugar();
}
