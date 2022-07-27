using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryCards
{
    public partial class FormMemory : Form
    {
        public FormMemory()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menu_game_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_help_rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "dumai sam");
        }

        private void menu_help_about_Click(object sender, EventArgs e)
        {
            DialogResult dr = 
            MessageBox.Show("privet","poka", MessageBoxButtons.OKCancel);
            if (dr == System.Windows.Forms.DialogResult.Cancel)
                Close();
                    

        }

        
    }
}
