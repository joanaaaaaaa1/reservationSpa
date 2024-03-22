namespace spaThings
{
    partial class Form4
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
            label1 = new Label();
            update = new Button();
            delete = new Button();
            comboBox1 = new ComboBox();
            dataGridView1 = new DataGridView();
            del = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(30, 32);
            label1.Name = "label1";
            label1.Size = new Size(233, 30);
            label1.TabIndex = 0;
            label1.Text = "Appointment booked!";
            // 
            // update
            // 
            update.Location = new Point(62, 209);
            update.Name = "update";
            update.Size = new Size(141, 23);
            update.TabIndex = 1;
            update.Text = "Update Appointment";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(103, 238);
            delete.Name = "delete";
            delete.Size = new Size(75, 23);
            delete.TabIndex = 2;
            delete.Text = "Cancel";
            delete.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Eda", "Elia", "Joana" });
            comboBox1.Location = new Point(82, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(30, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(354, 85);
            dataGridView1.TabIndex = 4;
            // 
            // del
            // 
            del.Location = new Point(227, 209);
            del.Name = "del";
            del.Size = new Size(141, 23);
            del.TabIndex = 5;
            del.Text = "Delete";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 273);
            Controls.Add(del);
            Controls.Add(dataGridView1);
            Controls.Add(comboBox1);
            Controls.Add(delete);
            Controls.Add(update);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button update;
        private Button delete;
        private ComboBox comboBox1;
        private DataGridView dataGridView1;
        private Button del;
    }
}