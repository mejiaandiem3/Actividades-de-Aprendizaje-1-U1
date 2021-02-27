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
    public partial class Ejercicio3Form : Form
    {
        //Declaracion
        public Graphics papel;
        public Ejercicio3Form()
        {
            InitializeComponent();
            //Inicializar mi grafico
            papel = pictureBox1.CreateGraphics();
        }

        private void btnDibujarDiana_Click(object sender, EventArgs e)
        {
            //Rellena los circulos
            SolidBrush Relleno = new SolidBrush(Color.Black);
            papel.FillEllipse(Relleno, 100, 100, 200, 200);
            papel.FillEllipse(Relleno, 113, 113, 173, 173);
            SolidBrush Relleno1 = new SolidBrush(Color.Blue);
            papel.FillEllipse(Relleno1, 123, 123, 153, 153);
            papel.FillEllipse(Relleno1, 135, 135, 130, 130);
            SolidBrush Relleno2 = new SolidBrush(Color.Red);
            papel.FillEllipse(Relleno2, 150, 150, 100, 100);
            papel.FillEllipse(Relleno2, 163, 163, 73, 73);
            SolidBrush Relleno3 = new SolidBrush(Color.Yellow);
            papel.FillEllipse(Relleno3, 175, 175, 50, 50);
            papel.FillEllipse(Relleno3, 185, 185, 30, 30);

            //Crea Los Bordes del circulo
            Pen lapiz1 = new Pen(Color.White);
            papel.DrawEllipse(lapiz1, 100, 100, 200, 200);
            papel.DrawEllipse(lapiz1, 113, 113, 173, 173);
            Pen lapiz2 = new Pen(Color.Black);
            papel.DrawEllipse(lapiz2, 123, 123, 153, 153);
            papel.DrawEllipse(lapiz2, 135, 135, 130, 130);
            papel.DrawEllipse(lapiz2, 150, 150, 100, 100);
            papel.DrawEllipse(lapiz2, 163, 163, 73, 73);
            papel.DrawEllipse(lapiz2, 175, 175, 50, 50);
            papel.DrawEllipse(lapiz2, 185, 185, 30, 30);

            //Habilita los botones  Borrar y Cambiar Color
            btnCambiarColor.Enabled = true;
            btnBorrar.Enabled = true;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            //Limpia el picturebox
            papel.Clear(Color.White);
            //Deshabilita los botones  Borrar y Cambiar Color
            btnCambiarColor.Enabled = false;
            btnBorrar.Enabled = false;
            //Habilita los botones Borrar y Cambiar Color
            btnDibujarDiana.Enabled = true;
        }

        private void btnCambiarColor_Click(object sender, EventArgs e)
        {
            //Rellena los circulos
            MessageBox.Show("Agrega el primer color", "Seleccion de Colores");
            //Muestra la venta de dialogo de colores
            colorDialog1.ShowDialog();
            SolidBrush Relleno = new SolidBrush(colorDialog1.Color);
            papel.FillEllipse(Relleno, 100, 100, 200, 200);
            papel.FillEllipse(Relleno, 113, 113, 173, 173);
            //Remarca el borde
            Pen lapiz1 = new Pen(Color.White);
            papel.DrawEllipse(lapiz1, 100, 100, 200, 200);
            papel.DrawEllipse(lapiz1, 113, 113, 173, 173);
            //Rellena Circulos
            MessageBox.Show("Agrega el Segundo color", "Seleccion de Colores");
            //Muestra la venta de dialogo de colores
            colorDialog1.ShowDialog();
            SolidBrush Relleno1 = new SolidBrush(colorDialog1.Color);
            papel.FillEllipse(Relleno1, 123, 123, 153, 153);
            papel.FillEllipse(Relleno1, 135, 135, 130, 130);
            //Remarca Borde
            Pen lapiz2 = new Pen(Color.Black);
            papel.DrawEllipse(lapiz2, 123, 123, 153, 153);
            papel.DrawEllipse(lapiz2, 135, 135, 130, 130);
            //Rellena Circulos
            MessageBox.Show("Agrega el tercer color", "Seleccion de Colores");
            //Muestra la venta de dialogo de colores
            colorDialog1.ShowDialog();
            SolidBrush Relleno2 = new SolidBrush(colorDialog1.Color);
            papel.FillEllipse(Relleno2, 150, 150, 100, 100);
            papel.FillEllipse(Relleno2, 163, 163, 73, 73);
            //Remarca Borde
            papel.DrawEllipse(lapiz2, 150, 150, 100, 100);
            papel.DrawEllipse(lapiz2, 163, 163, 73, 73);
            //Rellena Circulos
            MessageBox.Show("Agrega el Cuarto color", "Seleccion de Colores");
            //Muestra la venta de dialogo de colores
            colorDialog1.ShowDialog();
            SolidBrush Relleno3 = new SolidBrush(colorDialog1.Color);
            papel.FillEllipse(Relleno3, 175, 175, 50, 50);
            papel.FillEllipse(Relleno3, 185, 185, 30, 30);
            //Remarca Borde
            papel.DrawEllipse(lapiz2, 175, 175, 50, 50);
            papel.DrawEllipse(lapiz2, 185, 185, 30, 30);
            //Deshabilita el boton Dibujar Diana
            btnDibujarDiana.Enabled = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Cierra el formulario 
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            //Deshabilita los botones Cambiar Color y Borrar
            btnCambiarColor.Enabled = false;
            btnBorrar.Enabled = false;
        }
    }
}
