namespace NTier_method
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
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            Address_textbox = new TextBox();
            L_name_textbox = new TextBox();
            F_name_textbox = new TextBox();
            label1 = new Label();
            debt_CB = new ComboBox();
            DGV_students = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)DGV_students).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(776, 419);
            button3.Name = "button3";
            button3.Size = new Size(212, 40);
            button3.TabIndex = 34;
            button3.Text = "delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(776, 338);
            button2.Name = "button2";
            button2.Size = new Size(212, 40);
            button2.TabIndex = 33;
            button2.Text = "update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(776, 264);
            button1.Name = "button1";
            button1.Size = new Size(212, 40);
            button1.TabIndex = 32;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(354, 67);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 31;
            label5.Text = "date of birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 67);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 30;
            label4.Text = "Full Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 5);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 29;
            label3.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 5);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 28;
            label2.Text = "First Name";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(354, 85);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 27;
            // 
            // Address_textbox
            // 
            Address_textbox.Location = new Point(59, 85);
            Address_textbox.Name = "Address_textbox";
            Address_textbox.Size = new Size(253, 23);
            Address_textbox.TabIndex = 26;
            // 
            // L_name_textbox
            // 
            L_name_textbox.Location = new Point(197, 29);
            L_name_textbox.Name = "L_name_textbox";
            L_name_textbox.Size = new Size(100, 23);
            L_name_textbox.TabIndex = 25;
            // 
            // F_name_textbox
            // 
            F_name_textbox.Location = new Point(59, 29);
            F_name_textbox.Name = "F_name_textbox";
            F_name_textbox.Size = new Size(100, 23);
            F_name_textbox.TabIndex = 24;
            F_name_textbox.TextChanged += F_name_textbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(615, 88);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.TabIndex = 23;
            label1.Text = "Departments";
            // 
            // debt_CB
            // 
            debt_CB.FormattingEnabled = true;
            debt_CB.Location = new Point(705, 85);
            debt_CB.Name = "debt_CB";
            debt_CB.Size = new Size(121, 23);
            debt_CB.TabIndex = 22;
            debt_CB.SelectedIndexChanged += debt_CB_SelectedIndexChanged;
            // 
            // DGV_students
            // 
            DGV_students.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGV_students.Location = new Point(-2, 219);
            DGV_students.Name = "DGV_students";
            DGV_students.Size = new Size(762, 320);
            DGV_students.TabIndex = 21;
            DGV_students.RowHeaderMouseClick += DGV_students_RowHeaderMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1071, 540);
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
            MouseClick += Form1_MouseClick;
            ((System.ComponentModel.ISupportInitialize)DGV_students).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private TextBox Address_textbox;
        private TextBox L_name_textbox;
        private TextBox F_name_textbox;
        private Label label1;
        private ComboBox debt_CB;
        private DataGridView DGV_students;
    }
}
