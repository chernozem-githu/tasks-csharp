//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };

//        foreach (int num in numbers)
//        {
//            Console.WriteLine(num);
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            Console.WriteLine(numbers[i]);
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        int sum = 0;

//        foreach (int num in numbers)
//        {
//            sum += num;
//        }

//        Console.WriteLine("Сумма чисел: " + sum);
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 1, 2, 3, 4, 5 };
//        int sum = 0;

//        for (int i = 0; i < numbers.Length; i++)
//        {
//            sum += numbers[i];
//        }

//        Console.WriteLine("Сумма чисел: " + sum);
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "Здарова", "как", "у", "тебя", "дела" };

//        Console.WriteLine(string.Join(" ", words));
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int[] numbers = new int[10];

//        // Заполнение массива случайными числами от 1 до 100
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = random.Next(1, 101);
//        }

//        // Вывод массива
//        Console.WriteLine("Массив чисел: " + string.Join(" ", numbers));

//        // Подсчет четных чисел с использованием foreach
//        int evenCount = 0;
//        foreach (int num in numbers)
//        {
//            if (num % 2 == 0)
//            {
//                evenCount++;
//            }
//        }

//        // Вывод результата
//        Console.WriteLine("Количество четных чисел: " + evenCount);
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] numbers = { 10, 20, 30, 40, 50 };

//        Console.Write("Введите число: ");
//        int userInput = int.Parse(Console.ReadLine());

//        bool found = false;

//        foreach (int num in numbers)
//        {
//            if (num == userInput)
//            {
//                found = true;
//                break;
//            }
//        }

//        if (found)
//        {
//            Console.WriteLine("Число есть в массиве.");
//        }
//        else
//        {
//            Console.WriteLine("Числа нет в массиве.");
//        }
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random();
//        int[] numbers = new int[10];

//        // Заполняем массив случайными числами от 1 до 100
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = rand.Next(1, 101);
//        }

//        int evenCount = 0;

//        // Подсчитываем количество чётных чисел
//        foreach (int num in numbers)
//        {
//            if (num % 2 == 0)
//            {
//                evenCount++;
//            }
//        }

//        // Выводим массив и количество чётных чисел
//        Console.WriteLine("Массив: " + string.Join(" ", numbers));
//        Console.WriteLine("Количество чётных чисел: " + evenCount);
//    }
//}








//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int[] numbers = new int[10];

//        // Заполнение массива случайными числами от 1 до 100
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = random.Next(1, 101);
//        }

//        // Вывод массива
//        Console.WriteLine("Массив чисел: " + string.Join(" ", numbers));

//        // Вывод нечетных чисел
//        Console.Write("Нечетные числа: ");
//        foreach (int num in numbers)
//        {
//            if (num % 2 != 0)
//            {
//                Console.Write(num + " ");
//            }
//        }
//        Console.WriteLine();

//        // Вычисление суммы всех элементов массива
//        int sum = 0;
//        foreach (int num in numbers)
//        {
//            sum += num;
//        }

//        // Вывод суммы
//        Console.WriteLine("Сумма всех чисел: " + sum);
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        Random random = new Random();
//        int[] numbers = new int[10];

//        // Заполнение массива случайными числами от 1 до 100
//        for (int i = 0; i < numbers.Length; i++)
//        {
//            numbers[i] = random.Next(1, 101);
//        }

//        // Вывод массива
//        Console.WriteLine("Массив чисел: " + string.Join(" ", numbers));

//        // Вывод нечетных чисел
//        Console.Write("Нечетные числа: ");
//        foreach (int num in numbers)
//        {
//            if (num % 2 != 0)
//            {
//                Console.Write(num + " ");
//            }
//        }
//        Console.WriteLine();

//        // Вычисление суммы всех элементов массива
//        int sum = 0;
//        foreach (int num in numbers)
//        {
//            sum += num;
//        }
//        Console.WriteLine("Сумма всех чисел: " + sum);

//        // Ввод числа X
//        Console.Write("Введите число X: ");
//        int X = int.Parse(Console.ReadLine());

//        // Подсчет количества элементов больше X
//        int countGreaterX = 0;
//        foreach (int num in numbers)
//        {
//            if (num > X)
//            {
//                countGreaterX++;
//            }
//        }
//        Console.WriteLine($"Количество элементов больше {X}: {countGreaterX}");

//        // Вывод массива в обратном порядке
//        Console.Write("Массив в обратном порядке: ");
//        for (int i = numbers.Length - 1; i >= 0; i--)
//        {
//            Console.Write(numbers[i] + " ");
//        }
//        Console.WriteLine();

//        // Нахождение среднего арифметического
//        double average = (double)sum / numbers.Length;
//        Console.WriteLine("Среднее арифметическое: " + average);
//    }
//}


//1


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите размер массива N: ");
//        int n = int.Parse(Console.ReadLine() ?? "0");

//        int[] array = new int[n];
//        Random rand = new Random();

//        for (int i = 0; i < n; i++)
//            array[i] = rand.Next(-100, 101); // Заполняем случайными числами

//        Console.WriteLine("Массив: " + string.Join(", ", array));
//    }
//}

//2

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 3, 8, 1, 9, 6, 4, 2, 7 };
//        Console.WriteLine("Исходный массив: " + string.Join(", ", array));

//        int minIndex = 0, maxIndex = 0;
//        for (int i = 1; i < array.Length; i++)
//        {
//            if (array[i] < array[minIndex]) minIndex = i;
//            if (array[i] > array[maxIndex]) maxIndex = i;
//        }

//        (array[minIndex], array[maxIndex]) = (array[maxIndex], array[minIndex]); // Обмен

//        Console.WriteLine("Массив после замены: " + string.Join(", ", array));
//    }
//}

//3

//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 3, 8, 1, 9, 6, 4, 2, 7 };

//        int sum = 0;
//        for (int i = 1; i < array.Length; i += 2) // Берем только нечётные индексы
//            sum += array[i];

//        Console.WriteLine("Сумма элементов на нечётных индексах: " + sum);
//    }
//}

//4

//using System;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        int[] array = { 3, 8, 1, 9, 6, 4, 2, 7 };

//        int[] evenNumbers = array.Where(x => x % 2 == 0).ToArray(); // Чётные числа
//        int[] oddNumbers = array.Where(x => x % 2 != 0).ToArray();  // Нечётные числа

//        Console.WriteLine("Чётные: " + string.Join(", ", evenNumbers));
//        Console.WriteLine("Нечётные: " + string.Join(", ", oddNumbers));
//    }
//}





























//using System;

//class Program
//{
//    static void Main()
//    {
//        Random rand = new Random();// рандомайзер
//        int[] arr = new int[10];// массив из 10 чисел

//        for (int i = 0; i < arr.Length; i++)// проходимся по каждому элементу массива 
//        {
//            arr[i] = rand.Next(100);// генерирует в диапозоне от 0 до 99
//        }

//        Console.WriteLine("Исходный массив:");
//        Console.WriteLine(string.Join(", ", arr));// выводит на экран все элементы массива разделенные запятыми

//        Array.Sort(arr);// сортируем в порядке возрастания 

//        Console.WriteLine("Отсортированный массив:");
//        Console.WriteLine(string.Join(", ", arr));// выводим отсортированный массив 

//        int min = arr[0];// здесь будет минимальное 
//        int max = arr[arr.Length - 1];// а здесь максимальное 

//        Console.WriteLine($"Минимальное значение: {min}");
//        Console.WriteLine($"Максимальное значение: {max}");// выводим мин и макс знач массива 
//    }
//}


//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");// вводим что угодно
//        string input = Console.ReadLine();// записывает то что ввел пользователь в input

//        foreach (char c in input)// запускаем цикл и перебираем каждый символ с из строки input 
//        {
//            Console.WriteLine(c);// здесь выводим каждый символ в новой строке 
//        }
//    }
//}

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");// вводим снова что хотим 
//        string input = Console.ReadLine();// снова записываем все в input

//        int count = 0;// переменная count в которой будет храниться колич букв а 
//        foreach (char c in input)// снова перебираем все символы в строке input
//        {
//            if (c == 'а' || c == 'a' || c == 'А' || c == 'A') // учитываем как русскую, так и латинскую 'a'
//            {   
//                count++;// увеличиваем счетчик если условие истинно 
//            }
//        }

//        Console.WriteLine($"Количество букв 'а': {count}");// выводим сколько у нас букв а 
//    }
//}




//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");// снова вводим 
//        string input = Console.ReadLine();// снова записывается 

//        string result = input.Replace("кот", "пёс");// замена слова кот на пёс 

//        Console.WriteLine("Результат замены:");
//        Console.WriteLine(result);// выводим результат
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");// вводим
//        string input = Console.ReadLine();// снова записываем

//        Console.WriteLine($"Длина строки: {input.Length}");//возвращает колич символов в строке 
//    }
//}



//using system;

//class program
//{
//    static void main()
//    {
//        console.write("введите строку: ");// вводим
//        string input = console.readline();// сохраняем в переменную input

//        string upper = input.toupper();// преобразуем в верхний регистр и создаем переменную upper в которую будет все записываться в верхнем регистре 
//        console.writeline($"строка в верхнем регистре: {upper}");// и просто выводим это в верхнем регистре 
//    }
//}





//using System;

//class Program
//{
//    static void Main()
//    {
//        int[,] matrix = new int[3, 3];// создаем двумерный массив 
//        Random rand = new Random();// генерация случ чисел 
//        int sum = 0;// сумма всех элем массива 

//        Console.WriteLine("Матрица 3x3:");// 

//        for (int i = 0; i < 3; i++)// отвечает за строки матрицы 
//        {
//            for (int j = 0; j < 3; j++)// отвечает за столбец 
//            {
//                matrix[i, j] = rand.Next(10, 100);// заполняет каждый элемент массива случ числом от 10 до 99 
//                Console.Write(matrix[i, j] + "\t");// выводим текущий элемент массива с табуляцией чтобы распологались в столбцах 
//                sum += matrix[i, j];// добавляем знач текущего элем массива к общей сумме 
//            }
//            Console.WriteLine();// переход на новую строку после вывода всей строки матрицы 
//        }

//        Console.WriteLine($"Сумма всех элементов: {sum}");// выводим сумму всех элем массива 
//    }
//}





//using System;

//class Program
//{
//    static void Main()
//    {
//        int[] arr = { 5, 2, 9, 1, 7, 4 };// создаем массив из 6 случ чисел 

//        Console.WriteLine("Исходный массив:");// показываем исходный массив 
//        Console.WriteLine(string.Join(", ", arr));// разделяем запятыми и пробелом 

//        // Сортировка пузырьком
//        for (int i = 0; i < arr.Length - 1; i++)// мы сравниваем соседние элементы и если нужно меняем местами 
//        {
//            for (int j = 0; j < arr.Length - 1 - i; j++)// сравниваем элементы массива попарно 
//            {
//                if (arr[j] > arr[j + 1])// если текущий элем массива больше след происходит обмен местами
//                {
//                    // Обмен элементов
//                    int temp = arr[j];// сохраняем в временную переменную 
//                    arr[j] = arr[j + 1];//перезаписываем значение соседнего элем справа 
//                    arr[j + 1] = temp;//возвращаем старое значение которое мы записали в темп 
//                }
//            }
//        }

//        Console.WriteLine("Отсортированный массив:");
//        Console.WriteLine(string.Join(", ", arr));// выводим отсортированный массив в консоль 
//    }
//}






//using System;

//class Program
//{
//    static void Main()
//    {
//        string[] words = { "банан", "яблоко", "апельсин", "груша", "абрикос" };// создаем массив строк words 

//        Console.WriteLine("Исходный массив строк:");
//        Console.WriteLine(string.Join(", ", words));// преобразуем массив в одну строку элем разделены запятой и пробелом 

//        Array.Sort(words); // Сортировка по алфавиту

//        Console.WriteLine("Отсортированный массив:");
//        Console.WriteLine(string.Join(", ", words));//выводим отсортированный массив ч
//    }
//}




//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");
//        string input = Console.ReadLine();// снова сохраняем в input 

//        // Преобразуем строку в массив символов
//        char[] chars = input.ToCharArray();// в char chars это массив символов будут хранится символы полученные из input 

//        // Сортируем массив символов
//        Array.Sort(chars);// в порядке возрастания 

//        Console.WriteLine("Отсортированный массив символов:");
//        Console.WriteLine(string.Join("", chars));// выводим отсортированный массив символов в строку 
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");// вводим строку 
//        string input = Console.ReadLine();//все так же сохраняется в input 

//        string result = input.Replace(" ", "_");// заменяем вместо пробела на подчеркивание 

//        Console.WriteLine("Результат замены пробелов:");
//        Console.WriteLine(result);// выводим результат 
//    }
//}



//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите строку: ");// вводим
//        string input = Console.ReadLine();// опять так же сохраняем

//        Разделение строки на слова
//        string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
//        пустые строки должны быть удалены

//        Console.WriteLine("Слова в строке:");
//        foreach (string word in words)//перебирает слова из  массива words
//        {
//            Console.WriteLine(word);//выводим слово на экран на новой  строке 
//        }
//    }
//}

//1
/*
int[,] matrix = {
{1, 2, 3},
{4, 5, 6},
{7, 8, 9}
};
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
*/

/*int[,] matrix1 = {{1, 2, 3, 4},
                   {5, 6, 7, 8},
                   {9, 10, 11, 12},
                   {13, 14, 15, 16}
                  };
  for (int i = 0; i < matrix1.GetLength(0); i++)
  {
      for (int j = 0; j < matrix1.GetLength(1); j++)
      {
          Console.Write(matrix1[i, j] + " ");
      }
      Console.WriteLine();
  }

*/

/*
using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк: ");
        int rows = int.Parse(Console.ReadLine());// сохраняем в переменную

        Console.Write("Введите количество столбцов: ");
        int cols = int.Parse(Console.ReadLine());// сохраняем в переменную

        int[,] array = new int[rows, cols];// создаем двумерный массив 

        // Ввод элементов массива
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)// проходимся по элем массива 
            {
                Console.Write($"Введите элемент [{i},{j}]: ");// просим ввести знач конк элем 
                array[i, j] = int.Parse(Console.ReadLine());// здесь читаем то что ввели 
            }
        }

        // Вычисление суммы
        int sum = 0;// храним сумму элем
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)// проходимся по элем массива 
            {
                sum += array[i, j]; // прибавляем текущий элем массива 
            }
        }

        Console.WriteLine($"Сумма всех элементов массива: {sum}");// выводим общую сумму всех элем массива 
    }
}
*/
/*4
using System;

int[,] a = { { 1, 2, 3 },
     { 4, 5, 6 },
     { 7, 8, 9 },};
int max = a[0, 0];
for (int i = 0; i < a.GetLength(0); i++) // строки
{
    for (int j = 0; j < a.GetLength(1); j++) // столбцы
    {
        if (a[i, j] > max)
        {
            max = a[i, j];
        }
    }
}
Console.WriteLine("максимальный элемент массива" + max);
*/


/*5
 int[,] arr = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 3; i++)
    {
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
*/

/*6 
 *Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine());

int[][] triangle = new int[rows][];
int number = 1;

for (int r = 0; r < rows; r++)
{
    triangle[r] = new int[r + 1];
    for (int c = 0; c < triangle[r].Length; c++)
    {
        triangle[r][c] = number++;
    }
}

for (int r = 0; r < triangle.Length; r++)
{
    for (int c = 0; c < triangle[r].Length; c++)
    {
        Console.Write($"{triangle[r][c]} \t");
    }
    Console.WriteLine();
}
*/
