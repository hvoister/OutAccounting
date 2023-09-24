using dataBaseConnection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OutAccounting
{
    public partial class tarifs : Form
    {
        public tarifs()
        {
            InitializeComponent();
            this.tarifsdata.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            if (current_user.level == 1)
            {
                workerpic.Visible = true;
                deletebutton.Visible = true;
                createbitton.Visible = true;
                deletbutton.Visible = false;
            }
            else
            {
                workerpic.Visible = false;
                deletebutton.Visible = false;
                createbitton.Visible = false;
                deletbutton.Visible = true;

                fulltarifs.Visible = true;
            }
        }

        private void tarifs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tarifs_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "accountingDataSet.Tarifs". При необходимости она может быть перемещена или удалена.
            this.tarifsTableAdapter.Fill(this.accountingDataSet.Tarifs);

        }

        private void delete_note_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите \nудалить данный тариф?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    tarifsBindingSource.RemoveCurrent();
                    tarifsTableAdapter.Update(accountingDataSet);
                    MessageBox.Show("Данные успешно удалены!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch
            {
                MessageBox.Show("Операция не была проведена! Нечего удалять.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            if (infopanel.Visible == true) 
            {
                authorization authorization = new authorization();
                authorization.Show();
                this.Hide();
            }
            else {infopanel.Visible = true; }
        }

        private void moveleft_Click(object sender, EventArgs e)
        {
            tarifsBindingSource.MovePrevious();
        }

        private void moveright_Click(object sender, EventArgs e)
        {
            tarifsBindingSource.MoveNext();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {
            infopanel.Visible = false;
        }

        private void fulltarifs_Click(object sender, EventArgs e)
        {
            infopanel.Visible = false;
        }
    }
}
