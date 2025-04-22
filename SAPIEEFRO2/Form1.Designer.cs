namespace SAPIEEFRO2
{
    partial class Form1
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_min = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_detener = new System.Windows.Forms.Button();
            this.Lbl_Time = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Timer_tik = new System.Windows.Forms.Timer(this.components);
            this.Btn_suspender = new System.Windows.Forms.Button();
            this.Btn_config = new System.Windows.Forms.Button();
            this.Btn_alerta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Icon = Properties.Resources.Sin1;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.Red;
            this.btn_close.Location = new System.Drawing.Point(442, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 23);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = "X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_min
            // 
            this.btn_min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_min.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btn_min.FlatAppearance.BorderSize = 0;
            this.btn_min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_min.ForeColor = System.Drawing.Color.Red;
            this.btn_min.Location = new System.Drawing.Point(415, -1);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(25, 23);
            this.btn_min.TabIndex = 1;
            this.btn_min.Text = "_";
            this.btn_min.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Btn_detener);
            this.panel1.Controls.Add(this.Lbl_Time);
            this.panel1.Location = new System.Drawing.Point(182, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 94);
            this.panel1.TabIndex = 2;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Btn_detener
            // 
            this.Btn_detener.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Btn_detener.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_detener.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_detener.Location = new System.Drawing.Point(228, -1);
            this.Btn_detener.Name = "Btn_detener";
            this.Btn_detener.Size = new System.Drawing.Size(50, 94);
            this.Btn_detener.TabIndex = 4;
            this.Btn_detener.Text = "■";
            this.Btn_detener.UseVisualStyleBackColor = false;
            this.Btn_detener.Visible = false;
            this.Btn_detener.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbl_Time
            // 
            this.Lbl_Time.Font = new System.Drawing.Font("Arial Narrow", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Time.Location = new System.Drawing.Point(3, 18);
            this.Lbl_Time.Name = "Lbl_Time";
            this.Lbl_Time.Size = new System.Drawing.Size(271, 57);
            this.Lbl_Time.TabIndex = 3;
            this.Lbl_Time.Text = "TIME";
            this.Lbl_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Time.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SAPIEEFRO2.Properties.Resources.escudo;
            this.pictureBox1.Location = new System.Drawing.Point(15, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(13, 1);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(157, 54);
            this.Label1.TabIndex = 10;
            this.Label1.Text = "ESTHER FESTINI DE\r\nRAMOS OCAMPO";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(182, 47);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(279, 20);
            this.Lbl_fecha.TabIndex = 11;
            this.Lbl_fecha.Text = "Fecha";
            this.Lbl_fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_fecha.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            // 
            // Timer_tik
            // 
            this.Timer_tik.Enabled = true;
            this.Timer_tik.Interval = 1000;
            this.Timer_tik.Tick += new System.EventHandler(this.Timer_tik_Tick);
            // 
            // Btn_suspender
            // 
            this.Btn_suspender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_suspender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_suspender.Location = new System.Drawing.Point(376, 190);
            this.Btn_suspender.Name = "Btn_suspender";
            this.Btn_suspender.Size = new System.Drawing.Size(85, 33);
            this.Btn_suspender.TabIndex = 12;
            this.Btn_suspender.Text = "SUSPENDER";
            this.Btn_suspender.UseVisualStyleBackColor = true;
            this.Btn_suspender.Click += new System.EventHandler(this.Btn_suspender_Click);
            // 
            // Btn_config
            // 
            this.Btn_config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_config.Location = new System.Drawing.Point(182, 190);
            this.Btn_config.Name = "Btn_config";
            this.Btn_config.Size = new System.Drawing.Size(95, 33);
            this.Btn_config.TabIndex = 13;
            this.Btn_config.Text = "CONFIGURAR";
            this.Btn_config.UseVisualStyleBackColor = true;
            this.Btn_config.Click += new System.EventHandler(this.Btn_config_Click);
            // 
            // Btn_alerta
            // 
            this.Btn_alerta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_alerta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_alerta.Location = new System.Drawing.Point(284, 190);
            this.Btn_alerta.Name = "Btn_alerta";
            this.Btn_alerta.Size = new System.Drawing.Size(85, 33);
            this.Btn_alerta.TabIndex = 14;
            this.Btn_alerta.Text = "ALERTA!";
            this.Btn_alerta.UseVisualStyleBackColor = true;
            this.Btn_alerta.Click += new System.EventHandler(this.Sonar);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(473, 239);
            this.Controls.Add(this.Btn_alerta);
            this.Controls.Add(this.Btn_config);
            this.Controls.Add(this.Btn_suspender);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SAPIEEFRO2";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Lbl_Time;
        internal System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.Timer Timer_tik;
        private System.Windows.Forms.Button Btn_suspender;
        private System.Windows.Forms.Button Btn_config;
        private System.Windows.Forms.Button Btn_alerta;
        private System.Windows.Forms.Button Btn_detener;
    }
}

