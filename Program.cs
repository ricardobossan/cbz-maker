using System.IO.Compression;

//char dsc = Path.DirectorySeparatorChar;
//string dir = $@"{Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)}{dsc}Mangas{dsc}Vagabond";
string dir = Directory.GetCurrentDirectory();

IEnumerable<string> vols = Directory.EnumerateDirectories(dir);

foreach (string path in vols)
{
    try
    {
        ZipFile.CreateFromDirectory(path, path + ".cbz");
        Console.WriteLine(path + " Compressed successfully");
    }
    catch
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Failed to compress " + path);
        Console.ResetColor();
    }
}



