Console.WriteLine("Здравствуйте!");

Console.Write("Сколько строк вы хотите ввести? Напишите число: ");
int counter = Convert.ToInt32(Console.ReadLine());

string[] arrayString = new string[counter];

Console.WriteLine("Давайте я запишу все строки, которые вы хотите внести.");

for (int i = 0; i < arrayString.Length; i++)
{
    Console.Write($"Напишите {i+1} строку:  ");
    arrayString[i] = Console.ReadLine();
    while (arrayString[i] == "")
    {
        Console.Write("Вы не ввели строку. Пожалуйста, повторите ещё раз: ");
        arrayString[i] = Console.ReadLine();
    }
}

void PrintArray(string[] listOfString)
{
    int count = 0;
    while (count != listOfString.Length)
    {
        if (count == 0)  Console.Write($"[\"{listOfString[count]}\", ");
        else if (count + 1 == listOfString.Length) Console.WriteLine($"\"{listOfString[count]}\"]");
        else Console.Write($"\"{listOfString[count]}\", ");
        count++;
    }
}

Console.WriteLine();
Console.WriteLine("Вот ваш массив строк:");
PrintArray(arrayString);

string[] ChangeArrayString(string[] listOfString)
{
    int count = 0;
    for (int i = 0; i < listOfString.Length; i++)
    {
        if (listOfString[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];

    for (int i = 0; i < listOfString.Length ; i++)
    {
        if (listOfString[i].Length <= 3) newArray[i] = listOfString[i];
    }
    return newArray;
}

string[] newArrayString = ChangeArrayString(arrayString);

Console.WriteLine();
Console.WriteLine("Теперь я оставил только те строки, в которых есть максимум 3 символа. Вот что получилось:");
PrintArray(newArrayString);
