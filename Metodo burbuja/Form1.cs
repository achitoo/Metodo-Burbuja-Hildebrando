using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metodo_burbuja.Models;


namespace Metodo_burbuja

{
    public partial class Form1 : Form
    {
        int[] numbers = new int[10];
        int i = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(tbNumber.Text);
                numbers[i++] = number;
                ShowNumbers();
            } catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        public void ShowNumbers()
        {
            if (lbNumbers.Items.Count > 0)
            {
                lbNumbers.Items.Clear();
            }

            foreach (int number in numbers)
            {
                lbNumbers.Items.Add(number);
            }



        }
        private void Clear()
        {
            tbNumber.Clear();
            lbNumbers.ClearSelected();

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            Bubble bubble = new Bubble();
            bubble.SortBubble(numbers);
            ShowNumbers();
        }
    }
   
    
}
