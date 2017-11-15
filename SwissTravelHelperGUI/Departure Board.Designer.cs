namespace SwissTravelHelperGUI
{
    partial class DepartureBoard
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
            this.DepartureBoard_Listbox = new System.Windows.Forms.ListBox();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Mail_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DepartureBoard_Listbox
            // 
            this.DepartureBoard_Listbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartureBoard_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureBoard_Listbox.ItemHeight = 20;
            this.DepartureBoard_Listbox.Location = new System.Drawing.Point(12, 58);
            this.DepartureBoard_Listbox.Name = "DepartureBoard_Listbox";
            this.DepartureBoard_Listbox.Size = new System.Drawing.Size(233, 184);
            this.DepartureBoard_Listbox.TabIndex = 0;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date_Label.Location = new System.Drawing.Point(13, 13);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(154, 31);
            this.Date_Label.TabIndex = 1;
            this.Date_Label.Text = "DefaultText";
            // 
            // Stop_Button
            // 
            this.Stop_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.Location = new System.Drawing.Point(147, 248);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(98, 30);
            this.Stop_Button.TabIndex = 11;
            this.Stop_Button.Text = "Abbrechen";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Mail_Button
            // 
            this.Mail_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mail_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Mail_icon;
            this.Mail_Button.Location = new System.Drawing.Point(215, 16);
            this.Mail_Button.Name = "Mail_Button";
            this.Mail_Button.Size = new System.Drawing.Size(30, 30);
            this.Mail_Button.TabIndex = 12;
            this.Mail_Button.UseVisualStyleBackColor = true;
            // 
            // DepartureBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 284);
            this.Controls.Add(this.Mail_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Date_Label);
            this.Controls.Add(this.DepartureBoard_Listbox);
            this.Name = "DepartureBoard";
            this.Text = "DepartureBoard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox DepartureBoard_Listbox;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Mail_Button;
    }
}