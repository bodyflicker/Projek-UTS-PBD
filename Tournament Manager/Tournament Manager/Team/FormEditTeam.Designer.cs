﻿namespace Tournament_Manager.Team
{
    partial class FormEditTeam
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
            this.buttonEdit = new System.Windows.Forms.Button();
            this.textBoxTeamName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTeamId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(165)))), ((int)(((byte)(152)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.buttonEdit.Location = new System.Drawing.Point(248, 309);
            this.buttonEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(119, 39);
            this.buttonEdit.TabIndex = 9;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // textBoxTeamName
            // 
            this.textBoxTeamName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxTeamName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTeamName.Location = new System.Drawing.Point(49, 258);
            this.textBoxTeamName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTeamName.Name = "textBoxTeamName";
            this.textBoxTeamName.Size = new System.Drawing.Size(318, 30);
            this.textBoxTeamName.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label2.Location = new System.Drawing.Point(45, 232);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Team Name";
            // 
            // textBoxTeamId
            // 
            this.textBoxTeamId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.textBoxTeamId.Enabled = false;
            this.textBoxTeamId.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textBoxTeamId.Location = new System.Drawing.Point(49, 174);
            this.textBoxTeamId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTeamId.Name = "textBoxTeamId";
            this.textBoxTeamId.Size = new System.Drawing.Size(318, 30);
            this.textBoxTeamId.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(196)))), ((int)(((byte)(161)))));
            this.label1.Location = new System.Drawing.Point(45, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Team Id";
            // 
            // label5
            // 
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Coral;
            this.label5.Location = new System.Drawing.Point(99, 56);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 61);
            this.label5.TabIndex = 20;
            this.label5.Text = "EDIT TEAM";
            // 
            // FormEditTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(423, 388);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.textBoxTeamName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTeamId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormEditTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormEditTeam";
            this.Load += new System.EventHandler(this.FormEditTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.TextBox textBoxTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTeamId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
    }
}