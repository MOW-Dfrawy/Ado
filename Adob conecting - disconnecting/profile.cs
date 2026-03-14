using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Adob_conecting___ofconnectin___nt
{
    public partial class profile : Form
    {

        string profile_id;
        SqlConnection conn;
        private NotifyIcon notify;


        public profile(string id)
        {
            InitializeComponent();
            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;

            profile_id = id;
        }

        private void profile_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Student where St_Id=@St_Id", conn);
            cmd.Parameters.AddWithValue("@St_Id", int.Parse(profile_id));


            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                label1.Text = dr[1].ToString();
                label2.Text = dr[2].ToString();
                label3.Text = dr[3].ToString();
                label4.Text = dr[4].ToString();
                label5.Text = dr[5].ToString();
                label6.Text = dr[7].ToString();
                label7.Text = dr[8].ToString();

                pictureBox1.Image = Image.FromStream(new MemoryStream((byte[])dr[10]));




            }
            conn.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Images|*.jpg;*.png;*.jpeg;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            update_user_and_password update = new update_user_and_password(int.Parse(profile_id));
            update.ShowDialog();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageBytes = null;

            using (MemoryStream ms = new MemoryStream())
            {
                pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                imageBytes = ms.ToArray();
            }

            SqlCommand cmd = new SqlCommand("update Student set Student_Image=@Student_Image where St_Id=@St_Id", conn);
            cmd.Parameters.AddWithValue("@Student_Image", imageBytes);
            cmd.Parameters.AddWithValue("@St_Id", int.Parse(profile_id));

            conn.Open();
            cmd.ExecuteNonQuery();

            notify.BalloonTipTitle = "Success";
            notify.BalloonTipText = $"Updated!";
            notify.ShowBalloonTip(1000);

            conn.Close();



        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
