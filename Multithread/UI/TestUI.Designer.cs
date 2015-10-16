namespace Multithread.UI
{
    partial class TestUI
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
            this.btnClick = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClickFast = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(117, 60);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(75, 23);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click me!";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(114, 120);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(398, 185);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "Result--";
            // 
            // btnClickFast
            // 
            this.btnClickFast.Location = new System.Drawing.Point(274, 60);
            this.btnClickFast.Name = "btnClickFast";
            this.btnClickFast.Size = new System.Drawing.Size(202, 23);
            this.btnClickFast.TabIndex = 2;
            this.btnClickFast.Text = "Click me! (Faster version)";
            this.btnClickFast.UseVisualStyleBackColor = true;
            this.btnClickFast.Click += new System.EventHandler(this.btnClickFast_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(125, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(50, 17);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "status:";
            // 
            // lblResult2
            // 
            this.lblResult2.Location = new System.Drawing.Point(575, 120);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(398, 185);
            this.lblResult2.TabIndex = 4;
            this.lblResult2.Text = "Result--";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(107, 184);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(346, 200);
            this.txtResult.TabIndex = 5;
            // 
            // TestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 396);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnClickFast);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClick);
            this.Name = "TestUI";
            this.Text = "TestUI";
            this.Load += new System.EventHandler(this.TestUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClickFast;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.TextBox txtResult;
    }
}