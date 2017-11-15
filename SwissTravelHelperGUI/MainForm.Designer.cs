namespace SwissTravelHelperGUI
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.From_Label = new System.Windows.Forms.Label();
            this.To_Label = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ToTime_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureBoard_Button = new System.Windows.Forms.Button();
            this.Connection_Button = new System.Windows.Forms.Button();
            this.Map_Button = new System.Windows.Forms.Button();
            this.FromDelete_Button = new System.Windows.Forms.Button();
            this.ToDelete_Button = new System.Windows.Forms.Button();
            this.From_ComboBox = new System.Windows.Forms.ComboBox();
            this.To_ComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // From_Label
            // 
            this.From_Label.AutoSize = true;
            this.From_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_Label.Location = new System.Drawing.Point(13, 13);
            this.From_Label.Name = "From_Label";
            this.From_Label.Size = new System.Drawing.Size(62, 31);
            this.From_Label.TabIndex = 1;
            this.From_Label.Text = "Von";
            // 
            // To_Label
            // 
            this.To_Label.AutoSize = true;
            this.To_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_Label.Location = new System.Drawing.Point(13, 146);
            this.To_Label.Name = "To_Label";
            this.To_Label.Size = new System.Drawing.Size(78, 31);
            this.To_Label.TabIndex = 3;
            this.To_Label.Text = "Nach";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(196, 63);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // ToTime_DateTimePicker
            // 
            this.ToTime_DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToTime_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTime_DateTimePicker.Location = new System.Drawing.Point(196, 196);
            this.ToTime_DateTimePicker.Name = "ToTime_DateTimePicker";
            this.ToTime_DateTimePicker.Size = new System.Drawing.Size(200, 30);
            this.ToTime_DateTimePicker.TabIndex = 5;
            // 
            // DepartureBoard_Button
            // 
            this.DepartureBoard_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartureBoard_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureBoard_Button.Location = new System.Drawing.Point(423, 117);
            this.DepartureBoard_Button.Name = "DepartureBoard_Button";
            this.DepartureBoard_Button.Size = new System.Drawing.Size(121, 30);
            this.DepartureBoard_Button.TabIndex = 6;
            this.DepartureBoard_Button.Text = "Abfahrtstaffel";
            this.DepartureBoard_Button.UseVisualStyleBackColor = true;
            // 
            // Connection_Button
            // 
            this.Connection_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Connection_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_Button.Location = new System.Drawing.Point(423, 250);
            this.Connection_Button.Name = "Connection_Button";
            this.Connection_Button.Size = new System.Drawing.Size(121, 30);
            this.Connection_Button.TabIndex = 10;
            this.Connection_Button.Text = "Verbindung";
            this.Connection_Button.UseVisualStyleBackColor = true;
            // 
            // Map_Button
            // 
            this.Map_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Map_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Map_Marker_Bubble_Chartreuse_icon;
            this.Map_Button.Location = new System.Drawing.Point(483, 63);
            this.Map_Button.Name = "Map_Button";
            this.Map_Button.Size = new System.Drawing.Size(30, 30);
            this.Map_Button.TabIndex = 11;
            this.Map_Button.UseVisualStyleBackColor = true;
            // 
            // FromDelete_Button
            // 
            this.FromDelete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDelete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDelete_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Actions_edit_delete_icon_new;
            this.FromDelete_Button.Location = new System.Drawing.Point(423, 63);
            this.FromDelete_Button.Name = "FromDelete_Button";
            this.FromDelete_Button.Size = new System.Drawing.Size(30, 30);
            this.FromDelete_Button.TabIndex = 9;
            this.FromDelete_Button.UseVisualStyleBackColor = true;
            this.FromDelete_Button.Click += new System.EventHandler(this.FromDelete_Button_Click);
            // 
            // ToDelete_Button
            // 
            this.ToDelete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDelete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDelete_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Actions_edit_delete_icon_new;
            this.ToDelete_Button.Location = new System.Drawing.Point(423, 196);
            this.ToDelete_Button.Name = "ToDelete_Button";
            this.ToDelete_Button.Size = new System.Drawing.Size(30, 30);
            this.ToDelete_Button.TabIndex = 8;
            this.ToDelete_Button.UseVisualStyleBackColor = true;
            this.ToDelete_Button.Click += new System.EventHandler(this.ToDelete_Button_Click);
            // 
            // From_ComboBox
            // 
            this.From_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_ComboBox.FormattingEnabled = true;
            this.From_ComboBox.Location = new System.Drawing.Point(13, 63);
            this.From_ComboBox.Name = "From_ComboBox";
            this.From_ComboBox.Size = new System.Drawing.Size(153, 30);
            this.From_ComboBox.TabIndex = 12;
            // 
            // To_ComboBox
            // 
            this.To_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_ComboBox.FormattingEnabled = true;
            this.To_ComboBox.Location = new System.Drawing.Point(13, 196);
            this.To_ComboBox.Name = "To_ComboBox";
            this.To_ComboBox.Size = new System.Drawing.Size(153, 30);
            this.To_ComboBox.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 345);
            this.Controls.Add(this.To_ComboBox);
            this.Controls.Add(this.From_ComboBox);
            this.Controls.Add(this.Map_Button);
            this.Controls.Add(this.Connection_Button);
            this.Controls.Add(this.FromDelete_Button);
            this.Controls.Add(this.ToDelete_Button);
            this.Controls.Add(this.DepartureBoard_Button);
            this.Controls.Add(this.ToTime_DateTimePicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.From_Label);
            this.Name = "MainForm";
            this.Text = "SwissTravelHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Label To_Label;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker ToTime_DateTimePicker;
        private System.Windows.Forms.Button DepartureBoard_Button;
        private System.Windows.Forms.Button ToDelete_Button;
        private System.Windows.Forms.Button FromDelete_Button;
        private System.Windows.Forms.Button Connection_Button;
        private System.Windows.Forms.Button Map_Button;
        private System.Windows.Forms.ComboBox From_ComboBox;
        private System.Windows.Forms.ComboBox To_ComboBox;
    }
}

