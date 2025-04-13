using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace SAPIEEFRO2
{
    public partial class Form1 : Form
    {
        public int ex;
        public int ey;
        public bool activo=true;
        public  String[] Horas;
        //public String[] Config;

        public String[] Config { get; set; } 

        public event EventHandler<String[]> Config2;
        
        private WindowsMediaPlayer Mediap;
        private SoundPlayer simpleSound = new SoundPlayer();
        private string cnfSonido;

        public Form1()
        {
            InitializeComponent();

            Lbl_fecha.Text = DateTime.Today.ToString("D");
            DateTime fechaEntrada = DateTime.Now;
            Lbl_Time.Text = fechaEntrada.ToString("HH:mm:ss");

            Mediap = new WindowsMediaPlayer();

            CargarConfig();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button != MouseButtons.Left){
                ex = e.X;
                ey = e.Y;
            }else{
                this.Left = this.Left + (e.X - ex);
                this.Top = this.Top + (e.Y - ey);
            }
            
        }

        private void Timer_tik_Tick(object sender, EventArgs e)
        {
            Lbl_fecha.Text = DateTime.Today.ToString("D");
            DateTime fechaEntrada = DateTime.Now;
            Lbl_Time.Text = fechaEntrada.ToString("HH:mm:ss");

            if (Horas.Contains(fechaEntrada.ToString("HH:mm:ss")) && activo)
            {
                Sonar(null,null);
            }
            //TEST
            Console.WriteLine(Horas[Horas.Length-1]);

        }

        public void CargarConfig()
        {
            if (File.Exists(@"sapieefro.conf"))
            {
                Config = null;
                Config = File.ReadAllLines(@"sapieefro.conf", Encoding.UTF8);
                String[] Sonido = Config[0].Split('=');
                if (!Directory.Exists(@"Sonidos\"))
                {
                    Directory.CreateDirectory(@"Sonidos\");
                }
                switch (cnfSonido = Sonido[1].Trim())
                {
                    case "Default":
                        simpleSound = new SoundPlayer(Properties.Resources.Default);
                        break;
                    case "Himno":
                        simpleSound = new SoundPlayer(Properties.Resources.Himno1);
                        break;
                    default:
                        //simpleSound = new SoundPlayer(@"Sonidos/" + Sonido[1].Trim());
                        Mediap.URL = @"Sonidos/" + Sonido[1].Trim();
                        Mediap.controls.stop();
                        break;
                }
                String[] Colorconf = Config[1].Split('=');
                String[] RgbC = Colorconf[1].Split(',');
                this.BackColor = Color.FromArgb(int.Parse(RgbC[0]), int.Parse(RgbC[1]), int.Parse(RgbC[2]));
                String[] opciones = Config[2].Split('=');
                String[] Hours = opciones[1].Split('_');
                Horas = new String[Hours.Length];
                for (int i = 0; i < Hours.Length; i++)
                {
                    Horas[i] = Hours[i];
                }
            }
            else
            {
                try
                {
                    StreamWriter archivocfg = File.AppendText(@"sapieefro.conf");
                    archivocfg.WriteLine("Sound=Default");
                    simpleSound = new SoundPlayer(Properties.Resources.Himno1);
                    if (!Directory.Exists(@"Sonidos\"))
                    {
                        Directory.CreateDirectory(@"Sonidos\");
                    }
                    archivocfg.WriteLine("BackColor=120, 180, 255");
                    this.BackColor = Color.FromArgb(120, 180, 255);
                    archivocfg.WriteLine("Hours=08:00:00");
                    Horas = new String[] { "08:00:00" };
                    archivocfg.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("Ocurrio un error por los permisos de administrador en la aplicacion: " + e.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }



        }

        private void Btn_suspender_Click(object sender, EventArgs e)
        {
            if (activo){
                activo = false;
                simpleSound.Stop();
                Mediap.controls.stop();
                Lbl_Time.ForeColor = Color.Gray;
                Btn_suspender.Text = "REANUDAR";
            }else{
                activo = true;
                simpleSound.Stop();
                Mediap.controls.stop();
                Lbl_Time.ForeColor = Color.Black;
                Btn_suspender.Text = "SUSPENDER";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simpleSound.Stop();
            Mediap.controls.stop();
            Lbl_Time.Size = new Size( 271, 57);
            Btn_detener.Visible = false;
            Lbl_Time.ForeColor = Color.Black;
        }

        private void Sonar(object sender, EventArgs e)
        {
            switch (cnfSonido)
            {
                case "Default":
                    simpleSound.Play();
                    break;
                case "Himno":
                    simpleSound.Play();
                    break;
                default:
                    Mediap.controls.play();
                    break;
            }            
            Lbl_Time.ForeColor = Color.Green;
            Lbl_Time.Size = new Size(225, 57);
            Btn_detener.Visible = true;
            
        }

        private void Btn_config_Click(object sender, EventArgs e)
        {
            Lbl_Time.ForeColor = Color.Black;
            Ajustes FAjustes = new Ajustes();
            FAjustes.Config2 += AlterarConfig;
            FAjustes.MyParent = this;
            FAjustes.Show();
        }
        public void Probar(string Cfg)
        {
            Label1.Text = Cfg;
        }
        private void AlterarConfig(object sender, String[] e)
        {
            //Config = e; // Actualiza la variable del padre
            CargarConfig();
        }
    }
}
