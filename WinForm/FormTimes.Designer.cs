
namespace WinForm
{
    partial class FormTimes
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
            this.panelCandle = new System.Windows.Forms.Panel();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.dateTimPicStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimPicStop = new System.Windows.Forms.DateTimePicker();
            this.butExpandPan = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.butPrintViaDelegate = new System.Windows.Forms.Button();
            this.panelCandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCandle
            // 
            this.panelCandle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCandle.Controls.Add(this.textMessage);
            this.panelCandle.Controls.Add(this.dateTimPicStart);
            this.panelCandle.Controls.Add(this.dateTimPicStop);
            this.panelCandle.Controls.Add(this.butExpandPan);
            this.panelCandle.Controls.Add(this.label11);
            this.panelCandle.Controls.Add(this.label9);
            this.panelCandle.Controls.Add(this.label10);
            this.panelCandle.Location = new System.Drawing.Point(5, 6);
            this.panelCandle.Name = "panelCandle";
            this.panelCandle.Size = new System.Drawing.Size(351, 50);
            this.panelCandle.TabIndex = 43;
            // 
            // textMessage
            // 
            this.textMessage.ForeColor = System.Drawing.Color.Maroon;
            this.textMessage.Location = new System.Drawing.Point(176, 2);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(168, 20);
            this.textMessage.TabIndex = 45;
            this.textMessage.Text = "Example times in the FormTimes";
            // 
            // dateTimPicStart
            // 
            this.dateTimPicStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimPicStart.Location = new System.Drawing.Point(35, 25);
            this.dateTimPicStart.Name = "dateTimPicStart";
            this.dateTimPicStart.Size = new System.Drawing.Size(136, 20);
            this.dateTimPicStart.TabIndex = 43;
            // 
            // dateTimPicStop
            // 
            this.dateTimPicStop.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimPicStop.Location = new System.Drawing.Point(208, 25);
            this.dateTimPicStop.Name = "dateTimPicStop";
            this.dateTimPicStop.Size = new System.Drawing.Size(136, 20);
            this.dateTimPicStop.TabIndex = 44;
            // 
            // butExpandPan
            // 
            this.butExpandPan.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.butExpandPan.Font = new System.Drawing.Font("MS Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butExpandPan.Location = new System.Drawing.Point(360, 29);
            this.butExpandPan.Name = "butExpandPan";
            this.butExpandPan.Size = new System.Drawing.Size(15, 14);
            this.butExpandPan.TabIndex = 114;
            this.butExpandPan.Text = "v";
            this.butExpandPan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.butExpandPan.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(173, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Stop:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(1, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "Start:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.Location = new System.Drawing.Point(2, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Params";
            // 
            // butPrintViaDelegate
            // 
            this.butPrintViaDelegate.Location = new System.Drawing.Point(5, 60);
            this.butPrintViaDelegate.Name = "butPrintViaDelegate";
            this.butPrintViaDelegate.Size = new System.Drawing.Size(171, 20);
            this.butPrintViaDelegate.TabIndex = 44;
            this.butPrintViaDelegate.Text = "Print dates to Form1 via delegate";
            this.butPrintViaDelegate.UseVisualStyleBackColor = true;
            this.butPrintViaDelegate.Click += new System.EventHandler(this.butPrintViaDelegate_Click);
            // 
            // FormTimes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 89);
            this.Controls.Add(this.butPrintViaDelegate);
            this.Controls.Add(this.panelCandle);
            this.Name = "FormTimes";
            this.Text = "FormTimes";
            this.panelCandle.ResumeLayout(false);
            this.panelCandle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCandle;
        private System.Windows.Forms.DateTimePicker dateTimPicStart;
        private System.Windows.Forms.DateTimePicker dateTimPicStop;
        private System.Windows.Forms.Button butExpandPan;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button butPrintViaDelegate;
        private System.Windows.Forms.TextBox textMessage;
    }
}