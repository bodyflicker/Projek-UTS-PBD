﻿namespace Tournament_Manager.Player
{
    partial class FormDeletePlayer
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
            this.comboBoxTeam = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlayerEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPlayerId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTeam
            // 
            this.comboBoxTeam.FormattingEnabled = true;
            this.comboBoxTeam.Location = new System.Drawing.Point(46, 284);
            this.comboBoxTeam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxTeam.Name = "comboBoxTeam";
            this.comboBoxTeam.Size = new System.Drawing.Size(204, 24);
            this.comboBoxTeam.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(43, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Team";
            // 
            // textBoxPlayerEmail
            // 
            this.textBoxPlayerEmail.Location = new System.Drawing.Point(46, 212);
            this.textBoxPlayerEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayerEmail.Name = "textBoxPlayerEmail";
            this.textBoxPlayerEmail.Size = new System.Drawing.Size(204, 22);
            this.textBoxPlayerEmail.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Player Email";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(184)))), ((int)(((byte)(206)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Location = new System.Drawing.Point(183, 335);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(66, 38);
            this.buttonDelete.TabIndex = 23;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(46, 148);
            this.textBoxPlayerName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(204, 22);
            this.textBoxPlayerName.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Player Name";
            // 
            // textBoxPlayerId
            // 
            this.textBoxPlayerId.Location = new System.Drawing.Point(46, 78);
            this.textBoxPlayerId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayerId.Name = "textBoxPlayerId";
            this.textBoxPlayerId.Size = new System.Drawing.Size(204, 22);
            this.textBoxPlayerId.TabIndex = 20;
            this.textBoxPlayerId.TextChanged += new System.EventHandler(this.textBoxPlayerId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Player Id";
            // 
            // FormDeletePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(297, 402);
            this.Controls.Add(this.comboBoxTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlayerId);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormDeletePlayer";
            this.Text = "Delete Player";
            this.Load += new System.EventHandler(this.FormDeletePlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlayerEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPlayerId;
        private System.Windows.Forms.Label label3;
    }
}