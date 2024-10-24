using System.Net;
using System.Net.Http.Headers;

namespace HW_DownoloadImage
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlImage = "https://cdn.pixabay.com/photo/2013/04/03/12/05/tree-99852_640.jpg";
            string filepath = @"C:\Hello\image22.jpg";
            string directorypath = Path.GetDirectoryName(urlImage);
            
                if (!Directory.Exists(directorypath))
                {
                    Directory.CreateDirectory(directorypath);
                }
            
            
            

                WebClient client = new WebClient();
                using (Stream stream = client.OpenRead(urlImage))
                {
                    using (FileStream fileStream = File.Create(filepath))
                    {
                        stream.CopyTo(fileStream);
                    }
                }
                Console.WriteLine("File succseesful Loaded");
            
            //catch(Exception ex) 
            //{
            //    Console.WriteLine("something gone wrong");
            //}
        }
    }
}
