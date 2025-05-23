namespace Calculadora_IMC
{
    partial class FrmInicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DgvCalculo = new DataGridView();
            LblNuevo = new Label();
            BtnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvCalculo).BeginInit();
            SuspendLayout();
            // 
            // DgvCalculo
            // 
            DgvCalculo.BackgroundColor = Color.MistyRose;
            DgvCalculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCalculo.Location = new Point(225, 23);
            DgvCalculo.Name = "DgvCalculo";
            DgvCalculo.Size = new Size(240, 150);
            DgvCalculo.TabIndex = 0;
            // 
            // LblNuevo
            // 
            LblNuevo.AutoSize = true;
            LblNuevo.Location = new Point(302, 217);
            LblNuevo.Name = "LblNuevo";
            LblNuevo.Size = new Size(85, 15);
            LblNuevo.TabIndex = 1;
            LblNuevo.Text = "Nuevo Calculo";
            // 
            // BtnCalcular
            // 
            BtnCalcular.Location = new Point(236, 251);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(215, 47);
            BtnCalcular.TabIndex = 2;
            BtnCalcular.Text = "CALCULAR";
            BtnCalcular.UseVisualStyleBackColor = true;
            BtnCalcular.Click += btn1_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(691, 386);
            Controls.Add(BtnCalcular);
            Controls.Add(LblNuevo);
            Controls.Add(DgvCalculo);
            Name = "FrmInicio";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvCalculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DgvCalculo;
        private Label LblNuevo;
        private Button BtnCalcular;
    }
}
