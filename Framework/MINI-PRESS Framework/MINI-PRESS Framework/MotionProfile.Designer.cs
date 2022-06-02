
namespace MINI_PRESS_Framework
{
    partial class MotionProfile
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
            this.lbl_ForceLimit = new System.Windows.Forms.Label();
            this.txt_ForceLimit = new System.Windows.Forms.TextBox();
            this.lbl_GraphLimit = new System.Windows.Forms.Label();
            this.txt_GraphLimit = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_ForceLimit
            // 
            this.lbl_ForceLimit.AutoSize = true;
            this.lbl_ForceLimit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ForceLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_ForceLimit.Location = new System.Drawing.Point(29, 55);
            this.lbl_ForceLimit.Name = "lbl_ForceLimit";
            this.lbl_ForceLimit.Size = new System.Drawing.Size(85, 15);
            this.lbl_ForceLimit.TabIndex = 26;
            this.lbl_ForceLimit.Text = "Kuvvet Limiti:";
            this.lbl_ForceLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_ForceLimit
            // 
            this.txt_ForceLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_ForceLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ForceLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_ForceLimit.ForeColor = System.Drawing.Color.Black;
            this.txt_ForceLimit.Location = new System.Drawing.Point(134, 51);
            this.txt_ForceLimit.MinimumSize = new System.Drawing.Size(50, 15);
            this.txt_ForceLimit.Name = "txt_ForceLimit";
            this.txt_ForceLimit.Size = new System.Drawing.Size(160, 23);
            this.txt_ForceLimit.TabIndex = 24;
            this.txt_ForceLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_GraphLimit
            // 
            this.lbl_GraphLimit.AutoSize = true;
            this.lbl_GraphLimit.BackColor = System.Drawing.Color.Transparent;
            this.lbl_GraphLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_GraphLimit.Location = new System.Drawing.Point(29, 92);
            this.lbl_GraphLimit.Name = "lbl_GraphLimit";
            this.lbl_GraphLimit.Size = new System.Drawing.Size(76, 15);
            this.lbl_GraphLimit.TabIndex = 27;
            this.lbl_GraphLimit.Text = "Grafik Limit:";
            this.lbl_GraphLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_GraphLimit
            // 
            this.txt_GraphLimit.BackColor = System.Drawing.SystemColors.Window;
            this.txt_GraphLimit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_GraphLimit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txt_GraphLimit.ForeColor = System.Drawing.Color.White;
            this.txt_GraphLimit.Location = new System.Drawing.Point(134, 88);
            this.txt_GraphLimit.MinimumSize = new System.Drawing.Size(50, 15);
            this.txt_GraphLimit.Name = "txt_GraphLimit";
            this.txt_GraphLimit.Size = new System.Drawing.Size(160, 23);
            this.txt_GraphLimit.TabIndex = 25;
            this.txt_GraphLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MotionProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(186)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1114, 748);
            this.Controls.Add(this.lbl_ForceLimit);
            this.Controls.Add(this.txt_ForceLimit);
            this.Controls.Add(this.lbl_GraphLimit);
            this.Controls.Add(this.txt_GraphLimit);
            this.Name = "MotionProfile";
            this.Text = "MotionProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ForceLimit;
        private System.Windows.Forms.TextBox txt_ForceLimit;
        private System.Windows.Forms.Label lbl_GraphLimit;
        private System.Windows.Forms.TextBox txt_GraphLimit;
    }
}