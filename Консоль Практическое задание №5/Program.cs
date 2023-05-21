//Задание 1
class Program_1
{
    static void Main(string[] args)
    {
        string text = "Мама мыла раму, а папа молчал. Мама много работала, а папа мало помогал. Мама любила цветы, а папа - музыку. Мама готовила вкусно, а папа - пил пиво.";
        string[] words = text.Split(new char[] { ' ', ',', '.', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string maxWord = "";
        int maxCount = 0;

        foreach (string word in words)
        {
            int count = word.Count(c => c == 'м' || c == 'М');
            if (count > maxCount)
            {
                maxCount = count;
                maxWord = word;
            }
        }

        Console.WriteLine($"Слово с наибольшим количеством букв 'м': {maxWord}");
    }
}
//Задание 2
class Program_2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку:");
        string input = Console.ReadLine();

        string[] words = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        int count = 0;

        foreach (string word in words)
        {
            if (word.Length > 1 && word[0] == word[word.Length - 1])
            {
                count++;
            }
        }

        Console.WriteLine($"Количество слов, удовлетворяющих условию: {count}");
    }
}
//А роза упала на лапу Азора. Мама мыла раму. Кот тащит таз. Стрела нашла цель. Солнце встает на востоке.
//Количество слов, удовлетворяющих условию: 5
