
namespace ConsoleApp20
{
    public class CopyFile
    {
        public void Copyfile()
        {
            Console.WriteLine("Input path:");
            string path = Console.ReadLine();
            Console.WriteLine("Input copypath:");
            string copypath = Console.ReadLine();
            if (!File.Exists(path))
            {
                Console.WriteLine("ERROR");
            }
            else if (File.Exists(path))
            {
                File.Copy(path, copypath, true);
                Console.WriteLine("File Copy");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}