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
            mergesort(m, 0, n - 1);
            Console.WriteLine("after merge sort");

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine(m[i]);
            }
            Console.ReadLine();
        }
        public static void mergesort(int[] m,int l,int h)
        {
            if (l < h)
            {
                int mid = (l + h) / 2;
                mergesort(m, l, mid);
                mergesort(m, mid + 1, h);
                merge(m, l, mid, h);
            }
        }
        public static void merge(int[] m,int start,int mid,int end)
        {
            int i = start;
            int j = mid + 1;
            int k = start;
            int[] crr = new int[start + end + 1];
            while(i<=mid && j <= end)
            {
                if (m[i] <= m[j])
                {
                    crr[k++] = m[i++];

                }
                else
                {
                    crr[k++] = m[j++];
                }
            }
            for (; i <= mid; i++)
                crr[k++] = m[i];
            for (; j <= end; j++)
                crr[k++] = m[j];
            for(int py = start; py <= end; py++)
            {
                m[py] = crr[py];
            }
        }
    }
}