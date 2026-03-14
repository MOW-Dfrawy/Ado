using Microsoft.Data.SqlClient;
using NTier_method.Model;
using System.Data;

namespace NTier_method
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        private NotifyIcon notify;

        public Form1()
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;

            displayadd(true);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV_students.DataSource = studentBussLayer.getall();
            debt_CB.DataSource = departmentBussLayere.getall();
            debt_CB.DisplayMember = "Dept_Name";
            debt_CB.ValueMember = "Dept_Id";

        }

        int id;


        private void DGV_students_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)DGV_students.SelectedRows[0].Cells[0].Value;

            DataTable dt = studentBussLayer.getbyid(id);
            F_name_textbox.Text = dt.Rows[0]["St_Fname"].ToString();
            L_name_textbox.Text = dt.Rows[0]["St_Lname"].ToString(); ;
            Address_textbox.Text = dt.Rows[0]["St_Address"].ToString();
            dateTimePicker1.Value = DateTime.Now.AddYears(-int.Parse(dt.Rows[0]["St_Age"].ToString()));
            debt_CB.SelectedValue = dt.Rows[0]["Dept_Id"];

            displayadd(false);



        }
        private void F_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DateTime birthDate = dateTimePicker1.Value;

            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }
            int debt_CB_V = (int)debt_CB.SelectedValue;

            int roweffect = studentBussLayer.add(F_name_textbox.Text, L_name_textbox.Text, age, Address_textbox.Text, debt_CB_V);
            if (roweffect > 0)
            {
                F_name_textbox.Text = L_name_textbox.Text = Address_textbox.Text = "";
                Form1_Load(null, null);

                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"add!";
                notify.ShowBalloonTip(1000);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DateTime birthDate = dateTimePicker1.Value;

            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }

            int roweffect = studentBussLayer.update(id, F_name_textbox.Text, L_name_textbox.Text, age, Address_textbox.Text, (int)debt_CB.SelectedValue);
            if (roweffect > 0)
            {
                F_name_textbox.Text = L_name_textbox.Text = Address_textbox.Text = "";
                Form1_Load(null, null);
                displayadd(true);

                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"updated!";
                notify.ShowBalloonTip(1000);
            }

        }
        void displayadd(bool status)
        {
            button1.Visible = status;
            button2.Visible = !status;
            button3.Visible = !status;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                int roweffect = studentBussLayer.remove(id);
                if (roweffect > 0)
                {
                    F_name_textbox.Text = L_name_textbox.Text = Address_textbox.Text = "";
                    Form1_Load(null, null);
                    displayadd(true);
                    notify.BalloonTipTitle = "Success";
                    notify.BalloonTipText = $"deleted!";
                    notify.ShowBalloonTip(1000);
                }

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            displayadd(true);
        }

        private void debt_CB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
