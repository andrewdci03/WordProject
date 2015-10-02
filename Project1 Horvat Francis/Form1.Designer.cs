using System.Collections.Generic;

namespace Project1_Horvat_Francis
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
            this.components = new System.ComponentModel.Container();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.startButton = new System.Windows.Forms.Button();
            this.Letter_5 = new System.Windows.Forms.TextBox();
            this.Letter_4 = new System.Windows.Forms.TextBox();
            this.Letter_3 = new System.Windows.Forms.TextBox();
            this.Letter_2 = new System.Windows.Forms.TextBox();
            this.Letter_1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gameWordList = new System.Windows.Forms.ListBox();
            this.endButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(153, 35);
            this.checkBox5.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(15, 14);
            this.checkBox5.TabIndex = 23;
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(119, 35);
            this.checkBox4.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(15, 14);
            this.checkBox4.TabIndex = 22;
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(85, 35);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(15, 14);
            this.checkBox3.TabIndex = 21;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(51, 35);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.checkBox1.Location = new System.Drawing.Point(17, 35);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 19;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(193, 7);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(39, 30);
            this.startButton.TabIndex = 18;
            this.startButton.Text = "GO!";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Letter_5
            // 
            this.Letter_5.Location = new System.Drawing.Point(147, 14);
            this.Letter_5.Name = "Letter_5";
            this.Letter_5.Size = new System.Drawing.Size(28, 20);
            this.Letter_5.TabIndex = 17;
            // 
            // Letter_4
            // 
            this.Letter_4.Location = new System.Drawing.Point(113, 14);
            this.Letter_4.Name = "Letter_4";
            this.Letter_4.Size = new System.Drawing.Size(28, 20);
            this.Letter_4.TabIndex = 16;
            // 
            // Letter_3
            // 
            this.Letter_3.Location = new System.Drawing.Point(79, 14);
            this.Letter_3.Name = "Letter_3";
            this.Letter_3.Size = new System.Drawing.Size(28, 20);
            this.Letter_3.TabIndex = 15;
            // 
            // Letter_2
            // 
            this.Letter_2.Location = new System.Drawing.Point(45, 14);
            this.Letter_2.Name = "Letter_2";
            this.Letter_2.Size = new System.Drawing.Size(28, 20);
            this.Letter_2.TabIndex = 14;
            // 
            // Letter_1
            // 
            this.Letter_1.Location = new System.Drawing.Point(11, 14);
            this.Letter_1.Name = "Letter_1";
            this.Letter_1.Size = new System.Drawing.Size(28, 20);
            this.Letter_1.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gameWordList
            // 
            this.gameWordList.FormattingEnabled = true;
            this.gameWordList.Location = new System.Drawing.Point(8, 68);
            this.gameWordList.Margin = new System.Windows.Forms.Padding(2);
            this.gameWordList.Name = "gameWordList";
            this.gameWordList.Size = new System.Drawing.Size(297, 212);
            this.gameWordList.TabIndex = 25;
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(251, 7);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(39, 30);
            this.endButton.TabIndex = 24;
            this.endButton.Text = "End";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "Reset Game!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.Letter_5);
            this.Controls.Add(this.Letter_4);
            this.Controls.Add(this.Letter_3);
            this.Controls.Add(this.Letter_2);
            this.Controls.Add(this.Letter_1);
            this.Controls.Add(this.gameWordList);
            this.Controls.Add(this.endButton);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

           

        #endregion

        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox Letter_5;
        private System.Windows.Forms.TextBox Letter_4;
        private System.Windows.Forms.TextBox Letter_3;
        private System.Windows.Forms.TextBox Letter_2;
        private System.Windows.Forms.TextBox Letter_1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox gameWordList;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.Button button1;
    }
}

