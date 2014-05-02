using System;
using System.Windows.Forms;

namespace QLTOLabel
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new frmMain());
        }
    }
}
