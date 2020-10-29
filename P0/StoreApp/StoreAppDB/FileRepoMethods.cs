using System;
using StoreAppLib.Models;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;

namespace StoreAppDB
{
    public class FileRepoMethods : IEmployeeRepo
    {
        private string filename ="StoreAppDB/FileDatabase/Employees.txt";
       public async void AddEmployeeAsync(Employees employee)
       {

            using (FileStream fs = File.Create(path: filename)){
            await JsonSerializer.SerializeAsync(fs, employee);
            System.Console.WriteLine("Employee being written to file");
            }

       }
    }
}
