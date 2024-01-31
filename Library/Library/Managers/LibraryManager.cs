using Library.Models;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Library.Data
{
    public class DataManager
    {
        // Метод для сохранения данных в файл
        public static void SaveDataToFile(LibraryTable table)
        {
            try
            {
                using (FileStream fileStream = new FileStream("library_data.dat", FileMode.Create))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    binaryFormatter.Serialize(fileStream, table);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving data to file: {ex.Message}");
            }
        }

        // Метод для загрузки данных из файла
        public static LibraryTable LoadDataFromFile()
        {
            try
            {
                if (File.Exists("library_data.dat"))
                {
                    using (FileStream fileStream = new FileStream("library_data.dat", FileMode.Open))
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        return (LibraryTable)binaryFormatter.Deserialize(fileStream);
                    }
                }
                else
                {
                    Console.WriteLine("File not found. Returning a new LibraryTable.");
                    return new LibraryTable();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading data from file: {ex.Message}");
                return new LibraryTable();
            }
        }
    }
}
