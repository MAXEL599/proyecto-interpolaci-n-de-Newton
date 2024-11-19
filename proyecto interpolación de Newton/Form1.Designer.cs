namespace proyecto_interpolación_de_Newton
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
            label2 = new Label();
            txtX2 = new TextBox();
            txtY1 = new TextBox();
            txtX1 = new TextBox();
            txtY4 = new TextBox();
            txtY2 = new TextBox();
            txtY3 = new TextBox();
            txtX4 = new TextBox();
            txtX3 = new TextBox();
            txtResultado = new TextBox();
            label3 = new Label();
            btnCalcular = new Button();
            btnLimpiar = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(284, 108);
            label1.Name = "label1";
            label1.Size = new Size(24, 24);
            label1.TabIndex = 1;
            label1.Text = "Y";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(182, 108);
            label2.Name = "label2";
            label2.Size = new Size(24, 24);
            label2.TabIndex = 2;
            label2.Text = "X";
            // 
            // txtX2
            // 
            txtX2.Location = new Point(153, 236);
            txtX2.Multiline = true;
            txtX2.Name = "txtX2";
            txtX2.Size = new Size(79, 38);
            txtX2.TabIndex = 4;
            // 
            // txtY1
            // 
            txtY1.Location = new Point(261, 162);
            txtY1.Multiline = true;
            txtY1.Name = "txtY1";
            txtY1.Size = new Size(79, 38);
            txtY1.TabIndex = 5;
            // 
            // txtX1
            // 
            txtX1.Location = new Point(153, 162);
            txtX1.Multiline = true;
            txtX1.Name = "txtX1";
            txtX1.Size = new Size(79, 38);
            txtX1.TabIndex = 6;
            // 
            // txtY4
            // 
            txtY4.Location = new Point(261, 367);
            txtY4.Multiline = true;
            txtY4.Name = "txtY4";
            txtY4.Size = new Size(79, 38);
            txtY4.TabIndex = 7;
            // 
            // txtY2
            // 
            txtY2.Location = new Point(261, 236);
            txtY2.Multiline = true;
            txtY2.Name = "txtY2";
            txtY2.Size = new Size(79, 38);
            txtY2.TabIndex = 8;
            // 
            // txtY3
            // 
            txtY3.Location = new Point(261, 300);
            txtY3.Multiline = true;
            txtY3.Name = "txtY3";
            txtY3.Size = new Size(79, 38);
            txtY3.TabIndex = 9;
            // 
            // txtX4
            // 
            txtX4.Location = new Point(153, 367);
            txtX4.Multiline = true;
            txtX4.Name = "txtX4";
            txtX4.Size = new Size(79, 38);
            txtX4.TabIndex = 10;
            // 
            // txtX3
            // 
            txtX3.Location = new Point(153, 300);
            txtX3.Multiline = true;
            txtX3.Name = "txtX3";
            txtX3.Size = new Size(79, 38);
            txtX3.TabIndex = 11;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(538, 379);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(512, 176);
            txtResultado.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(527, 339);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 13;
            label3.Text = "RESULTADO";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(649, 140);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(240, 60);
            btnCalcular.TabIndex = 14;
            btnCalcular.Text = "calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(649, 236);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(240, 60);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "LIMIPIAR  DATOS";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 44);
            label4.Name = "label4";
            label4.Size = new Size(65, 24);
            label4.TabIndex = 16;
            label4.Text = "label4";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1384, 1060);
            Controls.Add(label4);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(txtResultado);
            Controls.Add(txtX3);
            Controls.Add(txtX4);
            Controls.Add(txtY3);
            Controls.Add(txtY2);
            Controls.Add(txtY4);
            Controls.Add(txtX1);
            Controls.Add(txtY1);
            Controls.Add(txtX2);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 4, 6, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtX2;
        private TextBox txtY1;
        private TextBox txtX1;
        private TextBox txtY4;
        private TextBox txtY2;
        private TextBox txtY3;
        private TextBox txtX4;
        private TextBox txtX3;
        private TextBox txtResultado;
        private Label label3;
        private Button btnCalcular;
        private Button btnLimpiar;
        private Label label4;
    }
}
