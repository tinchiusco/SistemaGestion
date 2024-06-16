using SistemaGestionUI;
using System.Security.Cryptography.X509Certificates;

namespace SistemaGestionUI
{
    internal static class Program
    {
        public static FormInit formInit;
        
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(formInit = new FormInit());
        }
    }
}