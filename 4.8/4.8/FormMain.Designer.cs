#nullable disable
namespace Bai4_8
{
    partial class FormMain
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
            menuStrip = new System.Windows.Forms.MenuStrip();
            mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            mnuCatalog = new System.Windows.Forms.ToolStripMenuItem();
            mnuStudent = new System.Windows.Forms.ToolStripMenuItem();
            mnuProduct = new System.Windows.Forms.ToolStripMenuItem();
            mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            mnuTileH = new System.Windows.Forms.ToolStripMenuItem();
            mnuTileV = new System.Windows.Forms.ToolStripMenuItem();
            toolStrip = new System.Windows.Forms.ToolStrip();
            ctxToolbar = new System.Windows.Forms.ContextMenuStrip();
            ctxStudent = new System.Windows.Forms.ToolStripMenuItem();
            ctxProduct = new System.Windows.Forms.ToolStripMenuItem();
            ctxCascade = new System.Windows.Forms.ToolStripMenuItem();
            ctxTileH = new System.Windows.Forms.ToolStripMenuItem();
            ctxTileV = new System.Windows.Forms.ToolStripMenuItem();
            tsbStudent = new System.Windows.Forms.ToolStripButton();
            tsbProduct = new System.Windows.Forms.ToolStripButton();
            toolSep = new System.Windows.Forms.ToolStripSeparator();
            tsbCascade = new System.Windows.Forms.ToolStripButton();
            tsbTile = new System.Windows.Forms.ToolStripButton();
            statusStrip = new System.Windows.Forms.StatusStrip();
            lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            lblMessage = new System.Windows.Forms.ToolStripStatusLabel();
            tspProgress = new System.Windows.Forms.ToolStripProgressBar();
            lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            clockTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Name = "menuStrip";
            menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuSystem, mnuCatalog, mnuWindow });
            menuStrip.TabIndex = 0;
            // 
            // mnuSystem
            // 
            mnuSystem.Name = "mnuSystem";
            mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuLogout, mnuExit });
            mnuSystem.Text = "Hệ thống";
            // 
            // mnuLogout
            // 
            mnuLogout.Name = "mnuLogout";
            mnuLogout.Text = "Đăng xuất";
            mnuLogout.Click += MnuLogout_Click;
            // 
            // mnuExit
            // 
            mnuExit.Name = "mnuExit";
            mnuExit.Text = "Thoát";
            mnuExit.Click += MnuExit_Click;
            // 
            // mnuCatalog
            // 
            mnuCatalog.Name = "mnuCatalog";
            mnuCatalog.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuStudent, mnuProduct });
            mnuCatalog.Text = "Danh mục";
            // 
            // mnuStudent
            // 
            mnuStudent.Name = "mnuStudent";
            mnuStudent.Text = "Quản lý Sinh viên";
            mnuStudent.Click += OpenStudent_Click;
            // 
            // mnuProduct
            // 
            mnuProduct.Name = "mnuProduct";
            mnuProduct.Text = "Quản lý Sản phẩm";
            mnuProduct.Click += OpenProduct_Click;
            // 
            // mnuWindow
            // 
            mnuWindow.Name = "mnuWindow";
            mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { mnuCascade, mnuTileH, mnuTileV });
            mnuWindow.Text = "Cửa sổ";
            // 
            // mnuCascade
            // 
            mnuCascade.Name = "mnuCascade";
            mnuCascade.Text = "Cascade";
            mnuCascade.Click += MnuCascade_Click;
            // 
            // mnuTileH
            // 
            mnuTileH.Name = "mnuTileH";
            mnuTileH.Text = "Tile Horizontal";
            mnuTileH.Click += MnuTileH_Click;
            // 
            // mnuTileV
            // 
            mnuTileV.Name = "mnuTileV";
            mnuTileV.Text = "Tile Vertical";
            mnuTileV.Click += MnuTileV_Click;
            // 
            // toolStrip
            // 
            toolStrip.Name = "toolStrip";
            toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { tsbStudent, tsbProduct, toolSep, tsbCascade, tsbTile });
            toolStrip.TabIndex = 1;
            toolStrip.ContextMenuStrip = ctxToolbar;
            // 
            // ctxToolbar
            // 
            ctxToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { ctxStudent, ctxProduct, ctxCascade, ctxTileH, ctxTileV });
            ctxStudent.Text = "Mở Quản lý Sinh viên";
            ctxStudent.Click += OpenStudent_Click;
            ctxProduct.Text = "Mở Quản lý Sản phẩm";
            ctxProduct.Click += OpenProduct_Click;
            ctxCascade.Text = "Cascade";
            ctxCascade.Click += MnuCascade_Click;
            ctxTileH.Text = "Tile Horizontal";
            ctxTileH.Click += MnuTileH_Click;
            ctxTileV.Text = "Tile Vertical";
            ctxTileV.Click += MnuTileV_Click;
            // 
            // tsbStudent
            // 
            tsbStudent.Name = "tsbStudent";
            tsbStudent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbStudent.Text = "Sinh viên";
            tsbStudent.Click += OpenStudent_Click;
            // 
            // tsbProduct
            // 
            tsbProduct.Name = "tsbProduct";
            tsbProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbProduct.Text = "Sản phẩm";
            tsbProduct.Click += OpenProduct_Click;
            // 
            // toolSep
            // 
            toolSep.Name = "toolSep";
            // 
            // tsbCascade
            // 
            tsbCascade.Name = "tsbCascade";
            tsbCascade.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbCascade.Text = "Cascade";
            tsbCascade.Click += MnuCascade_Click;
            // 
            // tsbTile
            // 
            tsbTile.Name = "tsbTile";
            tsbTile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.ImageAndText;
            tsbTile.Text = "Tile Vertical";
            tsbTile.Click += MnuTileV_Click;
            // 
            // statusStrip
            // 
            statusStrip.Name = "statusStrip";
            statusStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            statusStrip.SizingGrip = false;
            statusStrip.CanOverflow = false;
            statusStrip.Location = new System.Drawing.Point(0, 600);
            statusStrip.Size = new System.Drawing.Size(1000, 24);
            statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { lblUser, lblMessage, tspProgress, lblTime });
            statusStrip.TabIndex = 2;
            // 
            // lblUser
            // 
            lblUser.Name = "lblUser";
            lblUser.Text = "Người dùng: admin";
            lblUser.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            // 
            // lblMessage
            // 
            lblMessage.Name = "lblMessage";
            lblMessage.Spring = true;
            lblMessage.Text = "Sẵn sàng";
            lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tspProgress
            // 
            tspProgress.Name = "tspProgress";
            tspProgress.Size = new System.Drawing.Size(160, 18);
            tspProgress.Visible = false;
            // 
            // lblTime
            // 
            lblTime.Name = "lblTime";
            lblTime.Text = "00:00:00 01/01/2026";
            lblTime.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            // 
            // clockTimer
            // 
            clockTimer.Enabled = true;
            clockTimer.Interval = 1000;
            clockTimer.Tick += ClockTimer_Tick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1100, 680);
            Controls.Add(statusStrip);
            Controls.Add(toolStrip);
            Controls.Add(menuStrip);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip;
            Name = "FormMain";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Bài 4.8 - Async/await & ProgressBar (MDI)";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuCatalog;
        private System.Windows.Forms.ToolStripMenuItem mnuStudent;
        private System.Windows.Forms.ToolStripMenuItem mnuProduct;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileH;
        private System.Windows.Forms.ToolStripMenuItem mnuTileV;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ContextMenuStrip ctxToolbar;
        private System.Windows.Forms.ToolStripMenuItem ctxStudent, ctxProduct, ctxCascade, ctxTileH, ctxTileV;
        private System.Windows.Forms.ToolStripButton tsbStudent;
        private System.Windows.Forms.ToolStripButton tsbProduct;
        private System.Windows.Forms.ToolStripSeparator toolSep;
        private System.Windows.Forms.ToolStripButton tsbCascade;
        private System.Windows.Forms.ToolStripButton tsbTile;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel lblMessage;
        private System.Windows.Forms.ToolStripProgressBar tspProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.Timer clockTimer;
    }
}
