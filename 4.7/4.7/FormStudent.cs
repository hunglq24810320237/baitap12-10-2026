using System.ComponentModel;

namespace Bai4_7;

/// <summary>Form con MDI: quản lý sinh viên.</summary>
public partial class FormStudent : Form
{
    private readonly BindingList<Student> items = new();

    public FormStudent()
    {
        InitializeComponent();
        cboX.SelectedIndex = 0;
        bindingSource.DataSource = items;
        items.Add(new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam" });
        items.Add(new Student { StudentId = "SV002", FullName = "Trần Thị Bình", Age = 19, Gender = "Nữ" });
        items.Add(new Student { StudentId = "SV003", FullName = "Lê Quang Hưng", Age = 21, Gender = "Nam" });
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
}
