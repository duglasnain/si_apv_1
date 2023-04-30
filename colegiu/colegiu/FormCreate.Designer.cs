namespace colegiu
{
    partial class FormCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreate));
            write_db = new Button();
            table_label = new Label();
            table_dropdown = new ComboBox();
            SuspendLayout();
            // 
            // write_db
            // 
            write_db.BackColor = Color.FromArgb(128, 128, 255);
            write_db.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.World);
            write_db.ForeColor = SystemColors.ControlLightLight;
            write_db.Location = new Point(567, 333);
            write_db.Name = "write_db";
            write_db.Size = new Size(125, 40);
            write_db.TabIndex = 3;
            write_db.Text = "Add Record";
            write_db.UseVisualStyleBackColor = false;
            write_db.Click += write_db_Click;
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
            table_label.TabIndex = 5;
            table_label.Text = "Select table";
            // 
            // table_dropdown
            // 
            table_dropdown.FormattingEnabled = true;
            table_dropdown.Location = new Point(12, 36);
            table_dropdown.Name = "table_dropdown";
            table_dropdown.Size = new Size(106, 23);
            table_dropdown.TabIndex = 4;
            table_dropdown.SelectedIndexChanged += table_dropdown_SelectedIndexChanged;
            // 
            // FormCreate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 385);
            Controls.Add(table_label);
            Controls.Add(table_dropdown);
            Controls.Add(write_db);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCreate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Record";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button write_db;
        private Label table_label;
        private ComboBox table_dropdown;
    }
}