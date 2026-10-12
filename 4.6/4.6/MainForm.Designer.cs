#nullable disable
namespace Bai4_6
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblTitle = new System.Windows.Forms.Label();
            dgvStudents = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            grpInfo = new System.Windows.Forms.GroupBox();
            lblId = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblAge = new System.Windows.Forms.Label();
            txtAge = new System.Windows.Forms.TextBox();
            lblGender = new System.Windows.Forms.Label();
            cboGender = new System.Windows.Forms.ComboBox();
            picAvatar = new System.Windows.Forms.PictureBox();
            btnChooseImage = new System.Windows.Forms.Button();
            grpActions = new System.Windows.Forms.GroupBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnUpdate = new System.Windows.Forms.Button();
            btnExport = new System.Windows.Forms.Button();
            bindingSource = new System.Windows.Forms.BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            grpInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).BeginInit();
            grpActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            lblTitle.ForeColor = System.Drawing.Color.FromArgb(31, 78, 140);
            lblTitle.Location = new System.Drawing.Point(16, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new System.Drawing.Size(363, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "QUẢN LÝ SINH VIÊN (BINDINGSOURCE)";
            // 
            // dgvStudents
            // 
            dgvStudents.AllowUserToAddRows = false;
            dgvStudents.AllowUserToDeleteRows = false;
            dgvStudents.AllowUserToResizeRows = false;
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.BackgroundColor = System.Drawing.Color.White;
            dgvStudents.ColumnHeadersHeight = 32;
            dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colName, colAge, colGender });
            dgvStudents.DataSource = bindingSource;
            dgvStudents.Location = new System.Drawing.Point(16, 56);
            dgvStudents.MultiSelect = false;
            dgvStudents.Name = "dgvStudents";
            dgvStudents.ReadOnly = true;
            dgvStudents.RowHeadersVisible = false;
            dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvStudents.Size = new System.Drawing.Size(470, 420);
            dgvStudents.TabIndex = 1;
            // 
            // colId
            // 
            colId.DataPropertyName = "StudentId";
            colId.HeaderText = "Mã SV";
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Width = 90;
            // 
            // colName
            // 
            colName.DataPropertyName = "FullName";
            colName.HeaderText = "Họ tên";
            colName.Name = "colName";
            colName.ReadOnly = true;
            colName.Width = 190;
            // 
            // colAge
            // 
            colAge.DataPropertyName = "Age";
            colAge.HeaderText = "Tuổi";
            colAge.Name = "colAge";
            colAge.ReadOnly = true;
            colAge.Width = 60;
            // 
            // colGender
            // 
            colGender.DataPropertyName = "Gender";
            colGender.HeaderText = "Giới tính";
            colGender.Name = "colGender";
            colGender.ReadOnly = true;
            colGender.Width = 90;
            // 
            // grpInfo
            // 
            grpInfo.Controls.Add(lblId);
            grpInfo.Controls.Add(txtId);
            grpInfo.Controls.Add(lblName);
            grpInfo.Controls.Add(txtName);
            grpInfo.Controls.Add(lblAge);
            grpInfo.Controls.Add(txtAge);
            grpInfo.Controls.Add(lblGender);
            grpInfo.Controls.Add(cboGender);
            grpInfo.Controls.Add(picAvatar);
            grpInfo.Controls.Add(btnChooseImage);
            grpInfo.Location = new System.Drawing.Point(502, 56);
            grpInfo.Name = "grpInfo";
            grpInfo.Size = new System.Drawing.Size(420, 290);
            grpInfo.TabIndex = 2;
            grpInfo.TabStop = false;
            grpInfo.Text = "Thông tin sinh viên";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(16, 36);
            lblId.Name = "lblId";
            lblId.Text = "Mã SV:";
            // 
            // txtId
            // 
            txtId.Location = new System.Drawing.Point(90, 32);
            txtId.Name = "txtId";
            txtId.Size = new System.Drawing.Size(150, 27);
            txtId.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(16, 76);
            lblName.Name = "lblName";
            lblName.Text = "Họ tên:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(90, 72);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(150, 27);
            txtName.TabIndex = 1;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new System.Drawing.Point(16, 116);
            lblAge.Name = "lblAge";
            lblAge.Text = "Tuổi:";
            // 
            // txtAge
            // 
            txtAge.Location = new System.Drawing.Point(90, 112);
            txtAge.Name = "txtAge";
            txtAge.Size = new System.Drawing.Size(150, 27);
            txtAge.TabIndex = 2;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new System.Drawing.Point(16, 156);
            lblGender.Name = "lblGender";
            lblGender.Text = "Giới tính:";
            // 
            // cboGender
            // 
            cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            cboGender.Location = new System.Drawing.Point(90, 152);
            cboGender.Name = "cboGender";
            cboGender.Size = new System.Drawing.Size(150, 28);
            cboGender.TabIndex = 3;
            // 
            // picAvatar
            // 
            picAvatar.BackColor = System.Drawing.Color.WhiteSmoke;
            picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            picAvatar.Location = new System.Drawing.Point(262, 32);
            picAvatar.Name = "picAvatar";
            picAvatar.Size = new System.Drawing.Size(140, 140);
            picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            picAvatar.TabStop = false;
            // 
            // btnChooseImage
            // 
            btnChooseImage.Location = new System.Drawing.Point(262, 180);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new System.Drawing.Size(140, 34);
            btnChooseImage.TabIndex = 4;
            btnChooseImage.Text = "Chọn ảnh...";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += BtnChooseImage_Click;
            // 
            // grpActions
            // 
            grpActions.Controls.Add(btnAdd);
            grpActions.Controls.Add(btnDelete);
            grpActions.Controls.Add(btnUpdate);
            grpActions.Controls.Add(btnExport);
            grpActions.Location = new System.Drawing.Point(502, 360);
            grpActions.Name = "grpActions";
            grpActions.Size = new System.Drawing.Size(420, 116);
            grpActions.TabIndex = 3;
            grpActions.TabStop = false;
            grpActions.Text = "Chức năng";
            // 
            // btnAdd
            // 
            btnAdd.Location = new System.Drawing.Point(16, 30);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new System.Drawing.Size(120, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new System.Drawing.Point(150, 30);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new System.Drawing.Size(120, 34);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new System.Drawing.Point(284, 30);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new System.Drawing.Size(120, 34);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new System.Drawing.Point(16, 70);
            btnExport.Name = "btnExport";
            btnExport.Size = new System.Drawing.Size(388, 34);
            btnExport.TabIndex = 3;
            btnExport.Text = "Xuất file CSV";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += BtnExport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(940, 496);
            Controls.Add(lblTitle);
            Controls.Add(dgvStudents);
            Controls.Add(grpInfo);
            Controls.Add(grpActions);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 4.6 - Quản lý sinh viên";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            grpInfo.ResumeLayout(false);
            grpInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvatar).EndInit();
            grpActions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.GroupBox grpInfo;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.GroupBox grpActions;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.BindingSource bindingSource;
    }
}
