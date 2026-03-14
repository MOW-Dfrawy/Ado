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
    public partial class update_user_and_password : Form
    {
        SqlConnection conn;
        private NotifyIcon notify;
        int id;

        public update_user_and_password(int id )
        {
            InitializeComponent();
            this.id = id;

            notify = new NotifyIcon();
            notify.Icon = SystemIcons.Information;
            notify.Visible = true;

            conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=ITI;Integrated Security=True;Trust Server Certificate=True");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update Student set Username=@Username,PasswordHash=@PasswordHash where St_Id=@St_Id", conn);
            cmd.Parameters.AddWithValue("@Username", textBox1.Text);
            cmd.Parameters.AddWithValue("@PasswordHash", textBox2.Text);

            cmd.Parameters.AddWithValue("@St_Id", id);

            conn.Open();

            int roweffect = cmd.ExecuteNonQuery();

            conn.Close();
            if (roweffect > 0)
            {
                notify.BalloonTipTitle = "Success";
                notify.BalloonTipText = $"Updated!";
                this.Close();
                notify.ShowBalloonTip(1000);

            }
        }
    }
}
