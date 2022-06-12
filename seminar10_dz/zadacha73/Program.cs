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
int count = 1;
int groupNumber = 1;

while (count < baseNumber)
{
    Console.WriteLine($"Группа {groupNumber}: ");
    for (int i = 1; i < baseNumber; i++)
    {
        for (int j = count; j > 1; j--)
        {
            
        }
        if (i == 1)
        {
            Console.Write(i + " ");
            count++;
            continue;
        }
        else if (i != 1 && Divisibility(i, 2) && Divisibility(i, 3))
        {
            Console.Write(i + " ");
            count++;
        }
    }
    Console.WriteLine();
    groupNumber++;
}

bool Divisibility(int n, int m)
{
    if (n % m != 0) return true;
    else return false;
}

int EnterData(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}