
namespace Actividades_de_Aprendizaje_1_U1
{
    partial class Ejercicio1Form
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
            this.btnRelleno = new System.Windows.Forms.Button();
            this.lblHorizontal = new System.Windows.Forms.Label();
            this.lblVertical = new System.Windows.Forms.Label();
            this.TrackHor = new System.Windows.Forms.TrackBar();
            this.TracVer = new System.Windows.Forms.TrackBar();
            this.lblTV = new System.Windows.Forms.Label();
            this.lblTH = new System.Windows.Forms.Label();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.trackBarV = new System.Windows.Forms.TrackBar();
            this.trackBarH = new System.Windows.Forms.TrackBar();
            this.btnEjercicio1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackHor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TracVer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.groupBox1.Controls.Add(this.btnRelleno);
            this.groupBox1.Controls.Add(this.lblHorizontal);
            this.groupBox1.Controls.Add(this.lblVertical);
            this.groupBox1.Controls.Add(this.TrackHor);
            this.groupBox1.Controls.Add(this.TracVer);
            this.groupBox1.Controls.Add(this.lblTV);
            this.groupBox1.Controls.Add(this.lblTH);
            this.groupBox1.Controls.Add(this.btnBorrar);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.trackBarV);
            this.groupBox1.Controls.Add(this.trackBarH);
            this.groupBox1.Controls.Add(this.btnEjercicio1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(702, 360);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ejercicio 1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // btnRelleno
            // 
            this.btnRelleno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnRelleno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelleno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelleno.ForeColor = System.Drawing.Color.White;
            this.btnRelleno.Location = new System.Drawing.Point(500, 175);
            this.btnRelleno.Name = "btnRelleno";
            this.btnRelleno.Size = new System.Drawing.Size(141, 38);
            this.btnRelleno.TabIndex = 17;
            this.btnRelleno.Text = "Rellenar Figura";
            this.btnRelleno.UseVisualStyleBackColor = false;
            this.btnRelleno.Click += new System.EventHandler(this.btnRelleno_Click_1);
            // 
            // lblHorizontal
            // 
            this.lblHorizontal.AutoSize = true;
            this.lblHorizontal.Location = new System.Drawing.Point(301, 268);
            this.lblHorizontal.Name = "lblHorizontal";
            this.lblHorizontal.Size = new System.Drawing.Size(13, 13);
            this.lblHorizontal.TabIndex = 16;
            this.lblHorizontal.Text = "0";
            // 
            // lblVertical
            // 
            this.lblVertical.AutoSize = true;
            this.lblVertical.Location = new System.Drawing.Point(61, 132);
            this.lblVertical.Name = "lblVertical";
            this.lblVertical.Size = new System.Drawing.Size(13, 13);
            this.lblVertical.TabIndex = 15;
            this.lblVertical.Text = "0";
            // 
            // TrackHor
            // 
            this.TrackHor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.TrackHor.Location = new System.Drawing.Point(131, 236);
            this.TrackHor.Name = "TrackHor";
            this.TrackHor.Size = new System.Drawing.Size(348, 45);
            this.TrackHor.TabIndex = 14;
            this.TrackHor.Scroll += new System.EventHandler(this.TrackHor_Scroll_1);
            // 
            // TracVer
            // 
            this.TracVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.TracVer.Location = new System.Drawing.Point(80, 25);
            this.TracVer.Name = "TracVer";
            this.TracVer.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.TracVer.Size = new System.Drawing.Size(45, 205);
            this.TracVer.TabIndex = 13;
            this.TracVer.Scroll += new System.EventHandler(this.TracVer_Scroll_1);
            // 
            // lblTV
            // 
            this.lblTV.AutoSize = true;
            this.lblTV.Location = new System.Drawing.Point(10, 132);
            this.lblTV.Name = "lblTV";
            this.lblTV.Size = new System.Drawing.Size(13, 13);
            this.lblTV.TabIndex = 12;
            this.lblTV.Text = "0";
            // 
            // lblTH
            // 
            this.lblTH.AutoSize = true;
            this.lblTH.Location = new System.Drawing.Point(301, 319);
            this.lblTH.Name = "lblTH";
            this.lblTH.Size = new System.Drawing.Size(13, 13);
            this.lblTH.TabIndex = 11;
            this.lblTH.Text = "0";
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBorrar.Location = new System.Drawing.Point(500, 116);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(141, 38);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar Figura";
            this.btnBorrar.UseVisualStyleBackColor = false;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click_1);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(660, 11);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 24);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // trackBarV
            // 
            this.trackBarV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.trackBarV.Location = new System.Drawing.Point(29, 25);
            this.trackBarV.Name = "trackBarV";
            this.trackBarV.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBarV.Size = new System.Drawing.Size(45, 205);
            this.trackBarV.TabIndex = 8;
            this.trackBarV.Scroll += new System.EventHandler(this.trackBarV_Scroll_1);
            // 
            // trackBarH
            // 
            this.trackBarH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.trackBarH.Location = new System.Drawing.Point(131, 287);
            this.trackBarH.Name = "trackBarH";
            this.trackBarH.Size = new System.Drawing.Size(348, 45);
            this.trackBarH.TabIndex = 7;
            this.trackBarH.Scroll += new System.EventHandler(this.trackBarH_Scroll_1);
            // 
            // btnEjercicio1
            // 
            this.btnEjercicio1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.btnEjercicio1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjercicio1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEjercicio1.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEjercicio1.Location = new System.Drawing.Point(500, 57);
            this.btnEjercicio1.Name = "btnEjercicio1";
            this.btnEjercicio1.Size = new System.Drawing.Size(141, 38);
            this.btnEjercicio1.TabIndex = 6;
            this.btnEjercicio1.Text = "Dibujar Figura";
            this.btnEjercicio1.UseVisualStyleBackColor = false;
            this.btnEjercicio1.Click += new System.EventHandler(this.btnEjercicio1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(131, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(348, 205);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Ejercicio1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(48)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(728, 384);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ejercicio1Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio1Form";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackHor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TracVer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRelleno;
        private System.Windows.Forms.Label lblHorizontal;
        private System.Windows.Forms.Label lblVertical;
        private System.Windows.Forms.TrackBar TrackHor;
        private System.Windows.Forms.TrackBar TracVer;
        private System.Windows.Forms.Label lblTV;
        private System.Windows.Forms.Label lblTH;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TrackBar trackBarV;
        private System.Windows.Forms.TrackBar trackBarH;
        private System.Windows.Forms.Button btnEjercicio1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}