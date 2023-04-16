namespace Proje.Components
{
    partial class CompanyList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.ListView();
            this.colTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOwner = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNace = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colProdDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colLastCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.AutoArrange = false;
            this.list.CheckBoxes = true;
            this.list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTitle,
            this.colNumber,
            this.colAddress,
            this.colOwner,
            this.colPhone,
            this.colNace,
            this.colProdDate,
            this.colLastCheck});
            this.list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.list.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.list.GridLines = true;
            this.list.HideSelection = false;
            this.list.Location = new System.Drawing.Point(0, 0);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(1149, 708);
            this.list.TabIndex = 0;
            this.list.UseCompatibleStateImageBehavior = false;
            this.list.View = System.Windows.Forms.View.Details;
            this.list.SelectedIndexChanged += new System.EventHandler(this.list_SelectedIndexChanged);
            // 
            // colTitle
            // 
            this.colTitle.Text = "Firma Ünvanı";
            this.colTitle.Width = 139;
            // 
            // colNumber
            // 
            this.colNumber.Text = "Vergi/TC No";
            this.colNumber.Width = 135;
            // 
            // colAddress
            // 
            this.colAddress.Text = "İrtibat Adresi";
            this.colAddress.Width = 227;
            // 
            // colOwner
            // 
            this.colOwner.Text = "İrtibat Kişisi";
            this.colOwner.Width = 118;
            // 
            // colPhone
            // 
            this.colPhone.Text = "Telefon";
            this.colPhone.Width = 113;
            // 
            // colNace
            // 
            this.colNace.Text = "Nace Kodu";
            this.colNace.Width = 98;
            // 
            // colProdDate
            // 
            this.colProdDate.Text = "Üretime Başlama";
            this.colProdDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colProdDate.Width = 118;
            // 
            // colLastCheck
            // 
            this.colLastCheck.Text = "Son Kontrol";
            this.colLastCheck.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colLastCheck.Width = 111;
            // 
            // CompanyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.list);
            this.Name = "CompanyList";
            this.Size = new System.Drawing.Size(1149, 708);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView list;
        private System.Windows.Forms.ColumnHeader colTitle;
        private System.Windows.Forms.ColumnHeader colNumber;
        private System.Windows.Forms.ColumnHeader colAddress;
        private System.Windows.Forms.ColumnHeader colOwner;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colNace;
        private System.Windows.Forms.ColumnHeader colProdDate;
        private System.Windows.Forms.ColumnHeader colLastCheck;
    }
}
