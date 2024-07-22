namespace FileReadWritePoc
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //Read Write HTML file with File class

            string htmlFilePath = @"D:\C#programs\FileReadWritePoc\bin\Debug\net8.0\Text File\Text.html";
            string defaultHtmlContent = "<html><body><h1>Welcome to Samuel's HTML File</h1></body></html>";

            File.WriteAllText(htmlFilePath, defaultHtmlContent);
            Console.WriteLine("Html content written");
            if (File.Exists(htmlFilePath))
            {
                string htmlContent = File.ReadAllText(htmlFilePath);
                Console.Write("\nHTML File Content:");
                Console.WriteLine(htmlContent);
            }
            else
            {
                Console.WriteLine("HTML file not found.");
            }

            //Read Write Text File

            string textFilePath = @"D:\C#programs\FileReadWritePoc\bin\Debug\net8.0\Text File\Text.txt";
            string textContent = "Welcome to Samuel's Text File";

            File.WriteAllText(textFilePath, textContent);
            Console.WriteLine("\nText content written");
            if (File.Exists(textFilePath))
            {
                string textReadContent = File.ReadAllText(textFilePath);
                Console.Write("\nText File Content:");
                Console.WriteLine(textReadContent);
            }
            else
            {
                Console.WriteLine("Text file not found.");
            }


            //Append username 

            string filePath = @"D:\C#programs\FileReadWritePoc\bin\Debug\net8.0\Text File\Append.txt";

            Console.Write("\nEnter your username: ");
            string username = Console.ReadLine();

            File.AppendAllText(filePath, username + Environment.NewLine);

            Console.WriteLine("Username has been saved.");

            Console.WriteLine("All usernames in the file:");
            string[] allUsernames = File.ReadAllLines(filePath);
            foreach (string user in allUsernames)
            {
                Console.WriteLine(user);
            }

        }
    }
}
