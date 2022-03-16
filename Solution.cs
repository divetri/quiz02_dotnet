namespace Quiz02
{
    class Solution
    {
        public static void ReadInt(int[] list)
        {
            for(int i=0; i<list.Length; i++)
            {
                Console.Write($"{list[i]} ");
                
            }
            Console.WriteLine();
        }
        public static int[] leftShiftInt(int[] list)
        {
            int[] shiftedArray = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                if (i == list.Length - 1)
                {
                    shiftedArray[i] = list[0];
                }
                else
                {
                    shiftedArray[i] = list[i + 1];
                }
            }
            return shiftedArray;
        }
        public static int[] rightShiftInt(int[] list)
        {
            int[] shiftedArray = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                if (i == 0)
                {
                    shiftedArray[i] = list[list.Length-1];
                }
                else
                {
                    shiftedArray[i] = list[i-1];
                }
            }
            return shiftedArray;
        }
        public static void Soal1(int[] list)
        {
            Console.WriteLine("Before Random");
            ReadInt(list);
            Console.WriteLine("After Random Position Element Change");
            Random random = new Random();
            int[] randomArray = new int[list.Length];
            for (int i = 0; i < list.Length; i++)
            {
                randomArray[i] = list[random.Next(0, list.Length-1)];
            }
            ReadInt(randomArray);
        }
        public static void Soal2(int[] list)
        {
            Console.WriteLine("Before Shifting");
            ReadInt(list);
            Console.WriteLine("After Shifting");
            ReadInt(leftShiftInt(list));
        }
        public static void Soal3(int[] list)
        {
            Console.WriteLine("Rotate Shifting 3x");
            ReadInt(list);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Rotate ke {i}");
                ReadInt(leftShiftInt(list));
                list = leftShiftInt(list);                
            }  
        }
        public static void Soal4(int[] list) {
            Console.WriteLine("Rotate Shifting 3x");
            ReadInt(list);
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Rotate ke {i}");
                ReadInt(rightShiftInt(list));
                list = rightShiftInt(list);
            }
        }
        public static void Soal5(int[] list) {
            ReadInt(list);
            Array.Sort(list);
            int count = 1;
            for (int i=0; i<list.Length; i++)
            {
                int x = list[i];
                if (i<list.Length-1 && x == list[i + 1])
                {
                    count++;
                }
                else if (i == list.Length-1 && x==list[i-1])
                {
                    Console.WriteLine($"{list[i]} muncul {count} kali");
                }
                else {
                    Console.WriteLine($"{list[i]} muncul {count} kali");
                    count = 1;
                }
            }
        }
        public static void Soal6(int[] list)
        {
            Console.WriteLine("Before Marker");
            ReadInt(list);
            Array.Sort(list);
            for (int i=0; i<list.Length; i++)
            {
                int x = list[i];
                if(i<list.Length-1 && x == list[i + 1])
                {
                    for(int j=i; j<list.Length; j++)
                    {
                        if (j == list.Length - 1)
                        {
                            list[j] = -1;
                        }
                        else
                        {
                            list[j] = list[j + 1];
                        }
                        
                    }
                }
            }
            ReadInt(list);
        }
    }
}
