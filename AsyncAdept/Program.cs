using AsyncAdept;

Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 11");

/***********************************************************************
* Understanding Asynchronous and Synchronous Operations Code Example    *
* ***********************************************************************/

// Create an instance of OperationProcessor
OperationProcessor processor = new OperationProcessor();

// Call the synchronous method
processor.PerformTaskSynchronously();

// Call the asynchronous method
await processor.PerformTaskAsynchronously();

Console.WriteLine("Operations completed.");


// Provide the URL you want to download data from
string url = "https://ziggyrafiq.com";

try
{
    // Call the asynchronous method
    string data = await processor.DownloadDataAsync(url);

    // Output the downloaded data
    Console.WriteLine("Downloaded data:");
    Console.WriteLine(data);
}
catch (Exception ex)
{
    // Handle any exceptions that may occur during the download
    Console.WriteLine($"An error occurred: {ex.Message}");
}

try
{
    await processor.PerformAsyncOperation();
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}


try
{
    // Call the asynchronous method to fetch data
    string data = await processor.FetchDataAsync(url);

    // Output the fetched data
    Console.WriteLine("Fetched data:");
    Console.WriteLine(data);
}
catch (Exception ex)
{
    // Handle any exceptions that may occur during the operation
    Console.WriteLine($"An error occurred: {ex.Message}");
}