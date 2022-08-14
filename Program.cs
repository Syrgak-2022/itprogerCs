// Console.WriteLine(Math.Ceiling(4.56));
// Console.WriteLine(Math.Floor(4.4));
// Console.WriteLine(Math.Round(3.49));

// Прога, в котором вводишь 2 числа, а прога определяет максимальное введенное число
// int user_input1;
// int user_input2;
// user_input1 = Convert.ToInt32(Console.ReadLine());
// user_input2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(Math.Max(user_input1, user_input2));


// Возведение в степень
// Console.WriteLine(Math.Pow(5, 3));

Console.WriteLine("Введите радиус круга: ");
double radius = Convert.ToDouble(Console.ReadLine());
double area = Math.PI + Math.Pow(radius, 2);
Console.WriteLine("Площадь круга с радиусом {0} равна {1}", radius, area);