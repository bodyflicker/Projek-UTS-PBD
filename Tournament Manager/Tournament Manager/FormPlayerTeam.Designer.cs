﻿namespace Tournament_Manager
{
    partial class FormPlayerTeam
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
            this.tabControlTeam = new System.Windows.Forms.TabControl();
            this.tabPagePlayer = new System.Windows.Forms.TabPage();
            this.textBoxSearchPlayer = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.textBoxSearchTeam = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewTeam = new System.Windows.Forms.DataGridView();
            this.tabControlTeam.SuspendLayout();
            this.tabPagePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.tabPageTeam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTeam
            // 
            this.tabControlTeam.Controls.Add(this.tabPagePlayer);
            this.tabControlTeam.Controls.Add(this.tabPageTeam);
            this.tabControlTeam.Location = new System.Drawing.Point(9, 31);
            this.tabControlTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControlTeam.Name = "tabControlTeam";
            this.tabControlTeam.SelectedIndex = 0;
            this.tabControlTeam.Size = new System.Drawing.Size(643, 389);
            this.tabControlTeam.TabIndex = 1;
            // 
            // tabPagePlayer
            // 
            this.tabPagePlayer.Controls.Add(this.textBoxSearchPlayer);
            this.tabPagePlayer.Controls.Add(this.button2);
            this.tabPagePlayer.Controls.Add(this.button5);
            this.tabPagePlayer.Controls.Add(this.button6);
            this.tabPagePlayer.Controls.Add(this.dataGridViewPlayer);
            this.tabPagePlayer.Location = new System.Drawing.Point(4, 22);
            this.tabPagePlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagePlayer.Name = "tabPagePlayer";
            this.tabPagePlayer.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPagePlayer.Size = new System.Drawing.Size(635, 363);
            this.tabPagePlayer.TabIndex = 1;
            this.tabPagePlayer.Text = "Players";
            this.tabPagePlayer.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchPlayer
            // 
            this.textBoxSearchPlayer.Location = new System.Drawing.Point(14, 48);
            this.textBoxSearchPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchPlayer.Name = "textBoxSearchPlayer";
            this.textBoxSearchPlayer.Size = new System.Drawing.Size(200, 20);
            this.textBoxSearchPlayer.TabIndex = 7;
            this.textBoxSearchPlayer.TextChanged += new System.EventHandler(this.textBoxSearchPlayer_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(515, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 28);
            this.button2.TabIndex = 6;
            this.button2.Text = "Delete Player";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(406, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(105, 28);
            this.button5.TabIndex = 5;
            this.button5.Text = "Edit Player";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(296, 37);
            this.button6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 28);
            this.button6.TabIndex = 4;
            this.button6.Text = "Add New Player";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(14, 76);
            this.dataGridViewPlayer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.RowHeadersWidth = 51;
            this.dataGridViewPlayer.RowTemplate.Height = 24;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(610, 271);
            this.dataGridViewPlayer.TabIndex = 2;
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.textBoxSearchTeam);
            this.tabPageTeam.Controls.Add(this.button4);
            this.tabPageTeam.Controls.Add(this.button3);
            this.tabPageTeam.Controls.Add(this.button1);
            this.tabPageTeam.Controls.Add(this.dataGridViewTeam);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPageTeam.Size = new System.Drawing.Size(635, 363);
            this.tabPageTeam.TabIndex = 0;
            this.tabPageTeam.Text = "Teams";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // textBoxSearchTeam
            // 
            this.textBoxSearchTeam.Location = new System.Drawing.Point(13, 48);
            this.textBoxSearchTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSearchTeam.Name = "textBoxSearchTeam";
            this.textBoxSearchTeam.Size = new System.Drawing.Size(200, 20);
            this.textBoxSearchTeam.TabIndex = 8;
            this.textBoxSearchTeam.TextChanged += new System.EventHandler(this.textBoxSearchTeam_TextChanged);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(518, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "Delete Team";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(408, 37);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Edit Team";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 37);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 28);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add New Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewTeam
            // 
            this.dataGridViewTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeam.Location = new System.Drawing.Point(13, 80);
            this.dataGridViewTeam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTeam.Name = "dataGridViewTeam";
            this.dataGridViewTeam.RowHeadersWidth = 51;
            this.dataGridViewTeam.RowTemplate.Height = 24;
            this.dataGridViewTeam.Size = new System.Drawing.Size(610, 271);
            this.dataGridViewTeam.TabIndex = 0;
            // 
            // FormPlayerTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 430);
            this.Controls.Add(this.tabControlTeam);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPlayerTeam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPlayerTeam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPlayerTeam_FormClosing);
            this.Load += new System.EventHandler(this.FormPlayerTeam_Load);
            this.tabControlTeam.ResumeLayout(false);
            this.tabPagePlayer.ResumeLayout(false);
            this.tabPagePlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeam)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTeam;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewTeam;
        private System.Windows.Forms.TabPage tabPagePlayer;
        private System.Windows.Forms.DataGridView dataGridViewPlayer;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBoxSearchPlayer;
        private System.Windows.Forms.TextBox textBoxSearchTeam;
    }
}