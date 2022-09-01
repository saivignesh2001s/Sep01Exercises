namespace Sep01Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the elements to sort");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] m = new int[n];
            for(int i = 0; i < n; i++)
            {
                m[i]= Convert.ToInt32(Console.ReadLine());

            }
            shellsort(m);
            Console.WriteLine("after shell sort");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(m[i]);
            }
            Console.ReadLine();
        }
        public static void shellsort(int[] m) {
            int inner, outer, valueToInsert, interval = 1, i = 0;

            while (interval <= ((m.Length) / 3))
            {
                //  h=h*3+1
                interval = interval * 3 + 1;
            }
            while (interval > 0)
            {
                for (outer = 0; outer < m.Length; outer++)
                {
                    valueToInsert = m[outer];
                    inner = outer;
                    while ((inner > interval - 1) && (m[inner - interval] >= valueToInsert))
                    {
                        m[inner] = m[inner - interval];
                        inner = inner - interval;
                        Console.WriteLine("Item moved= " + m[inner]);
                    }
                    m[inner] = valueToInsert;
                    Console.WriteLine("Item inserted at =" + m[inner]);
                }
                interval = (interval - 1) / 3;
                i += 1;
            }

        }
        }
       
    }
