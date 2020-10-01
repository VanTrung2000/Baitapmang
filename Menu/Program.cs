using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int choice = 0;
            do
            {
                Console.WriteLine("1.Tao Mang");
                Console.WriteLine("2.Kiem tra mang doi xung ");
                Console.WriteLine("3.Sap xep mang ");
                Console.WriteLine("4.Tim kiem mang ");
                Console.WriteLine("5.Thoat ");
                Console.WriteLine("Please select an item: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        pr.CreateArray();
                        break;
                    case 2:
                       
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        return;

                }
            } while (choice != 5);
        }
        public void nhap(int[] array, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + i + "]=");
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        public void xuat(int[] array, int n)
        {
           Console.Write("Hien thi mang:");
            
            for (int i = 0; i < n; i++)
                Console.Write(array[i] + " ");
            Console.WriteLine("\n");
        }

        public void CreateArray()
        {
            Console.WriteLine("Nhap so ptu cua mang: ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[100];
            nhap(array, n);
            
        }
       public int kiemtramangdoixung(int[] array, int n)
        {
            int no = 1;
            for (int i = 0; i < n / 2; i++)
            {
                if (array[i] != array[n - 1 - i]) no = 0;
            }
            return no;
        }


        public void IsSymmetryArray()
        {
            
            
           
        }
        public void BubbleSort() { 
             int n, temp;
            int[] a;
            Console.WriteLine("Nhap so phan tu mang :");
            n = int.Parse(Console.ReadLine());

            a = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("a[{0}]:", i);
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                    if (a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }

            Console.WriteLine("Mang sau khi sap xep:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ,", a[i]);
            }
        }

        }

        public void Find()
        {

        }

    }



}

