using System.ComponentModel;

namespace Bai4_7;

/// <summary>Form con MDI: quản lý sản phẩm.</summary>
public partial class FormProduct : Form
{
    private readonly BindingList<Product> items = new();

    public FormProduct()
    {
        InitializeComponent();
        cboX.SelectedIndex = 0;
        bindingSource.DataSource = items;
        items.Add(new Product { ProductId = "SP001", ProductName = "Laptop Dell Inspiron", Price = 15990000, Category = "Điện tử" });
        items.Add(new Product { ProductId = "SP002", ProductName = "Nồi chiên không dầu", Price = 1890000, Category = "Gia dụng" });
        items.Add(new Product { ProductId = "SP003", ProductName = "Áo thun cotton", Price = 199000, Category = "Thời trang" });
    }

    /// <summary>Gửi thông điệp lên StatusStrip của Form cha (MDI Parent).</summary>
    private void Notify(string message)
    {
        if (MdiParent is FormMain main) main.SetStatus(message);
    }

    private Product? Current => bindingSource.Current as Product;

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã SP và Tên SP.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!decimal.TryParse(txtNum.Text, out decimal price) || price < 0)
        {
            MessageBox.Show("Đơn giá phải là số không âm.", "Dữ liệu sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (items.Any(x => x.ProductId.Equals(txtId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã SP đã tồn tại.", "Dữ liệu sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        items.Add(new Product { ProductId = txtId.Text.Trim(), ProductName = txtName.Text.Trim(), Price = price, Category = cboX.Text });
        Notify($"Đã thêm sản phẩm {txtId.Text.Trim()} - {txtName.Text.Trim()}");
        txtId.Clear();
        txtName.Clear();
        txtNum.Clear();
        txtId.Focus();
    }

    private void DeleteCurrent()
    {
        if (Current is not Product item)
        {
            MessageBox.Show("Chưa chọn dòng nào để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (MessageBox.Show($"Xóa {item.ProductId} - {item.ProductName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        bindingSource.RemoveCurrent();
        Notify($"Đã xóa {item.ProductId} - {item.ProductName}");
    }

    private void BtnDelete_Click(object? sender, EventArgs e) => DeleteCurrent();

    private void MnuDelete_Click(object? sender, EventArgs e) => DeleteCurrent();

    private void MnuRefresh_Click(object? sender, EventArgs e)
    {
        bindingSource.ResetBindings(false);
        Notify($"Đã làm mới dữ liệu ({items.Count} dòng)");
    }

    private void MnuDetail_Click(object? sender, EventArgs e)
    {
        if (Current is not Product item) return;
        MessageBox.Show($"Mã SP: {item.ProductId}\nTên: {item.ProductName}\nĐơn giá: {item.Price:N0} VNĐ\nDanh mục: {item.Category}", "Chi tiết sản phẩm", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
