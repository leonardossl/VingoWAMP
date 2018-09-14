//SET
public static void Set(string name, string value) 
{
    Environment.SetEnvironmentVariable(name, value, EnvironmentVariableTarget.Machine);
}

//GET
string path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine) + ";c:\\";
Environment.SetEnvironmentVariable("Path", path, EnvironmentVariableTarget.Machine);
