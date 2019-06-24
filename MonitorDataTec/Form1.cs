using System;
using System.IO;
using System.Windows.Forms;

namespace MonitorDataTec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            FileSystemWatcher observador = new FileSystemWatcher(@"C:\Temporal");
            observador.NotifyFilter = (
                NotifyFilters.LastAccess |
                NotifyFilters.LastWrite |
                NotifyFilters.FileName |
                NotifyFilters.DirectoryName);


            observador.Changed += Alcambiar;

            observador.EnableRaisingEvents = true;


       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();

            this.ShowInTaskbar = false;
        }
        private void Alcambiar(object source, FileSystemEventArgs e)
        {

            WatcherChangeTypes TipoCambio = e.ChangeType;
         
            if (e.Name.Equals("Data-Tec.txt"))
            {
                notifyIcon1.BalloonTipText = "El Archivo " + e.Name + " Fue Modificado";
                notifyIcon1.ShowBalloonTip(100);
            }
         

          

        }

    }
}
