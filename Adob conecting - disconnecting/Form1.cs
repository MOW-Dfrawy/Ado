using Microsoft.Data.SqlClient;
using System.Data;

namespace Adob_conecting___ofconnectin___nt
{

    public partial class Form1 : Form
    {
        SqlConnection conn;

        private NotifyIcon notify;

        public string super_id;

        int id;


        public Form1(string id, string SuperName)
        {
            InitializeComponent();

            super_name_lable.Text = SuperName;
            super_id = id;

            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;

            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
            displayadd(true);


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select St_Id,St_Fname,St_Lname,St_Address,St_Age,Dept_Id,St_super from Student", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGV_students.DataSource = dt;
            dr.Close();

            /*******************Combo box *********************/

            SqlCommand cmd2 = new SqlCommand("select Dept_Id,Dept_Name from Department", conn);


            SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            debt_CB.DataSource = dt2;
            debt_CB.DisplayMember = "Dept_Name";
            debt_CB.ValueMember = "Dept_Id";
            conn.Close();

            /******************* profile-photo *********************/

            SqlCommand cmd3 = new SqlCommand("select Student_Image from Student where St_Id=@id", conn);

            cmd3.Parameters.AddWithValue("@id", super_id);

            conn.Open();
            byte[] img = (byte[])cmd3.ExecuteScalar();
            conn.Close();

            if (img != null)
            {
                MemoryStream ms = new MemoryStream(img);
                pictureBox1.Image = Image.FromStream(ms);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            /******************* dateTimePicker *********************/

            DateTime birthDate = dateTimePicker1.Value;

            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }

            SqlCommand cmd = new SqlCommand("insert into Student(St_Fname,St_Lname,St_Address,St_Age,Dept_Id,St_super) values(@St_Fname,@St_Lname,@St_Address,@St_Age,@Dept_Id,@St_super)", conn);
            cmd.Parameters.AddWithValue("@St_Fname", F_name_textbox.Text);
            cmd.Parameters.AddWithValue("@St_Lname", L_name_textbox.Text);
            cmd.Parameters.AddWithValue("@St_Address", Address_textbox.Text);
            cmd.Parameters.AddWithValue("@St_Age", age);
            cmd.Parameters.AddWithValue("@Dept_Id", debt_CB.SelectedValue);
            cmd.Parameters.AddWithValue("@St_super", int.Parse(super_id));

            conn.Open();

            int roweffect = cmd.ExecuteNonQuery();

            conn.Close();
            if (roweffect > 0)
            {
                F_name_textbox.Text = L_name_textbox.Text = Address_textbox.Text = "";
                Form1_Load(null, null);

                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"add!";
                notify.ShowBalloonTip(1000);

            }
        }

        private void DGV_students_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id = (int)DGV_students.SelectedRows[0].Cells[0].Value;
            SqlCommand cmd = new SqlCommand("select * from Student where St_Id =@St_Id", conn);
            cmd.Parameters.AddWithValue("@St_Id", id);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            dr.Read();
            F_name_textbox.Text = dr[1].ToString();
            L_name_textbox.Text = dr[2].ToString();
            Address_textbox.Text = dr[3].ToString();
            dateTimePicker1.Value = DateTime.Now.AddYears(-int.Parse(dr[4].ToString()));
            debt_CB.SelectedValue = dr[5];

            conn.Close();
            displayadd(false);

        }
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime birthDate = dateTimePicker1.Value;

            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }

            SqlCommand cmd = new SqlCommand("update Student set St_Fname=@St_Fname,St_Lname=@St_Lname ,St_Address=@St_Address,St_Age=@St_Age ,Dept_Id=@Dept_Id,St_super=@St_super where St_Id=@St_Id", conn);
            cmd.Parameters.AddWithValue("@St_Fname", F_name_textbox.Text);
            cmd.Parameters.AddWithValue("@St_Lname", L_name_textbox.Text);
            cmd.Parameters.AddWithValue("@St_Address", Address_textbox.Text);
            cmd.Parameters.AddWithValue("@St_Age", age);
            cmd.Parameters.AddWithValue("@Dept_Id", debt_CB.SelectedValue);
            cmd.Parameters.AddWithValue("@St_super", int.Parse(super_id));
            cmd.Parameters.AddWithValue("@St_Id", id);

            conn.Open();

            int roweffect = cmd.ExecuteNonQuery();

            conn.Close();
            if (roweffect > 0)
            {
                F_name_textbox.Text = L_name_textbox.Text = Address_textbox.Text = "";
                Form1_Load(null, null);
                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"Updated!";
                notify.ShowBalloonTip(1000);

            }
            displayadd(true);


        }
        private void button3_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("are you sure to delete this student?", "confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("delete from student where St_Id =@St_Id", conn);
                cmd.Parameters.AddWithValue("@St_Id", id);
                conn.Open();
                int roweffect = cmd.ExecuteNonQuery();
                conn.Close();

                if (roweffect > 0)
                {
                    F_name_textbox.Text = L_name_textbox.Text = Address_textbox.Text = "";
                    Form1_Load(null, null);

                    notify.BalloonTipTitle = "Success";
                    notify.BalloonTipText = $"deleted!";
                    notify.ShowBalloonTip(1000);

                }
            }
            displayadd(true);

        }
        private void Form1_Click(object sender, EventArgs e)
        {
            displayadd(true);

        }
        void displayadd(bool status)
        {
            button1.Visible = status;
            button2.Visible = !status;
            button3.Visible = !status;
        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Disconnected_mode department_form = new Disconnected_mode(super_id, super_name_lable.Text);
            department_form.Show();

        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            profile profile = new profile(super_id);
            profile.ShowDialog();
            Form1_Load(null, null);



        }
        private void button3_Click_1(object sender, EventArgs e)
        {


        }
        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void DGV_students_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV_students_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }


    }
}


