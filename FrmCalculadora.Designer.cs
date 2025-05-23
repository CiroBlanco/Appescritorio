namespace Calculadora_IMC
{
    partial class Form2
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
            SuspendLayout();
            // 
            // LblAltura
            // 
            LblAltura.AutoSize = true;
            LblAltura.Location = new Point(313, 126);
            LblAltura.Name = "LblAltura";
            LblAltura.Size = new Size(39, 15);
            LblAltura.TabIndex = 0;
            LblAltura.Text = "Altura";
            // 
            // LblPeso
            // 
            LblPeso.AutoSize = true;
            LblPeso.Location = new Point(313, 179);
            LblPeso.Name = "LblPeso";
            LblPeso.Size = new Size(32, 15);
            LblPeso.TabIndex = 1;
            LblPeso.Text = "Peso";
            // 
            // TxtAltura
            // 
            TxtAltura.Location = new Point(361, 123);
            TxtAltura.Name = "TxtAltura";
            TxtAltura.Size = new Size(100, 23);
            TxtAltura.TabIndex = 2;
            // 
            // TxtPeso
            // 
            TxtPeso.Location = new Point(361, 176);
            TxtPeso.Name = "TxtPeso";
            TxtPeso.Size = new Size(100, 23);
            TxtPeso.TabIndex = 3;
            // 
            // BtnResultado
            // 
            BtnResultado.Location = new Point(313, 232);
            BtnResultado.Name = "BtnResultado";
            BtnResultado.Size = new Size(169, 62);
            BtnResultado.TabIndex = 4;
            BtnResultado.Text = "CALCULAR";
            BtnResultado.UseVisualStyleBackColor = true;
            // 
            // LblResultado
            // 
            LblResultado.AutoSize = true;
            LblResultado.Location = new Point(377, 329);
            LblResultado.Name = "LblResultado";
            LblResultado.Size = new Size(16, 15);
            LblResultado.TabIndex = 5;
            LblResultado.Text = "...";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(LblResultado);
            Controls.Add(BtnResultado);
            Controls.Add(TxtPeso);
            Controls.Add(TxtAltura);
            Controls.Add(LblPeso);
            Controls.Add(LblAltura);
            Name = "Form2";
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
    }
}