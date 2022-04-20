//Ввод цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число:");

int day_Number = Convert.ToInt32(Console.ReadLine());
string[] Days = { "пн ", "вт ", "ср ", "чт ", "пт ", "сб ", "вс " };

string Result = "";

        if (day_Number > 5) 
            {
                Result = "Выходной";
            }
        else 
            {
                Result = "Рабочий день";
            }

Console.WriteLine($"{day_Number}-й день недели - это { Days [day_Number - 1]}{Result}");