Console.Clear();

/* Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести  с квлавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*/

string[] arrayNew = { "hello", "32;;;5", "//4", "n82", "c_8-7", "add" };

void ShowArray(string[] TextArray)
{
    for (int i = 0; i < TextArray.Length; i++)
    {
        Console.Write($"{TextArray[i]} ");
    }
    Console.WriteLine();
}




string[] CheckElements(string[] text)
{
    string[] result = new string[text.Length];
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= 3)
        {
            result[count] = text[i];
            count++;
        }
    }

    return result;
}


ShowArray(arrayNew);
string [] text = CheckElements(arrayNew);
Console.WriteLine("Массив из строк, длина которых меньше либо равна 3 символа. ");
ShowArray(text);