using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract16_1_Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private string CountDigits(string[] stringArray)
        {
            int count = 0;
            string number = "";
            foreach (string str in stringArray)
            {
                foreach (char ch in str)
                {
                    if (char.IsDigit(ch))
                    {
                        count++;
                        number += ch;
                    }
                }
            }

            return $"Количество цифр: {count} {number}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = txtInput.Text;
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Введите не пустую строку");
                return;
            }
            string[] stringArray = input.Split('/');

            string digitCount = CountDigits(stringArray);
            lblResultA.Text = digitCount;
            
            var outputStrings = stringArray.TakeWhile(s => s != "/");
            lblResultB.Text = string.Join(Environment.NewLine, outputStrings);
            
            string outputPath = "output.txt";
            using (var writer = new StreamWriter(outputPath))
            {
                foreach (var str in stringArray.SkipWhile(s => s != "/").Skip(1))
                {
                    var modifiedStr = new StringBuilder(str);
                    for (int i = 0; i < modifiedStr.Length; i++)
                    {
                        if (char.IsUpper(modifiedStr[i]))
                        {
                            modifiedStr[i] = char.ToLower(modifiedStr[i]);
                        }
                        if (char.IsLower(modifiedStr[i]))
                        {
                            modifiedStr[i] = char.ToUpper(modifiedStr[i]);
                        }
                    }

                    lblResultC.Text = modifiedStr.ToString();
                    writer.WriteLine(modifiedStr);
                }
            }
            MessageBox.Show($"Запись в файл {outputPath} выполнена");
        }
    }
}