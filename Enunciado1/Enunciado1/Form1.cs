using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enunciado1
{
    public partial class Form1 : Form
    {
        private string[] array;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnIngresarDatos_Click(object sender, EventArgs e)
        {
            array = txtInput.Text.Split(' ');
            if (array.Length > 0)
            {
                lstDesordenado.Items.Clear();
                foreach (string item in array)
                {
                    lstDesordenado.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos válidos separados por comas.");
            }
        }

        private void btnOrdenarArray_Click(object sender, EventArgs e)
        {
            if (array != null && array.Length > 0)
            {
                OrdenarArray(array, 0, array.Length - 1);
                lstOrdenado.Items.Clear();
                foreach (string item in array)
                {
                    lstOrdenado.Items.Add(item);
                }
            }
            else
            {
                MessageBox.Show("El array no contiene elementos para ordenar.");
            }
        }

        private void OrdenarArray(string[] arr, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(arr, left, right);
                OrdenarArray(arr, left, pivotIndex - 1);
                OrdenarArray(arr, pivotIndex + 1, right);
            }
        }

        private int Partition(string[] arr, int left, int right)
        {
            string pivot = arr[right];
            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (string.Compare(arr[j], pivot) < 0)
                {
                    i++;
                    Swap(arr, i, j);
                }
            }
            Swap(arr, i + 1, right);
            return i + 1;
        }

        private void Swap(string[] arr, int i, int j)
        {
            string temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
