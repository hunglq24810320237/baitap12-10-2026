using System.ComponentModel;

namespace Bai4_8;

/// <summary>Form con MDI: quản lý sinh viên.</summary>
public partial class FormStudent : Form
{
    private readonly BindingList<Student> items = new();

    public FormStudent()
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

    private Student? Current => bindingSource.Current as Student;

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        if (string.IsNullOrWhiteSpace(txtId.Text) || string.IsNullOrWhiteSpace(txtName.Text))
        {
            MessageBox.Show("Vui lòng nhập Mã SV và Họ tên.", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (!int.TryParse(txtNum.Text, out int age) || age < 1 || age > 120)
        {
            MessageBox.Show("Tuổi phải là số từ 1 đến 120.", "Dữ liệu sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (items.Any(x => x.StudentId.Equals(txtId.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã SV đã tồn tại.", "Dữ liệu sai", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        items.Add(new Student { StudentId = txtId.Text.Trim(), FullName = txtName.Text.Trim(), Age = age, Gender = cboX.Text });
        Notify($"Đã thêm sinh viên {txtId.Text.Trim()} - {txtName.Text.Trim()}");
        txtId.Clear();
        txtName.Clear();
        txtNum.Clear();
        txtId.Focus();
    }

    private void DeleteCurrent()
    {
        if (Current is not Student item)
        {
            MessageBox.Show("Chưa chọn dòng nào để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (MessageBox.Show($"Xóa {item.StudentId} - {item.FullName}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        bindingSource.RemoveCurrent();
        Notify($"Đã xóa {item.StudentId} - {item.FullName}");
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
        if (Current is not Student item) return;
        MessageBox.Show($"Mã SV: {item.StudentId}\nHọ tên: {item.FullName}\nTuổi: {item.Age}\nGiới tính: {item.Gender}", "Chi tiết sinh viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ===== Bài 4.8: nạp dữ liệu bất đồng bộ + báo cáo tiến trình =====

    /// <summary>Phương thức nạp dữ liệu dạng async Task&lt;List&lt;Student&gt;&gt;, chạy ngầm bằng Task.Run.</summary>
    private static Task<List<Student>> LoadStudentsAsync(int total, IProgress<int> progress, CancellationToken ct)
    {
        return Task.Run(() =>
        {
            var list = new List<Student>();
            string[] ho = { "Nguyễn", "Trần", "Lê", "Phạm", "Hoàng", "Vũ", "Đặng", "Bùi" };
            string[] dem = { "Văn", "Thị", "Quang", "Thu", "Minh", "Ngọc" };
            string[] ten = { "An", "Bình", "Cường", "Dung", "Hưng", "Lan", "Nam", "Phúc", "Quân", "Trang" };
            for (int i = 1; i <= total; i++)
            {
                ct.ThrowIfCancellationRequested();
                Thread.Sleep(15); // giả lập đọc CSDL/File chậm
                list.Add(new Student
                {
                    StudentId = "SV" + i.ToString("000"),
                    FullName = $"{ho[i % ho.Length]} {dem[(i / 2) % dem.Length]} {ten[(i / 3) % ten.Length]}",
                    Age = 18 + i % 6,
                    Gender = i % 2 == 0 ? "Nữ" : "Nam"
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
            var data = await LoadStudentsAsync(200, progress, CancellationToken.None);
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
