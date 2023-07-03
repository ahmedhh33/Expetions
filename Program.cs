namespace Exeptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3,0 };
            //foreach (int i in a) { Console.WriteLine(i); }
            //Console.WriteLine(a[5]);//here will show exceptions

            //Console.WriteLine(divide(4, 2));
            //Console.WriteLine(divide(2, 2));
            //Console.WriteLine(divide(3, 0));
            try
            {
                Console.WriteLine(a[1] / a[0]);
                Console.WriteLine(a[10] / a[3]);
                Console.WriteLine(a[2] / a[3]);//once it found the exceptions it will print the exceptions message and go out try

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"divide by zero exeption");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Endex out of range");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine(a[1] / a[1]);
        }

        static float divide(int a,int b)
        {
            try
            {
                return a / b;
            } catch (DivideByZeroException e)
            {
                return 0;
            }
        }
    }
}