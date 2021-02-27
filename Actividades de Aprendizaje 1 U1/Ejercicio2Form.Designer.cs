
namespace Actividades_de_Aprendizaje_1_U1
{
    partial class Ejercicio2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnImportarImagen = new System.Windows.Forms.Button();
            this.picImagen = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.cboSeleccionarFigura = new System.Windows.Forms.ComboBox();
            this.cboPosicion = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDibujar = new System.Windows.Forms.Button();
            this.picFiguras = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFiguras)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(737, 368);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejercicio 2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnImportarImagen);
            this.groupBox3.Controls.Add(this.picImagen);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(404, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(314, 320);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Visualizar  imagen";
            // 
            // btnImportarImagen
            // 
            this.btnImportarImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnImportarImagen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportarImagen.ForeColor = System.Drawing.Color.White;
            this.btnImportarImagen.Location = new System.Drawing.Point(86, 282);
            this.btnImportarImagen.Name = "btnImportarImagen";
            this.btnImportarImagen.Size = new System.Drawing.Size(157, 23);
            this.btnImportarImagen.TabIndex = 18;
            this.btnImportarImagen.Text = "Importar imagen";
            this.btnImportarImagen.UseVisualStyleBackColor = false;
            this.btnImportarImagen.Click += new System.EventHandler(this.btnImportarImagen_Click_1);
            // 
            // picImagen
            // 
            this.picImagen.BackColor = System.Drawing.Color.White;
            this.picImagen.Location = new System.Drawing.Point(15, 19);
            this.picImagen.Name = "picImagen";
            this.picImagen.Size = new System.Drawing.Size(285, 257);
            this.picImagen.TabIndex = 17;
            this.picImagen.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.picFiguras);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(23, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(375, 284);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dibuja la figura";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnBorrar);
            this.groupBox4.Controls.Add(this.cboSeleccionarFigura);
            this.groupBox4.Controls.Add(this.cboPosicion);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnDibujar);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(19, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(191, 239);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Dibujar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Figuras";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Location = new System.Drawing.Point(20, 188);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(149, 26);
            this.btnBorrar.TabIndex = 13;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // cboSeleccionarFigura
            // 
            this.cboSeleccionarFigura.AutoCompleteCustomSource.AddRange(new string[] {
            "Rectangulo Dividido",
            "Rectangulo con elipse",
            "Elipse"});
            this.cboSeleccionarFigura.FormattingEnabled = true;
            this.cboSeleccionarFigura.Items.AddRange(new object[] {
            "Rectangulo con diagonal.",
            "Rectangulo con elipse.",
            "Elipse."});
            this.cboSeleccionarFigura.Location = new System.Drawing.Point(19, 50);
            this.cboSeleccionarFigura.Name = "cboSeleccionarFigura";
            this.cboSeleccionarFigura.Size = new System.Drawing.Size(150, 21);
            this.cboSeleccionarFigura.TabIndex = 14;
            this.cboSeleccionarFigura.Text = "Rectangulo con diagonal.";
            // 
            // cboPosicion
            // 
            this.cboPosicion.FormattingEnabled = true;
            this.cboPosicion.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cboPosicion.Location = new System.Drawing.Point(19, 102);
            this.cboPosicion.Name = "cboPosicion";
            this.cboPosicion.Size = new System.Drawing.Size(150, 21);
            this.cboPosicion.TabIndex = 17;
            this.cboPosicion.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Posición";
            // 
            // btnDibujar
            // 
            this.btnDibujar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnDibujar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDibujar.ForeColor = System.Drawing.Color.White;
            this.btnDibujar.Location = new System.Drawing.Point(20, 145);
            this.btnDibujar.Name = "btnDibujar";
            this.btnDibujar.Size = new System.Drawing.Size(149, 25);
            this.btnDibujar.TabIndex = 11;
            this.btnDibujar.Text = "Dibujar ";
            this.btnDibujar.UseVisualStyleBackColor = false;
            this.btnDibujar.Click += new System.EventHandler(this.btnDibujar_Click_1);
            // 
            // picFiguras
            // 
            this.picFiguras.BackColor = System.Drawing.Color.White;
            this.picFiguras.Location = new System.Drawing.Point(225, 36);
            this.picFiguras.Name = "picFiguras";
            this.picFiguras.Size = new System.Drawing.Size(125, 224);
            this.picFiguras.TabIndex = 1;
            this.picFiguras.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(688, 9);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 24);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // Ejercicio2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(766, 396);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejercicio2Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio2Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picImagen)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFiguras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnImportarImagen;
        private System.Windows.Forms.PictureBox picImagen;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.ComboBox cboSeleccionarFigura;
        private System.Windows.Forms.ComboBox cboPosicion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDibujar;
        private System.Windows.Forms.PictureBox picFiguras;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}