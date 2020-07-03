using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UndoRedoSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stack<string> textContent = new Stack<string>();

        Stack<string> allText = new Stack<string>();

        private void UndoBotton_Click(object sender, EventArgs e)
        {

            try
            {
                //Catch last item ino stack
            int lastItemIndex = textBox.Text.Length - 1;
            string lastItem = textBox.Text.Substring(lastItemIndex);
            textContent.Push(lastItem);

            //Remove last item from textBox
            textBox.Text = textBox.Text.Substring(0, lastItemIndex);
            }
            catch (ArgumentOutOfRangeException) { }
           
            
            
        }

        private void RedoBotton_Click(object sender, EventArgs e)
        {

            try
            {
                textBox.Text += textContent.Pop();
            }
            catch (InvalidOperationException) { }
          
            
        }

        private void SaveBotton_Click(object sender, EventArgs e)
        {
            try
            {
                string all = textBox.Text.Substring(0, textBox.Text.Length);
                allText.Push(all);
                textBox.Clear();
            }
            catch (ArgumentOutOfRangeException) { }
            
        }

        private void LoadSaved_Click(object sender, EventArgs e)
        {
            try
            {
                textBox.Text = allText.Pop();
            }
            catch (InvalidOperationException) { }
            
        }
    }
}
