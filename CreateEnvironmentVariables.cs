//SET
public static void Set(string name, string value) 
{
    Environment.SetEnvironmentVariable(name, value, EnvironmentVariableTarget.Machine);
}

//GET
string path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine) + ";c:\\";
Environment.SetEnvironmentVariable("Path", path, EnvironmentVariableTarget.Machine);

// Get a single environment variable in this sample LOCALAPPDATA
var localAppData = System.Environment.GetEnvironmentVariable("LOCALAPPDATA");
// Get a collection of all the environment variables
var env = System.Environment.GetEnvironmentVariables(); 
