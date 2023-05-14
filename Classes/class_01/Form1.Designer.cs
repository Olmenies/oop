namespace class_01
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
            this.ButtonCreateAlumn = new System.Windows.Forms.Button();
            this.ButtonAddName = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.ButtonDisplayData = new System.Windows.Forms.Button();
            this.TextBoxSurname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCreateAlumn
            // 
            this.ButtonCreateAlumn.Location = new System.Drawing.Point(12, 12);
            this.ButtonCreateAlumn.Name = "ButtonCreateAlumn";
            this.ButtonCreateAlumn.Size = new System.Drawing.Size(75, 23);
            this.ButtonCreateAlumn.TabIndex = 0;
            this.ButtonCreateAlumn.Text = "Create alumn";
            this.ButtonCreateAlumn.UseVisualStyleBackColor = true;
            this.ButtonCreateAlumn.Click += new System.EventHandler(this.ButtonCreateAlumn_Click);
            // 
            // ButtonAddName
            // 
            this.ButtonAddName.Location = new System.Drawing.Point(12, 41);
            this.ButtonAddName.Name = "ButtonAddName";
            this.ButtonAddName.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddName.TabIndex = 1;
            this.ButtonAddName.Text = "Add name";
            this.ButtonAddName.UseVisualStyleBackColor = true;
            this.ButtonAddName.Click += new System.EventHandler(this.ButtonAddName_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(93, 14);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(100, 20);
            this.TextBoxName.TabIndex = 2;
            // 
            // ButtonDisplayData
            // 
            this.ButtonDisplayData.Location = new System.Drawing.Point(12, 70);
            this.ButtonDisplayData.Name = "ButtonDisplayData";
            this.ButtonDisplayData.Size = new System.Drawing.Size(75, 23);
            this.ButtonDisplayData.TabIndex = 3;
            this.ButtonDisplayData.Text = "See data";
            this.ButtonDisplayData.UseVisualStyleBackColor = true;
            this.ButtonDisplayData.Click += new System.EventHandler(this.ButtonDisplayData_Click);
            // 
            // TextBoxSurname
            // 
            this.TextBoxSurname.Location = new System.Drawing.Point(93, 44);
            this.TextBoxSurname.Name = "TextBoxSurname";
            this.TextBoxSurname.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSurname.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 161);
            this.Controls.Add(this.TextBoxSurname);
            this.Controls.Add(this.ButtonDisplayData);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonAddName);
            this.Controls.Add(this.ButtonCreateAlumn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonCreateAlumn;
        private System.Windows.Forms.Button ButtonAddName;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Button ButtonDisplayData;
        private System.Windows.Forms.TextBox TextBoxSurname;
    }
}

