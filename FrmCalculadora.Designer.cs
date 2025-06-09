namespace Calculadora_IMC
{
    partial class FrmCalculadora
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
            LblAltura = new Label();
            LblPeso = new Label();
            TxtAltura = new TextBox();
            TxtPeso = new TextBox();
            BtnResultado = new Button();
            LblResultado = new Label();
            LblTitulo = new Label();
            SuspendLayout();
            // 
            // LblAltura
            // 
            LblAltura.AutoSize = true;
            LblAltura.Location = new Point(278, 126);
            LblAltura.Name = "LblAltura";
            LblAltura.Size = new Size(67, 15);
            LblAltura.TabIndex = 0;
            LblAltura.Text = "Altura(mts)";
            // 
            // LblPeso
            // 
            LblPeso.AutoSize = true;
            LblPeso.Location = new Point(278, 179);
            LblPeso.Name = "LblPeso";
            LblPeso.Size = new Size(53, 15);
            LblPeso.TabIndex = 1;
            LblPeso.Text = "Peso(kg)";
            // 
            // TxtAltura
            // 
            TxtAltura.Location = new Point(362, 126);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(100, 23);
            TxtAltura.TabIndex = 2;
            // 
            // TxtPeso
            // 
            TxtPeso.Location = new Point(362, 171);
            TxtPeso.Name = "TxtPeso";
            TxtPeso.Size = new Size(100, 23);
            TxtPeso.TabIndex = 3;
            // 
            // BtnResultado
            // 
            BtnResultado.Location = new Point(313, 229);
            BtnResultado.Name = "BtnResultado";
            BtnResultado.Size = new Size(169, 62);
            BtnResultado.TabIndex = 4;
            BtnResultado.Text = "CALCULAR";
            BtnResultado.UseVisualStyleBackColor = true;
            BtnResultado.Click += BtnResultado_Click;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(376, 315);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(16, 15);
            LblResultado.TabIndex = 5;
            LblResultado.Text = "...";
            // 
            // LblTitulo
            // 
            LblTitulo.AutoSize = true;
            LblTitulo.Font = new Font("Impact", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LblTitulo.Location = new Point(266, 38);
            LblTitulo.Name = "LblTitulo";
            LblTitulo.Size = new Size(267, 39);
            LblTitulo.TabIndex = 6;
            LblTitulo.Text = "CALCULADORA IMC";
            // 
            // FrmCalculadora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(TxtPeso);
            Controls.Add(TxtAltura);
            Controls.Add(LblTitulo);
            Controls.Add(LblResultado);
            Controls.Add(BtnResultado);
            Controls.Add(LblPeso);
            Controls.Add(LblAltura);
            Name = "FrmCalculadora";
            Text = "Form2";
            TransparencyKey = Color.White;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAltura;
        private Label LblPeso;
        private TextBox TxtAltura;
        private TextBox TxtPeso;
        private Button BtnResultado;
        private Label LblResultado;
        private Label LblTitulo;
    }
}