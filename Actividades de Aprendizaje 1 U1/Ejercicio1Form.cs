using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividades_de_Aprendizaje_1_U1
{
    public partial class Ejercicio1Form : Form
    {
        //Declaracion
        public Graphics papel;
        //Declaracion de Variables
        int x, y, ancho, altura;

        public Ejercicio1Form()
        {
            InitializeComponent();

            trackBarV.Minimum = 0;
            trackBarV.Maximum = pictureBox1.Height;

            trackBarH.Minimum = 0;
            trackBarH.Maximum = pictureBox1.Width;

            TracVer.Minimum = 0;
            TracVer.Maximum = pictureBox1.Height;

            TrackHor.Minimum = 0;
            TrackHor.Maximum = pictureBox1.Width;

            lblTV.Text = Convert.ToString(trackBarV.Value);
            lblTH.Text = Convert.ToString(trackBarH.Value);
            //Inicializar mi grafico
            papel = pictureBox1.CreateGraphics();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            //Cierra el formulario
            this.Close();
        }

        private void btnEjercicio1_Click(object sender, EventArgs e)
        {
            //Inicializar la pluma
            Pen lapiz = new Pen(Color.Black);
            papel.DrawRectangle(lapiz, 10, 10, 100, 50);
            papel.DrawRectangle(lapiz, 10, 75, 100, 100);
            //Habilita los botones Borrar y Relleno
            btnBorrar.Enabled = true;
            btnRelleno.Enabled = true;
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            papel.Clear(Color.White);
            //Deshabilita los botones Relleno y Borrar
            btnRelleno.Enabled = false;
            btnBorrar.Enabled = false;
            //Habilita el boton Ejercicio1
            btnEjercicio1.Enabled = true;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {
            //Deshabilita los botones Borrar y Relleeno
            btnBorrar.Enabled = false;
            btnRelleno.Enabled = false;

        }

        private void trackBarV_Scroll_1(object sender, EventArgs e)
        {
            lblTV.Text = Convert.ToString(trackBarV.Value);
            // Movimientos Track Bar
            x = trackBarH.Value;
            y = trackBarV.Value;

            ancho = TrackHor.Value;
            altura = TracVer.Value;
            //Inicializamos la pluma
            Pen lapiz = new Pen(Color.Black);
            Graphics papel;
            //Inicializar mi grafico
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.White);
            papel.DrawRectangle(lapiz, x, y, ancho, altura);
            btnBorrar.Enabled = true;
        }

        private void trackBarH_Scroll_1(object sender, EventArgs e)
        {
            lblTH.Text = Convert.ToString(trackBarH.Value);
            // Movimientos Track Bar
            x = trackBarH.Value;
            y = trackBarV.Value;

            ancho = TrackHor.Value;
            altura = TracVer.Value;

            //Inicializamos la pluma
            Pen lapiz = new Pen(Color.Black);
            Graphics papel;
            //Inicializar mi grafico
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.White);
            papel.DrawRectangle(lapiz, x, y, ancho, altura);
            btnBorrar.Enabled = true;
        }
        
        private void TracVer_Scroll_1(object sender, EventArgs e)
        {
            lblVertical.Text = Convert.ToString(TracVer.Value);
            // Movimientos Track Bar
            x = trackBarH.Value;
            y = trackBarV.Value;

            ancho = TrackHor.Value;
            altura = TracVer.Value;
            //Inicializamos la pluma
            Pen lapiz = new Pen(Color.Black);
            Graphics papel;
            //Inicializar mi grafico
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.White);
            papel.DrawRectangle(lapiz, x, y, ancho, altura);
            btnBorrar.Enabled = true;
        }

        private void TrackHor_Scroll_1(object sender, EventArgs e)
        {
            lblHorizontal.Text = Convert.ToString(TrackHor.Value);
            // Movimientos Track Bar
            x = trackBarH.Value;
            y = trackBarV.Value;

            ancho = TrackHor.Value;
            altura = TracVer.Value;
            //Inicializamos la pluma
            Pen lapiz = new Pen(Color.Black);
            Graphics papel;
            //Inicializar mi grafico
            papel = pictureBox1.CreateGraphics();
            papel.Clear(Color.White);
            papel.DrawRectangle(lapiz, x, y, ancho, altura);
            //Habilita el boton Borrar
            btnBorrar.Enabled = true;
        }

        private void btnRelleno_Click_1(object sender, EventArgs e)
        {
            //Muestra la venta de dialogo de colores
            colorDialog1.ShowDialog();
            //Inicializamos el relleno
            SolidBrush brocha = new SolidBrush(colorDialog1.Color);
            papel.FillRectangle(brocha, 10, 75, 100, 100);
            papel.FillRectangle(brocha, 10, 10, 100, 50);
            btnEjercicio1.Enabled = false;
        }
    }
}

