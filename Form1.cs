using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string Calculate(string e)
        {
            if (e.EndsWith("+") || e.EndsWith("-"))
                e = e.Insert(e.Length, "0");
            if (e.EndsWith("*") || e.EndsWith("/"))
                e = e.Insert(e.Length, "1");
            if (e.StartsWith("-"))
                e = e.Insert(0, "0");
            
            float[] nums = new float[99];
            string strResult = "ERROR";
            float result = 0;
            for (int i = 0; i < e.Split(new char[] { '+', '-', '*', '/' }).Length; i++)
            {
                nums[i] = float.Parse(e.Split(new char[] { '+', '-', '*', '/' })[i]);
            }
            switch (e.Split(new char[] { '+', '-', '*', '/' }).Length)
            {
                case 1:
                    result = nums[0];
                    break;

                case 2:
                    switch (e.Remove(e.Split(new char[] { '+', '-', '*', '/' })[0].Length + 1).Substring(e.Split(new char[] { '+', '-', '*', '/' })[0].Length))
                    {
                        case "+":
                            result = nums[0] + nums[1];
                            break;
                        case "-":
                            result = nums[0] - nums[1];
                            break;
                        case "*":
                            result = nums[0] * nums[1];
                            break;
                        case "/":
                            result = nums[0] / nums[1];
                            break;
                    }
                    break;

                case 3:


                default:
                    return strResult;
            }
            strResult = Convert.ToString(result);
            return strResult;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyDown += Form1_KeyDown;
            KeyPreview = true;
            Equal.Focus();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Equal.Focus();
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Up || e.KeyCode == Keys.Right || e.KeyCode == Keys.Down)
                Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
            Text = Convert.ToString(e.KeyValue);
            if (e.Modifiers == Keys.Enter)
            {
                Answer.Text = Calculate(Equasion.Text);
                if (Answer.Text == "ERROR")
                    return;
                Equasion.Text = Answer.Text;
            }

            if(e.Shift)
            {
                switch (e.KeyValue)
                {
                    case 27:
                        Close();
                        break;

                    case 187:
                        if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/"))
                            Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                        Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "*");
                        return;

                    case 55:
                        if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/"))
                            Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                        Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "/");
                        return;
                }
            }

            switch (e.KeyValue)
            {
                case 48:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "0");
                    break;

                case 49:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "1");
                    break;

                case 50:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "2");
                    break;

                case 51:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "3");
                    break;

                case 52:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "4");
                    break;

                case 53:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "5");
                    break;

                case 54:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "6");
                    break;

                case 55:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "7");
                    break;
                case 56:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "8");
                    break;
                case 57:
                    if (Equasion.Text == "0")
                        Equasion.Text = "";
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "9");
                    break;

                case 187:
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                        Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "+");
                    break;

                case 107:
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                        Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "+");
                    break;

                case 189:
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                        Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "-");
                    break;

                case 109:
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                        Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                    if (Equasion.Text.Equals("0"))
                        Equasion.ResetText();
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "-");
                    break;

                case 106:
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                        Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "*");
                    break;

                case 111:
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                        Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "/");
                    break;

                case 188:
                    if (Equasion.Text.Split(new char[] { '+', '-', '*', '/' })[(Equasion.Text.Split(new char[] { '+', '-', '*', '/' }).Length - 1)].Contains(","))
                        return;
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/"))
                        Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "0");
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, ",");
                    break;

                case 190:
                    if (Equasion.Text.Split(new char[] { '+', '-', '*', '/' })[(Equasion.Text.Split(new char[] { '+', '-', '*', '/' }).Length - 1)].Contains(","))
                        return;
                    if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/"))
                        Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "0");
                    Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, ",");
                    break;

                case 27:
                    WindowState = FormWindowState.Minimized;
                    break;

                case 46:
                    Equasion.Text = "0";
                    break;

                case 8:
                    if(Equasion.Text.Length == 1)
                    {
                        Equasion.Text = "0";
                        return;
                    }
                    Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
                    break;
            }
        }

        private void Comma_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.Split(new char[] { '+', '-', '*', '/' })[(Equasion.Text.Split(new char[] { '+', '-', '*', '/' }).Length - 1)].Contains(","))
                return;
            if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/"))
                Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "0");
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, ",");
        }

        private void Equal_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            Answer.Text = Calculate(Equasion.Text);
            if (Answer.Text == "ERROR")
                return;
            //Equasion.Text = Answer.Text;
        }

        private void Num0_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "0");
        }

        private void Num1_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "1");
        }

        private void Num2_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "2");
        }

        private void Num3_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "3");
        }

        private void Num4_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "4");
        }

        private void Num5_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "5");
        }

        private void Num6_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "6");
        }

        private void Num7_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "7");
        }

        private void Num8_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "8");
        }

        private void Num9_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text == "0")
                Equasion.Text = "";
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "9");
        }

        private void Add_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "+");
        }

        private void Sub_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
            if (Equasion.Text.Equals("0"))
                Equasion.ResetText();
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "-");
        }

        private void Multi_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "*");
        }

        private void Div_Click(object sender, EventArgs e)
        {
            Equal.Focus();
            if (Equasion.Text.EndsWith("+") || Equasion.Text.EndsWith("-") || Equasion.Text.EndsWith("*") || Equasion.Text.EndsWith("/") || Equasion.Text.EndsWith(","))
                Equasion.Text = Equasion.Text.Remove(Equasion.Text.Length - 1);
            Equasion.Text = Equasion.Text.Insert(Equasion.Text.Length, "/");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Equal.Focus();
        }
    }
}
