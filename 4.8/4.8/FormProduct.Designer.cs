#nullable disable
namespace Bai4_8
{
    partial class FormProduct
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
            pnlInput = new System.Windows.Forms.Panel();
            lblId = new System.Windows.Forms.Label();
            txtId = new System.Windows.Forms.TextBox();
            lblName = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            lblNum = new System.Windows.Forms.Label();
            txtNum = new System.Windows.Forms.TextBox();
            lblCbo = new System.Windows.Forms.Label();
            cboX = new System.Windows.Forms.ComboBox();
            btnAdd = new System.Windows.Forms.Button();
            btnDelete = new System.Windows.Forms.Button();
            btnLoad = new System.Windows.Forms.Button();
            dgv = new System.Windows.Forms.DataGridView();
            colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            colCbo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ctxMenu = new System.Windows.Forms.ContextMenuStrip(components);
            mnuDelete = new System.Windows.Forms.ToolStripMenuItem();
            mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            mnuDetail = new System.Windows.Forms.ToolStripMenuItem();
            bindingSource = new System.Windows.Forms.BindingSource(components);
            pnlBottom = new System.Windows.Forms.Panel();
            progressBar = new System.Windows.Forms.ProgressBar();
            lblPercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // pnlInput
            // 
            pnlInput.Name = "pnlInput";
            pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            pnlInput.Height = 110;
            pnlInput.TabIndex = 0;
            pnlInput.Controls.Add(lblId);
            pnlInput.Controls.Add(txtId);
            pnlInput.Controls.Add(lblName);
            pnlInput.Controls.Add(txtName);
            pnlInput.Controls.Add(lblNum);
            pnlInput.Controls.Add(txtNum);
            pnlInput.Controls.Add(lblCbo);
            pnlInput.Controls.Add(cboX);
            pnlInput.Controls.Add(btnAdd);
            pnlInput.Controls.Add(btnDelete);
            pnlInput.Controls.Add(btnLoad);
            // 
            // lblId
            // 
            lblId.Name = "lblId";
            lblId.AutoSize = true;
            lblId.Location = new System.Drawing.Point(16, 20);
            lblId.Text = "Mã SP:";
            // 
            // txtId
            // 
            txtId.Name = "txtId";
            txtId.Location = new System.Drawing.Point(92, 12);
            txtId.Size = new System.Drawing.Size(170, 27);
            txtId.TabIndex = 1;
            // 
            // lblName
            // 
            lblName.Name = "lblName";
            lblName.AutoSize = true;
            lblName.Location = new System.Drawing.Point(300, 20);
            lblName.Text = "Tên SP:";
            // 
            // txtName
            // 
            txtName.Name = "txtName";
            txtName.Location = new System.Drawing.Point(376, 12);
            txtName.Size = new System.Drawing.Size(170, 27);
            txtName.TabIndex = 2;
            // 
            // lblNum
            // 
            lblNum.Name = "lblNum";
            lblNum.AutoSize = true;
            lblNum.Location = new System.Drawing.Point(16, 64);
            lblNum.Text = "Đơn giá:";
            // 
            // txtNum
            // 
            txtNum.Name = "txtNum";
            txtNum.Location = new System.Drawing.Point(92, 56);
            txtNum.Size = new System.Drawing.Size(170, 27);
            txtNum.TabIndex = 3;
            // 
            // lblCbo
            // 
            lblCbo.Name = "lblCbo";
            lblCbo.AutoSize = true;
            lblCbo.Location = new System.Drawing.Point(300, 64);
            lblCbo.Text = "Danh mục:";
            // 
            // cboX
            // 
            cboX.Name = "cboX";
            cboX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cboX.Items.AddRange(new object[] { "Điện tử", "Gia dụng", "Thực phẩm", "Thời trang" });
            cboX.Location = new System.Drawing.Point(376, 56);
            cboX.Size = new System.Drawing.Size(170, 28);
            cboX.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Name = "btnAdd";
            btnAdd.Location = new System.Drawing.Point(570, 14);
            btnAdd.Size = new System.Drawing.Size(80, 34);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Name = "btnDelete";
            btnDelete.Location = new System.Drawing.Point(660, 14);
            btnDelete.Size = new System.Drawing.Size(80, 34);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += BtnDelete_Click;
            // 
            // btnLoad
            // 
            btnLoad.Name = "btnLoad";
            btnLoad.Location = new System.Drawing.Point(570, 56);
            btnLoad.Size = new System.Drawing.Size(170, 34);
            btnLoad.TabIndex = 6;
            btnLoad.Text = "Nạp dữ liệu";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += BtnLoad_Click;
            // 
            // dgv
            // 
            dgv.Name = "dgv";
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AutoGenerateColumns = false;
            dgv.BackgroundColor = System.Drawing.Color.White;
            dgv.ColumnHeadersHeight = 32;
            dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { colId, colName, colNum, colCbo });
            dgv.ContextMenuStrip = ctxMenu;
            dgv.DataSource = bindingSource;
            dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgv.TabIndex = 1;
            // 
            // colId
            // 
            colId.Name = "colId";
            colId.DataPropertyName = "ProductId";
            colId.HeaderText = "Mã SP";
            colId.ReadOnly = true;
            colId.Width = 90;
            // 
            // colName
            // 
            colName.Name = "colName";
            colName.DataPropertyName = "ProductName";
            colName.HeaderText = "Tên sản phẩm";
            colName.ReadOnly = true;
            colName.Width = 220;
            // 
            // colNum
            // 
            colNum.Name = "colNum";
            colNum.DataPropertyName = "Price";
            colNum.HeaderText = "Đơn giá (VNĐ)";
            colNum.ReadOnly = true;
            colNum.Width = 110;
            colNum.DefaultCellStyle = new System.Windows.Forms.DataGridViewCellStyle { Format = "N0" };
            // 
            // colCbo
            // 
            colCbo.Name = "colCbo";
            colCbo.DataPropertyName = "Category";
            colCbo.HeaderText = "Danh mục";
            colCbo.ReadOnly = true;
            colCbo.Width = 120;
            // 
            // ctxMenu
            // 
            ctxMenu.Name = "ctxMenu";
            ctxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuDelete, mnuRefresh, mnuDetail });
            // 
            // mnuDelete
            // 
            mnuDelete.Name = "mnuDelete";
            mnuDelete.Text = "Xóa dòng";
            mnuDelete.Click += MnuDelete_Click;
            // 
            // mnuRefresh
            // 
            mnuRefresh.Name = "mnuRefresh";
            mnuRefresh.Text = "Làm mới dữ liệu";
            mnuRefresh.Click += MnuRefresh_Click;
            // 
            // mnuDetail
            // 
            mnuDetail.Name = "mnuDetail";
            mnuDetail.Text = "Xem chi tiết";
            mnuDetail.Click += MnuDetail_Click;
            // 
            // bindingSource
            // 
            // 
            // pnlBottom
            // 
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnlBottom.Height = 44;
            pnlBottom.TabIndex = 2;
            pnlBottom.Controls.Add(progressBar);
            pnlBottom.Controls.Add(lblPercent);
            // 
            // progressBar
            // 
            progressBar.Name = "progressBar";
            progressBar.Location = new System.Drawing.Point(16, 10);
            progressBar.Size = new System.Drawing.Size(600, 24);
            // 
            // lblPercent
            // 
            lblPercent.Name = "lblPercent";
            lblPercent.AutoSize = true;
            lblPercent.Location = new System.Drawing.Point(630, 12);
            lblPercent.Text = "0%";
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(760, 460);
            Controls.Add(dgv);
            Controls.Add(pnlBottom);
            Controls.Add(pnlInput);
            Name = "FormProduct";
            Text = "Quản lý sản phẩm";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label lblCbo;
        private System.Windows.Forms.ComboBox cboX;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCbo;
        private System.Windows.Forms.ContextMenuStrip ctxMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuDelete;
        private System.Windows.Forms.ToolStripMenuItem mnuRefresh;
        private System.Windows.Forms.ToolStripMenuItem mnuDetail;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblPercent;
    }
}
