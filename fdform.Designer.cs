namespace BankingApplication
{
    partial class fdform
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelbtn = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.accnotxt = new System.Windows.Forms.TextBox();
            this.rupeestxt = new System.Windows.Forms.TextBox();
            this.periodtxt = new System.Windows.Forms.TextBox();
            this.intersttxt = new System.Windows.Forms.TextBox();
            this.modetxt = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // labelbtn
            // 
            this.labelbtn.AutoSize = true;
            this.labelbtn.Location = new System.Drawing.Point(247, 77);
            this.labelbtn.Name = "labelbtn";
            this.labelbtn.Size = new System.Drawing.Size(0, 13);
            this.labelbtn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Accountno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mode";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Rupees";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Period(day)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Interest(%)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // accnotxt
            // 
            this.accnotxt.Location = new System.Drawing.Point(125, 124);
            this.accnotxt.Name = "accnotxt";
            this.accnotxt.Size = new System.Drawing.Size(100, 20);
            this.accnotxt.TabIndex = 8;
            // 
            // rupeestxt
            // 
            this.rupeestxt.Location = new System.Drawing.Point(125, 199);
            this.rupeestxt.Name = "rupeestxt";
            this.rupeestxt.Size = new System.Drawing.Size(100, 20);
            this.rupeestxt.TabIndex = 9;
            // 
            // periodtxt
            // 
            this.periodtxt.Location = new System.Drawing.Point(125, 246);
            this.periodtxt.Name = "periodtxt";
            this.periodtxt.Size = new System.Drawing.Size(100, 20);
            this.periodtxt.TabIndex = 10;
            // 
            // intersttxt
            // 
            this.intersttxt.Location = new System.Drawing.Point(125, 302);
            this.intersttxt.Name = "intersttxt";
            this.intersttxt.Size = new System.Drawing.Size(100, 20);
            this.intersttxt.TabIndex = 11;
            // 
            // modetxt
            // 
            this.modetxt.FormattingEnabled = true;
            this.modetxt.Location = new System.Drawing.Point(125, 156);
            this.modetxt.Name = "modetxt";
            this.modetxt.Size = new System.Drawing.Size(100, 21);
            this.modetxt.TabIndex = 12;
            // 
            // fdform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.modetxt);
            this.Controls.Add(this.intersttxt);
            this.Controls.Add(this.periodtxt);
            this.Controls.Add(this.rupeestxt);
            this.Controls.Add(this.accnotxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelbtn);
            this.Controls.Add(this.label1);
            this.Name = "fdform";
            this.Text = "fdform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox accnotxt;
        private System.Windows.Forms.TextBox rupeestxt;
        private System.Windows.Forms.TextBox periodtxt;
        private System.Windows.Forms.TextBox intersttxt;
        private System.Windows.Forms.ComboBox modetxt;
    }
}