using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace _065EventosFile
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la ruta");
            FileSystemWatcher fileWa = new FileSystemWatcher();
            fileWa.Path = Console.ReadLine().Trim();

            fileWa.Renamed +=new RenamedEventHandler( (o, s) =>
            {
                Console.WriteLine($"Nombre anterior: {s.OldFullPath}");
                Console.WriteLine($"Nombre actual: {s.FullPath}");
            });
            fileWa.Changed += new FileSystemEventHandler((e, a) =>
              {
                  Console.WriteLine(a.FullPath);
              });
            fileWa.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.DirectoryName;
            Console.ReadLine();
            //Console.WriteLine(args[0]);
            //hola(args[0]);
        }
        static void hola(string ruta)
        {
            // If a directory is not specified, exit program.  
            if (string.IsNullOrWhiteSpace(ruta))
            {
                // Display the proper way to call the program.  
                Console.WriteLine("Usage: FileWatcher.exe <directory>");
                return;
            }
            try
            {
                // Create a new FileSystemWatcher and set its properties.  
                FileSystemWatcher watcher = new FileSystemWatcher();
                watcher.Path = ruta;
                // Watch both files and subdirectories.  
                watcher.IncludeSubdirectories = true;
                // Watch for all changes specified in the NotifyFilters  
                //enumeration.  
                watcher.NotifyFilter = NotifyFilters.Attributes |
                NotifyFilters.CreationTime |
                NotifyFilters.DirectoryName |
                NotifyFilters.FileName |
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.Security |
                NotifyFilters.Size;
                // Watch all files.  
                watcher.Filter = "*.*";
                // Add event handlers.  
                watcher.Changed += new FileSystemEventHandler(OnChanged);
                watcher.Created += new FileSystemEventHandler(OnChanged);
                watcher.Deleted += new FileSystemEventHandler(OnChanged);
                watcher.Renamed += new RenamedEventHandler(OnRenamed);
                //Start monitoring.  
                watcher.EnableRaisingEvents = true;
                //Do some changes now to the directory.  
                //Create a DirectoryInfo object.  
                DirectoryInfo d1 = new DirectoryInfo(ruta);
                //Create a new subdirectory.  
                d1.CreateSubdirectory("mydir");
                //Create some subdirectories.  
                d1.CreateSubdirectory("mydir1\\mydir2\\mydir3");
                //Move the subdirectory "mydir3 " to "mydir\mydir3"  
                Directory.Move(d1.FullName + "file://mydir1//mydir2//mydir3",
                d1.FullName + "\\mydir\\mydir3");
                //Check if subdirectory "mydir1" exists.  
                if (Directory.Exists(d1.FullName + "\\mydir1"))
                {
                    //Delete the directory "mydir1"  
                    //I have also passed 'true' to allow recursive deletion of  
                    //any subdirectories or files in the directory "mydir1"  
                    Directory.Delete(d1.FullName + "\\mydir1", true);
                }
                //Get an array of all directories in the given path.  
                DirectoryInfo[] d2 = d1.GetDirectories();
                //Iterate over all directories in the d2 array.  
                foreach (DirectoryInfo d in d2)
                {
                    if (d.Name == "mydir")
                    {
                        //If "mydir" directory is found then delete it recursively.  
                        Directory.Delete(d.FullName, true);
                    }
                }
                // Wait for user to quit program.  
                Console.WriteLine("Press \'q\' to quit the sample.");
                Console.WriteLine();
                //Make an infinite loop till 'q' is pressed.  
                while (Console.Read() != 'q') ;
            }
            catch (IOException e)
            {
                Console.WriteLine("A Exception Occurred :" + e);
            }
            catch (Exception oe)
            {
                Console.WriteLine("An Exception Occurred :" + oe);
            }
        }
        // Define the event handlers.  
        public static void OnChanged(object source, FileSystemEventArgs e)
        {
            // Specify what is done when a file is changed.  
            Console.WriteLine("{0}, with path {1} has been {2}", e.Name, e.FullPath, e.ChangeType);
        }
        public static void OnRenamed(object source, RenamedEventArgs e)
        {
            // Specify what is done when a file is renamed.  
            Console.WriteLine(" {0} renamed to {1}", e.OldFullPath, e.FullPath);
        }
    }
    
}
