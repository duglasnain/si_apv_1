namespace colegiu
{
    partial class FormRead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRead));
            read_db = new Button();
            table_dropdown = new ComboBox();
            table_label = new Label();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // read_db
            // 
            read_db.BackColor = SystemColors.ControlDarkDark;
            read_db.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.World);
            read_db.ForeColor = SystemColors.ControlLightLight;
            read_db.Location = new Point(587, 333);
            read_db.Name = "read_db";
            read_db.Size = new Size(105, 40);
            read_db.TabIndex = 1;
            read_db.Text = "View DB";
            read_db.UseVisualStyleBackColor = false;
            read_db.Click += read_db_Click;
            // 
            // table_dropdown
            // 
            table_dropdown.FormattingEnabled = true;
            table_dropdown.Location = new Point(12, 36);
            table_dropdown.Name = "table_dropdown";
            table_dropdown.Size = new Size(208, 23);
            table_dropdown.TabIndex = 2;
            // 
            // table_label
            // 
            table_label.AutoSize = true;
            table_label.BackColor = Color.FromArgb(255, 192, 128);
            table_label.BorderStyle = BorderStyle.FixedSingle;
            table_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            table_label.ForeColor = Color.White;
            table_label.Location = new Point(12, 9);
            table_label.Name = "table_label";
            table_label.Size = new Size(106, 24);
            table_label.TabIndex = 3;
            table_label.Text = "Select table";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 65);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(680, 262);
            dgv.TabIndex = 4;
            // 
            // FormRead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 385);
            Controls.Add(dgv);
            Controls.Add(table_label);
            Controls.Add(table_dropdown);
            Controls.Add(read_db);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormRead";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View DB";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button read_db;
        private ComboBox table_dropdown;
        private Label table_label;
        private DataGridView dgv;
    }
}