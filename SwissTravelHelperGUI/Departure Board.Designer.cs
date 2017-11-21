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
            this.Station_Label = new System.Windows.Forms.Label();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.Mail_Button = new System.Windows.Forms.Button();
            this.DepartureBoard_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DepartureBoard_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Station_Label
            // 
            this.Station_Label.AutoSize = true;
            this.Station_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Station_Label.Location = new System.Drawing.Point(13, 13);
            this.Station_Label.Name = "Station_Label";
            this.Station_Label.Size = new System.Drawing.Size(154, 31);
            this.Station_Label.TabIndex = 1;
            this.Station_Label.Text = "DefaultText";
            // 
            // Stop_Button
            // 
            this.Stop_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.Location = new System.Drawing.Point(303, 301);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(98, 34);
            this.Stop_Button.TabIndex = 10;
            this.Stop_Button.Text = "Abbrechen";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // Mail_Button
            // 
            this.Mail_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mail_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Mail_icon;
            this.Mail_Button.Location = new System.Drawing.Point(371, 16);
            this.Mail_Button.Name = "Mail_Button";
            this.Mail_Button.Size = new System.Drawing.Size(30, 30);
            this.Mail_Button.TabIndex = 5;
            this.Mail_Button.UseVisualStyleBackColor = true;
            // 
            // DepartureBoard_DataGridView
            // 
            this.DepartureBoard_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartureBoard_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepartureBoard_DataGridView.Location = new System.Drawing.Point(12, 58);
            this.DepartureBoard_DataGridView.Name = "DepartureBoard_DataGridView";
            this.DepartureBoard_DataGridView.Size = new System.Drawing.Size(389, 235);
            this.DepartureBoard_DataGridView.TabIndex = 1;
            // 
            // DepartureBoard
            // 
            this.AcceptButton = this.Mail_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Stop_Button;
            this.ClientSize = new System.Drawing.Size(413, 345);
            this.Controls.Add(this.DepartureBoard_DataGridView);
            this.Controls.Add(this.Mail_Button);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.Station_Label);
            this.Name = "DepartureBoard";
            this.Text = "DepartureBoard";
            ((System.ComponentModel.ISupportInitialize)(this.DepartureBoard_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Station_Label;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Button Mail_Button;
        private System.Windows.Forms.DataGridView DepartureBoard_DataGridView;
    }
}