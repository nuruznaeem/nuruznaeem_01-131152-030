namespace VP_assignment_2
{
    partial class search
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
            this.bid = new System.Windows.Forms.Button();
            this.bname = new System.Windows.Forms.Button();
            this.ssem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bid
            // 
            this.bid.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bid.Location = new System.Drawing.Point(70, 45);
            this.bid.Name = "bid";
            this.bid.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bid.Size = new System.Drawing.Size(206, 60);
            this.bid.TabIndex = 0;
            this.bid.Text = "SEARCH BY ID";
            this.bid.UseVisualStyleBackColor = true;
            this.bid.Click += new System.EventHandler(this.bid_Click);
            // 
            // bname
            // 
            this.bname.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bname.Location = new System.Drawing.Point(70, 111);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(206, 60);
            this.bname.TabIndex = 1;
            this.bname.Text = "SEARCH BY NAME";
            this.bname.UseVisualStyleBackColor = true;
            this.bname.Click += new System.EventHandler(this.bname_Click);
            // 
            // ssem
            // 
            this.ssem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ssem.Location = new System.Drawing.Point(70, 177);
            this.ssem.Name = "ssem";
            this.ssem.Size = new System.Drawing.Size(206, 60);
            this.ssem.TabIndex = 2;
            this.ssem.Text = "SEARCH BY SEMESTER";
            this.ssem.UseVisualStyleBackColor = true;
            this.ssem.Click += new System.EventHandler(this.ssem_Click);
            // 
            // search
            // 
            this.ClientSize = new System.Drawing.Size(344, 282);
            this.Controls.Add(this.ssem);
            this.Controls.Add(this.bname);
            this.Controls.Add(this.bid);
            this.Name = "search";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button bid;
        private System.Windows.Forms.Button bname;
        private System.Windows.Forms.Button ssem;
    }
}