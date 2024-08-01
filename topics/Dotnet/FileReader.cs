using System.IO.Enumeration;
using System.Net;

namespace interview_practice.topics.Dotnet
{
    public static class FileReader
    {

        public static int ReadFileAndSumNumber()
        {


            var filePath = "D:\\Code\\interview-practice\\resource\\numbers.txt";

            int sum = 0;

            try
            {
                string[] numbers = File.ReadAllLines(filePath);



                foreach (var numberStr in numbers)
                {
                    Int32.TryParse(numberStr.Trim(), out int number);

                    sum += number;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


            return sum;
        }


        public static async Task<long> DownloadFileAsync()
        {

            var fileUrl = "http://localhost:8080/videos/interface.mp4";
            var filePath = "D:\\Code\\interview-practice\\resource\\movie.mp4";
            var chunkSize = 1024 * 1024 * 2;


            using (var httpClient = new HttpClient())
            {

                var response = await httpClient.GetAsync(fileUrl, HttpCompletionOption.ResponseHeadersRead);

                response.EnsureSuccessStatusCode();

                long totalContentSize = response.Content.Headers.ContentLength ?? 0;


                using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.None, chunkSize))
                {

                    long totalBytesRead = 0;

                    int bytesRead = 0;

                    byte[] buffer = new byte[chunkSize];

                    Stream stream = await response.Content.ReadAsStreamAsync();

                    while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
                    {

                        await fileStream.WriteAsync(buffer, 0, bytesRead);

                        totalBytesRead += bytesRead;


                        Console.WriteLine($"Downloaded {totalBytesRead} of {totalContentSize} bytes ({(double)totalBytesRead / totalContentSize:P})");

                    }

                    stream.Close();


                    return fileStream.Length;
                }

            }

        }



        //class Program
        //    {
        //        static async Task Main(string[] args)
        //        {
        //            string fileUrl = "https://example.com/largefile.zip"; // URL of the large file
        //            string destinationFilePath = "largefile.zip"; // Local path to save the downloaded file
        //            int chunkSize = 1024 * 1024; // 1 MB chunks

        //            await DownloadFileInChunksAsync(fileUrl, destinationFilePath, chunkSize);
        //            Console.WriteLine("File download completed.");
        //        }

        //        static async Task DownloadFileInChunksAsync(string url, string destinationFilePath, int chunkSize)
        //        {
        //            using (HttpClient httpClient = new HttpClient())
        //            {
        //                HttpResponseMessage response = await httpClient.GetAsync(url, HttpCompletionOption.ResponseHeadersRead);

        //                response.EnsureSuccessStatusCode();

        //                long totalFileSize = response.Content.Headers.ContentLength ?? 0;

        //                Console.WriteLine($"Total file size: {totalFileSize} bytes");

        //                using (FileStream fileStream = new FileStream(destinationFilePath, FileMode.Create, FileAccess.Write, FileShare.None, chunkSize, useAsync: true))
        //                {
        //                    long totalBytesRead = 0;
        //                    int bytesRead;
        //                    byte[] buffer = new byte[chunkSize];

        //                    using (Stream contentStream = await response.Content.ReadAsStreamAsync())
        //                    {
        //                        while ((bytesRead = await contentStream.ReadAsync(buffer, 0, buffer.Length)) > 0)
        //                        {
        //                            await fileStream.WriteAsync(buffer, 0, bytesRead);
        //                            totalBytesRead += bytesRead;
        //                            Console.WriteLine($"Downloaded {totalBytesRead} of {totalFileSize} bytes ({(double)totalBytesRead / totalFileSize:P})");
        //                        }
        //                    }
        //                }
        //            }
        //        }
        //    }
    }
}
