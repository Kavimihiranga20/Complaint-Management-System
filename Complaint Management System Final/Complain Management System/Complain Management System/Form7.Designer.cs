namespace Complain_Management_System
{
    partial class Form7
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnViewAction = new System.Windows.Forms.Button();
            this.btnViewComplain = new System.Windows.Forms.Button();
            this.btnAddAction = new System.Windows.Forms.Button();
            this.btnAddComplain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(40, 469);
            this.btnBack.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(65, 27);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Exit";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnViewAction
            // 
            this.btnViewAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewAction.Location = new System.Drawing.Point(103, 379);
            this.btnViewAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewAction.Name = "btnViewAction";
            this.btnViewAction.Size = new System.Drawing.Size(291, 61);
            this.btnViewAction.TabIndex = 41;
            this.btnViewAction.Text = "View Action";
            this.btnViewAction.UseVisualStyleBackColor = true;
            this.btnViewAction.Click += new System.EventHandler(this.btnViewAction_Click);
            // 
            // btnViewComplain
            // 
            this.btnViewComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewComplain.Location = new System.Drawing.Point(103, 209);
            this.btnViewComplain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnViewComplain.Name = "btnViewComplain";
            this.btnViewComplain.Size = new System.Drawing.Size(291, 61);
            this.btnViewComplain.TabIndex = 40;
            this.btnViewComplain.Text = "View Complain";
            this.btnViewComplain.UseVisualStyleBackColor = true;
            this.btnViewComplain.Click += new System.EventHandler(this.btnViewComplain_Click);
            // 
            // btnAddAction
            // 
            this.btnAddAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAction.Location = new System.Drawing.Point(103, 295);
            this.btnAddAction.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddAction.Name = "btnAddAction";
            this.btnAddAction.Size = new System.Drawing.Size(291, 61);
            this.btnAddAction.TabIndex = 39;
            this.btnAddAction.Text = "Add Action";
            this.btnAddAction.UseVisualStyleBackColor = true;
            this.btnAddAction.Click += new System.EventHandler(this.btnAddAction_Click);
            // 
            // btnAddComplain
            // 
            this.btnAddComplain.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddComplain.Location = new System.Drawing.Point(103, 122);
            this.btnAddComplain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddComplain.Name = "btnAddComplain";
            this.btnAddComplain.Size = new System.Drawing.Size(291, 61);
            this.btnAddComplain.TabIndex = 38;
            this.btnAddComplain.Text = "Add Complain";
            this.btnAddComplain.UseCompatibleTextRendering = true;
            this.btnAddComplain.UseVisualStyleBackColor = true;
            this.btnAddComplain.Click += new System.EventHandler(this.btnAddComplain_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(45, 24);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 57);
            this.panel2.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Complaint Management System";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 7);
            this.lblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 13);
            this.lblID.TabIndex = 88;
            this.lblID.Visible = false;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(497, 521);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnViewAction);
            this.Controls.Add(this.btnAddAction);
            this.Controls.Add(this.btnViewComplain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnAddComplain);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnViewAction;
        private System.Windows.Forms.Button btnViewComplain;
        private System.Windows.Forms.Button btnAddAction;
        private System.Windows.Forms.Button btnAddComplain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblID;
    }
}