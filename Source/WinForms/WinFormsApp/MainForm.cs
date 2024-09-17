namespace WinFormsApp;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }

    private void newToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var child = new FinderForm
        {
            MdiParent = this
        };
        child.Show();
    }
}
