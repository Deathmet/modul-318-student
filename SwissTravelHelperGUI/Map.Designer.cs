namespace SwissTravelHelperGUI
{
    partial class Map
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
            this.GMap_GMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.Stop_Button = new System.Windows.Forms.Button();
            this.StationMap_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // GMap_GMapControl
            // 
            this.GMap_GMapControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GMap_GMapControl.Bearing = 0F;
            this.GMap_GMapControl.CanDragMap = true;
            this.GMap_GMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.GMap_GMapControl.GrayScaleMode = false;
            this.GMap_GMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.GMap_GMapControl.LevelsKeepInMemmory = 5;
            this.GMap_GMapControl.Location = new System.Drawing.Point(12, 54);
            this.GMap_GMapControl.MarkersEnabled = true;
            this.GMap_GMapControl.MaxZoom = 2;
            this.GMap_GMapControl.MinZoom = 2;
            this.GMap_GMapControl.MouseWheelZoomEnabled = true;
            this.GMap_GMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.GMap_GMapControl.Name = "GMap_GMapControl";
            this.GMap_GMapControl.NegativeMode = false;
            this.GMap_GMapControl.PolygonsEnabled = true;
            this.GMap_GMapControl.RetryLoadTile = 0;
            this.GMap_GMapControl.RoutesEnabled = true;
            this.GMap_GMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.GMap_GMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.GMap_GMapControl.ShowTileGridLines = false;
            this.GMap_GMapControl.Size = new System.Drawing.Size(394, 295);
            this.GMap_GMapControl.TabIndex = 1;
            this.GMap_GMapControl.Zoom = 0D;
            // 
            // Stop_Button
            // 
            this.Stop_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Stop_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Button.Location = new System.Drawing.Point(308, 368);
            this.Stop_Button.Name = "Stop_Button";
            this.Stop_Button.Size = new System.Drawing.Size(98, 34);
            this.Stop_Button.TabIndex = 5;
            this.Stop_Button.Text = "Abbrechen";
            this.Stop_Button.UseVisualStyleBackColor = true;
            this.Stop_Button.Click += new System.EventHandler(this.Stop_Button_Click);
            // 
            // StationMap_Label
            // 
            this.StationMap_Label.AutoSize = true;
            this.StationMap_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StationMap_Label.Location = new System.Drawing.Point(12, 9);
            this.StationMap_Label.Name = "StationMap_Label";
            this.StationMap_Label.Size = new System.Drawing.Size(154, 31);
            this.StationMap_Label.TabIndex = 13;
            this.StationMap_Label.Text = "DefaultText";
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Stop_Button;
            this.ClientSize = new System.Drawing.Size(418, 414);
            this.Controls.Add(this.StationMap_Label);
            this.Controls.Add(this.Stop_Button);
            this.Controls.Add(this.GMap_GMapControl);
            this.Name = "Map";
            this.Text = "Map";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl GMap_GMapControl;
        private System.Windows.Forms.Button Stop_Button;
        private System.Windows.Forms.Label StationMap_Label;
    }
}