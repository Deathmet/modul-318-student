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
            this.FromTime_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ToTime_DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DepartureBoard_Button = new System.Windows.Forms.Button();
            this.Connection_Button = new System.Windows.Forms.Button();
            this.To_ComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FromTo_Label = new System.Windows.Forms.Label();
            this.FromTo_Button = new System.Windows.Forms.Button();
            this.Map_Button = new System.Windows.Forms.Button();
            this.FromDelete_Button = new System.Windows.Forms.Button();
            this.ToDelete_Button = new System.Windows.Forms.Button();
            this.From_ComboBox = new System.Windows.Forms.ComboBox();
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
            // FromTime_DateTimePicker
            // 
            this.FromTime_DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromTime_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTime_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.FromTime_DateTimePicker.Location = new System.Drawing.Point(212, 63);
            this.FromTime_DateTimePicker.Name = "FromTime_DateTimePicker";
            this.FromTime_DateTimePicker.Size = new System.Drawing.Size(118, 30);
            this.FromTime_DateTimePicker.TabIndex = 5;
            // 
            // ToTime_DateTimePicker
            // 
            this.ToTime_DateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToTime_DateTimePicker.Enabled = false;
            this.ToTime_DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToTime_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ToTime_DateTimePicker.Location = new System.Drawing.Point(212, 196);
            this.ToTime_DateTimePicker.Name = "ToTime_DateTimePicker";
            this.ToTime_DateTimePicker.Size = new System.Drawing.Size(118, 30);
            this.ToTime_DateTimePicker.TabIndex = 15;
            // 
            // DepartureBoard_Button
            // 
            this.DepartureBoard_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DepartureBoard_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepartureBoard_Button.Location = new System.Drawing.Point(357, 117);
            this.DepartureBoard_Button.Name = "DepartureBoard_Button";
            this.DepartureBoard_Button.Size = new System.Drawing.Size(121, 30);
            this.DepartureBoard_Button.TabIndex = 7;
            this.DepartureBoard_Button.Text = "Abfahrtstaffel";
            this.DepartureBoard_Button.UseVisualStyleBackColor = true;
            this.DepartureBoard_Button.Click += new System.EventHandler(this.DepartureBoard_Button_Click);
            // 
            // Connection_Button
            // 
            this.Connection_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Connection_Button.Enabled = false;
            this.Connection_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Connection_Button.Location = new System.Drawing.Point(357, 250);
            this.Connection_Button.Name = "Connection_Button";
            this.Connection_Button.Size = new System.Drawing.Size(121, 30);
            this.Connection_Button.TabIndex = 17;
            this.Connection_Button.Text = "Verbindung";
            this.Connection_Button.UseVisualStyleBackColor = true;
            this.Connection_Button.Click += new System.EventHandler(this.Connection_Button_Click);
            // 
            // To_ComboBox
            // 
            this.To_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.To_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_ComboBox.FormattingEnabled = true;
            this.To_ComboBox.Location = new System.Drawing.Point(13, 196);
            this.To_ComboBox.Name = "To_ComboBox";
            this.To_ComboBox.Size = new System.Drawing.Size(173, 30);
            this.To_ComboBox.TabIndex = 10;
            this.To_ComboBox.Enter += new System.EventHandler(this.To_ComboBox_Enter);
            this.To_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.To_ComboBox_KeyPress);
            this.To_ComboBox.Leave += new System.EventHandler(this.To_ComboBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Von";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nach";
            // 
            // FromTo_Label
            // 
            this.FromTo_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromTo_Label.AutoSize = true;
            this.FromTo_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTo_Label.Location = new System.Drawing.Point(194, 122);
            this.FromTo_Label.Name = "FromTo_Label";
            this.FromTo_Label.Size = new System.Drawing.Size(95, 20);
            this.FromTo_Label.TabIndex = 24;
            this.FromTo_Label.Text = "Abfahrtszeit";
            // 
            // FromTo_Button
            // 
            this.FromTo_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromTo_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromTo_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Arrow_Updown_icon;
            this.FromTo_Button.Location = new System.Drawing.Point(305, 121);
            this.FromTo_Button.Name = "FromTo_Button";
            this.FromTo_Button.Size = new System.Drawing.Size(25, 25);
            this.FromTo_Button.TabIndex = 23;
            this.FromTo_Button.UseVisualStyleBackColor = true;
            this.FromTo_Button.Click += new System.EventHandler(this.FromTo_Button_Click);
            // 
            // Map_Button
            // 
            this.Map_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Map_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Map_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Map_Marker_Bubble_Chartreuse_icon;
            this.Map_Button.Location = new System.Drawing.Point(417, 63);
            this.Map_Button.Name = "Map_Button";
            this.Map_Button.Size = new System.Drawing.Size(30, 30);
            this.Map_Button.TabIndex = 20;
            this.Map_Button.UseVisualStyleBackColor = true;
            // 
            // FromDelete_Button
            // 
            this.FromDelete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FromDelete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromDelete_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Actions_edit_delete_icon_new;
            this.FromDelete_Button.Location = new System.Drawing.Point(357, 63);
            this.FromDelete_Button.Name = "FromDelete_Button";
            this.FromDelete_Button.Size = new System.Drawing.Size(30, 30);
            this.FromDelete_Button.TabIndex = 6;
            this.FromDelete_Button.UseVisualStyleBackColor = true;
            this.FromDelete_Button.Click += new System.EventHandler(this.FromDelete_Button_Click);
            // 
            // ToDelete_Button
            // 
            this.ToDelete_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ToDelete_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToDelete_Button.Image = global::SwissTravelHelperGUI.Properties.Resources.Actions_edit_delete_icon_new;
            this.ToDelete_Button.Location = new System.Drawing.Point(357, 196);
            this.ToDelete_Button.Name = "ToDelete_Button";
            this.ToDelete_Button.Size = new System.Drawing.Size(30, 30);
            this.ToDelete_Button.TabIndex = 16;
            this.ToDelete_Button.UseVisualStyleBackColor = true;
            this.ToDelete_Button.Click += new System.EventHandler(this.ToDelete_Button_Click);
            // 
            // From_ComboBox
            // 
            this.From_ComboBox.AllowDrop = true;
            this.From_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.From_ComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_ComboBox.FormattingEnabled = true;
            this.From_ComboBox.Location = new System.Drawing.Point(13, 63);
            this.From_ComboBox.Name = "From_ComboBox";
            this.From_ComboBox.Size = new System.Drawing.Size(173, 30);
            this.From_ComboBox.TabIndex = 1;
            this.From_ComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.From_ComboBox_KeyPress);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 329);
            this.Controls.Add(this.From_ComboBox);
            this.Controls.Add(this.FromTo_Label);
            this.Controls.Add(this.FromTo_Button);
            this.Controls.Add(this.To_ComboBox);
            this.Controls.Add(this.Map_Button);
            this.Controls.Add(this.Connection_Button);
            this.Controls.Add(this.FromDelete_Button);
            this.Controls.Add(this.ToDelete_Button);
            this.Controls.Add(this.DepartureBoard_Button);
            this.Controls.Add(this.ToTime_DateTimePicker);
            this.Controls.Add(this.FromTime_DateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.To_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.From_Label);
            this.Name = "MainForm";
            this.Text = "SwissTravelHelper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label From_Label;
        private System.Windows.Forms.Label To_Label;
        private System.Windows.Forms.DateTimePicker FromTime_DateTimePicker;
        private System.Windows.Forms.DateTimePicker ToTime_DateTimePicker;
        private System.Windows.Forms.Button DepartureBoard_Button;
        private System.Windows.Forms.Button ToDelete_Button;
        private System.Windows.Forms.Button FromDelete_Button;
        private System.Windows.Forms.Button Connection_Button;
        private System.Windows.Forms.Button Map_Button;
        private System.Windows.Forms.ComboBox To_ComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label FromTo_Label;
        private System.Windows.Forms.Button FromTo_Button;
        private System.Windows.Forms.ComboBox From_ComboBox;
    }
}

