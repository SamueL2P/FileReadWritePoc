namespace FileReadWritePoc
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Read Write HTML file with File class

            string htmlFilePath = @"D:\C#programs\FileReadWritePoc\bin\Debug\net8.0\Text File\Text.html";
            string defaultHtmlContent = "<html><body><h1>Welcome to Samuel's HTML File</h1></body></html>";

            Console.WriteLine("HTML File");
            WriteFile(htmlFilePath, defaultHtmlContent);
            ReadFile(htmlFilePath);


            //Read Write Text File
            Console.WriteLine("\n========================================");
            Console.WriteLine("\nText File");
            string textFilePath = @"D:\C#programs\FileReadWritePoc\bin\Debug\net8.0\Text File\Text.txt";
            string textContent = "Welcome to Samuel's Text File";

            WriteFile(textFilePath, textContent);
            ReadFile(textFilePath);


            //Append username 
            Console.WriteLine("==========================================");
            Console.WriteLine("Append File");
            string filePath = @"D:\C#programs\FileReadWritePoc\bin\Debug\net8.0\Text File\Append.txt";
            AppendUsername(filePath);

           

        }

        static void WriteFile(string path , string content)
        {

            File.WriteAllText(path, content);
            Console.WriteLine("\nContent written");
        }

        static void ReadFile(string path)
        {
            if (File.Exists(path))
            {
                string content = File.ReadAllText(path);
                Console.Write("\nFile Content:");
                Console.WriteLine(content);
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }

        static void AppendUsername(string path)
        {
            Console.Write("\nEnter your username: ");
            string username = Console.ReadLine();

            File.AppendAllText(path, username + Environment.NewLine);

            Console.WriteLine("Username has been saved.");

            Console.WriteLine("All usernames in the file:");
            string[] allUsernames = File.ReadAllLines(path);
            foreach (string user in allUsernames)
            {
                Console.WriteLine(user);
            }
        }
    }
}
