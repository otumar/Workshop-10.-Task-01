// Есть монотонная последовательность, каждое число встречается ровно то количество раз, 
// какое значение этого числа: 
//1, 2, 2, 3, 3, 3, 4, 4, 4, 4,... 
//Выведите ряд этой последовательности до N-го значения, желательно использовать рекурсию:
// N = 12 -> "1, 2, 2, 3, 3, 3, 4, 4, 4, 4, 5, 5"

int Prompt(string message)
{
    System.Console.WriteLine(message);
    string param = Console.ReadLine();
    return int.Parse(param);
}

void GetSequence(int Number)
{
    if (Number == 1)
    {
        System.Console.WriteLine(1);
    }
    else
    {
        for (int i = 0; i < Number; i++)
        {
             System.Console.Write(Number);
           
        }
         
    }
return;
}

int Number = Prompt("Введите число: ");
System.Console.WriteLine();
GetSequence(Number);

