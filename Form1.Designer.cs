namespace CalculadoraDeAnguloEntreVetores
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
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            VetorU = new MaskedTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            VetorV = new MaskedTextBox();
            label7 = new Label();
            button1 = new Button();
            TextAngulo = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 78);
            label1.Name = "label1";
            label1.Size = new Size(91, 32);
            label1.TabIndex = 0;
            label1.Text = "Vetor u";
            label1.Click += label1_Click;
            // 
            // VetorU
            // 
            VetorU.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            VetorU.Location = new Point(142, 75);
            VetorU.Mask = "0,0,0";
            VetorU.Name = "VetorU";
            VetorU.Size = new Size(64, 39);
            VetorU.TabIndex = 2;
            VetorU.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(110, 68);
            label3.Name = "label3";
            label3.Size = new Size(30, 46);
            label3.TabIndex = 3;
            label3.Text = "(";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(212, 68);
            label4.Name = "label4";
            label4.Size = new Size(30, 46);
            label4.TabIndex = 4;
            label4.Text = ")";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(212, 167);
            label5.Name = "label5";
            label5.Size = new Size(30, 46);
            label5.TabIndex = 8;
            label5.Text = ")";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(110, 167);
            label6.Name = "label6";
            label6.Size = new Size(30, 46);
            label6.TabIndex = 7;
            label6.Text = "(";
            label6.Click += label6_Click;
            // 
            // VetorV
            // 
            VetorV.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            VetorV.Location = new Point(146, 174);
            VetorV.Mask = "0,0,0";
            VetorV.Name = "VetorV";
            VetorV.Size = new Size(60, 39);
            VetorV.TabIndex = 6;
            VetorV.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(12, 177);
            label7.Name = "label7";
            label7.Size = new Size(89, 32);
            label7.TabIndex = 5;
            label7.Text = "Vetor v";
            // 
            // button1
            // 
            button1.Location = new Point(265, 115);
            button1.Name = "button1";
            button1.Size = new Size(133, 67);
            button1.TabIndex = 9;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TextAngulo
            // 
            TextAngulo.AutoSize = true;
            TextAngulo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TextAngulo.Location = new Point(12, 356);
            TextAngulo.Name = "TextAngulo";
            TextAngulo.Size = new Size(29, 32);
            TextAngulo.TabIndex = 10;
            TextAngulo.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TextAngulo);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(VetorV);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(VetorU);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label TextAngulo;
        private MaskedTextBox VetorU;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private MaskedTextBox VetorV;
        private Label label7;
        private Button button1;
    }
}