namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var test = "TestFolder";
            var path = @"C:\Users\USER\source\repos\ConsoleApp20";// + test;
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                //Directory.Delete(path, recursive: true);
            }
            Directory.Move(test, path);
            var dir = Directory.GetDirectories(path);
            foreach(var dir2 in dir)
            {
                Console.WriteLine(dir2);
            }
            var files = Directory.GetFiles(path);
            foreach (var file in files)
            {
                Console.WriteLine(file);
            }
            var info = new DirectoryInfo(path).GetFileSystemInfos();
            foreach(var info2 in info)
            {
                Console.WriteLine(info2.Name);
            }*/
            /*var FileName = "CopyMe.txt";
            using (StreamWriter writer = new StreamWriter(FileName, append: true))
            {
                 writer.WriteLine("a");
            }*/
            CopyFile filecopy = new CopyFile();
            MoveFile filemove = new MoveFile();
            CopyDirectory dircopy = new CopyDirectory();
            MoveDirectory dirmove = new MoveDirectory();
            filecopy.Copyfile();  
            filemove.Movefile();
            dircopy.Copydirectory();
            dirmove.Movedirectory();
        }
    }
}
