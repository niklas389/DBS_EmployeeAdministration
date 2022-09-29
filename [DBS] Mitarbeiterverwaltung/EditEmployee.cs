using System;
using System.Windows.Forms;

namespace _DBS__Mitarbeiterverwaltung
{
    public partial class EditEmployee : Form
    {
        public Employee emplData = new Employee();
        public EditEmployee(Employee emplData)
        {
            InitializeComponent();

            this.Text = "Edit Employee";
            loadEmployee(emplData);
        }

        private void loadEmployee (Employee x)
        {
            tBox_name.Text = x.Name;
            tBox_salary.Text = Convert.ToString(x.Salary);
            switch (x.Sex)
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
            cBox_covid.Checked = x.CovidSalary;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            emplData.Name = tBox_name.Text;
            emplData.Salary = Convert.ToDecimal(tBox_salary.Text);
            if (radBtn_male.Checked) { emplData.Sex = sex.male; }
            if (radBtn_female.Checked) { emplData.Sex = sex.female; }
            if (radBtn_other.Checked) { emplData.Sex = sex.other; }
            emplData.CovidSalary = cBox_covid.Checked;

            this.DialogResult = DialogResult.OK;
        }
    }
}
