using System;
using System.Linq;

namespace task_4_greedy_2
{
    class Program
    {

        static void Insert(ref int[] array, int value, int index) // метод для добавления в массив 
        {
            int[] newArray = new int[array.Length + 1];

            newArray[index] = value;

            for (int i = 0; i < index; i++)
                newArray[i] = array[i];
            for (int i = index; i < array.Length; i++)
                newArray[i + 1] = array[i];
            array = newArray;
        }

        static void AddLast(ref int[] array, int value) // метод для добавления в конец массива (для конечной точки маршрута)
        {
            Insert(ref array, value, array.Length);
        }


        static void Main(string[] args)
        {
            int[] station;// массив станций
            int capacity; //объём бака на км
            int result = 0; // оптимальное количество остановок
            int currentStop = 0; // остановка на которой в данный момент находится машина
            int way;
            int[] stop = { 0 };
            bool a = false;
            station = new int[] { 0 };
            capacity = 0;
            while (a == false)
            {
                try
                {
                    Console.WriteLine("Введите расстояние от А до В");
                    way = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("ВВедите на сколько километров хватает полного бака");
                    capacity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите количество бензоколонок и расстояние от бензоколонок до пункта А");
                    Console.ReadLine();
                    station = Console.ReadLine().Split().Select(int.Parse).ToArray();
                    Insert(ref station, 0, 0);
                    AddLast(ref station, way);
                    a = true;
                }
                catch (Exception)
                {
                    Console.WriteLine("Возникло исключение!");
                    a = false;
                }
            }
            int b; // сортировка массива по возрастанию
            for (int i = 0; i < station.Length - 1; i++)
            {
                for (int j = i + 1; j < station.Length; j++)
                {
                    if (station[i] > station[j])
                    {
                        b = station[i];
                        station[i] = station[j];
                        station[j] = b;
                    }
                }
            }

            {
                while (currentStop < station.Length - 1)
                {
                    int nextStop = currentStop; // для начала следующая заправка ровняется текущей заправке

                    while (nextStop < station.Length - 1 && station[nextStop + 1] - station[currentStop] <= capacity) // проверяем можем ли мы доехать до следующей заправки
                    {
                        nextStop++;
                    }
                    if (currentStop == nextStop)
                    {
                        Console.WriteLine($".. слишком далеко, даже полного бака бензина не хватит..");

                        break;
                    }
                    if (nextStop < station.Length - 1)
                    {
                        AddLast(ref stop, nextStop);
                        //сюда нужно закинуть nextStop, чтобы его каждое значение закидывалось в массив 
                        result++;
                    }
                    currentStop = nextStop;
                }

                Console.WriteLine($"ПРОЕХАЛИ ВЕСЬ ПУТЬ!!! [количество остановок на АЗС --> {result} раз(а)]\n");
                Console.WriteLine("Остановиться нужно на таких остановках:");
                Console.WriteLine(string.Join(",", stop));
            }
        }

    }
}
