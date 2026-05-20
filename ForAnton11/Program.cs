class Program
{
    static void Main()
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7};
        int[] numbers2 = {10, 20, 30, 40, 50, 60, 70};

        int[] result = new int[numbers.Length];

        SummFor(numbers, numbers2, result);

        for (int i = 0; i < result.Length; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    static void SummFor(int[] numbers, int[] numbers2, int[] result)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = numbers[i] + numbers2[i];
        }
    }
}

/*
как это работает

Создаю класс программы.
Создаю функцию Main.
Создаю 2 массива.
Создаю пустой массив к которому присваиваю длинну первого массива.
Вызываю функцию SummFor и передаю туда 3 массива.
Сама функция легкая, работает по условию что берет число из 1-го массива и складывает число со 2-го
после чего переходит на следующий индекс, саму длину он высчитывает из 1-го массива.
После чего записывает результат в result[i].
Для чего я использую цикл For при выводе, просто чтоб не писать в ручную 
Console.WriteLine(result[0]);
Console.WriteLine(result[1]);
и т.д


*/