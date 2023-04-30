namespace colegiu
{
    partial class FormUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUpdate));
            update_db = new Button();
            table_label = new Label();
            table_dropdown = new ComboBox();
            id_dropdown = new ComboBox();
            id_label = new Label();
            dgv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // update_db
            // 
            update_db.BackColor = Color.FromArgb(128, 255, 128);
            update_db.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.World);
            update_db.ForeColor = SystemColors.ControlLightLight;
            update_db.Location = new Point(542, 333);
            update_db.Name = "update_db";
            update_db.Size = new Size(150, 40);
            update_db.TabIndex = 2;
            update_db.Text = "Update Record";
            update_db.UseVisualStyleBackColor = false;
            update_db.Click += update_db_Click;
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
            table_label.TabIndex = 7;
            table_label.Text = "Select table";
            // 
            // table_dropdown
            // 
            table_dropdown.FormattingEnabled = true;
            table_dropdown.Location = new Point(12, 36);
            table_dropdown.Name = "table_dropdown";
            table_dropdown.Size = new Size(106, 23);
            table_dropdown.TabIndex = 6;
            table_dropdown.SelectedIndexChanged += table_dropdown_SelectedIndexChanged;
            // 
            // id_dropdown
            // 
            id_dropdown.FormattingEnabled = true;
            id_dropdown.Location = new Point(133, 36);
            id_dropdown.Name = "id_dropdown";
            id_dropdown.Size = new Size(83, 23);
            id_dropdown.TabIndex = 14;
            id_dropdown.SelectedIndexChanged += id_dropdown_SelectedIndexChanged;
            // 
            // id_label
            // 
            id_label.AutoSize = true;
            id_label.BackColor = Color.FromArgb(255, 192, 128);
            id_label.BorderStyle = BorderStyle.FixedSingle;
            id_label.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            id_label.ForeColor = Color.White;
            id_label.Location = new Point(133, 9);
            id_label.Name = "id_label";
            id_label.Size = new Size(83, 24);
            id_label.TabIndex = 13;
            id_label.Text = "Select Id";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(12, 229);
            dgv.Name = "dgv";
            dgv.RowTemplate.Height = 25;
            dgv.Size = new Size(680, 76);
            dgv.TabIndex = 15;
            // 
            // FormUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 385);
            Controls.Add(dgv);
            Controls.Add(id_dropdown);
            Controls.Add(id_label);
            Controls.Add(table_label);
            Controls.Add(table_dropdown);
            Controls.Add(update_db);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormUpdate";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Record";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button update_db;
        private Label table_label;
        private ComboBox table_dropdown;
        private ComboBox id_dropdown;
        private Label id_label;
        private DataGridView dgv;
    }
}