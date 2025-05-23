namespace Calculadora_IMC
{
    partial class Form1
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
            Dgv1 = new DataGridView();
            Lbl1 = new Label();
            btn1 = new Button();
            ((System.ComponentModel.ISupportInitialize)Dgv1).BeginInit();
            SuspendLayout();
            // 
            // Dgv1
            // 
            Dgv1.BackgroundColor = Color.MistyRose;
            Dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dgv1.Location = new Point(262, 31);
            Dgv1.Name = "Dgv1";
            Dgv1.Size = new Size(240, 150);
            Dgv1.TabIndex = 0;
            // 
            // Lbl1
            // 
            Lbl1.AutoSize = true;
            Lbl1.Location = new Point(334, 216);
            Lbl1.Name = "Lbl1";
            Lbl1.Size = new Size(85, 15);
            Lbl1.TabIndex = 1;
            Lbl1.Text = "Nuevo Calculo";
            // 
            // btn1
            // 
            btn1.Location = new Point(319, 250);
            btn1.Name = "btn1";
            btn1.Size = new Size(116, 23);
            btn1.TabIndex = 2;
            btn1.Text = "CALCULAR";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn1);
            Controls.Add(Lbl1);
            Controls.Add(Dgv1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Dgv1;
        private Label Lbl1;
        private Button btn1;
    }
}
