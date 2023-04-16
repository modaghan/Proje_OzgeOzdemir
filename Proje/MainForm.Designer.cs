namespace Proje
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.btnEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnControl = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabContinue = new System.Windows.Forms.TabPage();
            this.tabInPenalty = new System.Windows.Forms.TabPage();
            this.tabCompleted = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenu,
            this.btnControl});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1125, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnMenu
            // 
            this.btnMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.toolStripMenuItem1,
            this.btnDelete});
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(60, 24);
            this.btnMenu.Text = "Menü";
            // 
            // btnAdd
            // 
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(187, 26);
            this.btnAdd.Text = "Yeni Kayıt Ekle";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(187, 26);
            this.btnEdit.Text = "Düzenle";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 6);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(187, 26);
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnControl
            // 
            this.btnControl.Enabled = false;
            this.btnControl.Name = "btnControl";
            this.btnControl.Size = new System.Drawing.Size(89, 24);
            this.btnControl.Text = "Kontrol Et";
            this.btnControl.Click += new System.EventHandler(this.btnControl_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabContinue);
            this.tabMain.Controls.Add(this.tabInPenalty);
            this.tabMain.Controls.Add(this.tabCompleted);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(0, 30);
            this.tabMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1125, 822);
            this.tabMain.TabIndex = 1;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // tabContinue
            // 
            this.tabContinue.Location = new System.Drawing.Point(4, 32);
            this.tabContinue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabContinue.Name = "tabContinue";
            this.tabContinue.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabContinue.Size = new System.Drawing.Size(1117, 786);
            this.tabContinue.TabIndex = 0;
            this.tabContinue.Text = "Durumu Devam Edenler";
            this.tabContinue.UseVisualStyleBackColor = true;
            // 
            // tabInPenalty
            // 
            this.tabInPenalty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabInPenalty.Location = new System.Drawing.Point(4, 32);
            this.tabInPenalty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabInPenalty.Name = "tabInPenalty";
            this.tabInPenalty.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabInPenalty.Size = new System.Drawing.Size(1117, 786);
            this.tabInPenalty.TabIndex = 1;
            this.tabInPenalty.Text = "Cezalı Durumundakiler";
            // 
            // tabCompleted
            // 
            this.tabCompleted.BackColor = System.Drawing.Color.LightGreen;
            this.tabCompleted.Location = new System.Drawing.Point(4, 32);
            this.tabCompleted.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabCompleted.Name = "tabCompleted";
            this.tabCompleted.Size = new System.Drawing.Size(1117, 786);
            this.tabCompleted.TabIndex = 2;
            this.tabCompleted.Text = "Kaydı Tamamlananlar";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 852);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Sanayi Sicil Sistemi Ön Kayıt Takip Programı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnMenu;
        private System.Windows.Forms.ToolStripMenuItem btnAdd;
        private System.Windows.Forms.ToolStripMenuItem btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnControl;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabContinue;
        private System.Windows.Forms.TabPage tabInPenalty;
        private System.Windows.Forms.TabPage tabCompleted;
    }
}

