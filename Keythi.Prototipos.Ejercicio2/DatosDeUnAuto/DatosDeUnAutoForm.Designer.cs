namespace Keythi.Prototipos.Ejercicio2.DatosDeUnAuto
{
    partial class DatosDeUnAutoForm
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
            button1 = new Button();
            TxtModelo = new TextBox();
            TxtAño = new TextBox();
            TxtPrecio = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            TxtFechaHoy = new Label();
            ComboMarca = new ComboBox();
            labelName = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(563, 160);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TxtModelo
            // 
            TxtModelo.Location = new Point(192, 100);
            TxtModelo.Name = "TxtModelo";
            TxtModelo.Size = new Size(125, 27);
            TxtModelo.TabIndex = 2;
            // 
            // TxtAño
            // 
            TxtAño.Location = new Point(336, 100);
            TxtAño.Name = "TxtAño";
            TxtAño.Size = new Size(125, 27);
            TxtAño.TabIndex = 3;
            TxtAño.TextChanged += TxtAño_TextChanged;
            // 
            // TxtPrecio
            // 
            TxtPrecio.Location = new Point(481, 100);
            TxtPrecio.Name = "TxtPrecio";
            TxtPrecio.Size = new Size(125, 27);
            TxtPrecio.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 17);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 5;
            label1.Text = "Nombre de usuario:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 7;
            label2.Text = "Marca";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(192, 77);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 8;
            label3.Text = "Modelo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(336, 77);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 9;
            label4.Text = "Año";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(481, 77);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 10;
            label5.Text = "Precio";
            // 
            // TxtFechaHoy
            // 
            TxtFechaHoy.AutoSize = true;
            TxtFechaHoy.Location = new Point(563, 10);
            TxtFechaHoy.Name = "TxtFechaHoy";
            TxtFechaHoy.Size = new Size(45, 20);
            TxtFechaHoy.TabIndex = 11;
            TxtFechaHoy.Text = "lalala";
            TxtFechaHoy.Click += TxtFechaHoy_Click;
            // 
            // ComboMarca
            // 
            ComboMarca.FormattingEnabled = true;
            ComboMarca.Items.AddRange(new object[] { "Ford", "Fiat", "Chevrolet", "Audi" });
            ComboMarca.Location = new Point(21, 100);
            ComboMarca.Name = "ComboMarca";
            ComboMarca.Size = new Size(151, 28);
            ComboMarca.TabIndex = 12;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(158, 17);
            labelName.Name = "labelName";
            labelName.Size = new Size(53, 20);
            labelName.TabIndex = 13;
            labelName.Text = "lalala2";
            labelName.Click += label6_Click;
            // 
            // DatosDeUnAutoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 216);
            Controls.Add(labelName);
            Controls.Add(ComboMarca);
            Controls.Add(TxtFechaHoy);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtPrecio);
            Controls.Add(TxtAño);
            Controls.Add(TxtModelo);
            Controls.Add(button1);
            Name = "DatosDeUnAutoForm";
            Text = "DatosDeUnAutoForm";
            Load += DatosDeUnAutoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox TxtModelo;
        private TextBox TxtAño;
        private TextBox TxtPrecio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label TxtFechaHoy;
        private ComboBox ComboMarca;
        private Label labelName;
    }
}