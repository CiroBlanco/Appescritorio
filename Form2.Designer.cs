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
            Lbl2 = new Label();
            Lbl3 = new Label();
            Txt1 = new TextBox();
            Txt2 = new TextBox();
            SuspendLayout();
            // 
            // Lbl2
            // 
            Lbl2.AutoSize = true;
            Lbl2.Location = new Point(227, 97);
            Lbl2.Name = "Lbl2";
            Lbl2.Size = new Size(49, 15);
            Lbl2.TabIndex = 0;
            Lbl2.Text = "Estatura";
            // 
            // Lbl3
            // 
            Lbl3.AutoSize = true;
            Lbl3.Location = new Point(227, 162);
            Lbl3.Name = "Lbl3";
            Lbl3.Size = new Size(32, 15);
            Lbl3.TabIndex = 1;
            Lbl3.Text = "Peso";
            // 
            // Txt1
            // 
            Txt1.Location = new Point(227, 115);
            Txt1.Name = "Txt1";
            Txt1.Size = new Size(100, 23);
            Txt1.TabIndex = 2;
            // 
            // Txt2
            // 
            Txt2.Location = new Point(227, 180);
            Txt2.Name = "Txt2";
            Txt2.Size = new Size(100, 23);
            Txt2.TabIndex = 3;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Txt2);
            Controls.Add(Txt1);
            Controls.Add(Lbl3);
            Controls.Add(Lbl2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lbl2;
        private Label Lbl3;
        private TextBox Txt1;
        private TextBox Txt2;
    }
}