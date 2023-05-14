namespace class_01_thermometer
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
            this.buttonAssignTemperature = new System.Windows.Forms.Button();
            this.textBoxTemperature = new System.Windows.Forms.TextBox();
            this.buttonSubscribe = new System.Windows.Forms.Button();
            this.buttonUnsubscribe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAssignTemperature
            // 
            this.buttonAssignTemperature.Location = new System.Drawing.Point(12, 12);
            this.buttonAssignTemperature.Name = "buttonAssignTemperature";
            this.buttonAssignTemperature.Size = new System.Drawing.Size(75, 23);
            this.buttonAssignTemperature.TabIndex = 0;
            this.buttonAssignTemperature.Text = "Assign temperature";
            this.buttonAssignTemperature.UseVisualStyleBackColor = true;
            this.buttonAssignTemperature.Click += new System.EventHandler(this.buttonAssignTemperature_Click);
            // 
            // textBoxTemperature
            // 
            this.textBoxTemperature.Location = new System.Drawing.Point(93, 15);
            this.textBoxTemperature.Name = "textBoxTemperature";
            this.textBoxTemperature.Size = new System.Drawing.Size(100, 20);
            this.textBoxTemperature.TabIndex = 1;
            // 
            // buttonSubscribe
            // 
            this.buttonSubscribe.Location = new System.Drawing.Point(12, 41);
            this.buttonSubscribe.Name = "buttonSubscribe";
            this.buttonSubscribe.Size = new System.Drawing.Size(75, 23);
            this.buttonSubscribe.TabIndex = 2;
            this.buttonSubscribe.Text = "Subscribe";
            this.buttonSubscribe.UseVisualStyleBackColor = true;
            this.buttonSubscribe.Click += new System.EventHandler(this.buttonSubscribe_Click);
            // 
            // buttonUnsubscribe
            // 
            this.buttonUnsubscribe.Location = new System.Drawing.Point(12, 70);
            this.buttonUnsubscribe.Name = "buttonUnsubscribe";
            this.buttonUnsubscribe.Size = new System.Drawing.Size(75, 23);
            this.buttonUnsubscribe.TabIndex = 3;
            this.buttonUnsubscribe.Text = "Unsubscribe";
            this.buttonUnsubscribe.UseVisualStyleBackColor = true;
            this.buttonUnsubscribe.Click += new System.EventHandler(this.buttonUnsubscribe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 275);
            this.Controls.Add(this.buttonUnsubscribe);
            this.Controls.Add(this.buttonSubscribe);
            this.Controls.Add(this.textBoxTemperature);
            this.Controls.Add(this.buttonAssignTemperature);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAssignTemperature;
        private System.Windows.Forms.TextBox textBoxTemperature;
        private System.Windows.Forms.Button buttonSubscribe;
        private System.Windows.Forms.Button buttonUnsubscribe;
    }
}

