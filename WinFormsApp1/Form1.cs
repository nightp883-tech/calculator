
using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private TextBox display;
        private double firstNumber = 0;
        private string operation = "";
        private bool newNumber = true;

        public Form1()
        {
            CreateCalculator();
        }

        private void CreateCalculator()
        {
            Text = "Calculator";
            ClientSize = new Size(390, 420);
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            BackColor = Color.Gainsboro;
            Font = new Font("Segoe UI", 11);

            display = new TextBox();
            display.Location = new Point(25, 30);
            display.Size = new Size(340, 40);
            display.Font = new Font("Segoe UI", 20);
            display.TextAlign = HorizontalAlignment.Right;
            display.ReadOnly = true;
            display.Text = "0";
            Controls.Add(display);

            AddButton("BackSpace", 25, 95, 145, 40);
            AddButton("C", 180, 95, 85, 40);
            AddButton("OFF", 275, 95, 90, 40);

            string[,] keys =
            {
                { "7", "8", "9", "/", "x^" },
                { "4", "5", "6", "*", "Sqrt" },
                { "1", "2", "3", "-", "1/x" },
                { "0", "+/-", ".", "+", "=" }
            };

            for (int row = 0; row < 4; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    int x = 25 + col * 69;
                    int y = 155 + row * 55;

                    AddButton(keys[row, col], x, y, 62, 43);
                }
            }
        }

        private void AddButton(
            string text, int x, int y, int w, int h)
        {
            Button btn = new Button();

            btn.Text = text;
            btn.Location = new Point(x, y);
            btn.Size = new Size(w, h);
            btn.BackColor = text == "="
                ? Color.LightSkyBlue
                : Color.WhiteSmoke;
            btn.FlatStyle = FlatStyle.Standard;
            btn.Font = new Font("Segoe UI", 10);
            btn.Click += Button_Click;

            Controls.Add(btn);
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string key = btn.Text;

            // Тоон товчлуур
            if (key.Length == 1 && char.IsDigit(key[0]))
            {
                if (newNumber || display.Text == "0"
                    || display.Text == "Error")
                {
                    display.Text = key;
                    newNumber = false;
                }
                else
                {
                    display.Text += key;
                }
                return;
            }

            double value;

            // C - бүх утгыг цэвэрлэх
            if (key == "C")
            {
                display.Text = "0";
                firstNumber = 0;
                operation = "";
                newNumber = true;
                return;
            }

            // OFF - хаах
            if (key == "OFF")
            {
                Close();
                return;
            }

            // BackSpace
            if (key == "BackSpace")
            {
                if (newNumber || display.Text == "Error")
                    return;

                if (display.Text.Length > 1)
                    display.Text = display.Text.Substring(
                        0, display.Text.Length - 1);
                else
                    display.Text = "0";

                if (display.Text == "-")
                    display.Text = "0";

                return;
            }

            // Аравтын бутархай
            if (key == ".")
            {
                string dot = CultureInfo.CurrentCulture
                    .NumberFormat.NumberDecimalSeparator;

                if (newNumber || display.Text == "Error")
                {
                    display.Text = "0" + dot;
                    newNumber = false;
                }
                else if (!display.Text.Contains(dot))
                {
                    display.Text += dot;
                }
                return;
            }

            // Тоог унших
            if (!double.TryParse(display.Text,
                out value))
                return;

            // +/- тэмдэг солих
            if (key == "+/-")
            {
                display.Text = (-value).ToString();
                return;
            }

            // Квадрат язгуур
            if (key == "Sqrt")
            {
                if (value < 0)
                    ShowError();
                else
                    ShowResult(Math.Sqrt(value));
                return;
            }

            // Квадрат зэрэг
            if (key == "x^")
            {
                ShowResult(value * value);
                return;
            }

            // Урвуу тоо
            if (key == "1/x")
            {
                if (value == 0)
                    ShowError();
                else
                    ShowResult(1 / value);
                return;
            }

            // Үндсэн үйлдлүүд
            if (key == "+" || key == "-" ||
                key == "*" || key == "/")
            {
                firstNumber = value;
                operation = key;
                newNumber = true;
                return;
            }

            // Тэнцүү
            if (key == "=")
            {
                if (operation == "")
                    return;

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = firstNumber + value;
                        break;

                    case "-":
                        result = firstNumber - value;
                        break;

                    case "*":
                        result = firstNumber * value;
                        break;

                    case "/":
                        if (value == 0)
                        {
                            ShowError();
                            operation = "";
                            return;
                        }

                        result = firstNumber / value;
                        break;
                }

                ShowResult(result);
                operation = "";
            }
        }

        private void ShowResult(double value)
        {
            if (double.IsNaN(value) ||
                double.IsInfinity(value))
            {
                ShowError();
                return;
            }

            display.Text = value.ToString();
            newNumber = true;
        }

        private void ShowError()
        {
            display.Text = "Error";
            newNumber = true;
        }

        // Designer-ийн хуучин Load event-д
        // шаардлагатай функц
        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
