namespace WinFormsControls;

public partial class TitleBar : Control
{
    public TitleBar()
    {
        InitializeComponent();
    }

    private bool _isActive;
    public bool IsActive
    {
        get { return _isActive; }
        set { _isActive = value; Invalidate(); }
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var dc = e.Graphics;

        var size = dc.MeasureString(Text, Font);
        var y = (Height / 2) - (size.Height / 2);
        var x = (Width / 2) - (size.Width / 2);

        if (IsActive)
        {
            var ink = Pens.Black;
            const int delta = 8;

            for (int n = delta; n < Height; n += delta)
            {
                dc.DrawLine(ink, delta, n, x - delta, n);
                dc.DrawLine(ink, x + delta + size.Width, n, Width - delta, n);

                dc.DrawLine(ink, delta, n + 1, x - delta, n + 1);
                dc.DrawLine(ink, x + delta + size.Width, n + 1, Width - delta, n + 1);
            }
        }

        dc.DrawString(Text, Font, Brushes.Black, x, y);
    }

    private Point? _point;
    private void TitleBar_MouseDown(object sender, MouseEventArgs e)
    {
        _point = e.Location;
    }
    private void TitleBar_MouseUp(object sender, MouseEventArgs e)
    {
        _point = null;
    }

    private void TitleBar_MouseMove(object sender, MouseEventArgs e)
    {
        if (Parent is not null && _point is not null &&
            e.X != _point.Value.X && e.Y != _point.Value.Y)
        {
            var x = (e.X - _point.Value.X);
            var y = (e.Y - _point.Value.Y);
            Parent.Location = new Point(Parent.Location.X + x, Parent.Location.Y + y);
            _point = new Point(e.X-x, e.Y-y);
        }
    }
}
