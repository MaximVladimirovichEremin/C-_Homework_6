

//  ДЗ К 6 СЕМИНАРУ*******

// Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// // метод ввода чисел 
// int[] NumberArray(int size){ 
//     int[] array = new int[size];
//     for(int i=0; i<size; i++){
//     Console.Write("Введите число: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }    
// // Метод который считает положительные числа
// int PosEl(int[] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){
//     if(array[i] > 0) count++;
//     }
//     return count;
// }

// Console.Write("Введите кол-во цифр: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = NumberArray(size);
// int count = PosEl(array);
// PosEl(array);
// Console.WriteLine($"Количество цифр больше нуля =  {count}");



// Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// // метот нахождения точки пересечения по оси координат
// double Avarage(double k1, double b1, double k2, double b2){
//         double x = 0;
//         double y = 0;
        
//         x=(b2-b1)/(k1-k2);
//         y=(k1*(b2-b1))/(k1-k2)+b1;
//         Console.WriteLine("Точка пересечеиня по оси Х: " + x);
//         Console.WriteLine("Точка пересечеиня по оси Y: " + y);
//     return 0;
// }

// Console.Write("Введите координаты k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите координаты b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());
// Avarage(k1, b1, k2, b2);
