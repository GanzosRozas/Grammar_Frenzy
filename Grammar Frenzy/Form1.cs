using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
using System.Media;

namespace Grammar_Frenzy
{
    public partial class Form1 : MaterialForm
    {
        SoundPlayer Audios;
        public Form1()
        {
            InitializeComponent();
        }
        public string getPath(string cancion)
        {
            string[] s = { "\\bin" };
            string path = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\Audios\\" + cancion;

            return path;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string cancion = getPath("Welcome.wav");

            Audios = new SoundPlayer(cancion);


            Audios.Load();
            Audios.PlayLooping();
        }
    }

    

}
