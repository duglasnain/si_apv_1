namespace colegiu
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            read_db = new Button();
            update_db = new Button();
            write_db = new Button();
            delete_db = new Button();
            SuspendLayout();
            // 
            // read_db
            // 
            read_db.BackColor = SystemColors.ControlDarkDark;
            read_db.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.World);
            read_db.ForeColor = SystemColors.ControlLightLight;
            read_db.Location = new Point(15, 15);
            read_db.Name = "read_db";
            read_db.Size = new Size(105, 40);
            read_db.TabIndex = 0;
            read_db.Text = "View DB";
            read_db.UseVisualStyleBackColor = false;
            read_db.Click += read_db_Click;
            // 
            // update_db
            // 
            update_db.BackColor = Color.FromArgb(128, 255, 128);
            update_db.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.World);
            update_db.ForeColor = SystemColors.ControlLightLight;
            update_db.Location = new Point(15, 241);
            update_db.Name = "update_db";
            update_db.Size = new Size(150, 40);
            update_db.TabIndex = 1;
            update_db.Text = "Update Record";
            update_db.UseVisualStyleBackColor = false;
            update_db.Click += update_db_Click;
            // 
            // write_db
            // 
            write_db.BackColor = Color.FromArgb(128, 128, 255);
            write_db.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.World);
            write_db.ForeColor = SystemColors.ControlLightLight;
            write_db.Location = new Point(394, 15);
            write_db.Name = "write_db";
            write_db.Size = new Size(125, 40);
            write_db.TabIndex = 2;
            write_db.Text = "Add Record";
            write_db.UseVisualStyleBackColor = false;
            write_db.Click += write_db_Click;
            // 
            // delete_db
            // 
            delete_db.BackColor = Color.FromArgb(255, 128, 128);
            delete_db.Font = new Font("Times New Roman", 20F, FontStyle.Bold, GraphicsUnit.World);
            delete_db.ForeColor = SystemColors.ControlLightLight;
            delete_db.Location = new Point(375, 241);
            delete_db.Name = "delete_db";
            delete_db.Size = new Size(150, 40);
            delete_db.TabIndex = 3;
            delete_db.Text = "Delete Record";
            delete_db.UseVisualStyleBackColor = false;
            delete_db.Click += delete_db_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(531, 293);
            Controls.Add(delete_db);
            Controls.Add(write_db);
            Controls.Add(update_db);
            Controls.Add(read_db);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Gestionarea bazei de date Colegiu";
            ResumeLayout(false);
        }

        #endregion

        private Button read_db;
        private Button update_db;
        private Button write_db;
        private Button delete_db;
    }
}