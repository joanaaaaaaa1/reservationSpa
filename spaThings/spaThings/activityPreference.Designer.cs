namespace spaThings
{
    partial class activityPreferencePage
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
            duration = new ComboBox();
            preferences = new ComboBox();
            Reserve = new Button();
            activity = new ComboBox();
            name = new TextBox();
            SuspendLayout();
            // 
            // duration
            // 
            duration.FormattingEnabled = true;
            duration.Items.AddRange(new object[] { "30 ", "60" });
            duration.Location = new Point(149, 100);
            duration.Name = "duration";
            duration.Size = new Size(121, 23);
            duration.TabIndex = 0;
            // 
            // preferences
            // 
            preferences.FormattingEnabled = true;
            preferences.Items.AddRange(new object[] { "no heat", "heat" });
            preferences.Location = new Point(330, 100);
            preferences.Name = "preferences";
            preferences.Size = new Size(121, 23);
            preferences.TabIndex = 1;
            // 
            // Reserve
            // 
            Reserve.Location = new Point(303, 166);
            Reserve.Name = "Reserve";
            Reserve.Size = new Size(171, 22);
            Reserve.TabIndex = 2;
            Reserve.Text = "Reserve Appointment";
            Reserve.UseVisualStyleBackColor = true;
            Reserve.Click += Reserve_Click;
            // 
            // activity
            // 
            activity.FormattingEnabled = true;
            activity.Items.AddRange(new object[] { "facial", "fitness", "massage" });
            activity.Location = new Point(511, 100);
            activity.Name = "activity";
            activity.Size = new Size(121, 23);
            activity.TabIndex = 3;
            // 
            // name
            // 
            name.Location = new Point(330, 58);
            name.Name = "name";
            name.PlaceholderText = "name";
            name.Size = new Size(121, 23);
            name.TabIndex = 4;
            // 
            // activityPreferencePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 221);
            Controls.Add(name);
            Controls.Add(activity);
            Controls.Add(Reserve);
            Controls.Add(preferences);
            Controls.Add(duration);
            Name = "activityPreferencePage";
            Text = "activityPreference";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox duration;
        private ComboBox preferences;
        private Button Reserve;
        private ComboBox activity;
        private TextBox name;
    }
}