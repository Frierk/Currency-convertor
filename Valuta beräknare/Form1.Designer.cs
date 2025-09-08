namespace Valuta_beräknare
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
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            buttonHtV = new Button();
            buttonVtH = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            buttonCl = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox7 = new TextBox();
            label6 = new Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SEK", "EUR", "USD", "GBP", "Min valuta" });
            comboBox1.Location = new Point(121, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(96, 33);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SEK", "EUR", "USD", "GBP", "Min valuta" });
            comboBox2.Location = new Point(507, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(96, 33);
            comboBox2.TabIndex = 1;
            // 
            // buttonHtV
            // 
            buttonHtV.Location = new Point(348, 203);
            buttonHtV.Name = "buttonHtV";
            buttonHtV.Size = new Size(112, 34);
            buttonHtV.TabIndex = 2;
            buttonHtV.Text = "<---";
            buttonHtV.UseVisualStyleBackColor = true;
            buttonHtV.Click += buttonHtV_Click;
            // 
            // buttonVtH
            // 
            buttonVtH.Location = new Point(348, 150);
            buttonVtH.Name = "buttonVtH";
            buttonVtH.Size = new Size(112, 34);
            buttonVtH.TabIndex = 3;
            buttonVtH.Text = "--->";
            buttonVtH.UseVisualStyleBackColor = true;
            buttonVtH.Click += buttonVtH_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 203);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 31);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(507, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 31);
            textBox2.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(273, 64);
            label1.Name = "label1";
            label1.Size = new Size(249, 38);
            label1.TabIndex = 6;
            label1.Text = "Valutakonverterare";
            // 
            // buttonCl
            // 
            buttonCl.Location = new Point(348, 252);
            buttonCl.Name = "buttonCl";
            buttonCl.Size = new Size(112, 34);
            buttonCl.TabIndex = 7;
            buttonCl.Text = "Clear";
            buttonCl.UseVisualStyleBackColor = true;
            buttonCl.Click += buttonCl_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(273, 331);
            label4.Name = "label4";
            label4.Size = new Size(104, 28);
            label4.TabIndex = 18;
            label4.Text = "Min valuta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(391, 328);
            label5.Name = "label5";
            label5.Size = new Size(24, 25);
            label5.TabIndex = 19;
            label5.Text = "=";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(421, 328);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(90, 31);
            textBox7.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(517, 331);
            label6.Name = "label6";
            label6.Size = new Size(38, 25);
            label6.TabIndex = 21;
            label6.Text = "sek";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(789, 412);
            Controls.Add(label6);
            Controls.Add(textBox7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buttonCl);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonVtH);
            Controls.Add(buttonHtV);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Valutakonverterare";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button buttonHtV;
        private Button buttonVtH;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button buttonCl;
        private Label label4;
        private Label label5;
        private TextBox textBox7;
        private Label label6;
    }
}
