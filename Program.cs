/*На основе символов строки (тип string) сформир массив
символов (тип char[]). Вывести массив на экран.

Указание
Метод строки ToCharArray() не использовать.
Пример
“Hello!” => [‘H’, ‘e’, ‘l’, ‘l’, ‘o’, ‘!’ ]
20
*/

static char[] StringToCharArray(string str)
{
    char[] array = new char[str.Length];

    for (int i = 0; i < str.Length; i++)
    {
        array[i] = str[i];
    }

    return array;
}

System.Console.WriteLine(StringToCharArray("Hello!"));
