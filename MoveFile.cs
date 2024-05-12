
namespace ConsoleApp20
{
    public class MoveFile {
        public void Movefile()
        {
            Console.WriteLine("Input: ");
            string path = Console.ReadLine();
            Console.WriteLine("Input: ");
            string movepath = Console.ReadLine();
            if (!File.Exists(path))
            {
                Console.WriteLine("ERROR");
            }
            else if (File.Exists(path))
            {
                File.Move(path, movepath);
                Console.WriteLine("File Move");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
