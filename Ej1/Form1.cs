using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1
{
    public partial class Form1 : Form
    {

        Libreria libreria = new Libreria();
        Venta objVenta;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (
               string.IsNullOrWhiteSpace(textBox1.Text) ||
               string.IsNullOrWhiteSpace(textBox2.Text) ||
               string.IsNullOrWhiteSpace(textBox3.Text)
               )
            {
                MessageBox.Show("Complete los campos");
            } else
            {
                Articulo art = new Articulo();
                art.codigo_barra = textBox1.Text;
                art.descripcion = textBox2.Text;
                art.precio = float.Parse(textBox3.Text);
                listBox1.Items.Add(art);

            }

            /*objArticulo = new Articulo();
            objArticulo.codigo_barra = textBox1.Text;
            objArticulo.precio = float.Parse(textBox3.Text);
            objArticulo.descripcion = textBox2.Text;

            listBox1.Items.Add(objArticulo);
            */
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            Articulo art = (Articulo)listBox1.SelectedItem;

            label8.Text = art.codigo_barra;
            label9.Text = art.descripcion;
            label10.Text = art.precio.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(textBox4.Text);
            Articulo art = (Articulo)listBox1.SelectedItem;

            objVenta.Vender(art, cantidad);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(objVenta != null)
            {
                MessageBox.Show("Ya tiene una venta iniciada");
            } else
            {
                objVenta = new Venta();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (objVenta == null)
            {
                MessageBox.Show("Inicie una venta");
            }
            else
            {
                libreria.procesarVenta(objVenta);
                objVenta = null;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label5.Text = libreria.cantidadArticulosVendidos.ToString();
            label6.Text = libreria.totalCash.ToString();
            label7.Text = libreria.totalSell.ToString();

        }
    }
}
