namespace VP_assignment_2
{
    partial class delete
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
            this.label1 = new System.Windows.Forms.Label();
            this.path = new System.Windows.Forms.TextBox();
            this.next = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.TextBox();
            this.deletefunct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(514, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER THE PATH OF FILE FORM WHICH YOU WANT TO DELETE THE RECORD";
            // 
            // path
            // 
            this.path.Location = new System.Drawing.Point(165, 75);
            this.path.Name = "path";
            this.path.Size = new System.Drawing.Size(144, 20);
            this.path.TabIndex = 1;
            this.path.TextChanged += new System.EventHandler(this.path_TextChanged);
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.Location = new System.Drawing.Point(315, 65);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(81, 37);
            this.next.TabIndex = 2;
            this.next.Text = "NEXT";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTER THE ID";
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(186, 156);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(123, 20);
            this.id.TabIndex = 4;
            // 
            // deletefunct
            // 
            this.deletefunct.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletefunct.Location = new System.Drawing.Point(223, 210);
            this.deletefunct.Name = "deletefunct";
            this.deletefunct.Size = new System.Drawing.Size(86, 37);
            this.deletefunct.TabIndex = 5;
            this.deletefunct.Text = "DELETE";
            this.deletefunct.UseVisualStyleBackColor = true;
            this.deletefunct.Click += new System.EventHandler(this.button1_Click);
            // 
            // delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 297);
            this.Controls.Add(this.deletefunct);
            this.Controls.Add(this.id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.next);
            this.Controls.Add(this.path);
            this.Controls.Add(this.label1);
            this.Name = "delete";
            this.Text = "delete";
            this.Load += new System.EventHandler(this.delete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox path;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.Button deletefunct;
    }
}