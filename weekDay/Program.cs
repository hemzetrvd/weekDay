namespace weekDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-7 arasında bir ədəd daxil ed:");
            int gun = int.Parse(Console.ReadLine());

            switch (gun)
            {
                case 1:
                    Console.WriteLine("Bazar ertəsi");
                    break;
                case 2:
                    Console.WriteLine("Çərşənbə axşamı");
                    break;
                case 3:
                    Console.WriteLine("Çərşənbə");
                    break;
                case 4:
                    Console.WriteLine("Cümə axşamı");
                    break;
                case 5:
                    Console.WriteLine("Cümə");
                    break;
                case 6:
                    Console.WriteLine("Şənbə");
                    break;
                case 7:
                    Console.WriteLine("Bazar");
                    break;
                default:
                    Console.WriteLine("Düzgün ədəd daxil ed.");
                    break;
            }
        }
    }
}
        
