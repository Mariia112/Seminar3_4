// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16
 
  Console.Write("Введите число   : ");
  int number = int.Parse(Console.ReadLine());
  
  Console.Write("Введите степень : ");
  int n = int.Parse(Console.ReadLine());
  
  
  int number_n=1;
  for(int i=0; i<n; i++) {
   number_n*=number;
  }
  Console.WriteLine("{0} ^ {1} = {2}", number, n, number_n);
  Console.ReadKey();
  return 0;
 

