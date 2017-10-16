namespace Ignition
{
    partial class Main
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.tbClientName = new System.Windows.Forms.TextBox();
            this.tbPurpose = new System.Windows.Forms.TextBox();
            this.pbRandom = new System.Windows.Forms.ProgressBar();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.tmrPB = new System.Windows.Forms.Timer(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(313, 245);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(121, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Folders";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // tbClientName
            // 
            this.tbClientName.Location = new System.Drawing.Point(58, 64);
            this.tbClientName.Name = "tbClientName";
            this.tbClientName.Size = new System.Drawing.Size(376, 22);
            this.tbClientName.TabIndex = 1;
            // 
            // tbPurpose
            // 
            this.tbPurpose.Location = new System.Drawing.Point(58, 142);
            this.tbPurpose.Name = "tbPurpose";
            this.tbPurpose.Size = new System.Drawing.Size(376, 22);
            this.tbPurpose.TabIndex = 2;
            // 
            // pbRandom
            // 
            this.pbRandom.Location = new System.Drawing.Point(58, 203);
            this.pbRandom.Name = "pbRandom";
            this.pbRandom.Size = new System.Drawing.Size(376, 23);
            this.pbRandom.Step = 1;
            this.pbRandom.TabIndex = 3;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Location = new System.Drawing.Point(55, 44);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(101, 17);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "Client Name(s)";
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Location = new System.Drawing.Point(55, 122);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(113, 17);
            this.lblPurpose.TabIndex = 5;
            this.lblPurpose.Text = "Purpose for loan";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(58, 233);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(45, 17);
            this.lblDone.TabIndex = 6;
            this.lblDone.Text = "Done!";
            this.lblDone.Visible = false;
            // 
            // tmrPB
            // 
            this.tmrPB.Tick += new System.EventHandler(this.tmrPB_Tick);
            // 
            // btnTest
            // 
            this.btnTest.Enabled = false;
            this.btnTest.Location = new System.Drawing.Point(202, 262);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 7;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Visible = false;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 297);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.lblPurpose);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.pbRandom);
            this.Controls.Add(this.tbPurpose);
            this.Controls.Add(this.tbClientName);
            this.Controls.Add(this.btnCreate);
            this.Name = "Main";
            this.Text = "name";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox tbClientName;
        private System.Windows.Forms.TextBox tbPurpose;
        private System.Windows.Forms.ProgressBar pbRandom;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.Timer tmrPB;
        private System.Windows.Forms.Button btnTest;
    }
}

