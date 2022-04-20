//выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());


    if (number < 99) 
        {
            Console.WriteLine("нет третьго числа");
        }
    else
        {
            var str = number.ToString();
            Console.WriteLine(str[2]);
        }