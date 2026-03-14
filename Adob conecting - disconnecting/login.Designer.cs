namespace Adob_conecting___ofconnectin___nt
{
    partial class login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernaem_text = new TextBox();
            pass_text = new TextBox();
            Login_button = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            create_butt = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // usernaem_text
            // 
            usernaem_text.Location = new Point(100, 86);
            usernaem_text.Name = "usernaem_text";
            usernaem_text.Size = new Size(283, 23);
            usernaem_text.TabIndex = 0;
            // 
            // pass_text
            // 
            pass_text.Location = new Point(100, 137);
            pass_text.Name = "pass_text";
            pass_text.Size = new Size(283, 23);
            pass_text.TabIndex = 1;
            // 
            // Login_button
            // 
            Login_button.Location = new Point(162, 192);
            Login_button.Name = "Login_button";
            Login_button.Size = new Size(115, 25);
            Login_button.TabIndex = 2;
            Login_button.Text = "login";
            Login_button.UseVisualStyleBackColor = true;
            Login_button.Click += Login_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 89);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 3;
            label1.Text = "User Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(95, 34);
            label2.Name = "label2";
            label2.Size = new Size(295, 15);
            label2.TabIndex = 4;
            label2.Text = "Login form please insert your username and password ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 140);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(162, 12);
            label4.Name = "label4";
            label4.Size = new Size(134, 15);
            label4.TabIndex = 6;
            label4.Text = "HAPPY TO SEE U AGAIN";
            // 
            // create_butt
            // 
            create_butt.Location = new Point(486, 174);
            create_butt.Name = "create_butt";
            create_butt.Size = new Size(75, 23);
            create_butt.TabIndex = 7;
            create_butt.Text = "Create";
            create_butt.UseVisualStyleBackColor = true;
            create_butt.Click += create_butt_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 75);
            label5.Name = "label5";
            label5.Size = new Size(96, 15);
            label5.TabIndex = 8;
            label5.Text = "New supervisor ?";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(426, 111);
            label6.Name = "label6";
            label6.Size = new Size(208, 15);
            label6.TabIndex = 9;
            label6.Text = "Create your user name and  password ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(457, 126);
            label7.Name = "label7";
            label7.Size = new Size(150, 15);
            label7.TabIndex = 10;
            label7.Text = "to mange your department";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 273);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(create_butt);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Login_button);
            Controls.Add(pass_text);
            Controls.Add(usernaem_text);
            Name = "login";
            Text = "login";
            Load += login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernaem_text;
        private TextBox pass_text;
        private Button Login_button;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button create_butt;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}