using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Collections
{
    public partial class Form1 : Form
    {
        private Queue<string> q = new Queue<string>();
        public Form1()

        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // Queue<string> q = new Queue<string>();
            q.Enqueue(this.textBox1.Text);
            listBox1.DataSource = q.ToArray();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (q.Count > 0)
            textBox1.Text = q.Dequeue();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Check if string has balance paranthesis

            Stack<string> stack = new Stack<string>();
            for(int i = 0 ; i <textBox2.Text.Length ; i++ )
            {
                if(textBox2.Text.Substring(i, 1) == "(")
                {
                    stack.Push("C");
                }
                else if (textBox2.Text.Substring(i, 1) == ")")
                {
                    if(stack.Count > 0)
                        stack.Pop();
                    else
                    {
                        stack.Push("C");
                        break;
                    }

                }
            }

            if(stack.Count > 0)
            {
                MessageBox.Show("Failed");
            }
            else
            {
                MessageBox.Show("Pass");
            }
        }
    }
}
