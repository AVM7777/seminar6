/*На основе символов строки (тип string) сформир массив
символов (тип char[]). Вывести массив на экран.

Указание
Метод строки ToCharArray() не использовать.
Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
20
*/

static char[] ArrayCharsToString(string str)
{
    char[] array = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        array[i] = str[i];
    }

    return array;
}

void PrintArray(char[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"'{array[i]}', ");
        }
        else
        {
            Console.Write($"'{array[i]}' ");
        }

    }
    Console.WriteLine("]");
}

PrintArray(ArrayCharsToString("Hello!"));