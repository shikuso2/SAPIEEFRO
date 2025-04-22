namespace SAPIEEFRO2
{
    partial class Ajustes
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
            this.Num_Seg = new System.Windows.Forms.NumericUpDown();
            this.Num_Min = new System.Windows.Forms.NumericUpDown();
            this.Num_Hora = new System.Windows.Forms.NumericUpDown();
            this.Btn_Agregar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Lbx_Horas = new System.Windows.Forms.ListBox();
            this.Cb_Sonidos = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Btn_color = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Icon = Properties.Resources.Sin1;
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Seg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Hora)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Num_Seg);
            this.groupBox1.Controls.Add(this.Num_Min);
            this.groupBox1.Controls.Add(this.Num_Hora);
            this.groupBox1.Controls.Add(this.Btn_Agregar);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Lbx_Horas);
            this.groupBox1.Location = new System.Drawing.Point(13, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horas";
            // 
            // Num_Seg
            // 
            this.Num_Seg.Location = new System.Drawing.Point(227, 19);
            this.Num_Seg.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_Seg.Name = "Num_Seg";
            this.Num_Seg.Size = new System.Drawing.Size(34, 20);
            this.Num_Seg.TabIndex = 6;
            // 
            // Num_Min
            // 
            this.Num_Min.Location = new System.Drawing.Point(186, 19);
            this.Num_Min.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.Num_Min.Name = "Num_Min";
            this.Num_Min.Size = new System.Drawing.Size(32, 20);
            this.Num_Min.TabIndex = 5;
            // 
            // Num_Hora
            // 
            this.Num_Hora.Location = new System.Drawing.Point(142, 19);
            this.Num_Hora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.Num_Hora.Name = "Num_Hora";
            this.Num_Hora.Size = new System.Drawing.Size(35, 20);
            this.Num_Hora.TabIndex = 4;
            // 
            // Btn_Agregar
            // 
            this.Btn_Agregar.Location = new System.Drawing.Point(142, 45);
            this.Btn_Agregar.Name = "Btn_Agregar";
            this.Btn_Agregar.Size = new System.Drawing.Size(119, 23);
            this.Btn_Agregar.TabIndex = 2;
            this.Btn_Agregar.Text = "AGREGAR";
            this.Btn_Agregar.UseVisualStyleBackColor = true;
            this.Btn_Agregar.Click += new System.EventHandler(this.Btn_Agregar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(142, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "ELIMINAR";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Lbx_Horas
            // 
            this.Lbx_Horas.FormattingEnabled = true;
            this.Lbx_Horas.Location = new System.Drawing.Point(12, 19);
            this.Lbx_Horas.Name = "Lbx_Horas";
            this.Lbx_Horas.Size = new System.Drawing.Size(124, 95);
            this.Lbx_Horas.TabIndex = 0;
            // 
            // Cb_Sonidos
            // 
            this.Cb_Sonidos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Cb_Sonidos.FormattingEnabled = true;
            this.Cb_Sonidos.Location = new System.Drawing.Point(12, 25);
            this.Cb_Sonidos.Name = "Cb_Sonidos";
            this.Cb_Sonidos.Size = new System.Drawing.Size(179, 21);
            this.Cb_Sonidos.TabIndex = 1;
            this.Cb_Sonidos.SelectedValueChanged += new System.EventHandler(this.Cb_Sonidos_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sonido:";
            // 
            // Btn_color
            // 
            this.Btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_color.Location = new System.Drawing.Point(234, 25);
            this.Btn_color.Name = "Btn_color";
            this.Btn_color.Size = new System.Drawing.Size(53, 21);
            this.Btn_color.TabIndex = 3;
            this.Btn_color.UseVisualStyleBackColor = true;
            this.Btn_color.Click += new System.EventHandler(this.Btn_color_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Color:";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(192, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "+";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Ajustes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 198);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_color);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cb_Sonidos);
            this.Controls.Add(this.groupBox1);
            this.Name = "Ajustes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ajustes";
            this.Load += new System.EventHandler(this.Ajustes_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Seg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Hora)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox Cb_Sonidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button Btn_color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox Lbx_Horas;
        private System.Windows.Forms.Button Btn_Agregar;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.NumericUpDown Num_Seg;
        internal System.Windows.Forms.NumericUpDown Num_Min;
        internal System.Windows.Forms.NumericUpDown Num_Hora;
    }
}