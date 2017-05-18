using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication03
{
    public partial class Form1 : Form
    {

        double num1=0  , num2=0,step=0;  //
        bool a,s,m,d;                 //定义bool变量 +，-,*，/
       // Button[] btns;
        public Form1()
        {
            InitializeComponent();
        }
       // 新增取反，记忆存储按键
        private void SetInputFocus()            //定位焦点
        {
            textBox1.Focus();
            textBox1.SelectionStart = textBox1.TextLength;
            textBox1.SelectionLength = 0;
        }
        private void clear()                    //清除
        {
            textBox1.Text = String.Empty;
           // textBox1.Text = ("");
            num1 = num2 = 0;
            a = s = m = d = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += 0;
        }
        private void button11_Click(object sender, EventArgs e)  //+
        {         
            a = true;
            s = m = d = false;
            if (step== 0)
            {
                num1 += Convert.ToDouble(textBox1.Text);
                step++;
                clear();
            }
            else
            {
                num2 += Convert.ToDouble(textBox1.Text);
                step++;
                clear();
                textBox1.Text += num1 + num2;
                num1 += Convert.ToDouble(textBox1.Text);
            }
        }
        private void button12_Click(object sender, EventArgs e)     //-
        {

            s = true;
            a = m = d = false;
            if (step == 0)
            {
                num1 += Convert.ToDouble(textBox1.Text);
                step++;
                clear();
            }
            else
            {
                num2 += Convert.ToDouble(textBox1.Text);
                step++;
                clear();
                textBox1.Text += num1 - num2;
                num1 += Convert.ToDouble(textBox1.Text);
            }
        }
        private void button13_Click(object sender, EventArgs e)     //*
        {
            m = true;
            a = s = d = false;
            if (step == 0)
            {
                num1 += Convert.ToDouble(textBox1.Text);
                step++;
            }
            else
            {
                num2 += Convert.ToDouble(textBox1.Text);
                step++;
                clear();
                textBox1.Text += num1 * num2;
                num1 += Convert.ToDouble(textBox1.Text);
            }
        }
        private void button14_Click(object sender, EventArgs e) //  /
        {
            d = true;
            a = s = d = false;
            if (step == 0)
            {
                num1 += Convert.ToDouble(textBox1.Text);
                step++;
                clear();
            }
            else
            {
                num2 += Convert.ToDouble(textBox1.Text);
                step++;
                clear();
                if (num2 == 0 && d)
                {
                    textBox1.Text += "Error";
                } else {
                 textBox1.Text += num1 / num2;
                num1 += Convert.ToDouble(textBox1.Text);
                }
            }
        }
        /*   private void button15_Click(object sender, EventArgs e)
           {
               clear();
               AppendChar('.');
               SetInputFocus();
           }
           private void button16_Click(object sender, EventArgs e)
           {
               clear();
               SetInputFocus();
           }*/
        private void button17_Click(object sender, EventArgs e)     // 清屏
        {
            clear();
        }
        private void button18_Click(object sender, EventArgs e)     //  计算
        {
            num2 += Convert.ToDouble(textBox1.Text);
            clear();
            if (num2 == 0 && d)
            {
                textBox1.Text += "Error ：divisor 0！";
                clear();
            }
            if (a)
            {
                textBox1.Text += num1 + num2;
            }
            else if (s)
            {
                textBox1.Text += num1 - num2;
            }
            else if (m)
            {
                textBox1.Text += num1 * num2;
            }
            else if (d)
            {
                textBox1.Text += num1 / num2;
            }
        }
        private void button19_Click(object sender, EventArgs e)  //退格键
        {
            if(textBox1.TextLength > 0)
                textBox1.Text += textBox1.Text.Substring(textBox1.Text.Length, textBox1.Text.Length - 1);
        }

    }
}