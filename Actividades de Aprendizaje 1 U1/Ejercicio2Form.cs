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
    public partial class Ejercicio2Form : Form
    {
        //Declaracion
        public Graphics papel, papel1;

        public Ejercicio2Form()
        {
            InitializeComponent();
            //Inicializar mi grafico
            papel = picFiguras.CreateGraphics();
            papel1 = picImagen.CreateGraphics();
            //Deshabilita el boton Borrar
            btnBorrar.Enabled = false;

        }



        private void btnDibujar_Click_1(object sender, EventArgs e)
        {
            //Habilita boton Borrar
            btnBorrar.Enabled = true;

            //Seleccion de la figura a mostrar
            if (cboSeleccionarFigura.SelectedItem.ToString() == "Rectangulo con diagonal.")
            {
                //Seleccion de la posicion
                if (cboPosicion.SelectedItem.ToString() == "1")
                {
                    //Muestra la venta de dialogo de colores
                    colorDialog1.ShowDialog();
                    //Inicializamos la pluma
                    Pen lapiz = new Pen(colorDialog1.Color);

                    papel.DrawRectangle(lapiz, 10, 15, 100, 50);
                    papel.DrawLine(lapiz, 10, 15, 113, 65);
                    //Elimina un elemento del ComboBox
                    cboPosicion.Items.Remove("1");
                }
                else
                {
                    //Seleccion de la posicion
                    if (cboPosicion.SelectedItem.ToString() == "2")
                    {
                        //Muestra la venta de dialogo de colores
                        colorDialog1.ShowDialog();
                        //Inicializamos la pluma
                        Pen lapiz = new Pen(colorDialog1.Color);

                        papel.DrawRectangle(lapiz, 10, 80, 100, 50);
                        papel.DrawLine(lapiz, 10, 80, 110, 130);
                        //Elimina un elemento del ComboBox
                        cboPosicion.Items.Remove("2");
                    }
                    else
                    {
                        //Seleccion de la posicion
                        if (cboPosicion.SelectedItem.ToString() == "3")
                        {
                            //Muestra la venta de dialogo de colores
                            colorDialog1.ShowDialog();
                            //Inicializamos la pluma
                            Pen lapiz = new Pen(colorDialog1.Color);

                            papel.DrawRectangle(lapiz, 10, 150, 100, 50);
                            papel.DrawLine(lapiz, 10, 150, 110, 199);
                            //Elimina un elemento del ComboBox
                            cboPosicion.Items.Remove("3");
                        }
                    }
                }
            }
            else
            {
                //Seleccion de la figura a mostrar
                if (cboSeleccionarFigura.SelectedItem.ToString() == "Rectangulo con elipse.")
                {
                    //Seleccion de la posicion
                    if (cboPosicion.SelectedItem.ToString() == "1")
                    {
                        //Muestra la venta de dialogo de colores
                        colorDialog1.ShowDialog();
                        //Inicializamos la pluma
                        Pen lapiz = new Pen(colorDialog1.Color);

                        papel.DrawRectangle(lapiz, 10, 15, 100, 50);
                        papel.DrawEllipse(lapiz, 10, 15, 100, 50);
                        //Elimina un elemento del ComboBox
                        cboPosicion.Items.Remove("1");
                    }
                    else
                    {
                        //Seleccion de la posicion
                        if (cboPosicion.SelectedItem.ToString() == "2")
                        {
                            //Muestra la venta de dialogo de colores
                            colorDialog1.ShowDialog();
                            //Inicializamos la pluma
                            Pen lapiz = new Pen(colorDialog1.Color);

                            papel.DrawRectangle(lapiz, 10, 80, 100, 50);
                            papel.DrawEllipse(lapiz, 10, 80, 100, 50);
                            //Elimina un elemento del ComboBox
                            cboPosicion.Items.Remove("2");
                        }
                        else
                        {
                            //Seleccion de la posicion
                            if (cboPosicion.SelectedItem.ToString() == "3")
                            {
                                //Muestra la venta de dialogo de colores
                                colorDialog1.ShowDialog();
                                //Inicializamos la pluma
                                Pen lapiz = new Pen(colorDialog1.Color);

                                papel.DrawRectangle(lapiz, 10, 150, 100, 50);
                                papel.DrawEllipse(lapiz, 10, 150, 100, 50);
                                //Elimina un elemento del ComboBox
                                cboPosicion.Items.Remove("3");
                            }
                        }
                    }
                }
                else
                {
                    //Seleccion de la figura a mostrar
                    if (cboSeleccionarFigura.SelectedItem.ToString() == "Elipse.")
                    {
                        //Seleccion de la posicion
                        if (cboPosicion.SelectedItem.ToString() == "1")
                        {
                            //Muestra la venta de dialogo de colores
                            colorDialog1.ShowDialog();
                            //rellena la figura de un color
                            SolidBrush pincelRelleno = new SolidBrush(colorDialog1.Color);

                            papel.FillEllipse(pincelRelleno, 10, 15, 100, 50);
                            //Elimina un elemento del ComboBox
                            cboPosicion.Items.Remove("1");
                        }
                        else
                        {
                            //Seleccion de la posicion
                            if (cboPosicion.SelectedItem.ToString() == "2")
                            {
                                //Muestra la venta de dialogo de colores
                                colorDialog1.ShowDialog();
                                //rellena la figura de un color
                                SolidBrush pincelRelleno = new SolidBrush(colorDialog1.Color);

                                papel.FillEllipse(pincelRelleno, 10, 80, 100, 50);
                                //Elimina un elemento del ComboBox
                                cboPosicion.Items.Remove("2");
                            }
                            else
                            {
                                //Seleccion de la posicion
                                if (cboPosicion.SelectedItem.ToString() == "3")
                                {
                                    //Muestra la venta de dialogo de colores
                                    colorDialog1.ShowDialog();
                                    //rellena la figura de un color
                                    SolidBrush pincelRelleno = new SolidBrush(colorDialog1.Color);

                                    papel.FillEllipse(pincelRelleno, 10, 150, 100, 50);
                                    //Elimina un elemento del ComboBox
                                    cboPosicion.Items.Remove("3");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            //Cierra el Formulario
            this.Close();
        }

        private void btnBorrar_Click_1(object sender, EventArgs e)
        {
            //Limpia el picturebox
            papel.Clear(Color.White);
            //Añade elementos al ComboBox
            cboPosicion.Items.Add("1");
            cboPosicion.Items.Add("2");
            cboPosicion.Items.Add("3");
        }

        private void btnImportarImagen_Click_1(object sender, EventArgs e)
        {
            //Abre el Explorador de Archivos
            OpenFileDialog dlg = new OpenFileDialog();

            //Verifica si se selecciona el archivo
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                //Declara variable para Mapa de Bits y guarda la imagen
                Bitmap imagen = new Bitmap(dlg.FileName);
                //Muestra Imagen en el pictureBox
                papel1.DrawImage(imagen, 0, 0, 285, 257);
            }
        }
    }
}
