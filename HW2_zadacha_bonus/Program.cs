
Random rand = new Random();
int number_zagadka =rand.Next(10);
int count=1;

Console.WriteLine("Компьютер загадал число от 0 до 9. Попробуйте отгодать его за три попытки.");
Console.WriteLine("Введите первое число:");

int number_otgadka = Convert.ToInt32(Console.ReadLine()); // запишем число введенное

 while (count <=3)
            {
                if (number_zagadka == number_otgadka)
                 {
                Console.WriteLine($"Да! Компьютер загадал число {number_otgadka} ");
                break;
                 }
                        if  (number_otgadka > number_zagadka)
                            {
                                Console.WriteLine("Водимое число больше загаданного ");
                            }
                        if (number_otgadka < number_zagadka)
                             {   
                                Console.WriteLine("Водимое число меньше загаданного ");
                             }   

              else
                 {
                    count++;
                    if (count == 4)
                    {
                        Console.WriteLine($"НЕ отгодали загаданное число. Это было число {number_zagadka}");
                        break;
                    }
                    Console.WriteLine($"Нет, это не число  {number_otgadka} ! Попытка № {count} ");
                    number_otgadka = Convert.ToInt32(Console.ReadLine()); 
                 }  
            }
            Console.ReadLine();