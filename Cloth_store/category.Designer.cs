namespace Cloth_store
{
    partial class category
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
            this.button2 = new System.Windows.Forms.Button();
            this.category_name = new System.Windows.Forms.Label();
            this.txtcatnm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(270, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // category_name
            // 
            this.category_name.AutoSize = true;
            this.category_name.Location = new System.Drawing.Point(73, 86);
            this.category_name.Name = "category_name";
            this.category_name.Size = new System.Drawing.Size(97, 16);
            this.category_name.TabIndex = 1;
            this.category_name.Text = "category name";
            // 
            // txtcatnm
            // 
            this.txtcatnm.Location = new System.Drawing.Point(186, 83);
            this.txtcatnm.Name = "txtcatnm";
            this.txtcatnm.Size = new System.Drawing.Size(258, 22);
            this.txtcatnm.TabIndex = 2;
            // 
            // category
            // 
            this.ClientSize = new System.Drawing.Size(632, 328);
            this.Controls.Add(this.txtcatnm);
            this.Controls.Add(this.category_name);
            this.Controls.Add(this.button2);
            this.Name = "category";
            this.Load += new System.EventHandler(this.category_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox categoryname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label category_name;
        private System.Windows.Forms.TextBox txtcatnm;
    }
}