namespace VP_assignment_2
{
    partial class top3
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
            this.next = new System.Windows.Forms.Button();
            this.path1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sem1 = new System.Windows.Forms.TextBox();
            this.topofclass = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(244, 63);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(89, 42);
            this.next.TabIndex = 19;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // path1
            // 
            this.path1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path1.Location = new System.Drawing.Point(33, 73);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(171, 26);
            this.path1.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "ENTER THE  PATH OF FILE TO SEARCH (e.g E:/path.txt)";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(244, 181);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 42);
            this.search.TabIndex = 22;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "ENTER THE SEMESTER";
            // 
            // sem1
            // 
            this.sem1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sem1.Location = new System.Drawing.Point(202, 139);
            this.sem1.Name = "sem1";
            this.sem1.Size = new System.Drawing.Size(149, 27);
            this.sem1.TabIndex = 20;
            // 
            // topofclass
            // 
            this.topofclass.FormattingEnabled = true;
            this.topofclass.Location = new System.Drawing.Point(84, 264);
            this.topofclass.Name = "topofclass";
            this.topofclass.Size = new System.Drawing.Size(120, 95);
            this.topofclass.TabIndex = 23;
            // 
            // top3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 438);
            this.Controls.Add(this.topofclass);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sem1);
            this.Controls.Add(this.next);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.label2);
            this.Name = "top3";
            this.Text = "top3";
            this.Load += new System.EventHandler(this.top3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sem1;
        private System.Windows.Forms.ListBox topofclass;
    }
}