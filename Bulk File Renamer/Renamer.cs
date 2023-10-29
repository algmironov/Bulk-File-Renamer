using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulk_File_Renamer
{
    public class Renamer
    {
        public static void Rename(string path)
        {
            int num = 1;
            var files = Directory.GetFiles(path).ToList();
            string newFileName = string.Empty;

            // int num = files.Count;
            try { 
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                string fileExtension = Path.GetExtension(file);
                if (fileExtension != "null" && (fileExtension == ".jpg" || fileExtension == ".JPG"))
                {
                    if (num < 10)
                    {
                        newFileName = $"00000{num}{fileExtension}";
                        string newFilePath = Path.Combine(path, newFileName);
                        File.Move(file, newFilePath);
                    }
                    else if (num > 9 && num < 100)
                    {
                        newFileName = $"0000{num}{fileExtension}";
                        string newFilePath = Path.Combine(path, newFileName);
                        File.Move(file, newFilePath);
                    }
                    else if (num > 99 && num < 1000)
                    {
                        newFileName = $"000{num}{fileExtension}";
                        string newFilePath = Path.Combine(path, newFileName);
                        File.Move(file, newFilePath);
                    }
                    else if (num > 999 && num < 10000)
                    {
                        newFileName = $"00{num}{fileExtension}";
                        string newFilePath = Path.Combine(path, newFileName);
                        File.Move(file, newFilePath);
                    }
                    num++;
                }

            }
            } catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }

            Console.WriteLine("Все файлы успешно переименованы.");
        }
    }
}
