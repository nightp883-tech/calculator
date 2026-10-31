namespace WinFormsApp1
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
            txtDisplay = new TextBox();
            btnBack = new Button();
            btnClear = new Button();
            btnOff = new Button();
            btn0 = new Button();
            btnDot = new Button();
            btnSign = new Button();
            btnAdd = new Button();
            btnEqual = new Button();
            btn1 = new Button();
            btn4 = new Button();
            btn7 = new Button();
            btn2 = new Button();
            btn9 = new Button();
            btn6 = new Button();
            btn8 = new Button();
            btn5 = new Button();
            btn3 = new Button();
            btnDivide = new Button();
            btnSqrt = new Button();
            btnMultiply = new Button();
            btnReciprocal = new Button();
            btnSubtract = new Button();
            btnSquare = new Button();
            SuspendLayout();
            // 
            // txtDisplay
            // 
            txtDisplay.Location = new Point(25, 40);
            txtDisplay.Name = "txtDisplay";
            txtDisplay.ReadOnly = true;
            txtDisplay.Size = new Size(330, 35);
            txtDisplay.TabIndex = 0;
            txtDisplay.Text = "0";
            txtDisplay.TextAlign = HorizontalAlignment.Right;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 90);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(114, 40);
            btnBack.TabIndex = 1;
            btnBack.Text = "BackSpace";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(132, 90);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(111, 40);
            btnClear.TabIndex = 2;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnOff
            // 
            btnOff.Location = new Point(253, 90);
            btnOff.Name = "btnOff";
            btnOff.Size = new Size(111, 40);
            btnOff.TabIndex = 3;
            btnOff.Text = "OFF";
            btnOff.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 319);
            btn0.Name = "btn0";
            btn0.Size = new Size(58, 40);
            btn0.TabIndex = 4;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            // 
            // btnDot
            // 
            btnDot.Location = new Point(158, 319);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(58, 40);
            btnDot.TabIndex = 5;
            btnDot.Text = ".";
            btnDot.UseVisualStyleBackColor = true;
            // 
            // btnSign
            // 
            btnSign.Location = new Point(85, 319);
            btnSign.Name = "btnSign";
            btnSign.Size = new Size(58, 40);
            btnSign.TabIndex = 6;
            btnSign.Text = "+/-";
            btnSign.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(233, 319);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(58, 40);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEqual
            // 
            btnEqual.BackColor = Color.LightCyan;
            btnEqual.Location = new Point(306, 319);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(58, 40);
            btnEqual.TabIndex = 8;
            btnEqual.Text = "=";
            btnEqual.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 263);
            btn1.Name = "btn1";
            btn1.Size = new Size(58, 40);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 205);
            btn4.Name = "btn4";
            btn4.Size = new Size(58, 40);
            btn4.TabIndex = 10;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 148);
            btn7.Name = "btn7";
            btn7.Size = new Size(58, 40);
            btn7.TabIndex = 11;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.Location = new Point(85, 263);
            btn2.Name = "btn2";
            btn2.Size = new Size(58, 40);
            btn2.TabIndex = 12;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn9
            // 
            btn9.Location = new Point(158, 148);
            btn9.Name = "btn9";
            btn9.Size = new Size(58, 40);
            btn9.TabIndex = 13;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            btn6.Location = new Point(159, 205);
            btn6.Name = "btn6";
            btn6.Size = new Size(58, 40);
            btn6.TabIndex = 14;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            // 
            // btn8
            // 
            btn8.Location = new Point(85, 148);
            btn8.Name = "btn8";
            btn8.Size = new Size(58, 40);
            btn8.TabIndex = 15;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.Location = new Point(85, 205);
            btn5.Name = "btn5";
            btn5.Size = new Size(58, 40);
            btn5.TabIndex = 16;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.Location = new Point(159, 263);
            btn3.Name = "btn3";
            btn3.Size = new Size(58, 40);
            btn3.TabIndex = 17;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btnDivide
            // 
            btnDivide.Location = new Point(231, 148);
            btnDivide.Name = "btnDivide";
            btnDivide.Size = new Size(58, 40);
            btnDivide.TabIndex = 18;
            btnDivide.Text = "/";
            btnDivide.UseVisualStyleBackColor = true;
            // 
            // btnSqrt
            // 
            btnSqrt.Location = new Point(306, 205);
            btnSqrt.Name = "btnSqrt";
            btnSqrt.Size = new Size(58, 40);
            btnSqrt.TabIndex = 19;
            btnSqrt.Text = "sqrt";
            btnSqrt.UseVisualStyleBackColor = true;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(231, 205);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(58, 40);
            btnMultiply.TabIndex = 20;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            // 
            // btnReciprocal
            // 
            btnReciprocal.Location = new Point(306, 263);
            btnReciprocal.Name = "btnReciprocal";
            btnReciprocal.Size = new Size(58, 40);
            btnReciprocal.TabIndex = 21;
            btnReciprocal.Text = "1/x";
            btnReciprocal.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(233, 263);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(58, 40);
            btnSubtract.TabIndex = 22;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            // 
            // btnSquare
            // 
            btnSquare.Location = new Point(306, 148);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(58, 40);
            btnSquare.TabIndex = 23;
            btnSquare.Text = "x^";
            btnSquare.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(376, 386);
            Controls.Add(btnSquare);
            Controls.Add(btnSubtract);
            Controls.Add(btnReciprocal);
            Controls.Add(btnMultiply);
            Controls.Add(btnSqrt);
            Controls.Add(btnDivide);
            Controls.Add(btn3);
            Controls.Add(btn5);
            Controls.Add(btn8);
            Controls.Add(btn6);
            Controls.Add(btn9);
            Controls.Add(btn2);
            Controls.Add(btn7);
            Controls.Add(btn4);
            Controls.Add(btn1);
            Controls.Add(btnEqual);
            Controls.Add(btnAdd);
            Controls.Add(btnSign);
            Controls.Add(btnDot);
            Controls.Add(btn0);
            Controls.Add(btnOff);
            Controls.Add(btnClear);
            Controls.Add(btnBack);
            Controls.Add(txtDisplay);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDisplay;
        private Button btnBack;
        private Button btnClear;
        private Button btnOff;
        private Button btn0;
        private Button btnDot;
        private Button btnSign;
        private Button btnAdd;
        private Button btnEqual;
        private Button btn1;
        private Button btn4;
        private Button btn7;
        private Button btn2;
        private Button btn9;
        private Button btn6;
        private Button btn8;
        private Button btn5;
        private Button btn3;
        private Button btnDivide;
        private Button btnSqrt;
        private Button btnMultiply;
        private Button btnReciprocal;
        private Button btnSubtract;
        private Button btnSquare;
    }
}
