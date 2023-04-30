namespace colegiu
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void read_db_Click(object sender, EventArgs e)
        {
            FormRead f = new FormRead();
            f.ShowDialog();

        }
        private void update_db_Click(object sender, EventArgs e)
        {
            FormUpdate f = new FormUpdate();
            f.ShowDialog();
        }

        private void write_db_Click(object sender, EventArgs e)
        {
            
            FormCreate f = new FormCreate();
            f.ShowDialog();
        }


        private void delete_db_Click(object sender, EventArgs e)
        {
            
            FormDelete f = new FormDelete();
            f.ShowDialog();
        }
    }
}