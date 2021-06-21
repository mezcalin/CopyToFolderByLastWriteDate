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
            this.gbx_log = new System.Windows.Forms.GroupBox();
            this.lbx_log = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_selectSourceDir = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.lbl_sourceDir = new System.Windows.Forms.Label();
            this.edt_sourceDir = new System.Windows.Forms.TextBox();
            this.gbx_log.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_log
            // 
            this.gbx_log.Controls.Add(this.lbx_log);
            this.gbx_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbx_log.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_log.Location = new System.Drawing.Point(0, 122);
            this.gbx_log.Name = "gbx_log";
            this.gbx_log.Size = new System.Drawing.Size(831, 328);
            this.gbx_log.TabIndex = 5;
            this.gbx_log.TabStop = false;
            this.gbx_log.Text = "Log";
            // 
            // lbx_log
            // 
            this.lbx_log.BackColor = System.Drawing.SystemColors.Control;
            this.lbx_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbx_log.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbx_log.FormattingEnabled = true;
            this.lbx_log.ItemHeight = 20;
            this.lbx_log.Location = new System.Drawing.Point(3, 28);
            this.lbx_log.Name = "lbx_log";
            this.lbx_log.Size = new System.Drawing.Size(825, 297);
            this.lbx_log.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_selectSourceDir);
            this.panel2.Controls.Add(this.btn_Start);
            this.panel2.Controls.Add(this.lbl_sourceDir);
            this.panel2.Controls.Add(this.edt_sourceDir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 122);
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
            this.Controls.Add(this.gbx_log);
            this.Name = "MainForm";
            this.Text = "Move To Folder By Last Write Date";
            this.gbx_log.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gbx_log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_selectSourceDir;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_sourceDir;
        private System.Windows.Forms.TextBox edt_sourceDir;
        private System.Windows.Forms.ListBox lbx_log;
    }
}

