using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula20240515
{
    public partial class Form1 : Form
    {
        List<Item> lista;

        public Form1()
        {
            InitializeComponent();
            lista = new List<Item>();
            comboBox1.DisplayMember = "nome";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item aux = new Item(comboBox1.Items.Count + 1, 
                ("OPÇÃO " + (comboBox1.Items.Count + 1)).ToString());
            lista.Add(aux);
            comboBox1.Items.Add(aux);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = comboBox1.Items;
            dataGridView1.Refresh();

            //dataGridView1.Columns["id"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Item i = dataGridView1.SelectedRows[0].DataBoundItem as Item;
                MessageBox.Show("ITEM ("+i.id+" - "+i.nome+")");

            }
            catch {
                MessageBox.Show("ERRO");
            }
        }
    }
}
