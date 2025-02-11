﻿//Найти сумму элементов массива, лежащих между максимальныи и минимальным по значению элементами

class Program {                                                                 // Команда class привносит функционала, Sum_Min_Max - Любое название нашей программы

    int i = 0;
    int sum = 0;
    int min_i = 0;
    int max_i = 0;
    static void Main(string[] args) {                                           // Static void - говорит об инициализации этого кода 1 раз, а затем сохраняет данные в переменную и код больше не используется, Main - код в нутри метода мэйн будет выполняться первым
    
        Console.Write("Введите количество элементов массива:\t");               // Выводит на экран просьбу ввести

        int elementsCount = int.Parse(Console.ReadLine()!);                     // elementsCount - просто переменная, Parse - конвертирует вводимые данные в 32 битное целое число, чтобы было удобно с ними работать

        int[] myArray = new int[elementsCount];                                 // myArray - название массива, new int[elementsCount] - создание нового массива с количеством цифр введенных шагом ранее

        for (int i = 0; i < myArray.Length; i++)                                // Стандартная пробежка по каждому элементу массива
        {
            Console.Write($"\nВведите элемент массива под индексом №{i}:\t");   // Вывод на экран сообщения где  {i} - порядковый номер элемента массива
            myArray[i] = int.Parse(Console.ReadLine()!);                        // Считываем вводимые данные и снова конвертим в целые числа
        }

        Console.WriteLine("\nВывод массива:");                                  // Вывод на экран сообщения 
        for (int i = 0; i < myArray.Length; i++)                                // (для каждого i в массиве, пока не кончился массив
        {
            Console.Write(myArray[i] + " ");                                    // вывести его значение и после него пробел)
        }

var mc = new Program();    
int tMAX = myArray[mc.i];
int tMIN = myArray[mc.i];

while (mc.i < elementsCount)
{
    if (tMAX < myArray[mc.i])
    {
        tMAX = myArray[mc.i];
        mc.max_i = mc.i;
    }
    else
    {
        if (tMIN < myArray[mc.i])
        {}
        else
        {
            tMIN = myArray[mc.i];
            mc.min_i = mc.i;
        }
    }
mc.i++;
}

if ( mc.max_i < mc.min_i )
{
    int max_i_step = mc.max_i + 1;
    while (max_i_step < mc.min_i)
    {
        mc.sum = mc.sum + myArray[max_i_step];
        max_i_step++;
    }
}
else
{
    int min_i_step = mc.min_i + 1;
    while (min_i_step < mc.max_i)
    {
        mc.sum = mc.sum + myArray[min_i_step];
        min_i_step++;
    }
}
Console.WriteLine($"\nСуммы элементов массива между минимальным значением и максимальным равна:\t" + mc.sum);
}
}
