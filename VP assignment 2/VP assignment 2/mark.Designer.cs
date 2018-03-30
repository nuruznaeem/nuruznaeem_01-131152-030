namespace VP_assignment_2
{
    partial class mark
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
            this.button1 = new System.Windows.Forms.Button();
            this.sem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sname = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.path2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.next = new System.Windows.Forms.Button();
            this.path1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(237, 417);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 66);
            this.button1.TabIndex = 25;
            this.button1.Text = "START MARKING";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sem
            // 
            this.sem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem.Location = new System.Drawing.Point(293, 349);
            this.sem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sem.Name = "sem";
            this.sem.Size = new System.Drawing.Size(92, 27);
            this.sem.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 352);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 19);
            this.label3.TabIndex = 23;
            this.label3.Text = "ENTER THE SEMESTER NUMBER";
            // 
            // sname
            // 
            this.sname.AutoSize = true;
            this.sname.Location = new System.Drawing.Point(81, 516);
            this.sname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(52, 19);
            this.sname.TabIndex = 26;
            this.sname.Text = "NAME";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(400, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 56);
            this.button2.TabIndex = 29;
            this.button2.Text = "NEXT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // path2
            // 
            this.path2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path2.Location = new System.Drawing.Point(117, 94);
            this.path2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.path2.Name = "path2";
            this.path2.Size = new System.Drawing.Size(227, 26);
            this.path2.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "ENTER THE PATH TO SAVE THE MARKED STUDENTS (e.g E:/mark.txt)";
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(400, 231);
            this.next.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(99, 56);
            this.next.TabIndex = 32;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // path1
            // 
            this.path1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path1.Location = new System.Drawing.Point(117, 248);
            this.path1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(227, 26);
            this.path1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(370, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "ENTER THE  PATH OF FILE TO SEARCH (e.g E:/path.txt)";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(194, 516);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(88, 23);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PRESENT\r\n";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(350, 512);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(81, 23);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "ABSENT";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 671);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sem);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "mark";
            this.Text = "mark";
            this.Load += new System.EventHandler(this.mark_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox sem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label sname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox path2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}