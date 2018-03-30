namespace VP_assignment_2
{
    partial class write
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
            this.id = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.semester = new System.Windows.Forms.Label();
            this.cgpa = new System.Windows.Forms.Label();
            this.dept = new System.Windows.Forms.Label();
            this.uni = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.ssem = new System.Windows.Forms.TextBox();
            this.scgpa = new System.Windows.Forms.TextBox();
            this.sdept = new System.Windows.Forms.TextBox();
            this.suni = new System.Windows.Forms.TextBox();
            this.done = new System.Windows.Forms.Button();
            this.failpath = new System.Windows.Forms.Label();
            this.Path = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(66, 146);
            this.id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(23, 19);
            this.id.TabIndex = 0;
            this.id.Text = "ID";
            this.id.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(66, 195);
            this.name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(49, 19);
            this.name.TabIndex = 1;
            this.name.Text = "NAME";
            this.name.Click += new System.EventHandler(this.label2_Click);
            // 
            // semester
            // 
            this.semester.AutoSize = true;
            this.semester.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.Location = new System.Drawing.Point(66, 246);
            this.semester.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(77, 19);
            this.semester.TabIndex = 2;
            this.semester.Text = "SEMESTER";
            this.semester.Click += new System.EventHandler(this.label3_Click);
            // 
            // cgpa
            // 
            this.cgpa.AutoSize = true;
            this.cgpa.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cgpa.Location = new System.Drawing.Point(66, 296);
            this.cgpa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cgpa.Name = "cgpa";
            this.cgpa.Size = new System.Drawing.Size(44, 19);
            this.cgpa.TabIndex = 3;
            this.cgpa.Text = "CGPA";
            this.cgpa.Click += new System.EventHandler(this.label4_Click);
            // 
            // dept
            // 
            this.dept.AutoSize = true;
            this.dept.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dept.Location = new System.Drawing.Point(66, 345);
            this.dept.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dept.Name = "dept";
            this.dept.Size = new System.Drawing.Size(99, 19);
            this.dept.TabIndex = 4;
            this.dept.Text = "DEPARTMENT";
            this.dept.Click += new System.EventHandler(this.label5_Click);
            // 
            // uni
            // 
            this.uni.AutoSize = true;
            this.uni.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uni.Location = new System.Drawing.Point(66, 396);
            this.uni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uni.Name = "uni";
            this.uni.Size = new System.Drawing.Size(86, 19);
            this.uni.TabIndex = 5;
            this.uni.Text = "UNIVERSITY";
            this.uni.Click += new System.EventHandler(this.label6_Click);
            // 
            // sid
            // 
            this.sid.Location = new System.Drawing.Point(210, 138);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(120, 27);
            this.sid.TabIndex = 1;
            this.sid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sname
            // 
            this.sname.Location = new System.Drawing.Point(210, 192);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(120, 27);
            this.sname.TabIndex = 2;
            this.sname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ssem
            // 
            this.ssem.Location = new System.Drawing.Point(210, 243);
            this.ssem.Name = "ssem";
            this.ssem.Size = new System.Drawing.Size(120, 27);
            this.ssem.TabIndex = 3;
            // 
            // scgpa
            // 
            this.scgpa.Location = new System.Drawing.Point(210, 293);
            this.scgpa.Name = "scgpa";
            this.scgpa.Size = new System.Drawing.Size(120, 27);
            this.scgpa.TabIndex = 4;
            this.scgpa.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // sdept
            // 
            this.sdept.Location = new System.Drawing.Point(210, 342);
            this.sdept.Name = "sdept";
            this.sdept.Size = new System.Drawing.Size(120, 27);
            this.sdept.TabIndex = 5;
            // 
            // suni
            // 
            this.suni.Location = new System.Drawing.Point(210, 393);
            this.suni.Name = "suni";
            this.suni.Size = new System.Drawing.Size(120, 27);
            this.suni.TabIndex = 6;
            this.suni.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // done
            // 
            this.done.Location = new System.Drawing.Point(191, 459);
            this.done.Name = "done";
            this.done.Size = new System.Drawing.Size(119, 46);
            this.done.TabIndex = 7;
            this.done.Text = "WRITE DATA";
            this.done.UseVisualStyleBackColor = true;
            this.done.Click += new System.EventHandler(this.done_Click);
            // 
            // failpath
            // 
            this.failpath.AutoSize = true;
            this.failpath.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failpath.Location = new System.Drawing.Point(10, 25);
            this.failpath.Name = "failpath";
            this.failpath.Size = new System.Drawing.Size(300, 19);
            this.failpath.TabIndex = 8;
            this.failpath.Text = "ENTER THE PATH OF FILE (e.g \"E:/path.txt\")";
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(103, 67);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(227, 27);
            this.Path.TabIndex = 9;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(358, 67);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(78, 27);
            this.next.TabIndex = 10;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // write
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 529);
            this.Controls.Add(this.next);
            this.Controls.Add(this.Path);
            this.Controls.Add(this.failpath);
            this.Controls.Add(this.done);
            this.Controls.Add(this.suni);
            this.Controls.Add(this.sdept);
            this.Controls.Add(this.scgpa);
            this.Controls.Add(this.ssem);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.uni);
            this.Controls.Add(this.dept);
            this.Controls.Add(this.cgpa);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.name);
            this.Controls.Add(this.id);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "write";
            this.Text = "WRITE";
            this.Load += new System.EventHandler(this.write_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label semester;
        private System.Windows.Forms.Label cgpa;
        private System.Windows.Forms.Label dept;
        private System.Windows.Forms.Label uni;
        private System.Windows.Forms.TextBox sid;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox ssem;
        private System.Windows.Forms.TextBox scgpa;
        private System.Windows.Forms.TextBox sdept;
        private System.Windows.Forms.TextBox suni;
        private System.Windows.Forms.Button done;
        private System.Windows.Forms.Label failpath;
        private System.Windows.Forms.TextBox Path;
        private System.Windows.Forms.Button next;
    }
}