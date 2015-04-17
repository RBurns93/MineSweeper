namespace Minesweeper
{
    partial class InitializationForm
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
            this.txtBName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.radBtnEasy = new System.Windows.Forms.RadioButton();
            this.radBtnMedium = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBName
            // 
            this.txtBName.Location = new System.Drawing.Point(12, 89);
            this.txtBName.Name = "txtBName";
            this.txtBName.Size = new System.Drawing.Size(145, 22);
            this.txtBName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 54);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(166, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Please Enter your Name:";
            // 
            // radBtnEasy
            // 
            this.radBtnEasy.AutoSize = true;
            this.radBtnEasy.Location = new System.Drawing.Point(195, 50);
            this.radBtnEasy.Name = "radBtnEasy";
            this.radBtnEasy.Size = new System.Drawing.Size(60, 21);
            this.radBtnEasy.TabIndex = 2;
            this.radBtnEasy.TabStop = true;
            this.radBtnEasy.Text = "Easy";
            this.radBtnEasy.UseVisualStyleBackColor = true;
            // 
            // radBtnMedium
            // 
            this.radBtnMedium.AutoSize = true;
            this.radBtnMedium.Location = new System.Drawing.Point(195, 77);
            this.radBtnMedium.Name = "radBtnMedium";
            this.radBtnMedium.Size = new System.Drawing.Size(78, 21);
            this.radBtnMedium.TabIndex = 3;
            this.radBtnMedium.TabStop = true;
            this.radBtnMedium.Text = "Medium";
            this.radBtnMedium.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(195, 104);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(60, 21);
            this.radioButton3.TabIndex = 4;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Hard";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(103, 180);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(99, 37);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // InitializationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 253);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radBtnMedium);
            this.Controls.Add(this.radBtnEasy);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtBName);
            this.Name = "InitializationForm";
            this.Text = "Select a Difficulty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.RadioButton radBtnEasy;
        private System.Windows.Forms.RadioButton radBtnMedium;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnStart;
    }
}

