using Serilog;

Console.WriteLine("Hello, from Ziggy Rafiq");
Console.WriteLine("This Code Example Project is for Chapter 9");

/**********************************************************************
* Handling Exceptions Using try-catch Blocks Code Example             *
***********************************************************************/
try
{
    // Code that may throw an exception
    int result = 10 / 0;
}
catch (Exception ex)
{
    // Handle the exception
    Console.WriteLine($"An error occurred: {ex.Message}");
}


/**********************************************************************
* Throwing and Catching Exceptions Code Example                       *
***********************************************************************/
try
{
    throw new Exception("Something went wrong");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}


/**********************************************************************
* Handling and Throwing Exceptions in C# Code Example                 *
***********************************************************************/
try
{
    int[] numbers = null;
    int sum = numbers.Sum(); // Throws NullReferenceException
}
catch (NullReferenceException ex)
{
    Console.WriteLine($"Null reference exception: {ex.Message}");
}

/**********************************************************************
* try-catch-finally Blocks Code Example                               *
***********************************************************************/
try
{
    // Code that may throw an exception
}
catch (Exception ex)
{
    // Handle the exception
}
finally
{
    // Cleanup operations
}

/**********************************************************************
* Custom Exception Code Example                                       *
***********************************************************************/
try
{
    // Throw the custom exception
    throw new ExceptionExplorer.CustomException("This is a custom exception.");
}
catch (ExceptionExplorer.CustomException ex)
{
    // Catch and handle the custom exception
    Console.WriteLine(ex.Message);
}

/**********************************************************************
* Best Practices for Exception Handling Code Example                  *
***********************************************************************/
// Configure Serilog to write log messages to the console
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .CreateLogger();
try
{
    // Code that may throw an exception
}
catch (Exception ex)
{
    // Log the exception
    // Provide user-friendly error message
    Log.Error(ex, "An error occurred/n");
    Log.Error($"{ex.Message} /n");
    Log.Error($"{ex.StackTrace} /n");
    Console.WriteLine("An error occurred. Please contact support.");

    
    

    // Throw the exception (optional)
    throw;
}



