using System.ComponentModel;

namespace Bai4_8;

/// <summary>Form con MDI: quản lý sản phẩm.</summary>
public partial class FormProduct : Form
{
    private readonly BindingList<Product> items = new();

    public FormProduct()
    {
        InitializeComponent();
        cboX.SelectedIndex = 0;
        bindingSource.DataSource = items;
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

    // ===== Bài 4.8: nạp dữ liệu bất đồng bộ + báo cáo tiến trình =====

    /// <summary>Phương thức nạp dữ liệu dạng async Task&lt;List&lt;Product&gt;&gt;, chạy ngầm bằng Task.Run.</summary>
    private static Task<List<Product>> LoadProductsAsync(int total, IProgress<int> progress, CancellationToken ct)
    {
        return Task.Run(() =>
        {
            var list = new List<Product>();
            string[] cat = { "Điện tử", "Gia dụng", "Thực phẩm", "Thời trang" };
            string[] name = { "Tai nghe", "Bàn phím", "Nồi cơm", "Bánh quy", "Áo khoác", "Chuột", "Quạt", "Sữa hạt" };
            for (int i = 1; i <= total; i++)
            {
                ct.ThrowIfCancellationRequested();
                Thread.Sleep(15); // giả lập đọc CSDL/File chậm
                list.Add(new Product
                {
                    ProductId = "SP" + i.ToString("000"),
                    ProductName = $"{name[i % name.Length]} mẫu {i}",
                    Price = 50000 + i * 7000,
                    Category = cat[i % cat.Length]
                });
                progress.Report(i * 100 / total);
            }
            return list;
        }, ct);
    }

    private async void BtnLoad_Click(object? sender, EventArgs e)
    {
        btnLoad.Enabled = false;                       // khóa nút để tránh bấm lặp
        progressBar.Value = 0;
        lblPercent.Text = "0%";
        Notify("Đang nạp dữ liệu...");

        // Progress<int> được tạo trên UI thread nên callback tự chạy về UI thread.
        var progress = new Progress<int>(percent =>
        {
            progressBar.Value = percent;
            lblPercent.Text = percent + "%";
            if (MdiParent is FormMain main) main.SetProgress(percent);
        });

        try
        {
            var data = await LoadProductsAsync(200, progress, CancellationToken.None);
            items.Clear();
            foreach (var x in data) items.Add(x);
            bindingSource.ResetBindings(false);
            Notify($"Nạp xong {data.Count} dòng dữ liệu.");
            MessageBox.Show($"Nạp dữ liệu hoàn tất: {data.Count} dòng.", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (OperationCanceledException)
        {
            Notify("Đã hủy nạp dữ liệu.");
        }
        catch (Exception ex)
        {
            Notify("Lỗi khi nạp dữ liệu.");
            MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            btnLoad.Enabled = true;                    // mở lại nút
            if (MdiParent is FormMain main) main.SetProgress(null);
        }
    }
}
