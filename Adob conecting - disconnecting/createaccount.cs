using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Adob_conecting___ofconnectin___nt
{
    public partial class createaccount : Form
    {
        SqlConnection conn;

        int id;
        private NotifyIcon notify;


        public createaccount()
        {
            InitializeComponent();
            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;
            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

        }

        private void createaccount_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select St_Id,St_Fname,St_Lname from Student", conn);
            //SqlCommand cmd2 = new SqlCommand("select St_Id,St_Fname,St_Lname,St_Address,St_Age,Dept_Id,St_super from Student", conn);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            //SqlDataReader dr2 = cmd2.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            DGV_students.DataSource = dt;
            dr.Close();



            SqlCommand cmd3 = new SqlCommand("select Dept_Id,Dept_Name from Department", conn);


            SqlDataReader dr2 = cmd3.ExecuteReader();
            DataTable dt2 = new DataTable();
            dt2.Load(dr2);

            debt_CB.DataSource = dt2;
            debt_CB.DisplayMember = "Dept_Name";
            debt_CB.ValueMember = "Dept_Id";
            conn.Close();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {

            byte[] imageBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                imageBytes = ms.ToArray();
            }

            DateTime birthDate = dateTimePicker1.Value;

            int age = DateTime.Now.Year - birthDate.Year;

            if (DateTime.Now.DayOfYear < birthDate.DayOfYear)
            {
                age--;
            }
            SqlCommand cmd;
            if (id == 0)
            {
                 cmd = new SqlCommand("insert into Student(St_Fname,St_Lname,St_Address,St_Age,Dept_Id,Username,PasswordHash,Student_Image) values(@St_Fname,@St_Lname,@St_Address,@St_Age,@Dept_Id,@Username,@PasswordHash,@Student_Image)", conn);
                cmd.Parameters.AddWithValue("@St_Fname", F_name_textbox.Text);
                cmd.Parameters.AddWithValue("@St_Lname", L_name_textbox.Text);
                cmd.Parameters.AddWithValue("@St_Address", Address_textbox.Text);
                cmd.Parameters.AddWithValue("@St_Age", age);
                cmd.Parameters.AddWithValue("@Dept_Id", debt_CB.SelectedValue);
                //cmd.Parameters.AddWithValue("@St_super", "NULL");
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", textBox2.Text);
                cmd.Parameters.AddWithValue("@Student_Image", imageBytes);
            }
            else
            {

                 cmd = new SqlCommand("update Student set St_Fname=@St_Fname,St_Lname=@St_Lname ,St_Address=@St_Address,St_Age=@St_Age ,Dept_Id=@Dept_Id,Username=@Username,PasswordHash=@PasswordHash,Student_Image=@Student_Image where St_Id=@St_Id", conn);
                cmd.Parameters.AddWithValue("@St_Fname", F_name_textbox.Text);
                cmd.Parameters.AddWithValue("@St_Lname", L_name_textbox.Text);
                cmd.Parameters.AddWithValue("@St_Address", Address_textbox.Text);
                cmd.Parameters.AddWithValue("@St_Age", age);
                cmd.Parameters.AddWithValue("@Dept_Id", debt_CB.SelectedValue);
                cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                cmd.Parameters.AddWithValue("@PasswordHash", textBox2.Text);
                cmd.Parameters.AddWithValue("@Student_Image", imageBytes);

                cmd.Parameters.AddWithValue("@St_Id", id);

            }

            conn.Open();

            int roweffect = cmd.ExecuteNonQuery();

            conn.Close();
            if (roweffect > 0)
            {

                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"created!";
                notify.ShowBalloonTip(1000);

            }

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }


    }
}
