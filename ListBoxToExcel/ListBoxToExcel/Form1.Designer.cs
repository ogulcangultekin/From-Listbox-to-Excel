
namespace ListBoxToExcel
{
    partial class Form1
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox_Add = new System.Windows.Forms.Button();
            this.excel_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(41, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(722, 238);
            this.listBox1.TabIndex = 0;
            // 
            // listBox_Add
            // 
            this.listBox_Add.Location = new System.Drawing.Point(244, 270);
            this.listBox_Add.Name = "listBox_Add";
            this.listBox_Add.Size = new System.Drawing.Size(136, 39);
            this.listBox_Add.TabIndex = 1;
            this.listBox_Add.Text = "Add";
            this.listBox_Add.UseVisualStyleBackColor = true;
            this.listBox_Add.Click += new System.EventHandler(this.listBox_Add_Click);
            // 
            // excel_Add
            // 
            this.excel_Add.Location = new System.Drawing.Point(426, 270);
            this.excel_Add.Name = "excel_Add";
            this.excel_Add.Size = new System.Drawing.Size(136, 39);
            this.excel_Add.TabIndex = 2;
            this.excel_Add.Text = "Excel";
            this.excel_Add.UseVisualStyleBackColor = true;
            this.excel_Add.Click += new System.EventHandler(this.excel_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 360);
            this.Controls.Add(this.excel_Add);
            this.Controls.Add(this.listBox_Add);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button listBox_Add;
        private System.Windows.Forms.Button excel_Add;
    }
}

