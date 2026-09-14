using System;

namespace lop_problem_9_4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("숫자를 입력하시오(2~100000): ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (num < 2 || num > 100000)
                    {
                        Console.WriteLine("범위를 벗어난 값입니다. 2~100000 사이의 정수를 입력해주세요.");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다.");
                    continue;
                }

                List<int> perfect_nums = [];

                for (int i = 2; i < num; i++)
                {
                    int sum = 0;
                    for (int j = 1; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                            sum += j;
                    }

                    if (sum == i)
                    {
                        perfect_nums.Add(i);
                    }
                }

                Console.WriteLine($"완전수 목록: {string.Join(" ", perfect_nums)}");
                Console.WriteLine($"완전수 개수: {perfect_nums.Count}");
                break;
            }
        }
    }
}