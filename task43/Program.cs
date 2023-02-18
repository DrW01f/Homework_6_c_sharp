// Задача 43: Напишите программу, которая найдёт точку пересечения двух 
// прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


string Input()
{
    Console.Write("Введите коэффициенты двух прямых: k1, b1 и k2, b2 через запятую");
    string coefficient = Console.ReadLine()!;
    return coefficient;
}

int[] Convert(string inputString)
{
    string input_array = inputString.Replace(" ", ""); 
    string[] array = input_array.Split(",");
    int[] out_array = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        out_array[i] = int.Parse(array[i]);
    }
    return out_array;

}

string Calculation(int[] parameter)
{
    if(parameter[0] == parameter[2])
    {
        if (parameter[1] == parameter[3]) Console.Write("Прямые совпадают");
        else Console.Write("Прямые не пересекуются");

    }

}





void Main()
{
    Console.Clear();
    string coef = Input();
    int[] parameters = Convert(coef);
    


}


Main();