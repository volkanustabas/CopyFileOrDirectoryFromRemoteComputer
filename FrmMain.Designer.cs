namespace CopyFileOrDirectoryFromRemoteComputer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.lbl_info_sourcePath = new System.Windows.Forms.Label();
            this.tb_sourcePath = new System.Windows.Forms.TextBox();
            this.tb_destinationIpAdress = new System.Windows.Forms.TextBox();
            this.lbl_info_destinationIpAdress = new System.Windows.Forms.Label();
            this.tb_destinationFileOrDirectoryPath = new System.Windows.Forms.TextBox();
            this.lbl_info_destinationFileOrDirectoryPath = new System.Windows.Forms.Label();
            this.btn_copy = new System.Windows.Forms.Button();
            this.rtb_log = new System.Windows.Forms.RichTextBox();
            this.lbl_info_log = new System.Windows.Forms.Label();
            this.bw_copy = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // lbl_info_sourcePath
            // 
            this.lbl_info_sourcePath.AutoSize = true;
            this.lbl_info_sourcePath.Location = new System.Drawing.Point(15, 15);
            this.lbl_info_sourcePath.Name = "lbl_info_sourcePath";
            this.lbl_info_sourcePath.Size = new System.Drawing.Size(66, 13);
            this.lbl_info_sourcePath.TabIndex = 0;
            this.lbl_info_sourcePath.Text = "Source Path";
            // 
            // tb_sourcePath
            // 
            this.tb_sourcePath.Location = new System.Drawing.Point(15, 35);
            this.tb_sourcePath.Name = "tb_sourcePath";
            this.tb_sourcePath.Size = new System.Drawing.Size(400, 20);
            this.tb_sourcePath.TabIndex = 1;
            this.tb_sourcePath.Text = "PC01\\_setup\\GoogleChrome";
            // 
            // tb_destinationIpAdress
            // 
            this.tb_destinationIpAdress.Location = new System.Drawing.Point(15, 90);
            this.tb_destinationIpAdress.Name = "tb_destinationIpAdress";
            this.tb_destinationIpAdress.Size = new System.Drawing.Size(400, 20);
            this.tb_destinationIpAdress.TabIndex = 3;
            this.tb_destinationIpAdress.Text = "PC02";
            // 
            // lbl_info_destinationIpAdress
            // 
            this.lbl_info_destinationIpAdress.AutoSize = true;
            this.lbl_info_destinationIpAdress.Location = new System.Drawing.Point(15, 70);
            this.lbl_info_destinationIpAdress.Name = "lbl_info_destinationIpAdress";
            this.lbl_info_destinationIpAdress.Size = new System.Drawing.Size(107, 13);
            this.lbl_info_destinationIpAdress.TabIndex = 2;
            this.lbl_info_destinationIpAdress.Text = "Destination Ip Adress";
            // 
            // tb_destinationFileOrDirectoryPath
            // 
            this.tb_destinationFileOrDirectoryPath.Location = new System.Drawing.Point(15, 145);
            this.tb_destinationFileOrDirectoryPath.Name = "tb_destinationFileOrDirectoryPath";
            this.tb_destinationFileOrDirectoryPath.Size = new System.Drawing.Size(400, 20);
            this.tb_destinationFileOrDirectoryPath.TabIndex = 5;
            this.tb_destinationFileOrDirectoryPath.Text = "Z:\\_setup\\GoogleChrome";
            // 
            // lbl_info_destinationFileOrDirectoryPath
            // 
            this.lbl_info_destinationFileOrDirectoryPath.AutoSize = true;
            this.lbl_info_destinationFileOrDirectoryPath.Location = new System.Drawing.Point(15, 125);
            this.lbl_info_destinationFileOrDirectoryPath.Name = "lbl_info_destinationFileOrDirectoryPath";
            this.lbl_info_destinationFileOrDirectoryPath.Size = new System.Drawing.Size(161, 13);
            this.lbl_info_destinationFileOrDirectoryPath.TabIndex = 4;
            this.lbl_info_destinationFileOrDirectoryPath.Text = "Destination File or Directory Path";
            // 
            // btn_copy
            // 
            this.btn_copy.BackColor = System.Drawing.Color.Wheat;
            this.btn_copy.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_copy.Location = new System.Drawing.Point(15, 193);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(400, 30);
            this.btn_copy.TabIndex = 6;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = false;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // rtb_log
            // 
            this.rtb_log.Location = new System.Drawing.Point(453, 35);
            this.rtb_log.Name = "rtb_log";
            this.rtb_log.ReadOnly = true;
            this.rtb_log.Size = new System.Drawing.Size(335, 188);
            this.rtb_log.TabIndex = 7;
            this.rtb_log.Text = "";
            // 
            // lbl_info_log
            // 
            this.lbl_info_log.AutoSize = true;
            this.lbl_info_log.Location = new System.Drawing.Point(453, 15);
            this.lbl_info_log.Name = "lbl_info_log";
            this.lbl_info_log.Size = new System.Drawing.Size(25, 13);
            this.lbl_info_log.TabIndex = 8;
            this.lbl_info_log.Text = "Log";
            // 
            // bw_copy
            // 
            this.bw_copy.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bw_copy_DoWork);
            this.bw_copy.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bw_copy_RunWorkerCompleted);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 240);
            this.Controls.Add(this.lbl_info_log);
            this.Controls.Add(this.rtb_log);
            this.Controls.Add(this.btn_copy);
            this.Controls.Add(this.tb_destinationFileOrDirectoryPath);
            this.Controls.Add(this.lbl_info_destinationFileOrDirectoryPath);
            this.Controls.Add(this.tb_destinationIpAdress);
            this.Controls.Add(this.lbl_info_destinationIpAdress);
            this.Controls.Add(this.tb_sourcePath);
            this.Controls.Add(this.lbl_info_sourcePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "Copy File Or Directory From Remote Computer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info_sourcePath;
        private System.Windows.Forms.TextBox tb_sourcePath;
        private System.Windows.Forms.TextBox tb_destinationIpAdress;
        private System.Windows.Forms.Label lbl_info_destinationIpAdress;
        private System.Windows.Forms.TextBox tb_destinationFileOrDirectoryPath;
        private System.Windows.Forms.Label lbl_info_destinationFileOrDirectoryPath;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.RichTextBox rtb_log;
        private System.Windows.Forms.Label lbl_info_log;
        private System.ComponentModel.BackgroundWorker bw_copy;
    }
}

