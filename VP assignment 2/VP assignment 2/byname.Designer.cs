namespace VP_assignment_2
{
    partial class byname
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
            this.path2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.namerecord = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(272, 44);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(74, 38);
            this.next.TabIndex = 13;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // path2
            // 
            this.path2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path2.Location = new System.Drawing.Point(60, 55);
            this.path2.Name = "path2";
            this.path2.Size = new System.Drawing.Size(171, 26);
            this.path2.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "ENTER THE  PATH OF FILE TO SEARCH (e.g E:/path.txt)";
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(179, 144);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 42);
            this.search.TabIndex = 10;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // namerecord
            // 
            this.namerecord.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namerecord.FormattingEnabled = true;
            this.namerecord.ItemHeight = 18;
            this.namerecord.Location = new System.Drawing.Point(97, 192);
            this.namerecord.Name = "namerecord";
            this.namerecord.Size = new System.Drawing.Size(167, 184);
            this.namerecord.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "ENTER THE NAME";
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(135, 111);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(149, 27);
            this.name.TabIndex = 7;
            // 
            // byname
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 390);
            this.Controls.Add(this.next);
            this.Controls.Add(this.path2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.namerecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Name = "byname";
            this.Text = "byname";
            this.Load += new System.EventHandler(this.byname_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox path2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.ListBox namerecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
    }
}