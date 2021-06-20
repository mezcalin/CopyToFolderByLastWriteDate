namespace CopyToFolderByLastWriteDateUI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Close = new System.Windows.Forms.Button();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_selectSourceDir = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_sourceDir = new System.Windows.Forms.Label();
            this.edt_sourceDir = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.lbl_Title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 65);
            this.panel1.TabIndex = 0;
            // 
            // btn_Close
            // 
            this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.BackgroundImage = global::CopyToFolderByLastWriteDateUI.Properties.Resources.Close_32;
            this.btn_Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Location = new System.Drawing.Point(785, 17);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(32, 32);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.UseVisualStyleBackColor = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_Title
            // 
            this.lbl_Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Title.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(0, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_Title.Size = new System.Drawing.Size(831, 65);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Copy/Move To Folder By Last Write Date";
            this.lbl_Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_log);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 328);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Log";
            // 
            // txt_log
            // 
            this.txt_log.BackColor = System.Drawing.SystemColors.Control;
            this.txt_log.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_log.Location = new System.Drawing.Point(3, 28);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.Size = new System.Drawing.Size(825, 297);
            this.txt_log.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_selectSourceDir);
            this.panel2.Controls.Add(this.btn_Start);
            this.panel2.Controls.Add(this.lbl_sourceDir);
            this.panel2.Controls.Add(this.edt_sourceDir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 57);
            this.panel2.TabIndex = 6;
            // 
            // btn_selectSourceDir
            // 
            this.btn_selectSourceDir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_selectSourceDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_selectSourceDir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_selectSourceDir.FlatAppearance.BorderSize = 2;
            this.btn_selectSourceDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_selectSourceDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_selectSourceDir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectSourceDir.ForeColor = System.Drawing.Color.White;
            this.btn_selectSourceDir.Location = new System.Drawing.Point(605, 6);
            this.btn_selectSourceDir.Name = "btn_selectSourceDir";
            this.btn_selectSourceDir.Size = new System.Drawing.Size(45, 45);
            this.btn_selectSourceDir.TabIndex = 8;
            this.btn_selectSourceDir.Text = "...";
            this.btn_selectSourceDir.UseVisualStyleBackColor = false;
            this.btn_selectSourceDir.Click += new System.EventHandler(this.btn_selectSourceDir_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Start.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Start.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Start.FlatAppearance.BorderSize = 2;
            this.btn_Start.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Start.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(688, 6);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(120, 45);
            this.btn_Start.TabIndex = 7;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // lbl_sourceDir
            // 
            this.lbl_sourceDir.AutoSize = true;
            this.lbl_sourceDir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sourceDir.Location = new System.Drawing.Point(9, 16);
            this.lbl_sourceDir.Name = "lbl_sourceDir";
            this.lbl_sourceDir.Size = new System.Drawing.Size(188, 25);
            this.lbl_sourceDir.TabIndex = 6;
            this.lbl_sourceDir.Text = "Quellverzeichnis:";
            // 
            // edt_sourceDir
            // 
            this.edt_sourceDir.BackColor = System.Drawing.SystemColors.Control;
            this.edt_sourceDir.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.edt_sourceDir.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edt_sourceDir.Location = new System.Drawing.Point(203, 14);
            this.edt_sourceDir.Name = "edt_sourceDir";
            this.edt_sourceDir.Size = new System.Drawing.Size(396, 32);
            this.edt_sourceDir.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_selectSourceDir;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_sourceDir;
        private System.Windows.Forms.TextBox edt_sourceDir;
    }
}

