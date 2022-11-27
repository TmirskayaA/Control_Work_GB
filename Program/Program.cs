Console.WriteLine("Здравствуйте!");

Console.Write("Сколько слов вы хотите ввести? Напишите число: ");
int counter = Convert.ToInt32(Console.ReadLine());

string[] arrayWords = new string[counter];

Console.WriteLine("Давайте я запишу все слова, которые вы хотите внести.");

for (int i = 0; i < arrayWords.Length; i++)
{
    Console.Write($"Напишите {i+1} слово:  ");
    arrayWords[i] = Console.ReadLine();
    while (arrayWords[i] == "")
    {
        Console.Write("Вы не ввели слово. Пожалуйста, повторите ещё раз: ");
        arrayWords[i] = Console.ReadLine();
    }
}
