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
            BtnCalcular = new Button();
            ((System.ComponentModel.ISupportInitialize)DgvCalculo).BeginInit();
            SuspendLayout();
            // 
            // DgvCalculo
            // 
            DgvCalculo.BackgroundColor = Color.MistyRose;
            DgvCalculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DgvCalculo.Location = new Point(225, 37);
            DgvCalculo.Name = "DgvCalculo";
            DgvCalculo.Size = new Size(252, 184);
            DgvCalculo.TabIndex = 0;
            // 
            // BtnCalcular
            // 
            BtnCalcular.BackColor = Color.FromArgb(192, 255, 192);
            BtnCalcular.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnCalcular.Location = new Point(239, 276);
            BtnCalcular.Name = "BtnCalcular";
            BtnCalcular.Size = new Size(215, 47);
            BtnCalcular.TabIndex = 2;
            BtnCalcular.Text = "NUEVO CALCULO";
            BtnCalcular.UseVisualStyleBackColor = false;
            BtnCalcular.Click += btn1_Click;
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(691, 386);
            Controls.Add(BtnCalcular);
            Controls.Add(DgvCalculo);
            Name = "FrmInicio";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)DgvCalculo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView DgvCalculo;
        private Button BtnCalcular;
    }
}
