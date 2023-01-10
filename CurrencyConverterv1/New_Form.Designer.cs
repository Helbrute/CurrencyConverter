namespace CurrencyConverterv1
{
    partial class New_Form
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
            this.fromCurrency = new System.Windows.Forms.ComboBox();
            this.txt_from = new System.Windows.Forms.TextBox();
            this.txt_to = new System.Windows.Forms.TextBox();
            this.toCurrency = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fromCurrency
            // 
            this.fromCurrency.AllowDrop = true;
            this.fromCurrency.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fromCurrency.FormattingEnabled = true;
            this.fromCurrency.Location = new System.Drawing.Point(227, 129);
            this.fromCurrency.Name = "fromCurrency";
            this.fromCurrency.Size = new System.Drawing.Size(260, 39);
            this.fromCurrency.TabIndex = 0;
            // 
            // txt_from
            // 
            this.txt_from.AllowDrop = true;
            this.txt_from.Font = new System.Drawing.Font("Tw Cen MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_from.Location = new System.Drawing.Point(12, 128);
            this.txt_from.Name = "txt_from";
            this.txt_from.Size = new System.Drawing.Size(194, 38);
            this.txt_from.TabIndex = 1;
            // 
            // txt_to
            // 
            this.txt_to.AllowDrop = true;
            this.txt_to.Font = new System.Drawing.Font("Tw Cen MT", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_to.Location = new System.Drawing.Point(12, 246);
            this.txt_to.Name = "txt_to";
            this.txt_to.Size = new System.Drawing.Size(194, 38);
            this.txt_to.TabIndex = 3;
            // 
            // toCurrency
            // 
            this.toCurrency.AllowDrop = true;
            this.toCurrency.Font = new System.Drawing.Font("Tw Cen MT", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toCurrency.FormattingEnabled = true;
            this.toCurrency.Location = new System.Drawing.Point(227, 247);
            this.toCurrency.Name = "toCurrency";
            this.toCurrency.Size = new System.Drawing.Size(260, 39);
            this.toCurrency.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "From currency:";
            // 
            // label4
            // 
            this.label4.AllowDrop = true;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label4.Location = new System.Drawing.Point(12, 215);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "To currency:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 42);
            this.panel1.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label5.Location = new System.Drawing.Point(147, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 31);
            this.label5.TabIndex = 1;
            this.label5.Text = "CURRENCY CONVERTER";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_back.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.btn_back.Location = new System.Drawing.Point(0, 0);
            this.btn_back.Margin = new System.Windows.Forms.Padding(0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(121, 42);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(199, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 9;
            this.button1.Text = "Convert";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AllowDrop = true;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label7.Location = new System.Drawing.Point(490, 250);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "$";
            // 
            // label6
            // 
            this.label6.AllowDrop = true;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(490, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 31);
            this.label6.TabIndex = 11;
            this.label6.Text = "$";
            // 
            // New_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(524, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_to);
            this.Controls.Add(this.toCurrency);
            this.Controls.Add(this.txt_from);
            this.Controls.Add(this.fromCurrency);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "New_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Form";
            this.Load += new System.EventHandler(this.New_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox fromCurrency;
        private TextBox txt_from;
        private TextBox txt_to;
        private ComboBox toCurrency;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button btn_back;
        private Button button1;
        private Label label5;
        private Label label7;
        private Label label6;
    }
}