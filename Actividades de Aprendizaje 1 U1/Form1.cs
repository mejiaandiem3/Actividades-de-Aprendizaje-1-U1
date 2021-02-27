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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            //Cierra la Aplicacion
            Application.Exit();
        }

        private void btnEjercicio1_Click_1(object sender, EventArgs e)
        {
            //Abre un nuevo formulario
            Form Formulario1 = new Ejercicio1Form();
            Formulario1.Show();
            //Instrucciones de como se usa el programa
            MessageBox.Show("Puedes dibujar la figura de dos formas.", "Instrucciónes:");
            MessageBox.Show("Utiliza el boton dibujar para crear la primera figura, para después poder aplicar relleno.", "Instrucciónes:");
            MessageBox.Show("La segunda forma son las barras no contiene opcion de relleno.", "Instrucciónes:");
        }

        private void btnEjercicio2_Click_1(object sender, EventArgs e)
        {  //Abre un nuevo formulario
            Form Formulario1 = new Ejercicio2Form();
            Formulario1.Show();
            //Instrucciones de como se usa el programa
            MessageBox.Show("Encontraras dos apartados primer apartado DIBUJA LA FIGURA y el segundo apartado VISUALIZAR IMAGEN, en el cual puedes hacer lo siguiente:", "Instrucciónes:");
            MessageBox.Show("En el apartado DIBUJA LA FIGURA podras crear figuras seleccionando la FIGURA y la POSICION en la cual estara.", "Instrucciónes:");
            MessageBox.Show("En el apartado de VISUALIZAR IMAGEN podra cargar la imagen que uted desde el EXPLORADOR DE ARCHIVOS.", "Instrucciónes:");
        }

        private void btnEjercicio3_Click(object sender, EventArgs e)
        {
            //Abre un nuevo formulario
            Form Formulario1 = new Ejercicio3Form();
            Formulario1.Show();
            //Instrucciones de como se usa el programa
            MessageBox.Show("Dibuja la diana con el boton DIBUJAR DIANA.", "Instrucciónes:");
            MessageBox.Show("Una vez dibujada la diana, podra utilizar los botones BORRAR y CAMBIAR COLOR.", "Instrucciónes:");
            MessageBox.Show("Una vez que usted cambio el color y quiere cambiar a la DIANA ORIGINAL, debera Borrar la diana para poder volver activar el boton DIBUJAR DIANA.", "Instrucciónes:");


        }

        private void lblCreditos_Click(object sender, EventArgs e)
        {
            //Abre un nuevo formulario
            Form Formulario1 = new Creditos();
            Formulario1.Show();
            //Mensaje de derechos de autor
            MessageBox.Show("Gracias Por Utilizar Nuestro Programa.", "Copyright Oficial ©:");

        }


    }
}

