
namespace WinForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.textDelegat = new System.Windows.Forms.TextBox();
            this.butCreateFormTimes = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.labTime2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labTime1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create next Form2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textDelegat
            // 
            this.textDelegat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.textDelegat.Location = new System.Drawing.Point(7, 18);
            this.textDelegat.Name = "textDelegat";
            this.textDelegat.Size = new System.Drawing.Size(141, 20);
            this.textDelegat.TabIndex = 2;
            // 
            // butCreateFormTimes
            // 
            this.butCreateFormTimes.Location = new System.Drawing.Point(4, 51);
            this.butCreateFormTimes.Name = "butCreateFormTimes";
            this.butCreateFormTimes.Size = new System.Drawing.Size(124, 24);
            this.butCreateFormTimes.TabIndex = 4;
            this.butCreateFormTimes.Text = "Create next FormTimes";
            this.butCreateFormTimes.UseVisualStyleBackColor = true;
            this.butCreateFormTimes.Click += new System.EventHandler(this.butCreateFormTimes_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textMessage);
            this.panel1.Controls.Add(this.labTime2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labTime1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(153, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 66);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(3, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "FormTimes";
            // 
            // textMessage
            // 
            this.textMessage.ForeColor = System.Drawing.Color.Maroon;
            this.textMessage.Location = new System.Drawing.Point(6, 41);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(172, 20);
            this.textMessage.TabIndex = 46;
            // 
            // labTime2
            // 
            this.labTime2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTime2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTime2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labTime2.Location = new System.Drawing.Point(98, 22);
            this.labTime2.Name = "labTime2";
            this.labTime2.Size = new System.Drawing.Size(80, 16);
            this.labTime2.TabIndex = 6;
            this.labTime2.Text = "00000,0000";
            this.labTime2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Stop:";
            // 
            // labTime1
            // 
            this.labTime1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labTime1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labTime1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labTime1.Location = new System.Drawing.Point(98, 3);
            this.labTime1.Name = "labTime1";
            this.labTime1.Size = new System.Drawing.Size(80, 16);
            this.labTime1.TabIndex = 5;
            this.labTime1.Text = "00000,0000";
            this.labTime1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Start:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DELEGAT";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.butCreateFormTimes);
            this.panel2.Location = new System.Drawing.Point(7, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 86);
            this.panel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Create next child";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SeaGreen;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "This is the                    Form";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textDelegat);
            this.panel3.Location = new System.Drawing.Point(153, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(184, 42);
            this.panel3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label7.Location = new System.Drawing.Point(4, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "DELEGAT Form2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.Color.SeaGreen;
            this.label8.Location = new System.Drawing.Point(59, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "PARENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 132);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textDelegat;
        private System.Windows.Forms.Button butCreateFormTimes;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labTime2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labTime1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textMessage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

