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
            button1 = new Button();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "SEK", "EUR", "USD", "GBP" });
            comboBox1.Location = new Point(121, 152);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(96, 33);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "SEK", "EUR", "USD", "GBP" });
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
            // button1
            // 
            button1.Location = new Point(348, 252);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 7;
            button1.Text = "Clear";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
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
        private Button button1;
    }
}
