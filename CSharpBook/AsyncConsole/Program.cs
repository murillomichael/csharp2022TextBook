namespace AsyncConsole
{
    public class Program
    {
        public static async Task Main(string[] args) // only C# 7.1 can make main async.
        {
            // Creating HttpClient instance
            HttpClient client = new();

            HttpResponseMessage response = await client.GetAsync("http://www.apple.com/");

            WriteLine("Apple's home page contains {0:N0} bytes", response.Content.Headers.ContentLength);
        }
    }
}