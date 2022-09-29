using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace _DBS__Mitarbeiterverwaltung
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Text = "Employee List";
        }

        List<Employee> EmplList = new List<Employee>();
        private void btn_save_Click(object sender, EventArgs e)
        {
            Employee m = new Employee();
            m.Name = tBox_name.Text;
            try
            {
                m.Salary = Convert.ToDecimal(tBox_salary.Text.Replace(".", ","));
            }
            catch (Exception)
            {
                MessageBox.Show("Nur Zahlen im Feld >Gehalt< erlaubt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (radBtn_male.Checked) { m.Sex = sex.male; }
            if (radBtn_female.Checked) { m.Sex = sex.female; }
            if (radBtn_other.Checked) { m.Sex = sex.other; }

            m.CovidSalary = cBox_covid.Checked;

            EmplList.Add(m);
            fillListBox(m);
            tBox_name.Focus();
        }

        private void fillListBox(Employee x)
        {
            ListViewItem item = new ListViewItem(x.Name);
            item.SubItems.Add(Convert.ToString(x.Salary) + "€");
            item.SubItems.Add(Convert.ToString(x.Sex));
            item.SubItems.Add(Convert.ToString(x.CovidSalary));

            listView1.Items.Add(item);

            clearInput();
        }

        private void clearInput()
        {
            tBox_name.Text = "";
            tBox_salary.Text = "";

            foreach (RadioButton radioButton in groupBox2.Controls)
            {
                radioButton.Checked = false;
            }

            cBox_covid.Checked = false;
        }

        private void updateUserList(List<Employee> list)
        {
            listView1.Items.Clear();
            foreach (var employee in list)
            {
                fillListBox(employee);
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
            {
                btn_edit.Enabled = true;
                btn_deleteItem.Enabled = true;
            }
            else
            { 
                btn_edit.Enabled = false;
                btn_deleteItem.Enabled = false;
            }

            tBox_name.Text = EmplList[listView1.FocusedItem.Index].Name;
            tBox_salary.Text = Convert.ToString(EmplList[listView1.FocusedItem.Index].Salary);
            switch (EmplList[listView1.FocusedItem.Index].Sex)
            {
                case sex.male:
                    radBtn_male.Checked = true;
                    break;
                case sex.female:
                    radBtn_female.Checked = true;
                    break;
                case sex.other:
                    radBtn_other.Checked = true;
                    break;
                default:
                    break;
            }
            cBox_covid.Checked = EmplList[listView1.FocusedItem.Index].CovidSalary;
        }

        private void btn_ClearInput_Click(object sender, EventArgs e)
        {
            clearInput();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            EditEmployee frmEdit = new EditEmployee(EmplList[listView1.FocusedItem.Index]);
            frmEdit.StartPosition = FormStartPosition.CenterParent;

            // Show testDialog as a modal dialog and determine if DialogResult = OK.
            if (frmEdit.ShowDialog(this) == DialogResult.OK)
            {
                EmplList.RemoveAt(listView1.FocusedItem.Index);
                EmplList.Insert(listView1.FocusedItem.Index, frmEdit.emplData);
                updateUserList(EmplList);
            }
            else
            {
                MessageBox.Show("Nothing was changed.");
            }
            frmEdit.Dispose();
        }

        private void btn_deleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("You sure 'bout that?", "Remove Item", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                listView1.SelectedIndices.Clear();
                EmplList.RemoveAt(listView1.FocusedItem.Index);
                if (listView1.Items.Count > 0) { listView1.FocusedItem.Remove(); } 
            }
        }
    }
}
