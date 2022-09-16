// Пользователь вводит 8 чисел. Поместите их в массив и распечатайте.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

Console.WriteLine("Введите 8 чисел через пробел");
string numbers = Console.ReadLine()!;
string[] parts = numbers.Split(" "); // Разделение на коллекцию чисел
int[] array = new int[8];

for (int i = 0; i < 8; i++)
{
    array[i] = int.Parse(parts[i]);
}

Console.WriteLine($"[{string.Join(", ", array)}]"); // string.Join - метод, объединяющий каждый элемент в массиве без явного преобразования элементов в строки
