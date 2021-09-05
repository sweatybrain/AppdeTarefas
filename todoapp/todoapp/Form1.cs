using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todoapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            dgv.Rows.Add(tbTipo.Text, tbData.Text, tbTarefa.Text, tbPrazo.Text);
            tbTipo.Clear(); tbData.Clear(); tbTarefa.Clear(); tbPrazo.Clear();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.CurrentRow.Cells["tipo"].Value = tbTipo.Text;
                dgv.CurrentRow.Cells["data"].Value = tbData.Text;
                dgv.CurrentRow.Cells["tarefa"].Value = tbTarefa.Text;
                dgv.CurrentRow.Cells["prazo"].Value = tbPrazo.Text;
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            }
        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                tbTipo.Text = dgv.CurrentRow.Cells["tipo"].Value.ToString();
                tbData.Text = dgv.CurrentRow.Cells["data"].Value.ToString();
                tbTarefa.Text = dgv.CurrentRow.Cells["tarefa"].Value.ToString();
                tbPrazo.Text = dgv.CurrentRow.Cells["prazo"].Value.ToString();
            }
        }
    }
}
