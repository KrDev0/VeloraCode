using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeloraCode
{
    public partial class FastTextBox : UserControl
    {
        public FastTextBox()
        {
            InitializeComponent();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextProce.Copy();
        }

        private void MenuEditor_Opening(object sender, CancelEventArgs e)
        {
            if (TextProce.SelectedText.Length > 0)
            {
                copiarToolStripMenuItem.Enabled = true;
                cortarToolStripMenuItem.Enabled = true;
            }
            else
            {
                cortarToolStripMenuItem.Enabled = false;
                copiarToolStripMenuItem.Enabled= false;
            }
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextProce.Cut();
        }

        private void pegarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextProce.Paste();
        }

        private void seleccionarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextProce.SelectAll();
        }

        private void insertarHoraYFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextProce.InsertText(DateTime.Now.ToString("hh:mm dd/mm/yyyy"));
        }
    }
}
