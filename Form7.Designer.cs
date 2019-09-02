namespace Fantasy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.userinput = new System.Windows.Forms.TextBox();
            this.extBtn = new System.Windows.Forms.Button();
            this.LogBtn = new System.Windows.Forms.Button();
            this.label59 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userinput
            // 
            this.userinput.Location = new System.Drawing.Point(644, 388);
            this.userinput.Name = "userinput";
            this.userinput.Size = new System.Drawing.Size(186, 22);
            this.userinput.TabIndex = 29;
            // 
            // extBtn
            // 
            this.extBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("extBtn.BackgroundImage")));
            this.extBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.extBtn.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extBtn.Location = new System.Drawing.Point(440, 581);
            this.extBtn.Name = "extBtn";
            this.extBtn.Size = new System.Drawing.Size(217, 55);
            this.extBtn.TabIndex = 28;
            this.extBtn.Text = "EXIT";
            this.extBtn.UseVisualStyleBackColor = true;
            // 
            // LogBtn
            // 
            this.LogBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LogBtn.BackgroundImage")));
            this.LogBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LogBtn.Font = new System.Drawing.Font("Times New Roman", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBtn.Location = new System.Drawing.Point(688, 581);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(217, 55);
            this.LogBtn.TabIndex = 27;
            this.LogBtn.Text = "LOGIN";
            this.LogBtn.UseVisualStyleBackColor = true;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.BackColor = System.Drawing.Color.Transparent;
            this.label59.Font = new System.Drawing.Font("Viner Hand ITC", 60F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.ForeColor = System.Drawing.Color.Gold;
            this.label59.Location = new System.Drawing.Point(471, 154);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(377, 162);
            this.label59.TabIndex = 26;
            this.label59.Text = "LOGIN";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.BackColor = System.Drawing.Color.Transparent;
            this.label60.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label60.ForeColor = System.Drawing.Color.Maroon;
            this.label60.Location = new System.Drawing.Point(404, 451);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(185, 45);
            this.label60.TabIndex = 25;
            this.label60.Text = "Password";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.BackColor = System.Drawing.Color.Transparent;
            this.label61.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.Color.Maroon;
            this.label61.Location = new System.Drawing.Point(404, 368);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(211, 45);
            this.label61.TabIndex = 24;
            this.label61.Text = "User Name";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1382, 753);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.extBtn);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.label59);
            this.Controls.Add(this.label60);
            this.Controls.Add(this.label61);
            this.Name = "Form7";
            this.Text = "Form7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.Button extBtn;
        private System.Windows.Forms.Button LogBtn;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Label label61;
    }
}