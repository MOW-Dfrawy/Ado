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
    public partial class Disconnected_mode : Form
    {
        SqlConnection conn;

        DataTable dt;

        private NotifyIcon notify;

        public string super_id;

        int id;
        public Disconnected_mode(string id, string SuperName)
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
        void displayadd(bool status)
        {
            button1.Visible = status;
            button2.Visible = !status;
            button3.Visible = !status;
        }

        private void Disconnected_mode_Load(object sender, EventArgs e)
        {
            SqlCommand selectcmd = new SqlCommand("select * from department", conn);
            SqlDataAdapter adpter = new SqlDataAdapter(selectcmd);

            dt = new DataTable();
            adpter.Fill(dt);


            DGV_students.DataSource = dt;

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
        private void button1_Click_1(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow();
            dr["Dept_Id"] = txt_id.Text;
            dr["Dept_Name"] = txt_name.Text;
            dr["Dept_Desc"] = txt_Desc.Text;
            dr["Dept_Location"] = txt_loc.Text;
            dr["Dept_Manager"] = txt_manger.Text;
            dr["Manager_hiredate"] = dateTimePicker1.Value;


            dt.Rows.Add(dr);

            txt_id.Text = txt_loc.Text = txt_name.Text = txt_Desc.Text = txt_manger.Text = "";
            MessageBox.Show("added");
        }
        private void button4_Click(object sender, EventArgs e)
        {

            SqlCommand insertcmd = new SqlCommand("insert into department values (@Dept_Id, @Dept_Name,@Dept_Desc,@Dept_Location,@Dept_Manager,@Manager_hiredate)", conn);

            insertcmd.Parameters.Add("@Dept_Id", SqlDbType.Int, 4, "Dept_Id");
            insertcmd.Parameters.Add("@Dept_Name", SqlDbType.NVarChar, 50, "Dept_Name");
            insertcmd.Parameters.Add("@Dept_Desc", SqlDbType.NVarChar, 150, "Dept_Desc");
            insertcmd.Parameters.Add("@Dept_Location", SqlDbType.NVarChar, 150, "Dept_Location");
            insertcmd.Parameters.Add("@Dept_Manager", SqlDbType.Int, 4, "Dept_Manager");
            insertcmd.Parameters.Add("@Manager_hiredate", SqlDbType.Date, 50, "Manager_hiredate");

            SqlCommand updatecmd = new SqlCommand("update department set Dept_Name=@Dept_Name, Dept_Desc=@Dept_Desc, Dept_Location=@Dept_Location, Dept_Manager=@Dept_Manager, Manager_hiredate=@Manager_hiredate where Dept_Id=@Dept_Id", conn);

            updatecmd.Parameters.Add("@Dept_Name", SqlDbType.NVarChar, 50, "Dept_Name");
            updatecmd.Parameters.Add("@Dept_Desc", SqlDbType.NVarChar, 150, "Dept_Desc");
            updatecmd.Parameters.Add("@Dept_Location", SqlDbType.NVarChar, 150, "Dept_Location");
            updatecmd.Parameters.Add("@Dept_Manager", SqlDbType.Int, 4, "Dept_Manager");
            updatecmd.Parameters.Add("@Manager_hiredate", SqlDbType.Date, 50, "Manager_hiredate");
            updatecmd.Parameters.Add("@Dept_Id", SqlDbType.Int, 4, "Dept_Id");


            SqlCommand deletecmd = new SqlCommand("delete from department where Dept_Id=@Dept_Id", conn);

            deletecmd.Parameters.Add("@Dept_Id", SqlDbType.Int, 4, "Dept_Id");

            SqlDataAdapter adpter = new SqlDataAdapter();

            adpter.InsertCommand = insertcmd;
            adpter.UpdateCommand = updatecmd;
            adpter.DeleteCommand = deletecmd;

            adpter.Update(dt);

            MessageBox.Show("Database Updated Successfully");
        }
        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void DGV_students_RowHeaderMouseClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {

            DataGridViewRow row = DGV_students.Rows[e.RowIndex];

            txt_id.Text = row.Cells["Dept_Id"].Value.ToString();
            txt_name.Text = row.Cells["Dept_Name"].Value.ToString();
            txt_Desc.Text = row.Cells["Dept_Desc"].Value.ToString();
            txt_loc.Text = row.Cells["Dept_Location"].Value.ToString();
            txt_manger.Text = row.Cells["Dept_Manager"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(row.Cells["Manager_hiredate"].Value);

            displayadd(false);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            if (DGV_students.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGV_students.SelectedRows[0];

                row.Cells["Dept_Name"].Value = txt_name.Text;
                row.Cells["Dept_Desc"].Value = txt_Desc.Text;
                row.Cells["Dept_Location"].Value = txt_loc.Text;
                row.Cells["Dept_Manager"].Value = txt_manger.Text;
                row.Cells["Manager_hiredate"].Value = dateTimePicker1.Value;

                txt_name.Text = txt_Desc.Text = txt_loc.Text = txt_manger.Text = "";
                MessageBox.Show("Updated in DataTable");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DGV_students.SelectedRows.Count > 0)
            {
                DGV_students.Rows.RemoveAt(DGV_students.SelectedRows[0].Index);
                MessageBox.Show("Deleted from DataTable");
            }
        }

        private void Disconnected_mode_Click(object sender, EventArgs e)
        {
            displayadd(true);

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            profile profile = new profile( super_id);
            profile.ShowDialog();
            Disconnected_mode_Load(null, null);
        }
    }
}
