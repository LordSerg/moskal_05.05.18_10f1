using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace moskal_05._05._18_10f_1_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string[] s;
        private void Form1_Load(object sender, EventArgs e)
        {
            s = File.ReadAllLines("st.txt",Encoding.Default);
            for (int i = 0; i < s.Length; i++)
            {
                listBox1.Items.Add(s[i]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            string[] s1;
            int[] x;
            char ch = Convert.ToChar(textBox1.Text);
            x = new int[listBox1.Items.Count];
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                s1=(s[i].Split(ch));
                x[i] = s1.Length-1;
            }
            int max, imax=0;
            max = x[0];
            imax = 0;
            for(int i=0;i< listBox1.Items.Count; i++)
            {
                max = x[i];
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    if (max < x[j])
                    {
                        imax = j;
                        max = x[j];
                    }
                }
            }
            if (max != 0)
            {
                label3.Text = (imax + 1).ToString();
            }else
            {
                label3.Text = "-1";
            }
            //2
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                x[i] = s[i].Length - 1;
            }
            max = x[0];
            imax = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                max = x[i];
                for (int j = 0; j < listBox1.Items.Count; j++)
                {
                    if (max < x[j])
                    {
                        imax = j;
                        max = x[j];
                    }
                }
            }
            label7.Text = (imax + 1).ToString();
            //3
            int n=0;
            char[] ch2;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                ch2 = new char[max];//где max - размер самой большой строки
                ch2 = s[i].ToCharArray();
                for (int j = 0; j < ch2.Length; j++)
                {
                    if (proverka(ch2[j]) == true)
                    {
                        n++;
                    }
                }
            }
            label9.Text = n.ToString();
        }
        bool proverka(char ch2)
        {
            bool b = false;
            
            for(int i=0;i<10;i++)
            {
                if(ch2.ToString()==i.ToString())
                {
                    b = true;
                }
            }
            return b;
        }
    }
}
