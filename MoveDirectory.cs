
namespace ConsoleApp20
{
    public class MoveDirectory
    {
        public void Movedirectory()
        {
            Console.WriteLine("Input: ");
            string dir = Console.ReadLine();
            Console.WriteLine("Input: ");
            string copydir = Console.ReadLine();
            if (!Directory.Exists(dir))
            {
                Console.WriteLine("Error");
            }
            else if (Directory.Exists(dir))
            {
                Directory.Move(dir, copydir);
                Console.WriteLine("Directory Move");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
