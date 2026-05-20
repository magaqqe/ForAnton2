
class Prices
{
    public int drinkPrice = 10;
    public int firstPrice = 20;
    public int secondPrice = 25;
}

class Choices
{
    public int drinkCount = 0;
    public int firstCount = 0;
    public int secondCount = 0;
}

class Program
{
    static int CustomerTotal(Prices prices, Choices choices)
    {
        int total = prices.drinkPrice * choices.drinkCount
          + prices.firstPrice * choices.firstCount
          + prices.secondPrice * choices.secondCount;

        return total;
    }

    static void Main()
    {
        /*
        простыми словами:
        1.Prices - чертеж
        2.prices - имя переменной
        3.Prices - создает обьект по чертежу
        */
        Prices prices = new Prices();

        Choices client1 = new Choices();
        Choices client2 = new Choices();

        client1.drinkCount = 1;
        client1.firstCount = 0;
        client1.secondCount = 2;

        client2.drinkCount = 2;
        client2.firstCount = 0;
        client2.secondCount = 0;

        Console.WriteLine(CustomerTotal(prices, client1));
        Console.WriteLine(CustomerTotal(prices, client2));
    }
}