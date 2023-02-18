// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 
// 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

string[] Input()
{

    Console.Write("Введите количество чисел (больше 0):  ");
    string[] outFunc = { "0", "0" };
    outFunc[0] = Console.ReadLine()!;
    Console.WriteLine("Введите массив чисел через запятую, например: 1, -5, 3");
    outFunc[1] = Console.ReadLine()!;
    return outFunc;
}

int[] Magic(string[] inputArray) //Преобразование строки в массив строк и преобразование в массив чисел
{
    int lenght = int.Parse(inputArray[0]);
    string input_array = inputArray[1].Replace(" ", ""); //убираю пробелы    
    string[] array = input_array.Split(",");
    int[] out_array = new int[lenght];
    for (int i = 0; i < lenght - 1; i++)
    {
        out_array[i] = int.Parse(array[i]);
    }
    return out_array;
}

int Counter(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result += 1;
    }
    return result;
}

void Main()
{
    Console.Clear();
    string[] inputString = Input();
    int[] array = Magic(inputString);
    int count = Counter(array);
    Console.WriteLine($"Количество чисел больше нуля: {count}");

}

Main();