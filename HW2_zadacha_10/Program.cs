//вход трёхзначного число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трехзначное число:");

int number = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Второй цифрой числа {number} является цифра {(number/10)%10}");