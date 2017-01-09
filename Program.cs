namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (B b = new B())
            {
                var aa = 2;
            }         
        }
    }
}
