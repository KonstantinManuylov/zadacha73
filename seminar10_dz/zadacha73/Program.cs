// Есть число N. Сколько групп M, можно получить при разбиении всех чисел на группы, 
// так чтобы в одной группе все числа были взаимно просты (все числа в группе друг на друга не делятся)?
// Найдите M при заданном N и получите одно из разбиений на группы N ≤ 10²⁰. 
// Можно использовать рекурсию.
/*
 Например, для N = 50, M получается 6
Группа 1: 1
Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 7 16 24 36 40
Группа 6: 5 32 48

Или
Группа 1: 1
Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
Группа 4: 8 12 18 20 27 28 30 42 44 45 50
Группа 5: 16 24 36 40
Группа 6: 32 48 
*/

int baseNumber = EnterData("Введите число N: ");
int[] array = new int[baseNumber];
int groupNumber = 1;
int countNumbers = 0;
FillArray(array);
int[] tempArray = array;

while (countNumbers < baseNumber)
{
    Console.WriteLine($"Группа {groupNumber}: ");
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == 1)
            {
                Console.Write(array[i] + " ");
            }
            else if (tempArray[j] % array[i] != 0)
            {
                for (int k = i; k > 0; k--)
                {
                    if (tempArray[j] % array[k] != 0)
                    {
                        Console.Write(tempArray[j] + " ");
                    }
                }
            }
        }
    }
    countNumbers++;
    groupNumber++;
}



void FillArray(int[] array)
{
    int num = 1;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = num;
        num++;
    }
}

/* void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
} */

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}