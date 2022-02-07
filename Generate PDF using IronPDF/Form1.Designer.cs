
namespace Generate_PDF_using_IronPDF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_htmlstring = new System.Windows.Forms.RichTextBox();
            this.txt_url = new System.Windows.Forms.TextBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_url = new System.Windows.Forms.Button();
            this.btn_file = new System.Windows.Forms.Button();
            this.txt_file = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_htmlstring
            // 
            this.txt_htmlstring.Location = new System.Drawing.Point(21, 108);
            this.txt_htmlstring.Name = "txt_htmlstring";
            this.txt_htmlstring.Size = new System.Drawing.Size(623, 452);
            this.txt_htmlstring.TabIndex = 0;
            this.txt_htmlstring.Text = "";
            // 
            // txt_url
            // 
            this.txt_url.Location = new System.Drawing.Point(755, 108);
            this.txt_url.Name = "txt_url";
            this.txt_url.Size = new System.Drawing.Size(349, 27);
            this.txt_url.TabIndex = 1;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(506, 566);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(138, 46);
            this.btn_generate.TabIndex = 2;
            this.btn_generate.Text = "Generate PDF";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(362, 566);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(138, 46);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_url
            // 
            this.btn_url.Location = new System.Drawing.Point(964, 141);
            this.btn_url.Name = "btn_url";
            this.btn_url.Size = new System.Drawing.Size(138, 46);
            this.btn_url.TabIndex = 4;
            this.btn_url.Text = "Generate PDF";
            this.btn_url.UseVisualStyleBackColor = true;
            this.btn_url.Click += new System.EventHandler(this.btn_url_Click);
            // 
            // btn_file
            // 
            this.btn_file.Location = new System.Drawing.Point(964, 517);
            this.btn_file.Name = "btn_file";
            this.btn_file.Size = new System.Drawing.Size(138, 33);
            this.btn_file.TabIndex = 6;
            this.btn_file.Text = "Generate PDF";
            this.btn_file.UseVisualStyleBackColor = true;
            this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
            // 
            // txt_file
            // 
            this.txt_file.Enabled = false;
            this.txt_file.Location = new System.Drawing.Point(755, 471);
            this.txt_file.Name = "txt_file";
            this.txt_file.Size = new System.Drawing.Size(349, 27);
            this.txt_file.TabIndex = 5;
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(849, 517);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(109, 33);
            this.btn_browse.TabIndex = 7;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 46);
            this.label1.TabIndex = 8;
            this.label1.Text = "Generate PDF from HTML String";
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(755, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(284, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "Generate PDF from URL";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(755, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "Generate PDF from HTML File";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Generate_PDF_using_IronPDF.Properties.Resources.Iron_pdf_logo;
            this.pictureBox1.Location = new System.Drawing.Point(938, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 646);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_browse);
            this.Controls.Add(this.btn_file);
            this.Controls.Add(this.txt_file);
            this.Controls.Add(this.btn_url);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.txt_url);
            this.Controls.Add(this.txt_htmlstring);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_htmlstring;
        private System.Windows.Forms.TextBox txt_url;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_url;
        private System.Windows.Forms.Button btn_file;
        private System.Windows.Forms.TextBox txt_file;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

