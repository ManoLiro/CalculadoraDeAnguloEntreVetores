namespace CalculadoraDeAnguloEntreVetores
{
    partial class CalculadoraDeAngulo
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
            PrimeiroCalculo = new Label();
            label2 = new Label();
            label8 = new Label();
            SegundoCalculoVetorA = new Label();
            SegundoCalculoVetorB = new Label();
            label9 = new Label();
            CosTheta = new Label();
            ConvertendoGraus = new Label();
            label11 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(13, 32);
            label1.Name = "label1";
            label1.Size = new Size(93, 32);
            label1.TabIndex = 0;
            label1.Text = "Vetor U";
            label1.Click += label1_Click;
            // 
            // VetorU
            // 
            VetorU.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            VetorU.Location = new Point(143, 29);
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
            label3.Location = new Point(111, 22);
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
            label4.Location = new Point(213, 22);
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
            label5.Location = new Point(213, 121);
            label5.Name = "label5";
            label5.Size = new Size(30, 46);
            label5.TabIndex = 8;
            label5.Text = ")";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(111, 121);
            label6.Name = "label6";
            label6.Size = new Size(30, 46);
            label6.TabIndex = 7;
            label6.Text = "(";
            label6.Click += label6_Click;
            // 
            // VetorV
            // 
            VetorV.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            VetorV.Location = new Point(147, 128);
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
            label7.Location = new Point(13, 131);
            label7.Name = "label7";
            label7.Size = new Size(92, 32);
            label7.TabIndex = 5;
            label7.Text = "Vetor V";
            // 
            // button1
            // 
            button1.Location = new Point(268, 20);
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
            TextAngulo.Location = new Point(563, 546);
            TextAngulo.Name = "TextAngulo";
            TextAngulo.Size = new Size(29, 32);
            TextAngulo.TabIndex = 10;
            TextAngulo.Text = "...";
            // 
            // PrimeiroCalculo
            // 
            PrimeiroCalculo.AutoSize = true;
            PrimeiroCalculo.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PrimeiroCalculo.Location = new Point(563, 81);
            PrimeiroCalculo.Name = "PrimeiroCalculo";
            PrimeiroCalculo.Size = new Size(19, 32);
            PrimeiroCalculo.TabIndex = 11;
            PrimeiroCalculo.Text = ".";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(563, 22);
            label2.Name = "label2";
            label2.Size = new Size(419, 32);
            label2.TabIndex = 12;
            label2.Text = "Calcule o produto escalar dos vetores:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(563, 135);
            label8.Name = "label8";
            label8.Size = new Size(338, 32);
            label8.TabIndex = 13;
            label8.Text = "Calcule o Modulo dos vetores:";
            label8.Click += label8_Click;
            // 
            // SegundoCalculoVetorA
            // 
            SegundoCalculoVetorA.AutoSize = true;
            SegundoCalculoVetorA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SegundoCalculoVetorA.Location = new Point(563, 201);
            SegundoCalculoVetorA.Name = "SegundoCalculoVetorA";
            SegundoCalculoVetorA.Size = new Size(19, 32);
            SegundoCalculoVetorA.TabIndex = 14;
            SegundoCalculoVetorA.Text = ".";
            // 
            // SegundoCalculoVetorB
            // 
            SegundoCalculoVetorB.AutoSize = true;
            SegundoCalculoVetorB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            SegundoCalculoVetorB.Location = new Point(563, 266);
            SegundoCalculoVetorB.Name = "SegundoCalculoVetorB";
            SegundoCalculoVetorB.Size = new Size(19, 32);
            SegundoCalculoVetorB.TabIndex = 15;
            SegundoCalculoVetorB.Text = ".";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(563, 326);
            label9.Name = "label9";
            label9.Size = new Size(259, 32);
            label9.TabIndex = 16;
            label9.Text = "Calcule o Cos de Theta";
            // 
            // CosTheta
            // 
            CosTheta.AutoSize = true;
            CosTheta.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            CosTheta.Location = new Point(563, 379);
            CosTheta.Name = "CosTheta";
            CosTheta.Size = new Size(19, 32);
            CosTheta.TabIndex = 17;
            CosTheta.Text = ".";
            // 
            // ConvertendoGraus
            // 
            ConvertendoGraus.AutoSize = true;
            ConvertendoGraus.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ConvertendoGraus.Location = new Point(563, 471);
            ConvertendoGraus.Name = "ConvertendoGraus";
            ConvertendoGraus.Size = new Size(19, 32);
            ConvertendoGraus.TabIndex = 19;
            ConvertendoGraus.Text = ".";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(563, 424);
            label11.Name = "label11";
            label11.Size = new Size(261, 32);
            label11.TabIndex = 18;
            label11.Text = "Convertendo em Graus";
            label11.Click += label11_Click;
            // 
            // button2
            // 
            button2.Location = new Point(268, 119);
            button2.Name = "button2";
            button2.Size = new Size(133, 67);
            button2.TabIndex = 20;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1565, 651);
            Controls.Add(button2);
            Controls.Add(ConvertendoGraus);
            Controls.Add(label11);
            Controls.Add(CosTheta);
            Controls.Add(label9);
            Controls.Add(SegundoCalculoVetorB);
            Controls.Add(SegundoCalculoVetorA);
            Controls.Add(label8);
            Controls.Add(label2);
            Controls.Add(PrimeiroCalculo);
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
        private Label PrimeiroCalculo;
        private Label label2;
        private Label label8;
        private Label SegundoCalculoVetorA;
        private Label SegundoCalculoVetorB;
        private Label label9;
        private Label CosTheta;
        private Label ConvertendoGraus;
        private Label label11;
        private Button button2;
    }
}