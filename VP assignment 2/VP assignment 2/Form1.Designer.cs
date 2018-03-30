namespace VP_assignment_2
{
    partial class introduction
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
            this.write = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.top3 = new System.Windows.Forms.Button();
            this.mark = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // write
            // 
            this.write.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.write.Location = new System.Drawing.Point(106, 67);
            this.write.Name = "write";
            this.write.Size = new System.Drawing.Size(154, 45);
            this.write.TabIndex = 0;
            this.write.Text = "STUDENT PROFILE";
            this.write.UseVisualStyleBackColor = true;
            this.write.Click += new System.EventHandler(this.button1_Click);
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(106, 118);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(154, 45);
            this.search.TabIndex = 1;
            this.search.Text = "SEARCH STUDENT";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.button2_Click);
            // 
            // delete
            // 
            this.delete.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.Location = new System.Drawing.Point(106, 169);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(154, 45);
            this.delete.TabIndex = 2;
            this.delete.Text = "DELETE RECORD";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.top3_Click);
            // 
            // top3
            // 
            this.top3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3.Location = new System.Drawing.Point(106, 220);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(154, 45);
            this.top3.TabIndex = 3;
            this.top3.Text = "TOP 3 STUDENTS";
            this.top3.UseVisualStyleBackColor = true;
            this.top3.Click += new System.EventHandler(this.button4_Click);
            // 
            // mark
            // 
            this.mark.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mark.Location = new System.Drawing.Point(106, 271);
            this.mark.Name = "mark";
            this.mark.Size = new System.Drawing.Size(154, 45);
            this.mark.TabIndex = 4;
            this.mark.Text = "MARK ATTENDANCE";
            this.mark.UseVisualStyleBackColor = true;
            this.mark.Click += new System.EventHandler(this.button5_Click);
            // 
            // view
            // 
            this.view.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.Location = new System.Drawing.Point(106, 322);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(154, 45);
            this.view.TabIndex = 5;
            this.view.Text = "VIEW ATTENDANCE";
            this.view.UseVisualStyleBackColor = true;
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.Location = new System.Drawing.Point(123, 20);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(118, 25);
            this.welcome.TabIndex = 6;
            this.welcome.Text = "WELCOME ";
            // 
            // introduction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 400);
            this.Controls.Add(this.welcome);
            this.Controls.Add(this.view);
            this.Controls.Add(this.mark);
            this.Controls.Add(this.top3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.search);
            this.Controls.Add(this.write);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "introduction";
            this.Text = "STUDENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button write;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button top3;
        private System.Windows.Forms.Button mark;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Label welcome;

    }
}

