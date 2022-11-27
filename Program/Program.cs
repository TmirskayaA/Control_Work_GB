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

string[] ChangeArrayString(string[] listOfWords)
{
    string[] newArray = new string[listOfWords.Length];

    for (int i = 0; i < listOfWords.Length ; i++)
    {
        if (listOfWords[i].Length <= 3) newArray[i] = listOfWords[i];
    }
    return newArray;
}

