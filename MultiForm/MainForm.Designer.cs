namespace MultiForm
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
            this.PersonlistBox = new System.Windows.Forms.ListBox();
            this.ViewButton = new System.Windows.Forms.Button();
            this.Addbutton1 = new System.Windows.Forms.Button();
            this.Deletebutton1 = new System.Windows.Forms.Button();
            this.Editbutton1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PersonlistBox
            // 
            this.PersonlistBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonlistBox.ForeColor = System.Drawing.Color.Red;
            this.PersonlistBox.FormattingEnabled = true;
            this.PersonlistBox.ItemHeight = 48;
            this.PersonlistBox.Location = new System.Drawing.Point(17, 16);
            this.PersonlistBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PersonlistBox.Name = "PersonlistBox";
            this.PersonlistBox.Size = new System.Drawing.Size(640, 196);
            this.PersonlistBox.TabIndex = 0;
            // 
            // ViewButton
            // 
            this.ViewButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewButton.ForeColor = System.Drawing.Color.Red;
            this.ViewButton.Location = new System.Drawing.Point(17, 286);
            this.ViewButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(205, 55);
            this.ViewButton.TabIndex = 1;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = false;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // Addbutton1
            // 
            this.Addbutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Addbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Addbutton1.ForeColor = System.Drawing.Color.Red;
            this.Addbutton1.Location = new System.Drawing.Point(453, 286);
            this.Addbutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Addbutton1.Name = "Addbutton1";
            this.Addbutton1.Size = new System.Drawing.Size(205, 55);
            this.Addbutton1.TabIndex = 2;
            this.Addbutton1.Text = "Add";
            this.Addbutton1.UseVisualStyleBackColor = false;
            this.Addbutton1.Click += new System.EventHandler(this.Addbutton1_Click);
            // 
            // Deletebutton1
            // 
            this.Deletebutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Deletebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Deletebutton1.ForeColor = System.Drawing.Color.Red;
            this.Deletebutton1.Location = new System.Drawing.Point(232, 286);
            this.Deletebutton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Deletebutton1.Name = "Deletebutton1";
            this.Deletebutton1.Size = new System.Drawing.Size(213, 55);
            this.Deletebutton1.TabIndex = 3;
            this.Deletebutton1.Text = "Delete";
            this.Deletebutton1.UseVisualStyleBackColor = false;
            this.Deletebutton1.Click += new System.EventHandler(this.Deletebutton1_Click);
            // 
            // Editbutton1
            // 
            this.Editbutton1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Editbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Editbutton1.ForeColor = System.Drawing.Color.Red;
            this.Editbutton1.Location = new System.Drawing.Point(17, 349);
            this.Editbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Editbutton1.Name = "Editbutton1";
            this.Editbutton1.Size = new System.Drawing.Size(640, 55);
            this.Editbutton1.TabIndex = 4;
            this.Editbutton1.Text = "Edit";
            this.Editbutton1.UseVisualStyleBackColor = false;
            this.Editbutton1.Click += new System.EventHandler(this.Editbutton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 692);
            this.Controls.Add(this.Editbutton1);
            this.Controls.Add(this.Deletebutton1);
            this.Controls.Add(this.Addbutton1);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.PersonlistBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.DoubleClick += new System.EventHandler(this.Form1_DoubleClick);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox PersonlistBox;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Button Addbutton1;
        private System.Windows.Forms.Button Deletebutton1;
        private System.Windows.Forms.Button Editbutton1;
    }
}

