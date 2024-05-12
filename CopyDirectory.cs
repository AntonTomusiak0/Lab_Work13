
namespace ConsoleApp20
{
    public class CopyDirectory
    {
        public void Copydirectory()
        {
            Console.WriteLine("Input: ");
            string dir = Console.ReadLine();
            Console.WriteLine("Input: ");
            string copydir = Console.ReadLine();
            if (!Directory.Exists(dir))
            {
                Console.WriteLine("ERROR");
            }
            else if (Directory.Exists(dir))
            {
                Directory.CreateDirectory(copydir);
                foreach (string dirPath in Directory.GetDirectories(dir, "*", SearchOption.AllDirectories))
                {
                    Directory.CreateDirectory(dirPath.Replace(dir, copydir));
                }
                foreach (string newPath in Directory.GetFiles(dir, ".", SearchOption.AllDirectories))
                {
                    File.Copy(newPath, newPath.Replace(dir, copydir), true);
                }
                Console.WriteLine("Directory copy");
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
