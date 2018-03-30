namespace VP_assignment_2
{
    partial class byid
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ids = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.idrecord = new System.Windows.Forms.ListBox();
            this.search = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.path1 = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ids
            // 
            this.ids.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ids.Location = new System.Drawing.Point(133, 126);
            this.ids.Name = "ids";
            this.ids.Size = new System.Drawing.Size(149, 27);
            this.ids.TabIndex = 0;
            this.ids.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ENTER THE ID";
            // 
            // idrecord
            // 
            this.idrecord.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idrecord.FormattingEnabled = true;
            this.idrecord.ItemHeight = 18;
            this.idrecord.Location = new System.Drawing.Point(95, 207);
            this.idrecord.Name = "idrecord";
            this.idrecord.Size = new System.Drawing.Size(167, 184);
            this.idrecord.TabIndex = 2;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(177, 159);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(89, 42);
            this.search.TabIndex = 3;
            this.search.Text = "SEARCH";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(370, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "ENTER THE  PATH OF FILE TO SEARCH (e.g E:/path.txt)";
            // 
            // path1
            // 
            this.path1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.path1.Location = new System.Drawing.Point(58, 70);
            this.path1.Name = "path1";
            this.path1.Size = new System.Drawing.Size(171, 26);
            this.path1.TabIndex = 5;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(270, 59);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(74, 38);
            this.next.TabIndex = 6;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // byid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 435);
            this.Controls.Add(this.next);
            this.Controls.Add(this.path1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search);
            this.Controls.Add(this.idrecord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ids);
            this.Name = "byid";
            this.Text = "byid";
            this.Load += new System.EventHandler(this.byid_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox ids;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox idrecord;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox path1;
        private System.Windows.Forms.Button next;
    }
}