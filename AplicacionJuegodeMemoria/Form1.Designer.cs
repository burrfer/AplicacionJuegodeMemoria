namespace AplicacionJuegodeMemoria
{
    partial class frm_inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_inicio));
            this.PanelJuego = new System.Windows.Forms.Panel();
            this.btn_Reiniciar = new System.Windows.Forms.Button();
            this.lbl_Movimientos = new System.Windows.Forms.Label();
            this.lbl_Record = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelJuego
            // 
            this.PanelJuego.Location = new System.Drawing.Point(52, 31);
            this.PanelJuego.Name = "PanelJuego";
            this.PanelJuego.Size = new System.Drawing.Size(476, 483);
            this.PanelJuego.TabIndex = 0;
            // 
            // btn_Reiniciar
            // 
            this.btn_Reiniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reiniciar.ForeColor = System.Drawing.Color.IndianRed;
            this.btn_Reiniciar.Location = new System.Drawing.Point(617, 160);
            this.btn_Reiniciar.Name = "btn_Reiniciar";
            this.btn_Reiniciar.Size = new System.Drawing.Size(113, 62);
            this.btn_Reiniciar.TabIndex = 1;
            this.btn_Reiniciar.Text = "Reinicio del juego";
            this.btn_Reiniciar.UseVisualStyleBackColor = true;
            this.btn_Reiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lbl_Movimientos
            // 
            this.lbl_Movimientos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Movimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movimientos.Location = new System.Drawing.Point(558, 31);
            this.lbl_Movimientos.Name = "lbl_Movimientos";
            this.lbl_Movimientos.Size = new System.Drawing.Size(123, 27);
            this.lbl_Movimientos.TabIndex = 2;
            this.lbl_Movimientos.Text = "Movimientos:";
            // 
            // lbl_Record
            // 
            this.lbl_Record.AutoEllipsis = true;
            this.lbl_Record.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Record.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Record.Location = new System.Drawing.Point(696, 31);
            this.lbl_Record.Name = "lbl_Record";
            this.lbl_Record.Size = new System.Drawing.Size(34, 27);
            this.lbl_Record.TabIndex = 3;
            this.lbl_Record.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(630, 418);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LawnGreen;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Permanent Marker", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 534);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(702, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "*TRABAJO PRÁCTICO FINAL REALIZADO PARA LA MATERIA PROGRAMACIÓN VISUAL AVANZADA (B" +
    "ritez, Pérez, Burrafato).";
            // 
            // frm_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 559);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Record);
            this.Controls.Add(this.lbl_Movimientos);
            this.Controls.Add(this.btn_Reiniciar);
            this.Controls.Add(this.PanelJuego);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frm_inicio";
            this.Text = "Juego de Memoria (*)";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelJuego;
        private System.Windows.Forms.Button btn_Reiniciar;
        private System.Windows.Forms.Label lbl_Movimientos;
        private System.Windows.Forms.Label lbl_Record;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

