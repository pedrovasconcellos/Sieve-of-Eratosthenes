//MIT License
//
//Copyright (c) 2019 Pedro Vasconcellos
//
//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:
//
//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.
//
//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE.

//Pedro Vasconcellos ( Sieve of Eratosthenes / Crivo de Eratóstenes )

using System;
using System.Windows.Forms;

namespace CrivoEratostenes_Pedro_Vasconcellos
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrimo_Click(object sender, EventArgs e)
        {
            int v, raiz;
            int i, j;
            int[] vetor = new int[int.MaxValue / 10];

            v = Convert.ToInt32(txtNumero.Text);

            raiz = Convert.ToInt32(Math.Sqrt(v));

            for (i = 2; i <= v; i++)
            {
                vetor[i] = i;
            }

            for (i = 2; i <= raiz; i++)
            {
                if (vetor[i] == i)
                {
                    for (j = i + i; j <= v; j += i)
                    {
                        vetor[j] = 0;
                    }
                }
            }

            for (i = 1; i <= v; i++)
            {
                if (vetor[i] != 0)
                {
                    lboPrimo.Text = Convert.ToString(vetor[i]);
                    lboPrimo.Items.Add(lboPrimo.Text);
                }
            }
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            lboPrimo.Items.Clear();

            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
