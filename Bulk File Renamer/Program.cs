using Bulk_File_Renamer;

bool dirIsValid = false;
string dir = string.Empty;

while (!dirIsValid)
{
    Console.WriteLine("Введите адрес папки: ");
    dir = Console.ReadLine();
    if (Directory.Exists(dir)) 
    {  
        dirIsValid = true;
    }
}

var files = Directory.GetFiles(dir);

Console.WriteLine($"В папке {dir} содержится {files.Length} файлов");

Console.WriteLine("Переименовать их? Y/N");
var renameAnswer = Console.ReadLine();

if (renameAnswer == "y" || renameAnswer == "Y")
{
    Renamer.Rename(dir);
    Console.WriteLine("Все файлы переименованы успешно!\n Завершение работы....");
    Thread.Sleep(2000);
    Environment.Exit(0);
}
else
{
    {
        Console.WriteLine("завершение работы....");
        Thread.Sleep(2000);
        Environment.Exit(0);
    }
}






