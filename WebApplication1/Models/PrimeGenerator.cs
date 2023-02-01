using System.Diagnostics;

namespace WebApplication1.Models
{
    public class PrimeGenerator
    {
        public int N { get; set; }
        public string OutputPath { get; }

        public PrimeGenerator()
        {
            OutputPath =  @"C:\Users\hanih\RiderProjects\WebApplication1\WebApplication1\Models\prime.txt";
            
        }
        public void LaunchCommandLineApp()
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
                
            startInfo.FileName = "prime.exe";
            startInfo.CreateNoWindow = false;
            startInfo.WorkingDirectory =@"C:\Users\hanih\RiderProjects\WebApplication1\WebApplication1\Models";
            //startInfo.WorkingDirectory = @"C:\Users\hanih\RiderProjects\WebApplication1\WebApplication1\Views\Home";
            // startInfo.WorkingDirectory = @".\";
            startInfo.Arguments = N.ToString();

            
            Process.Start(startInfo);
            Process p = Process.GetProcessesByName("prime")[0];
            p.WaitForExit();
        }
    }
}