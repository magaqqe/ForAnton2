int[] numbers = {1, 2, 3, 4, 5, 6, 7};
int[] numbers2 = {10, 20, 30, 40, 50, 60, 70};

for (int i = 0; i < numbers.Length; i++)
{
    int sum = numbers[i] + numbers2[i];
    Console.WriteLine(sum);
}

/*
после int мы ставим [] т.к это означает что у нас массив данных
numbers.Length - количество элементов в массиве

*/