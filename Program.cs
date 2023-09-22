using System;

class Calculator
{
    static void Main()
    {
        while (true) // цикл для повторного использования калькулятора
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. 1 процент от числа");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выход");

            int choice = int.Parse(Console.ReadLine()); // считывание выбора 

            if (choice == 9) // условие выхода из калькулятора
            {
                Console.WriteLine("Выход. До свидания!");
                break;
            }

            Console.Write("Введите первое число: ");
            double num1 = double.Parse(Console.ReadLine());

            if (choice == 6) // если выбрано извлечение квадратного корня
            {
                double result = Math.Sqrt(num1); // вычисление квадратного корня
                Console.WriteLine("Результат: " + result);
            }
            else if (choice == 7) // если выбрано нахождение 1 процента от числа
            {
                double result = num1 / 100; // вычисление 1 процента
                Console.WriteLine("Результат: " + result);
            }
            else if (choice == 8) // если выбрано вычисление факториала
            {
                int fact = 1;
                for (int i = 2; i <= num1; i++)
                {
                    fact *= i; // вычисление факториала
                }
                Console.WriteLine("Результат: " + fact);
            }
            else // для остальных операций нужно ввести два числа
            {
                Console.Write("Введите второе число: ");
                double num2 = double.Parse(Console.ReadLine());
                double result = 0;

                switch (choice) // вычисление в зависимости от выбранной операции
                {
                    case 1:
                        result = num1 + num2; // сложение
                        break;
                    case 2:
                        result = num2 - num1; // вычитание
                        break;
                    case 3:
                        result = num1 * num2; // умножение
                        break;
                    case 4:
                        result = num1 / num2; // деление
                        break;
                    case 5:
                        int Power(int baseNum, int exponent) //  baseNum - основание, exponent - степень
                        {
                            int result = 1;
                            int count = 0;

                            while (count < exponent)
                            {
                                result *= baseNum;
                                count++; // возведение в степень
                            }

                            return result;
                        }
                      
                }

                Console.WriteLine("Результат: " + result);
            }

            Console.WriteLine(); 
        }
    }
}
