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
    public partial class login : Form
    {
        SqlConnection conn;
        private NotifyIcon notify;

        public string super_name;
        public string super_ID;

        public login()
        {
            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");

            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;
            InitializeComponent();
        }

        private void Login_button_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from Student where Username=@UserName and PasswordHash=@Password", conn);
            cmd.Parameters.AddWithValue("@UserName", usernaem_text.Text);
            cmd.Parameters.AddWithValue("@Password", pass_text.Text);

            SqlCommand cmd2 = new SqlCommand("select St_Id,St_Fname from Student where Username=@UserName and PasswordHash=@Password", conn);
            cmd2.Parameters.AddWithValue("@UserName", usernaem_text.Text);
            cmd2.Parameters.AddWithValue("@Password", pass_text.Text);

            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                SqlDataReader dr2 = cmd2.ExecuteReader();
                dr2.Read();
                super_ID = dr2["St_Id"].ToString();
                super_name = dr2["St_Fname"].ToString();
                dr2.Close();

                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"Login successful!\n Wellocme {super_name}";


                //Form1 mainForm = new Form1(super_ID, super_name);              
                Form1 mainForm = new Form1(super_ID, super_name);
                mainForm.Show();
                this.Hide();
                notify.ShowBalloonTip(3000);


            }
            else
            {
                MessageBox.Show("Invalid username or password.");
                conn.Close();
            }
            conn.Close();

        }
        private void create_butt_Click(object sender, EventArgs e)
        {
            createaccount createform = new createaccount();
            createform.Owner = this;
            createform.Show();
            this.Hide();

        }
        private void label2_Click(object sender, EventArgs e) { }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
