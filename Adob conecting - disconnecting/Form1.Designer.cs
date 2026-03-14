namespace Adob_conecting___ofconnectin___nt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGV_students = new DataGridView();
            debt_CB = new ComboBox();
            label1 = new Label();
            F_name_textbox = new TextBox();
            L_name_textbox = new TextBox();
            Address_textbox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label7 = new Label();
            super_name_lable = new Label();
            pictureBox1 = new PictureBox();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)DGV_students).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // DGV_students
            // 
            DGV_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_students.Location = new Point(0, 226);
            DGV_students.Name = "DGV_students";
            DGV_students.Size = new Size(762, 320);
            DGV_students.TabIndex = 0;
            DGV_students.CellDoubleClick += DGV_students_CellDoubleClick;
            DGV_students.RowHeaderMouseClick += DGV_students_RowHeaderMouseClick;
            DGV_students.MouseDoubleClick += DGV_students_MouseDoubleClick;
            // 
            // debt_CB
            // 
            debt_CB.FormattingEnabled = true;
            debt_CB.Location = new Point(707, 89);
            debt_CB.Name = "debt_CB";
            debt_CB.Size = new Size(121, 23);
            debt_CB.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(617, 92);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 2;
            label1.Text = "Departments";
            label1.Click += label1_Click;
            // 
            // F_name_textbox
            // 
            F_name_textbox.Location = new Point(61, 33);
            F_name_textbox.Name = "F_name_textbox";
            F_name_textbox.Size = new Size(100, 23);
            F_name_textbox.TabIndex = 3;
            F_name_textbox.TextChanged += textBox1_TextChanged;
            // 
            // L_name_textbox
            // 
            L_name_textbox.Location = new Point(199, 33);
            L_name_textbox.Name = "L_name_textbox";
            L_name_textbox.Size = new Size(100, 23);
            L_name_textbox.TabIndex = 4;
            // 
            // Address_textbox
            // 
            Address_textbox.Location = new Point(61, 89);
            Address_textbox.Name = "Address_textbox";
            Address_textbox.Size = new Size(253, 23);
            Address_textbox.TabIndex = 5;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(356, 89);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 9);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 7;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(210, 9);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 8;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 71);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 9;
            label4.Text = "Full Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(356, 71);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 10;
            label5.Text = "date of birth";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.Location = new Point(778, 268);
            button1.Name = "button1";
            button1.Size = new Size(212, 40);
            button1.TabIndex = 13;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(778, 342);
            button2.Name = "button2";
            button2.Size = new Size(212, 40);
            button2.TabIndex = 14;
            button2.Text = "update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(778, 423);
            button3.Name = "button3";
            button3.Size = new Size(212, 40);
            button3.TabIndex = 15;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(784, 23);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 16;
            label7.Text = "Wellcome ";
            // 
            // super_name_lable
            // 
            super_name_lable.AutoSize = true;
            super_name_lable.Location = new Point(853, 23);
            super_name_lable.Name = "super_name_lable";
            super_name_lable.Size = new Size(71, 15);
            super_name_lable.TabIndex = 17;
            super_name_lable.Text = "super_name";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(930, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 38);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(939, 53);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(41, 15);
            linkLabel1.TabIndex = 19;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Profile";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(877, 71);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(114, 15);
            linkLabel2.TabIndex = 20;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Mange departments";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 550);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(super_name_lable);
            Controls.Add(label7);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(Address_textbox);
            Controls.Add(L_name_textbox);
            Controls.Add(F_name_textbox);
            Controls.Add(label1);
            Controls.Add(debt_CB);
            Controls.Add(DGV_students);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)DGV_students).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGV_students;
        private ComboBox debt_CB;
        private Label label1;
        private TextBox F_name_textbox;
        private TextBox L_name_textbox;
        private TextBox Address_textbox;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label7;
        private Label super_name_lable;
        private PictureBox pictureBox1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
    }
}
