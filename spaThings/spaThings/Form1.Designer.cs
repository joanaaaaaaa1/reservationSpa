namespace spaThings
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            activityCm = new ComboBox();
            employee = new ComboBox();
            timeSlot = new ComboBox();
            dataGridView1 = new DataGridView();
            filterButton = new Button();
            activityPreference = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // activityCm
            // 
            activityCm.FormattingEnabled = true;
            activityCm.Items.AddRange(new object[] { "massage", "facial", "fitness" });
            activityCm.Location = new Point(59, 107);
            activityCm.Name = "activityCm";
            activityCm.Size = new Size(200, 23);
            activityCm.TabIndex = 0;
            // 
            // employee
            // 
            employee.FormattingEnabled = true;
            employee.Items.AddRange(new object[] { "Elia", "Tedi", "Mitko" });
            employee.Location = new Point(544, 107);
            employee.Name = "employee";
            employee.Size = new Size(200, 23);
            employee.TabIndex = 1;
            // 
            // timeSlot
            // 
            timeSlot.FormattingEnabled = true;
            timeSlot.Items.AddRange(new object[] { "afternoon", "morning" });
            timeSlot.Location = new Point(300, 107);
            timeSlot.Name = "timeSlot";
            timeSlot.Size = new Size(200, 23);
            timeSlot.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(59, 163);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(685, 171);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(59, 350);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(75, 23);
            filterButton.TabIndex = 4;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += button1_Click;
            // 
            // activityPreference
            // 
            activityPreference.Location = new Point(482, 350);
            activityPreference.Name = "activityPreference";
            activityPreference.Size = new Size(262, 23);
            activityPreference.TabIndex = 5;
            activityPreference.Text = "Activity Preference";
            activityPreference.UseVisualStyleBackColor = true;
            activityPreference.Click += activityPreference_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 52);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(activityPreference);
            Controls.Add(filterButton);
            Controls.Add(dataGridView1);
            Controls.Add(timeSlot);
            Controls.Add(employee);
            Controls.Add(activityCm);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox activityCm;
        private ComboBox employee;
        private ComboBox timeSlot;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button filterButton;
        private Button activityPreference;
        private Label label1;
    }
}