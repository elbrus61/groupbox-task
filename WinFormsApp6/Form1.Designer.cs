namespace WinFormsApp6
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
            groupBox1 = new GroupBox();
            listuni = new ListBox();
            uni = new Label();
            checkjava = new CheckBox();
            checkpython = new CheckBox();
            checkc = new CheckBox();
            label1 = new Label();
            check = new Button();
            checkrus = new CheckBox();
            checkeng = new CheckBox();
            checkturk = new CheckBox();
            label4 = new Label();
            country = new Label();
            comboCountry = new ComboBox();
            listcity = new ListBox();
            city = new Label();
            gender = new Label();
            other = new RadioButton();
            female = new RadioButton();
            male = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaption;
            groupBox1.Controls.Add(listuni);
            groupBox1.Controls.Add(uni);
            groupBox1.Controls.Add(checkjava);
            groupBox1.Controls.Add(checkpython);
            groupBox1.Controls.Add(checkc);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(check);
            groupBox1.Controls.Add(checkrus);
            groupBox1.Controls.Add(checkeng);
            groupBox1.Controls.Add(checkturk);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(country);
            groupBox1.Controls.Add(comboCountry);
            groupBox1.Controls.Add(listcity);
            groupBox1.Controls.Add(city);
            groupBox1.Controls.Add(gender);
            groupBox1.Controls.Add(other);
            groupBox1.Controls.Add(female);
            groupBox1.Controls.Add(male);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(46, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(721, 338);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personal Information";
            // 
            // listuni
            // 
            listuni.FormattingEnabled = true;
            listuni.ItemHeight = 20;
            listuni.Items.AddRange(new object[] { "BMU ", "ADNSU", "UNEC", "ADU", "AZMIU" });
            listuni.Location = new Point(189, 218);
            listuni.Name = "listuni";
            listuni.Size = new Size(139, 64);
            listuni.TabIndex = 18;
            // 
            // uni
            // 
            uni.AutoSize = true;
            uni.BackColor = Color.FromArgb(255, 255, 192);
            uni.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            uni.Location = new Point(211, 180);
            uni.Name = "uni";
            uni.Size = new Size(87, 20);
            uni.TabIndex = 17;
            uni.Text = "University";
            // 
            // checkjava
            // 
            checkjava.AutoSize = true;
            checkjava.BackColor = Color.FromArgb(128, 255, 128);
            checkjava.Location = new Point(580, 262);
            checkjava.Name = "checkjava";
            checkjava.Size = new Size(60, 24);
            checkjava.TabIndex = 16;
            checkjava.Text = "java";
            checkjava.UseVisualStyleBackColor = false;
            // 
            // checkpython
            // 
            checkpython.AutoSize = true;
            checkpython.BackColor = Color.FromArgb(128, 255, 128);
            checkpython.Location = new Point(469, 262);
            checkpython.Name = "checkpython";
            checkpython.Size = new Size(82, 24);
            checkpython.TabIndex = 15;
            checkpython.Text = "python";
            checkpython.UseVisualStyleBackColor = false;
            // 
            // checkc
            // 
            checkc.AutoSize = true;
            checkc.BackColor = Color.FromArgb(128, 255, 128);
            checkc.Location = new Point(394, 262);
            checkc.Name = "checkc";
            checkc.Size = new Size(47, 24);
            checkc.TabIndex = 14;
            checkc.Text = "c#";
            checkc.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(255, 255, 192);
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(394, 218);
            label1.Name = "label1";
            label1.Size = new Size(208, 20);
            label1.TabIndex = 13;
            label1.Text = "Programming Languages";
            // 
            // check
            // 
            check.BackColor = Color.FromArgb(255, 255, 128);
            check.Cursor = Cursors.Hand;
            check.Location = new Point(640, 303);
            check.Name = "check";
            check.Size = new Size(75, 29);
            check.TabIndex = 12;
            check.Text = "check";
            check.UseVisualStyleBackColor = false;
            check.Click += button1_Click;
            // 
            // checkrus
            // 
            checkrus.AutoSize = true;
            checkrus.BackColor = Color.FromArgb(128, 255, 128);
            checkrus.Location = new Point(573, 176);
            checkrus.Name = "checkrus";
            checkrus.Size = new Size(93, 24);
            checkrus.TabIndex = 11;
            checkrus.Text = "Russian";
            checkrus.UseVisualStyleBackColor = false;
            // 
            // checkeng
            // 
            checkeng.AutoSize = true;
            checkeng.BackColor = Color.FromArgb(128, 255, 128);
            checkeng.Location = new Point(469, 175);
            checkeng.Name = "checkeng";
            checkeng.Size = new Size(87, 24);
            checkeng.TabIndex = 10;
            checkeng.Text = "English";
            checkeng.UseVisualStyleBackColor = false;
            // 
            // checkturk
            // 
            checkturk.AutoSize = true;
            checkturk.BackColor = Color.FromArgb(128, 255, 128);
            checkturk.Location = new Point(377, 175);
            checkturk.Name = "checkturk";
            checkturk.Size = new Size(86, 24);
            checkturk.TabIndex = 9;
            checkturk.Text = "Turkish";
            checkturk.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(255, 255, 192);
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(436, 134);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 8;
            label4.Text = "Languages";
            // 
            // country
            // 
            country.AutoSize = true;
            country.BackColor = Color.FromArgb(255, 255, 192);
            country.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            country.Location = new Point(450, 55);
            country.Name = "country";
            country.Size = new Size(71, 20);
            country.TabIndex = 7;
            country.Text = "Country";
            country.Click += label3_Click_1;
            // 
            // comboCountry
            // 
            comboCountry.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboCountry.FormattingEnabled = true;
            comboCountry.Items.AddRange(new object[] { "Russia", "Azerbaijan", "Turkey", "Georgia" });
            comboCountry.Location = new Point(420, 90);
            comboCountry.Name = "comboCountry";
            comboCountry.Size = new Size(157, 28);
            comboCountry.TabIndex = 6;
            comboCountry.Text = "select your country";
            // 
            // listcity
            // 
            listcity.FormattingEnabled = true;
            listcity.ItemHeight = 20;
            listcity.Items.AddRange(new object[] { "Aghdas", "Ucar", "Baku" });
            listcity.Location = new Point(189, 90);
            listcity.Name = "listcity";
            listcity.Size = new Size(139, 64);
            listcity.TabIndex = 5;
            listcity.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // city
            // 
            city.AutoSize = true;
            city.BackColor = Color.FromArgb(255, 255, 192);
            city.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            city.Location = new Point(227, 55);
            city.Name = "city";
            city.Size = new Size(39, 20);
            city.TabIndex = 4;
            city.Text = "City";
            city.Click += label2_Click;
            // 
            // gender
            // 
            gender.AutoSize = true;
            gender.BackColor = Color.FromArgb(255, 255, 192);
            gender.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            gender.Location = new Point(46, 55);
            gender.Name = "gender";
            gender.Size = new Size(69, 20);
            gender.TabIndex = 3;
            gender.Text = "Gender";
            gender.Click += label1_Click;
            // 
            // other
            // 
            other.AutoSize = true;
            other.BackColor = Color.FromArgb(128, 255, 128);
            other.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            other.Location = new Point(46, 231);
            other.Name = "other";
            other.Size = new Size(87, 24);
            other.TabIndex = 2;
            other.TabStop = true;
            other.Text = "Other...";
            other.UseVisualStyleBackColor = false;
            other.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // female
            // 
            female.AutoSize = true;
            female.BackColor = Color.FromArgb(128, 255, 128);
            female.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            female.Location = new Point(46, 175);
            female.Name = "female";
            female.Size = new Size(86, 24);
            female.TabIndex = 1;
            female.TabStop = true;
            female.Text = "Female";
            female.UseVisualStyleBackColor = false;
            // 
            // male
            // 
            male.AutoSize = true;
            male.BackColor = Color.FromArgb(128, 255, 128);
            male.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold);
            male.Location = new Point(46, 113);
            male.Name = "male";
            male.Size = new Size(65, 24);
            male.TabIndex = 0;
            male.TabStop = true;
            male.Text = "Male";
            male.UseVisualStyleBackColor = false;
            male.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton other;
        private RadioButton female;
        private RadioButton male;
        private Label gender;
        private ListBox listcity;
        private Label city;
        private ComboBox comboCountry;
        private Label country;
        private CheckBox checkturk;
        private Label label4;
        private CheckBox checkrus;
        private CheckBox checkeng;
        private Button check;
        private ListBox listuni;
        private Label uni;
        private CheckBox checkjava;
        private CheckBox checkpython;
        private CheckBox checkc;
        private Label label1;
    }
}
