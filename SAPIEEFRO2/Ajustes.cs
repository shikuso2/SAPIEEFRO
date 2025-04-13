using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAPIEEFRO2
{
    public partial class Ajustes : Form
    {
        public Form1 MyParent { get; set; }
        public event EventHandler<String[]> Config2;
        Form1 fPrincipal= new Form1();
        public String[] Config ;
        public String[] Horas;
        public bool Abierto= false;
        public string cfgColor;

        public Ajustes()
        {
            InitializeComponent();
            fPrincipal.Probar("aaaa");
            Config = fPrincipal.Config;
            //label1.Text = this.MyParent.Lbl_Time.Text;
            //CARGAR SONIDOS
            CargarSonidos();
            //CARGAR COLORES
            String[] Colorconf = Config[1].Split('=');
            String[] RgbC = Colorconf[1].Split(',');
            Btn_color.BackColor = Color.FromArgb(int.Parse(RgbC[0]), int.Parse(RgbC[1]), int.Parse(RgbC[2]));
            cfgColor = RgbC[0] + "," + RgbC[1] + "," + RgbC[2];
            //Btn_color.BackColor = Color.FromArgb(120, 180, 255);

            //CARGAR HORAS
            Horas = fPrincipal.Horas;
            for (int i = 0; i < Horas.Length; i++)
            {
                Lbx_Horas.Items.Add(Horas[i]);
            }
            //INICIAR
            Abierto = true;
        }

        private void Ajustes_Load(object sender, EventArgs e)
        {            

        }
        
        private void Cb_Sonidos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Abierto)
                Guardar();
        }
        public void CargarSonidos()
        {
            Cb_Sonidos.Items.Add("Default");
            Cb_Sonidos.Items.Add("Himno");
            if (!Directory.Exists(@"Sonidos\"))
            {
                DirectoryInfo di = Directory.CreateDirectory(@"Sonidos\");
            }
            DirectoryInfo carpeta = new DirectoryInfo(@"Sonidos\");
            foreach (var fi in carpeta.GetFiles())
            {
                Cb_Sonidos.Items.Add(fi.Name);
            }
                   
            String[] Sonido = Config[0].Split('=');
            Cb_Sonidos.SelectedIndex = Cb_Sonidos.Items.IndexOf(Sonido[1]);
        }

        private void Btn_color_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                
                Btn_color.BackColor = colorDialog1.Color;
                this.MyParent.BackColor = colorDialog1.Color;
                cfgColor=colorDialog1.Color.R+","+colorDialog1.Color.G+","+colorDialog1.Color.B;
                Guardar();
            }
        }

        private void Btn_Agregar_Click(object sender, EventArgs e)
        {
            Lbx_Horas.Items.Add(Decimal.ToInt32(Num_Hora.Value).ToString("D2") + ":" + Decimal.ToInt32(Num_Min.Value).ToString("D2") + ":" + Decimal.ToInt32(Num_Seg.Value).ToString("D2"));
            Guardar();
        }  
        public void Guardar()
        {
            if (File.Exists(@"sapieefro.conf"))
            {
                try
                {
                    File.Delete(@"sapieefro.conf");
                }
                catch (IOException ex)
                {
                    MessageBox.Show("Ocurrio un error por los permisos de administrador en la aplicacion: " + ex.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            StreamWriter archivo = File.AppendText(@"sapieefro.conf");

            archivo.WriteLine("Sound=" + Cb_Sonidos.Text);
            archivo.WriteLine("BackColor =" + cfgColor);

            string varHoras = "Hours=";

            for (int i = 0; i < (Lbx_Horas.Items.Count); i++)
            {
                varHoras += Lbx_Horas.Items[i];
                if ((Lbx_Horas.Items.Count - 1) != i)
                    varHoras += "_";
            }
            archivo.WriteLine(varHoras);
            archivo.Close();
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");

            if (Config2 != null)
            {
                //Config2(this, File.ReadAllLines(@"sapieefro.conf", Encoding.UTF8)); 
                Config2(this,null); 
            }

            simpleSound.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Lbx_Horas.SelectedItem != null)
            {
                Lbx_Horas.Items.Remove(Lbx_Horas.SelectedItem);
                Guardar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Application.StartupPath + @"\Sonidos\");
        }
    }
}
