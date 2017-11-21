namespace SwissTravelHelperGUI
{
    partial class TimeTable
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
            this.Previous_Button = new System.Windows.Forms.Button();
            this.LaterOn_Button = new System.Windows.Forms.Button();
            this.From_Label = new System.Windows.Forms.Label();
            this.To_Label = new System.Windows.Forms.Label();
            this.TimeTable_DataGridView = new System.Windows.Forms.DataGridView();
            this.FromMap_Button = new System.Windows.Forms.Button();
            this.ToMap_Button = new System.Windows.Forms.Button();
            this.Directions_Button = new System.Windows.Forms.Button();
            this.Mail_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Previous_Button
            // 
            this.Previous_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Previous_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Previous_Button.Location = new System.Drawing.Point(430, 63);
            this.Previous_Button.Name = "Previous_Button";
            this.Previous_Button.Size = new System.Drawing.Size(127, 30);
            this.Previous_Button.TabIndex = 5;
            this.Previous_Button.Text = "Frühere Verbindung";
            this.Previous_Button.UseVisualStyleBackColor = true;
            this.Previous_Button.Click += new System.EventHandler(this.Previous_Button_Click);
            // 
            // LaterOn_Button
            // 
            this.LaterOn_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LaterOn_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaterOn_Button.Location = new System.Drawing.Point(430, 412);
            this.LaterOn_Button.Name = "LaterOn_Button";
            this.LaterOn_Button.Size = new System.Drawing.Size(127, 30);
            this.LaterOn_Button.TabIndex = 10;
            this.LaterOn_Button.Text = "Später Verbindung";
            this.LaterOn_Button.UseVisualStyleBackColor = true;
            this.LaterOn_Button.Click += new System.EventHandler(this.LaterOn_Button_Click);
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_Label.Location = new System.Drawing.Point(108, 18);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(62, 31);
            this.From_Label.TabIndex = 14;
            this.From_Label.Text = "Von";
            // 
            // To_Label
            // 
            this.To_Label.AutoSize = true;
            this.To_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_Label.Location = new System.Drawing.Point(338, 18);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(78, 31);
            this.To_Label.TabIndex = 15;
            this.To_Label.Text = "Nach";
            // 
            // TimeTable_DataGridView
            // 
            this.TimeTable_DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeTable_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TimeTable_DataGridView.Location = new System.Drawing.Point(12, 111);
            this.TimeTable_DataGridView.Name = "TimeTable_DataGridView";
            this.TimeTable_DataGridView.Size = new System.Drawing.Size(545, 286);
            this.TimeTable_DataGridView.TabIndex = 1;
            // 
            // FromMap_Button
            // 
            this.FromMap_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromMap_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Map_Marker_Bubble_Chartreuse_icon;
            this.FromMap_Button.Location = new System.Drawing.Point(168, 18);
            this.FromMap_Button.Name = "FromMap_Button";
            this.FromMap_Button.Size = new System.Drawing.Size(30, 30);
            this.FromMap_Button.TabIndex = 20;
            this.FromMap_Button.UseVisualStyleBackColor = true;
            this.FromMap_Button.Click += new System.EventHandler(this.FromMap_Button_Click);
            // 
            // ToMap_Button
            // 
            this.ToMap_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToMap_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Map_Marker_Bubble_Chartreuse_icon;
            this.ToMap_Button.Location = new System.Drawing.Point(413, 18);
            this.ToMap_Button.Name = "ToMap_Button";
            this.ToMap_Button.Size = new System.Drawing.Size(30, 30);
            this.ToMap_Button.TabIndex = 25;
            this.ToMap_Button.UseVisualStyleBackColor = true;
            this.ToMap_Button.Click += new System.EventHandler(this.ToMap_Button_Click);
            // 
            // Directions_Button
            // 
            this.Directions_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Arrow_OutRight_icon;
            this.Directions_Button.Location = new System.Drawing.Point(241, 21);
            this.Directions_Button.Name = "Directions_Button";
            this.Directions_Button.Size = new System.Drawing.Size(75, 30);
            this.Directions_Button.TabIndex = 15;
            this.Directions_Button.UseVisualStyleBackColor = true;
            this.Directions_Button.Click += new System.EventHandler(this.Directions_Button_Click);
            // 
            // Mail_Button
            // 
            this.Mail_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Mail_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mail_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Mail_icon;
            this.Mail_Button.Location = new System.Drawing.Point(527, 19);
            this.Mail_Button.Name = "Mail_Button";
            this.Mail_Button.Size = new System.Drawing.Size(30, 30);
            this.Mail_Button.TabIndex = 30;
            this.Mail_Button.UseVisualStyleBackColor = true;
            // 
            // TimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 454);
            this.Controls.Add(this.Mail_Button);
            this.Controls.Add(this.Directions_Button);
            this.Controls.Add(this.ToMap_Button);
            this.Controls.Add(this.TimeTable_DataGridView);
            this.Controls.Add(this.FromMap_Button);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.From_Label);
            this.Controls.Add(this.LaterOn_Button);
            this.Controls.Add(this.Previous_Button);
            this.Name = "TimeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TimeTable";
            ((System.ComponentModel.ISupportInitialize)(this.TimeTable_DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Previous_Button;
        private System.Windows.Forms.Button LaterOn_Button;
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Label To_Label;
        private System.Windows.Forms.Button FromMap_Button;
        private System.Windows.Forms.DataGridView TimeTable_DataGridView;
        private System.Windows.Forms.Button ToMap_Button;
        private System.Windows.Forms.Button Directions_Button;
        private System.Windows.Forms.Button Mail_Button;
    }
}