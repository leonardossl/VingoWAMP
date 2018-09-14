Process myProcess = new Process();
myProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
myProcess.StartInfo.CreateNoWindow = true;
myProcess.StartInfo.UseShellExecute = false;
myProcess.StartInfo.FileName = "cmd.exe";
myProcess.StartInfo.Arguments = "/c " + path;
myProcess.EnableRaisingEvents = true;
myProcess.Exited += new EventHandler(process_Exited);
myProcess.Start();
myProcess.WaitForExit();
ExitCode = myProcess.ExitCode;
