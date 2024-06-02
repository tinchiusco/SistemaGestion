using GestionMuebles.Forms;
using System.Security.Cryptography.X509Certificates;

namespace GestionMuebles
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