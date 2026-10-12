using System.ComponentModel;
using System.Text;

namespace Bai4_6;

/// <summary>
/// Bài 4.6: Quản lý sinh viên bằng BindingSource (binding 2 chiều), chọn ảnh Avatar và xuất CSV.
/// </summary>
public partial class MainForm : Form
{
    private readonly BindingList<Student> students = new();

    public MainForm()
    {
        InitializeComponent();

        string avatars = Path.Combine(AppContext.BaseDirectory, "Avatars");
        students.Add(new Student { StudentId = "SV001", FullName = "Nguyễn Văn An", Age = 20, Gender = "Nam", AvatarPath = Path.Combine(avatars, "sv1.png") });
        students.Add(new Student { StudentId = "SV002", FullName = "Trần Thị Bình", Age = 19, Gender = "Nữ", AvatarPath = Path.Combine(avatars, "sv2.png") });
        students.Add(new Student { StudentId = "SV003", FullName = "Lê Quang Hưng", Age = 21, Gender = "Nam", AvatarPath = Path.Combine(avatars, "sv3.png") });
        students.Add(new Student { StudentId = "SV004", FullName = "Phạm Thu Cúc", Age = 20, Gender = "Nữ", AvatarPath = Path.Combine(avatars, "sv4.png") });

        // BindingSource là trung gian giữa BindingList<Student> với DataGridView và các control nhập liệu.
        bindingSource.DataSource = students;

        // Liên kết 2 chiều: control <-> thuộc tính của dòng đang chọn.
        txtId.DataBindings.Add("Text", bindingSource, nameof(Student.StudentId), false, DataSourceUpdateMode.OnPropertyChanged);
        txtName.DataBindings.Add("Text", bindingSource, nameof(Student.FullName), false, DataSourceUpdateMode.OnPropertyChanged);
        txtAge.DataBindings.Add("Text", bindingSource, nameof(Student.Age), true, DataSourceUpdateMode.OnPropertyChanged);
        cboGender.DataBindings.Add("SelectedItem", bindingSource, nameof(Student.Gender), true, DataSourceUpdateMode.OnPropertyChanged);

        // Đổi dòng -> nạp lại ảnh. Đổi AvatarPath -> nạp lại ảnh.
        bindingSource.CurrentChanged += (_, _) => LoadAvatar();
        bindingSource.CurrentItemChanged += (_, _) => LoadAvatar();
        LoadAvatar();
    }

    private Student? Current => bindingSource.Current as Student;

    private string? loadedPath;

    private void LoadAvatar()
    {
        string? path = Current?.AvatarPath;
        if (path == loadedPath) return;
        loadedPath = path;

        Image? old = picAvatar.Image;
        picAvatar.Image = null;
        old?.Dispose();

        if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) return;
        try
        {
            // Đọc qua MemoryStream rồi sao chép sang Bitmap để không khóa file ảnh.
            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
            using var img = Image.FromStream(fs);
            picAvatar.Image = new Bitmap(img);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Không đọc được ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void BtnAdd_Click(object? sender, EventArgs e)
    {
        var s = new Student
        {
            StudentId = "SV" + (students.Count + 1).ToString("000"),
            FullName = "Sinh viên mới",
            Age = 18,
            Gender = "Nam"
        };
        students.Add(s);
        bindingSource.Position = students.Count - 1;
        txtName.Focus();
        txtName.SelectAll();
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (Current is not Student s)
        {
            MessageBox.Show("Chưa có sinh viên nào để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        if (MessageBox.Show($"Xóa sinh viên {s.StudentId} - {s.FullName}?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;
        bindingSource.RemoveCurrent();
    }

    private void BtnUpdate_Click(object? sender, EventArgs e)
    {
        if (Current is not Student s) return;
        bindingSource.EndEdit();

        if (string.IsNullOrWhiteSpace(s.StudentId) || string.IsNullOrWhiteSpace(s.FullName))
        {
            MessageBox.Show("Mã SV và Họ tên không được để trống.", "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (s.Age < 1 || s.Age > 120)
        {
            MessageBox.Show("Tuổi phải nằm trong khoảng 1 - 120.", "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        if (students.Any(x => !ReferenceEquals(x, s) && string.Equals(x.StudentId, s.StudentId, StringComparison.OrdinalIgnoreCase)))
        {
            MessageBox.Show("Mã SV đã tồn tại.", "Dữ liệu chưa hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        bindingSource.ResetCurrentItem();
        MessageBox.Show("Đã cập nhật thông tin sinh viên.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void BtnChooseImage_Click(object? sender, EventArgs e)
    {
        if (Current is not Student s)
        {
            MessageBox.Show("Hãy chọn một sinh viên trước.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        using var dlg = new OpenFileDialog
        {
            Title = "Chọn ảnh đại diện",
            Filter = "Ảnh (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp"
        };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        s.AvatarPath = dlg.FileName;
        LoadAvatar();
    }

    private void BtnExport_Click(object? sender, EventArgs e)
    {
        using var dlg = new SaveFileDialog
        {
            Title = "Xuất danh sách sinh viên",
            Filter = "CSV (*.csv)|*.csv",
            FileName = "danh_sach_sinh_vien.csv"
        };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;

        var sb = new StringBuilder();
        sb.AppendLine("StudentId,FullName,Age,Gender,AvatarPath");
        foreach (var s in students)
            sb.AppendLine(string.Join(",", Csv(s.StudentId), Csv(s.FullName), s.Age, Csv(s.Gender), Csv(s.AvatarPath)));

        // UTF-8 có BOM để Excel đọc đúng tiếng Việt.
        File.WriteAllText(dlg.FileName, sb.ToString(), new UTF8Encoding(true));
        MessageBox.Show($"Đã xuất {students.Count} sinh viên ra:\n{dlg.FileName}", "Xuất CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private static string Csv(string value) =>
        value.Contains(',') || value.Contains('"') || value.Contains('\n')
            ? "\"" + value.Replace("\"", "\"\"") + "\""
            : value;
}
