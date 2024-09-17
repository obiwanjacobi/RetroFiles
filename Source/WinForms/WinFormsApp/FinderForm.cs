
namespace WinFormsApp;

public partial class FinderForm : Form
{
    public FinderForm()
    {
        InitializeComponent();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        Console.WriteLine("Paint");

        var dc = e.Graphics;
        dc.DrawRectangle(Pens.Black, 0, 0, Width, Height);

        if (titleBar1.IsActive)
        {
            for (int i = 1; i < 6; i++)
            {
                dc.DrawLine(Pens.Black, Width - i, 0, Width - i, Height - i);
                dc.DrawLine(Pens.Black, 0, Height - i, Width - i, Height - i);
            }
        }
    }

    protected override void OnActivated(EventArgs e)
    {
        titleBar1.IsActive = true;
        base.OnActivated(e);
        Invalidate();
    }
    protected override void OnDeactivate(EventArgs e)
    {
        titleBar1.IsActive = false;
        base.OnDeactivate(e);
        Invalidate();
    }
}
