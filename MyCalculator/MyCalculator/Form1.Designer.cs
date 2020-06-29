namespace MyCalculator
{
    partial class Form1
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
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnBackSpace = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnsubtraction = new System.Windows.Forms.Button();
            this.btndot = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnequal = new System.Windows.Forms.Button();
            this.btnOnOff = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.White;
            this.txtDisplay.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDisplay.Location = new System.Drawing.Point(12, 12);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.ReadOnly = true;
            this.txtDisplay.Size = new System.Drawing.Size(210, 27);
            this.txtDisplay.TabIndex = 1;
            this.txtDisplay.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnBackSpace);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btnplus);
            this.panel1.Controls.Add(this.btn9);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btnsubtraction);
            this.panel1.Controls.Add(this.btndot);
            this.panel1.Controls.Add(this.btnMultiply);
            this.panel1.Controls.Add(this.btnDivision);
            this.panel1.Controls.Add(this.btnequal);
            this.panel1.Location = new System.Drawing.Point(1, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 299);
            this.panel1.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 11);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 53);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnBackSpace
            // 
            this.btnBackSpace.Location = new System.Drawing.Point(9, 11);
            this.btnBackSpace.Name = "btnBackSpace";
            this.btnBackSpace.Size = new System.Drawing.Size(102, 53);
            this.btnBackSpace.TabIndex = 16;
            this.btnBackSpace.Text = "<-------";
            this.btnBackSpace.UseVisualStyleBackColor = true;
            this.btnBackSpace.Click += new System.EventHandler(this.btnBachSpace_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(9, 70);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(48, 53);
            this.btn7.TabIndex = 15;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(9, 129);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(48, 53);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(9, 188);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(48, 53);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(9, 247);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(48, 53);
            this.btn0.TabIndex = 12;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(63, 70);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(48, 53);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(63, 129);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(48, 53);
            this.btn5.TabIndex = 10;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(63, 188);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(48, 53);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnplus
            // 
            this.btnplus.Location = new System.Drawing.Point(63, 247);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(48, 53);
            this.btnplus.TabIndex = 8;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = true;
            this.btnplus.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(117, 70);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(48, 53);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(117, 129);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(48, 53);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(117, 188);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(48, 53);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnsubtraction
            // 
            this.btnsubtraction.Location = new System.Drawing.Point(117, 247);
            this.btnsubtraction.Name = "btnsubtraction";
            this.btnsubtraction.Size = new System.Drawing.Size(48, 53);
            this.btnsubtraction.TabIndex = 4;
            this.btnsubtraction.Text = "-";
            this.btnsubtraction.UseVisualStyleBackColor = true;
            this.btnsubtraction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // btndot
            // 
            this.btndot.Location = new System.Drawing.Point(171, 70);
            this.btndot.Name = "btndot";
            this.btndot.Size = new System.Drawing.Size(48, 53);
            this.btndot.TabIndex = 3;
            this.btndot.Text = ".";
            this.btndot.UseVisualStyleBackColor = true;
            this.btndot.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Numbers);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(171, 129);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(48, 53);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(171, 188);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(48, 53);
            this.btnDivision.TabIndex = 17;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.MouseClick += new System.Windows.Forms.MouseEventHandler(this.operators);
            // 
            // btnequal
            // 
            this.btnequal.Location = new System.Drawing.Point(171, 247);
            this.btnequal.Name = "btnequal";
            this.btnequal.Size = new System.Drawing.Size(48, 53);
            this.btnequal.TabIndex = 18;
            this.btnequal.Text = "=";
            this.btnequal.UseVisualStyleBackColor = true;
            this.btnequal.Click += new System.EventHandler(this.btnequal_Click);
            // 
            // btnOnOff
            // 
            this.btnOnOff.Location = new System.Drawing.Point(12, 45);
            this.btnOnOff.Name = "btnOnOff";
            this.btnOnOff.Size = new System.Drawing.Size(102, 42);
            this.btnOnOff.TabIndex = 16;
            this.btnOnOff.Text = "ON";
            this.btnOnOff.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnOnOff);
            this.Controls.Add(this.txtDisplay);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.Text = "My Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnBackSpace;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnsubtraction;
        private System.Windows.Forms.Button btndot;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnequal;
        private System.Windows.Forms.Button btnOnOff;
    }
}

