
/***********************************************************************
* Understanding Asynchronous and Synchronous Operations Code Example    *
* ***********************************************************************/
namespace AsyncAdept;
public class OperationProcessor
{
    private HttpClient _httpClient;

    public OperationProcessor()
    {
      _httpClient = new HttpClient();
    }
    // Synchronous operation
    public void PerformTaskSynchronously()
    {
        // Blocks the execution thread
        Task.Delay(1000).Wait(); 
        Console.WriteLine("Synchronous task completed.");
    }

    // Asynchronous operation
    public async Task PerformTaskAsynchronously()
    {
        // Frees the execution thread
        await Task.Delay(1000); 
        Console.WriteLine("Asynchronous task completed.");
    }

    public async Task<string> DownloadDataAsync(string url)
    {
        using (HttpClient client = new HttpClient())
        {
            string data = await client.GetStringAsync(url);
            return data;
        }
    }


    public async Task PerformAsyncOperation()
    {
        // Simulate an asynchronous operation that may throw an exception
        await Task.Delay(1000); // Simulate some work
        throw new InvalidOperationException("Something went wrong during the asynchronous operation.");
    }

    public async Task<string> FetchDataAsync(string url)
    {
        try
        {
            // Perform the HTTP request asynchronously
            HttpResponseMessage response = await _httpClient.GetAsync(url);

            // Ensure the request was successful
            response.EnsureSuccessStatusCode();

            // Read the content of the response asynchronously
            return await response.Content.ReadAsStringAsync();
        }
        catch (Exception ex)
        {
            // Handle any exceptions that occurred during the operation
            Console.WriteLine($"An error occurred: {ex.Message}");
            return null;
        }
    }

     



}
