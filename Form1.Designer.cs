namespace FileCopyTest
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
            this.btnTest1 = new System.Windows.Forms.Button();
            this.lblResults = new System.Windows.Forms.Label();
            this.btnTestNetworkDrive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTest1
            // 
            this.btnTest1.Location = new System.Drawing.Point(0, 0);
            this.btnTest1.Name = "btnTest1";
            this.btnTest1.Size = new System.Drawing.Size(93, 23);
            this.btnTest1.TabIndex = 0;
            this.btnTest1.Text = "test1_local";
            this.btnTest1.Click += new System.EventHandler(this.btnTest1_Click);
            // 
            // lblResults
            // 
            this.lblResults.AutoSize = true;
            this.lblResults.Location = new System.Drawing.Point(12, 239);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(58, 13);
            this.lblResults.TabIndex = 1;
            this.lblResults.Text = "Status: .....";
            // 
            // btnTestNetworkDrive
            // 
            this.btnTestNetworkDrive.Location = new System.Drawing.Point(0, 29);
            this.btnTestNetworkDrive.Name = "btnTestNetworkDrive";
            this.btnTestNetworkDrive.Size = new System.Drawing.Size(93, 23);
            this.btnTestNetworkDrive.TabIndex = 2;
            this.btnTestNetworkDrive.Text = "test2_remote";
            this.btnTestNetworkDrive.Click += new System.EventHandler(this.btnTestNetworkDrive_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnTestNetworkDrive);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.btnTest1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

      
        private System.Windows.Forms.Button btnTest1;
        private System.Windows.Forms.Label lblResults;
        private System.Windows.Forms.Button btnTestNetworkDrive;
    }
}

