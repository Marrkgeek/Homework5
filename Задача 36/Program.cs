// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

 int[] arr = new int[8];
            int k = 0, sum = 0;
            Random rnd = new Random();
 
            Console.WriteLine("Исходный массив");
            for (int i = 0; i < 8; i++)
            {
                arr[i] = rnd.Next(-999, 999);
                Console.Write("{0} ", arr[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив ");
            Array.Sort(arr);
 
            foreach(int element in arr)
            {
                Console.Write("{0} ", element);
                if (element % 2 == 0)
                {
                    k++;
                    sum += element;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Количество четных элементов {0}, сумма четных элементов {1}", k, sum);