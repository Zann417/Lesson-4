Console.WriteLine("какое задание будем проверять?");
   var vibor = Console.ReadLine();
switch (vibor)
{
    case "1":
        for (int i = 1; i <= 99; i += 2)
        {
            Console.WriteLine(i);
        }
        break;
    case "2":
    for (int i = 5; i >= 1; i--)
    {
        Console.WriteLine(i);
    }
    break;
case "3":
    Console.WriteLine("Введите целое положительное число:");
    int number = int.Parse(Console.ReadLine());
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum += i;
    }
    Console.WriteLine("Сумма чисел от 1 до {0} равна {1}.", number, sum);
    break;
case "4":
    {
    int num1 = 7; 
    while (num1 <= 98) 
    {
    Console.Write(num1 + " "); 
    num1 += 7; 
    }
        Console.ReadLine();
    }
    break;
case "5":
    {
    int num2 = 0; 
    int count = 0; 
    while (count < 10) 
    {
    Console.Write(num2 + " "); 
    num2 -= 5; 
    count++; 
    }
    Console.ReadLine();
    }
    break;
case "6":
    int num3 = 10; 
    while (num3 <= 20) 
    {
    Console.Write(num3 * num3 + " "); 
    num3++; 
    }
    Console.ReadLine();
    break;
case "7":
        Console.WriteLine("Введите число для проверки:");
        int[] array = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 }; 
        int number1 = int.Parse(Console.ReadLine()); 

        bool isFound = false; 

        foreach (int element in array)
        {
            if (element == number1)
            {
                isFound = true;
                break;
            }
        }

        if (isFound)
        {
            Console.WriteLine("Заданное число {0} найдено в массиве.", number1);
        }
        else
        {
            Console.WriteLine("Заданное число {0} не найдено в массиве.", number1);
        }

        Console.ReadLine();
        break;
    case "8":
        int[] array1 = { 1, 3, 5, 3, 7, 9, 3, 11, 13, 15, 17, 19 }; 

        Console.Write("Введите число для удаления: ");
        int number2 = int.Parse(Console.ReadLine()); 

        int[] newArray = array1.Where(x => x != number2).ToArray(); 

        if (newArray.Length != array1.Length)
        {
            Console.WriteLine($"Число {number2} удалено из массива.");
            Console.WriteLine("Новый массив: " + string.Join(", ", newArray));
        }
        else
        {
            Console.WriteLine($"Число {number2} не найдено в массиве.");
        }
        break;
    case "9":
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine()); 
        double[] array2 = new double[size]; 
        Random rand = new Random();
        for (int i = 0; i < size; i++)
        {
            array2[i] = rand.NextDouble();
        }
        Console.Write("Массив: [");
        for (int i = 0; i < size; i++)
        {
            Console.Write(array2[i]);
            if (i != size - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
        double max = array2[0];
        double min = array2[0];
        double sum1 = array2[0];

        for (int i = 1; i < size; i++)
        {
            if (array2[i] > max)
            {
                max = array2[i];
            }
            if (array2[i] < min)
            {
                min = array2[i];
            }
            sum1 += array2[i];
        }
        double average = sum1 / size;
        Console.WriteLine("Максимальное значение: " + max);
        Console.WriteLine("Минимальное значение: " + min);
        Console.WriteLine("Среднее значение: " + average);
        break;
    case "10":
        int[] array3 = GenerateRandomArray(5); // создание первого массива из случайных чисел
        int[] array4 = GenerateRandomArray(5); // создание второго массива из случайных чисел

        Console.WriteLine("Массив 1: " + string.Join(", ", array3));
        Console.WriteLine("Массив 2: " + string.Join(", ", array4));

        double average1 = CalculateAverage(array3);
        double average2 = CalculateAverage(array4);

        Console.WriteLine("Среднее арифметическое Массива 1: " + average1);
        Console.WriteLine("Среднее арифметическое Массива 2: " + average2);

        if (average1 > average2)
        {
            Console.WriteLine("Среднее арифметическое Массива 1 больше.");
        }
        else if (average1 < average2)
        {
            Console.WriteLine("Среднее арифметическое Массива 2 больше.");
        }
        else
        {
            Console.WriteLine("Средние арифметические Массивов равны.");
        }
        break;
}

static int[] GenerateRandomArray(int size)
{
    Random rand = new Random();
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(100); // генерация случайного числа от 0 до 99
    }

    return array;
}

static double CalculateAverage(int[] array)
{
    double sum = 0;
    foreach (int num in array)
    {
        sum += num;
    }

    return sum / array.Length;
}















