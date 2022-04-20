//У случайного трёхзначного число и удаляет вторую цифру этого числа.

//Console.WriteLine(new Random().Next(10, 100) * 10);

Random rnd = new Random();
int result = rnd.Next(10, 100)*10;

Console.WriteLine(result);


var str = result.ToString();
result = int.Parse(str.Remove(str.Length - 2, 1));

Console.WriteLine(result);
