namespace Bai4_8;

/// <summary>Form chính dạng MDI Parent.</summary>
public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
        tsbStudent.Image = SystemIcons.Information.ToBitmap();
        tsbProduct.Image = SystemIcons.Application.ToBitmap();
        tsbCascade.Image = SystemIcons.Shield.ToBitmap();
        tsbTile.Image = SystemIcons.WinLogo.ToBitmap();
        lblTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
        WindowState = FormWindowState.Maximized;
    }

    /// <summary>Form con gọi hàm này để cập nhật thông điệp lên StatusStrip.</summary>
    public void SetStatus(string message) => lblMessage.Text = message;

    /// <summary>Hiển thị % tiến trình trên StatusStrip (null = ẩn).</summary>
    public void SetProgress(int? percent)
    {
        if (percent is null)
        {
            tspProgress.Visible = false;
            return;
        }
        tspProgress.Visible = true;
        tspProgress.Value = percent.Value;
        lblMessage.Text = $"Đang nạp dữ liệu... {percent}%";
    }

    /// <summary>Nếu form con đã mở thì chỉ Activate, chưa mở thì tạo mới.</summary>
    private void OpenChild<T>() where T : Form, new()
    {
        var existing = MdiChildren.OfType<T>().FirstOrDefault();
        if (existing is not null)
        {
            if (existing.WindowState == FormWindowState.Minimized) existing.WindowState = FormWindowState.Normal;
            existing.Activate();
            SetStatus($"Form \"{existing.Text}\" đã mở, chuyển lên trên cùng.");
            return;
        }
        var child = new T { MdiParent = this };
        child.Show();
        SetStatus($"Đã mở form \"{child.Text}\".");
    }

    private void OpenStudent_Click(object? sender, EventArgs e) => OpenChild<FormStudent>();

    private void OpenProduct_Click(object? sender, EventArgs e) => OpenChild<FormProduct>();

    private void MnuCascade_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.Cascade);

    private void MnuTileH_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileHorizontal);

    private void MnuTileV_Click(object? sender, EventArgs e) => LayoutMdi(MdiLayout.TileVertical);

    private void MnuLogout_Click(object? sender, EventArgs e)
    {
        if (MessageBox.Show("Bạn có muốn đăng xuất?", "Đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        foreach (var child in MdiChildren) child.Close();
        lblUser.Text = "Người dùng: (chưa đăng nhập)";
        mnuCatalog.Enabled = mnuWindow.Enabled = toolStrip.Enabled = false;
        mnuLogout.Text = "Đăng nhập";
        mnuLogout.Click -= MnuLogout_Click;
        mnuLogout.Click += MnuLogin_Click;
        SetStatus("Đã đăng xuất.");
    }

    private void MnuLogin_Click(object? sender, EventArgs e)
    {
        lblUser.Text = "Người dùng: admin";
        mnuCatalog.Enabled = mnuWindow.Enabled = toolStrip.Enabled = true;
        mnuLogout.Text = "Đăng xuất";
        mnuLogout.Click -= MnuLogin_Click;
        mnuLogout.Click += MnuLogout_Click;
        SetStatus("Đã đăng nhập.");
    }

    private void MnuExit_Click(object? sender, EventArgs e) => Close();

    private void ClockTimer_Tick(object? sender, EventArgs e) => lblTime.Text = DateTime.Now.ToString("HH:mm:ss dd/MM/yyyy");
}
