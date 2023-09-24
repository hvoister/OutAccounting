using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutAccounting
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                   comboBox2.Items.AddRange(new string[] { "Начальник отдела закупки", "Зам. начальника отдела закупки" });
                    break;
                case 1:
                    comboBox2.Items.AddRange(new string[] { "Начальник коммерческого отдела", "Зам. начальника коммерческого отдела" });
                    break;
                case 2:
                    comboBox2.Items.AddRange(new string[] { "Начальник отдела кадров", "Зам. начальника отдела кадров" });
                    break;
            }
        }
    }
}
