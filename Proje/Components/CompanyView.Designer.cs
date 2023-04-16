namespace Proje.Components
{
    partial class CompanyView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTaxNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblOwner = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblNace = new System.Windows.Forms.Label();
            this.lblProductionStart = new System.Windows.Forms.Label();
            this.lblIsRegistered = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtTaxNo = new System.Windows.Forms.TextBox();
            this.txtOwner = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtProductionStart = new System.Windows.Forms.DateTimePicker();
            this.chkIsRegistered = new System.Windows.Forms.CheckBox();
            this.cmbNace = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.64906F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.35094F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 269F));
            this.tableLayoutPanel1.Controls.Add(this.lblTitle, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblTaxNo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAddress, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblOwner, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblPhone, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblNace, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblProductionStart, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblIsRegistered, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.txtTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTaxNo, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtOwner, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPhone, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtProductionStart, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.chkIsRegistered, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbNace, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtAddress, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 9);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 14);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 470);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Location = new System.Drawing.Point(3, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Firma Ünvanı";
            // 
            // lblTaxNo
            // 
            this.lblTaxNo.AutoSize = true;
            this.lblTaxNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTaxNo.Location = new System.Drawing.Point(3, 38);
            this.lblTaxNo.Name = "lblTaxNo";
            this.lblTaxNo.Size = new System.Drawing.Size(196, 38);
            this.lblTaxNo.TabIndex = 1;
            this.lblTaxNo.Text = "Vergi / TC No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAddress.Location = new System.Drawing.Point(3, 76);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(196, 60);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "İletişim Adresi";
            // 
            // lblOwner
            // 
            this.lblOwner.AutoSize = true;
            this.lblOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOwner.Location = new System.Drawing.Point(3, 136);
            this.lblOwner.Name = "lblOwner";
            this.lblOwner.Size = new System.Drawing.Size(196, 38);
            this.lblOwner.TabIndex = 3;
            this.lblOwner.Text = "İrtibat Kişisi";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPhone.Location = new System.Drawing.Point(3, 174);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(196, 38);
            this.lblPhone.TabIndex = 4;
            this.lblPhone.Text = "Telefon";
            // 
            // lblNace
            // 
            this.lblNace.AutoSize = true;
            this.lblNace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNace.Location = new System.Drawing.Point(3, 212);
            this.lblNace.Name = "lblNace";
            this.lblNace.Size = new System.Drawing.Size(196, 30);
            this.lblNace.TabIndex = 5;
            this.lblNace.Text = "NACE Rev Kodu";
            // 
            // lblProductionStart
            // 
            this.lblProductionStart.AutoSize = true;
            this.lblProductionStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProductionStart.Location = new System.Drawing.Point(3, 242);
            this.lblProductionStart.Name = "lblProductionStart";
            this.lblProductionStart.Size = new System.Drawing.Size(196, 38);
            this.lblProductionStart.TabIndex = 6;
            this.lblProductionStart.Text = "Üretime Başlama Tarihi";
            // 
            // lblIsRegistered
            // 
            this.lblIsRegistered.AutoSize = true;
            this.lblIsRegistered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblIsRegistered.Location = new System.Drawing.Point(3, 280);
            this.lblIsRegistered.Name = "lblIsRegistered";
            this.lblIsRegistered.Size = new System.Drawing.Size(196, 25);
            this.lblIsRegistered.TabIndex = 7;
            this.lblIsRegistered.Text = "Kayıt Yapılmış mı?";
            // 
            // txtTitle
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtTitle, 2);
            this.txtTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTitle.Location = new System.Drawing.Point(205, 4);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(600, 30);
            this.txtTitle.TabIndex = 0;
            // 
            // txtTaxNo
            // 
            this.txtTaxNo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaxNo.Location = new System.Drawing.Point(205, 42);
            this.txtTaxNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaxNo.Name = "txtTaxNo";
            this.txtTaxNo.Size = new System.Drawing.Size(330, 30);
            this.txtTaxNo.TabIndex = 1;
            // 
            // txtOwner
            // 
            this.txtOwner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOwner.Location = new System.Drawing.Point(205, 140);
            this.txtOwner.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOwner.Name = "txtOwner";
            this.txtOwner.Size = new System.Drawing.Size(330, 30);
            this.txtOwner.TabIndex = 3;
            // 
            // txtPhone
            // 
            this.txtPhone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPhone.Location = new System.Drawing.Point(205, 178);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(330, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // dtProductionStart
            // 
            this.dtProductionStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProductionStart.Location = new System.Drawing.Point(205, 246);
            this.dtProductionStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtProductionStart.Name = "dtProductionStart";
            this.dtProductionStart.Size = new System.Drawing.Size(330, 30);
            this.dtProductionStart.TabIndex = 6;
            // 
            // chkIsRegistered
            // 
            this.chkIsRegistered.AutoSize = true;
            this.chkIsRegistered.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkIsRegistered.Location = new System.Drawing.Point(205, 284);
            this.chkIsRegistered.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkIsRegistered.Name = "chkIsRegistered";
            this.chkIsRegistered.Size = new System.Drawing.Size(330, 17);
            this.chkIsRegistered.TabIndex = 7;
            this.chkIsRegistered.UseVisualStyleBackColor = true;
            // 
            // cmbNace
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbNace, 2);
            this.cmbNace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbNace.FormattingEnabled = true;
            this.cmbNace.Items.AddRange(new object[] {
            "05.10 Taş kömürü madenciliği",
            "05.20 Linyit madenciliği",
            "06.10 Ham petrol çıkarımı",
            "06.20 Doğal gaz çıkarımı",
            "07.10 Demir cevherleri madenciliği",
            "07.2 Demir dışı metal cevherleri madenciliği",
            "07.21 Uranyum ve toryum cevherleri madenciliği",
            "07.29 Diğer demir dışı metal cevherleri madenciliği",
            "08.1 Kum, kil ve taş ocakçılığı",
            "08.11 Süsleme ve yapı taşları ile kireç taşı, alçı taşı, tebeşir ve kayağantaşı (" +
                "arduvaz-kayraktaşı) ocakçılığı",
            "08.12 Çakıl ve kum ocaklarının faaliyetleri; kil ve kaolin çıkarımı",
            "08.9 Başka yerde sınıflandırılmamış madencilik ve taş ocakçılığı",
            "08.91 Kimyasal ve gübreleme amaçlı mineral madenciliği",
            "08.92 Turba çıkarımı",
            "08.93 Tuz çıkarımı",
            "08.99 Başka yerde sınıflandırılmamış diğer madencilik ve taş ocakçılığı",
            "09.10 Petrol ve doğal gaz çıkarımını destekleyici faaliyetler",
            "09.90 Madencilik ve taş ocakçılığını destekleyici diğer faaliyetler",
            "10.1 Etin işlenmesi ve saklanması ile et ürünlerinin imalatı",
            "10.11 Etin işlenmesi ve saklanması",
            "10.12 Kümes hayvanları etlerinin işlenmesi ve saklanması",
            "10.13 Et ve kümes hayvanları etlerinden üretilen ürünlerin imalatı",
            "10.20 Balık, kabuklu deniz hayvanları ve yumuşakçaların işlenmesi ve saklanması",
            "10.3 Sebze ve meyvelerin işlenmesi ve saklanması",
            "10.31 Patatesin işlenmesi ve saklanması",
            "10.32 Sebze ve meyve suyu imalatı",
            "10.39 Başka yerde sınıflandırılmamış meyve ve sebzelerin işlenmesi ve saklanması",
            "10.4 Bitkisel ve hayvansal sıvı ve katı yağların imalatı",
            "10.41 Sıvı ve katı yağ imalatı",
            "10.42 Margarin ve benzeri yenilebilir katı yağların imalatı",
            "10.5 Süt ürünleri imalatı",
            "10.51 Süthane işletmeciliği ve peynir imalatı",
            "10.52 Dondurma imalatı",
            "10.6 Öğütülmüş tahıl ürünleri, nişasta ve nişastalı ürünlerin imalatı",
            "10.61 Öğütülmüş hububat ve sebze ürünleri imalatı",
            "10.62 Nişasta ve nişastalı ürünlerin imalatı",
            "10.7 Fırın ve unlu mamuller imalatı",
            "10.71 Ekmek, taze pastane ürünleri ve taze kek imalatı",
            "10.72 Peksimet ve bisküvi imalatı; dayanıklı pastane ürünleri ve dayanıklı kek im" +
                "alatı",
            "10.73 Makarna, şehriye, kuskus ve benzeri unlu mamullerin imalatı",
            "10.8 Diğer gıda maddelerinin imalatı",
            "10.81 Şeker imalatı",
            "10.82 Kakao, çikolata ve şekerleme imalatı",
            "10.83 Kahve ve çayın işlenmesi",
            "10.84 Baharat, sos, sirke ve diğer çeşni maddelerinin imalatı",
            "10.85 Hazır yemeklerin imalatı",
            "10.86 Homojenize gıda müstahzarları ve diyetetik gıda imalatı",
            "10.89 Başka yerde sınıflandırılmamış diğer gıda maddelerinin imalatı",
            "10.9 Hazır hayvan yemleri imalatı",
            "10.91 Çiftlik hayvanları için hazır yem imalatı",
            "10.92 Ev hayvanları için hazır gıda imalatı",
            "11.0 İçeceklerin imalatı",
            "11.01 Alkollü içeceklerin damıtılması, arıtılması ve harmanlanması",
            "11.02 Üzümden şarap imalatı",
            "11.03 Elma şarabı ve diğer meyve şaraplarının imalatı",
            "11.04 Diğer damıtılmamış mayalı içeceklerin imalatı",
            "11.05 Bira imalatı",
            "11.06 Malt imalatı",
            "11.07 Alkolsüz içeceklerin imalatı; maden sularının ve diğer şişelenmiş suların ü" +
                "retimi",
            "12.00 Tütün ürünleri imalatı",
            "13.10 Tekstil elyafının hazırlanması ve bükülmesi",
            "13.20 Dokuma",
            "13.30 Tekstil ürünlerinin bitirilmesi",
            "13.9 Diğer tekstil ürünlerinin imalatı",
            "13.91 Örgü (triko) veya tığ işi (kroşe) kumaşların imalatı",
            "13.92 Giyim eşyası dışındaki tamamlanmış tekstil ürünlerinin imalatı",
            "13.93 Halı ve kilim imalatı",
            "13.94 Halat, urgan, kınnap ve ağ imalatı",
            "13.95 Dokusuz kumaşların ve dokusuz kumaştan yapılan ürünlerin imalatı, giyim eşy" +
                "ası hariç",
            "13.96 Diğer teknik ve endüstriyel tekstillerin imalatı",
            "13.99 Başka yerde sınıflandırılmamış diğer tekstillerin imalatı",
            "14.1 Kürk hariç, giyim eşyası imalatı",
            "14.11 Deri giyim eşyası imalatı",
            "14.12 İş giysisi imalatı",
            "14.13 Diğer dış giyim eşyaları imalatı",
            "14.14 İç giyim eşyası imalatı",
            "14.19 Diğer giyim eşyalarının ve giysi aksesuarlarının imalatı",
            "14.20 Kürkten eşya imalatı",
            "14.3 Örme (trikotaj) ve tığ işi (kroşe) ürünlerin imalatı",
            "14.31 Örme (trikotaj) ve tığ işi (kroşe) çorap imalatı",
            "14.39 Örme (trikotaj) ve tığ işi (kroşe) diğer giyim eşyası imalatı",
            "15.1 Derinin tabaklanması ve işlenmesi; bavul, el çantası, saraçlık ve koşum takı" +
                "mı imalatı; kürkün işlenmesi ve boyanması",
            "15.11 Derinin tabaklanması ve işlenmesi; kürkün işlenmesi ve boyanması",
            "15.12 Bavul, el çantası ve benzerleri ile saraçlık ve koşum takımı imalatı (deri " +
                "giyim eşyası hariç)",
            "15.20 Ayakkabı, bot, terlik vb. imalatı",
            "16.10 Ağaçların biçilmesi ve planyalanması",
            "16.2 Ağaç, mantar, kamış ve örgü malzeme ürünü imalatı",
            "16.21 Ahşap kaplama paneli ve ağaç esaslı panel imalatı",
            "16.22 Birleştirilmiş parke yer döşemelerinin imalatı",
            "16.23 Diğer bina doğramacılığı ve marangozluk ürünlerinin imalatı",
            "16.24 Ahşap konteyner imalatı",
            "16.29 Diğer ağaç ürünleri imalatı; mantardan, saz, saman ve benzeri örme malzemel" +
                "erinden yapılmış ürünlerin imalatı",
            "17.1 Kağıt hamuru, kağıt ve mukavva imalatı",
            "17.11 Kağıt hamuru imalatı",
            "17.12 Kağıt ve mukavva imalatı",
            "17.2 Kağıt ve mukavva ürünleri imalatı",
            "17.21 Oluklu kağıt ve mukavva imalatı ile kağıt ve mukavvadan yapılan muhafazalar" +
                "ın imalatı",
            "17.22 Kağıttan yapılan ev eşyası, sıhhi malzemeler ve tuvalet malzemeleri imalatı" +
                "",
            "17.23 Kağıt kırtasiye ürünleri imalatı",
            "17.24 Duvar kağıdı imalatı",
            "17.29 Kağıt ve mukavvadan diğer ürünlerin imalatı",
            "18.1 Basım ve basım ile ilgili hizmet faaliyetleri",
            "18.11 Gazetelerin basımı",
            "18.12 Diğer matbaacılık",
            "18.13 Basım ve yayım öncesi hizmetler",
            "18.14 Ciltçilik ve ilgili hizmetler",
            "18.20 Kayıtlı medyanın çoğaltılması",
            "19.10 Kok fırını ürünlerinin imalatı",
            "19.20 Rafine edilmiş petrol ürünleri imalatı",
            "20.1 Temel kimyasal maddelerin, kimyasal gübre ve azot bileşikleri, birincil form" +
                "da plastik ve sentetik kauçuk imalatı",
            "20.11 Sanayi gazları imalatı",
            "20.12 Boya maddeleri ve pigment imalatı",
            "20.13 Diğer inorganik temel kimyasal maddelerin imalatı",
            "20.14 Diğer organik temel kimyasalların imalatı",
            "20.15 Kimyasal gübre ve azot bileşiklerinin imalatı",
            "20.16 Birincil formda plastik hammaddelerin imalatı",
            "20.17 Birincil formda sentetik kauçuk imalatı",
            "20.20 Haşere ilaçları ve diğer zirai-kimyasal ürünlerin imalatı",
            "20.30 Boya, vernik ve benzeri kaplayıcı maddeler ile matbaa mürekkebi ve macun im" +
                "alatı",
            "20.4 Sabun ve deterjan, temizlik ve parlatıcı maddeleri; parfüm; kozmetik ve tuva" +
                "let malzemeleri imalatı",
            "20.41 Sabun ve deterjan ile temizlik ve parlatıcı maddeler imalatı",
            "20.42 Parfümlerin, kozmetiklerin ve kişisel bakım ürünlerinin imalatı",
            "20.5 Diğer kimyasal ürünlerin imalatı",
            "20.51 Patlayıcı madde imalatı",
            "20.52 Tutkal imalatı",
            "20.53 Uçucu yağların imalatı",
            "20.59 Başka yerde sınıflandırılmamış diğer kimyasal ürünlerin imalatı",
            "20.60 Suni veya sentetik elyaf imalatı",
            "21.10 Temel eczacılık ürünleri imalatı",
            "21.20 Eczacılığa ilişkin ilaçların imalatı",
            "22.1 Kauçuk ürünlerin imalatı",
            "22.11 İç ve dış lastik imalatı; lastiğe sırt geçirilmesi ve yeniden işlenmesi",
            "22.19 Diğer kauçuk ürünleri imalatı",
            "22.2 Plastik ürünlerin imalatı",
            "22.21 Plastik tabaka, levha, tüp ve profil imalatı",
            "22.22 Plastik torba, çanta, poşet, çuval, kutu, damacana, şişe, makara vb. paketl" +
                "eme malzemelerinin imalatı",
            "22.23 Plastik inşaat malzemesi imalatı",
            "22.29 Diğer plastik ürünlerin imalatı",
            "23.1 Cam ve cam ürünleri imalatı",
            "23.11 Düz cam imalatı",
            "23.12 Düz camın şekillendirilmesi ve işlenmesi",
            "23.13 Çukur cam imalatı",
            "23.14 Cam elyafı imalatı",
            "23.19 Diğer camların imalatı ve işlenmesi (teknik amaçlı cam eşyalar dahil)",
            "23.20 Ateşe dayanıklı (refrakter) ürünlerin imalatı",
            "23.3 Kilden inşaat malzemeleri imalatı",
            "23.31 Seramik karo ve kaldırım taşları imalatı",
            "23.32 Fırınlanmış kilden tuğla, karo ve inşaat malzemeleri imalatı",
            "23.4 Diğer porselen ve seramik ürünlerin imalatı",
            "23.41 Seramik ev ve süs eşyaları imalatı",
            "23.42 Seramik sıhhi ürünlerin imalatı",
            "23.43 Seramik yalıtkanların (izolatörlerin) ve yalıtkan bağlantı parçalarının ima" +
                "latı",
            "23.44 Diğer teknik seramik ürünlerin imalatı",
            "23.49 Başka yerde sınıflandırılmamış diğer seramik ürünlerin imalatı",
            "23.5 Çimento, kireç ve alçı imalatı",
            "23.51 Çimento imalatı",
            "23.52 Kireç ve alçı imalatı",
            "23.6 Beton, çimento ve alçıdan yapılmış eşyaların imalatı",
            "23.61 İnşaat amaçlı beton ürünlerin imalatı",
            "23.62 İnşaat amaçlı alçı ürünlerin imalatı",
            "23.63 Hazır beton imalatı",
            "23.64 Toz harç imalatı",
            "23.65 Lif ve çimento karışımlı ürünlerin imalatı",
            "23.69 Beton, alçı ve çimentodan yapılmış diğer ürünlerin imalatı",
            "23.70 Taş ve mermerin kesilmesi, şekil verilmesi ve bitirilmesi",
            "23.9 Aşındırıcı ürünlerin ve başka yerde sınıflandırılmamış metalik olmayan miner" +
                "al ürünlerin imalatı",
            "23.91 Aşındırıcı ürünlerin imalatı",
            "23.99 Başka yerde sınıflandırılmamış metalik olmayan diğer mineral ürünlerin imal" +
                "atı",
            "24.10 Ana demir ve çelik ürünleri ile ferro alaşımların imalatı",
            "24.20 Çelikten tüpler, borular, içi boş profiller ve benzeri bağlantı parçalarını" +
                "n imalatı",
            "24.3 Çeliğin ilk işlenmesinde elde edilen diğer ürünlerin imalatı",
            "24.31 Barların soğuk çekilmesi",
            "24.32 Dar şeritlerin soğuk haddelenmesi",
            "24.33 Soğuk şekillendirme veya katlama",
            "24.34 Tellerin soğuk çekilmesi",
            "24.4 Değerli ana metaller ve diğer demir dışı metallerin imalatı",
            "24.41 Değerli metal üretimi",
            "24.42 Alüminyum üretimi",
            "24.43 Kurşun, çinko ve kalay üretimi",
            "24.44 Bakır üretimi",
            "24.45 Demir dışı diğer metallerin üretimi",
            "24.46 Nükleer yakıtların işlenmesi",
            "24.5 Metal döküm sanayii",
            "24.51 Demir döküm",
            "24.52 Çelik dökümü",
            "24.53 Hafif metallerin dökümü",
            "24.54 Diğer demir dışı metallerin dökümü",
            "25.1 Metal yapı malzemeleri imalatı",
            "25.11 Metal yapı ve yapı parçaları imalatı",
            "25.12 Metalden kapı ve pencere imalatı",
            "25.2 Metal tank, rezervuar ve muhafaza kapları imalatı",
            "25.21 Merkezi ısıtma radyatörleri (elektrikli radyatörler hariç) ve sıcak su kaza" +
                "nları (boylerleri) imalatı",
            "25.29 Metalden diğer tank, rezervuar ve konteynerler imalatı",
            "25.30 Buhar jeneratörü imalatı, merkezi ısıtma sıcak su kazanları (boylerleri) ha" +
                "riç",
            "25.40 Silah ve mühimmat (cephane) imalatı",
            "25.50 Metallerin dövülmesi, preslenmesi, baskılanması ve yuvarlanması; toz metalü" +
                "rjisi",
            "25.6 Metallerin işlenmesi ve kaplanması; makinede işleme",
            "25.61 Metallerin işlenmesi ve kaplanması",
            "25.62 Metallerin makinede işlenmesi ve şekil verilmesi",
            "25.7 Çatal-bıçak takımı ve diğer kesici aletler ile el aletleri ve genel hırdavat" +
                " malzemeleri imalatı",
            "25.71 Çatal-bıçak takımları ve diğer kesici aletlerin imalatı",
            "25.72 Kilit ve menteşe imalatı",
            "25.73 El aletleri, takım tezgahı uçları, testere ağızları vb. imalatı",
            "25.9 Diğer fabrikasyon metal ürünlerin imalatı",
            "25.91 Çelik varil ve benzer muhafazaların imalatı",
            "25.92 Metalden hafif paketleme malzemeleri imalatı",
            "25.93 Tel ürünleri, zincir ve yayların imalatı",
            "25.94 Bağlantı malzemelerinin ve vida makinesi ürünlerinin imalatı",
            "25.99 Başka yerde sınıflandırılmamış diğer fabrikasyon metal ürünlerin imalatı",
            "26.1 Elektronik bileşenlerin ve devre kartlarının imalatı",
            "26.11 Elektronik bileşenlerin imalatı",
            "26.12 Yüklü elektronik kart imalatı",
            "26.20 Bilgisayar ve bilgisayar çevre birimleri imalatı",
            "26.30 İletişim ekipmanlarının imalatı",
            "26.40 Tüketici elektroniği ürünlerinin imalatı",
            "26.5 Ölçme, test ve seyrüsefer amaçlı alet ve cihazlar ile saat imalatı",
            "26.51 Ölçme, test ve seyrüsefer amaçlı alet ve cihazların imalatı",
            "26.52 Kol saatlerinin, masa ve duvar saatlerinin ve benzerlerinin imalatı",
            "26.60 Işınlama, elektro medikal ve elektro terapi ile ilgili cihazların imalatı",
            "26.70 Optik aletlerin ve fotografik ekipmanların imalatı",
            "26.80 Manyetik ve optik kaset, bant, CD, vb. ortamların imalatı",
            "27.1 Elektrik motoru, jeneratör, transformatör ile elektrik dağıtım ve kontrol ci" +
                "hazlarının imalatı",
            "27.11 Elektrik motorlarının, jeneratörlerin ve transformatörlerin imalatı",
            "27.12 Elektrik dağıtım ve kontrol cihazları imalatı",
            "27.20 Akümülatör ve pil imalatı",
            "27.3 Kablolamada kullanılan teller ve kablolar ile gereçlerin imalatı",
            "27.31 Fiber optik kabloların imalatı",
            "27.32 Diğer elektronik ve elektrik telleri ve kablolarının imalatı",
            "27.33 Kablolamada kullanılan gereçlerin imalatı",
            "27.40 Elektrikli aydınlatma ekipmanlarının imalatı",
            "27.5 Ev aletleri imalatı",
            "27.51 Elektrikli ev aletlerinin imalatı",
            "27.52 Elektriksiz ev aletlerinin imalatı",
            "27.90 Diğer elektrikli ekipmanların imalatı",
            "28.1 Genel amaçlı makinelerin imalatı",
            "28.11 Motor ve türbin imalatı (hava taşıtı, motorlu taşıt ve motosiklet motorları" +
                " hariç)",
            "28.12 Akışkan gücü ile çalışan ekipmanların imalatı",
            "28.13 Diğer pompaların ve kompresörlerin imalatı",
            "28.14 Diğer musluk ve valf/vana imalatı",
            "28.15 Rulman, dişli/dişli takımı, şanzıman ve tahrik elemanlarının imalatı",
            "28.2 Genel amaçlı diğer makinelerin imalatı",
            "28.21 Fırın, ocak (sanayi ocakları) ve brülör (ocak ateşleyicileri) imalatı",
            "28.22 Kaldırma ve taşıma ekipmanları imalatı",
            "28.23 Büro makineleri ve ekipmanları imalatı (bilgisayarlar ve çevre birimleri ha" +
                "riç)",
            "28.24 Motorlu veya pnömatik (hava basınçlı) el aletlerinin imalatı",
            "28.25 Soğutma ve havalandırma donanımlarının imalatı, evde kullanılanlar hariç",
            "28.29 Başka yerde sınıflandırılmamış diğer genel amaçlı makinelerin imalatı",
            "28.30 Tarım ve ormancılık makinelerinin imalatı",
            "28.4 Metal işleme makineleri ve takım tezgahları imalatı",
            "28.41 Metal işleme makinelerinin imalatı",
            "28.49 Diğer takım tezgahlarının imalatı",
            "28.9 Diğer özel amaçlı makinelerin imalatı",
            "28.91 Metalürji makineleri imalatı",
            "28.92 Maden, taş ocağı ve inşaat makineleri imalatı",
            "28.93 Gıda, içecek ve tütün işleme makineleri imalatı",
            "28.94 Tekstil, giyim eşyası ve deri üretiminde kullanılan makinelerin imalatı",
            "28.95 Kağıt ve mukavva üretiminde kullanılan makinelerin imalatı",
            "28.96 Plastik ve kauçuk makinelerinin imalatı",
            "28.99 Başka yerde sınıflandırılmamış diğer özel amaçlı makinelerin imalatı",
            "29.10 Motorlu kara taşıtlarının imalatı",
            "29.20 Motorlu kara taşıtları karoseri (kaporta) imalatı; treyler (römork) ve yarı" +
                " treyler (yarı römork) imalatı",
            "29.3 Motorlu kara taşıtları için parça ve aksesuar imalatı",
            "29.31 Motorlu kara taşıtları için elektrik ve elektronik donanımların imalatı",
            "29.32 Motorlu kara taşıtları için diğer parça ve aksesuarların imalatı",
            "30.1 Gemi ve tekne yapımı",
            "30.11 Gemilerin ve yüzen yapıların inşası",
            "30.12 Eğlence ve spor amaçlı teknelerin yapımı",
            "30.20 Demir yolu lokomotifleri ve vagonlarının imalatı",
            "30.30 Hava taşıtları ve uzay araçları ile bunlarla ilgili makinelerin imalatı",
            "30.40 Askeri savaş araçlarının imalatı",
            "30.9 Başka yerde sınıflandırılmamış ulaşım araçlarının imalatı",
            "30.91 Motosiklet imalatı",
            "30.92 Bisiklet ve engelli aracı imalatı",
            "30.99 Başka yerde sınıflandırılmamış diğer ulaşım ekipmanlarının imalatı",
            "31.0 Mobilya imalatı",
            "31.01 Büro ve mağaza mobilyaları imalatı",
            "31.02 Mutfak mobilyalarının imalatı",
            "31.03 Yatak imalatı",
            "31.09 Diğer mobilyaların imalatı",
            "32.1 Mücevherat, bijuteri eşyaları ve ilgili ürünlerin imalatı",
            "32.11 Madeni para basımı",
            "32.12 Mücevher ve benzeri eşyaların imalatı",
            "32.13 İmitasyon (taklit) takılar ve ilgili eşyaların imalatı",
            "32.20 Müzik aletleri imalatı",
            "32.30 Spor malzemeleri imalatı",
            "32.40 Oyun ve oyuncak imalatı",
            "32.50 Tıbbi ve dişçilik ile ilgili araç ve gereçlerin imalatı",
            "32.9 Başka yerde sınıflandırılmamış imalatlar",
            "32.91 Süpürge ve fırça imalatı",
            "32.99 Başka yerde sınıflandırılmamış diğer imalatlar",
            "33.1 Fabrikasyon metal ürünlerin, makinelerin ve ekipmanların onarımı",
            "33.11 Fabrikasyon metal ürünlerin onarımı",
            "33.12 Makinelerin onarımı",
            "33.13 Elektronik veya optik ekipmanların onarımı",
            "33.14 Elektrikli ekipmanların onarımı",
            "33.15 Gemilerin ve teknelerin bakım ve onarımı",
            "33.16 Hava taşıtlarının ve uzay araçlarının bakım ve onarımı",
            "33.17 Diğer ulaşım ekipmanlarının bakım ve onarımı",
            "33.19 Diğer ekipmanların onarımı",
            "33.20 Sanayi makine ve ekipmanlarının kurulumu",
            "35.11 Elektrik enerjisi üretimi",
            "35.12 Elektrik enerjisinin iletimi",
            "35.13 Elektrik enerjisinin dağıtımı",
            "35.14 Elektrik enerjisinin ticareti",
            "35.21 Gaz imalatı",
            "35.22 Ana şebeke üzerinden gaz yakıtların dağıtımı",
            "35.23 Ana şebeke üzerinden gaz ticareti",
            "35.30 Buhar ve iklimlendirme temini",
            "38.21 Tehlikesiz atıkların ıslahı ve bertaraf edilmesi",
            "38.22 Tehlikeli atıkların ıslahı ve bertaraf edilmesi",
            "62.01 Bilgisayar programlama faaliyetleri"});
            this.cmbNace.Location = new System.Drawing.Point(205, 215);
            this.cmbNace.Name = "cmbNace";
            this.cmbNace.Size = new System.Drawing.Size(600, 31);
            this.cmbNace.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.txtAddress, 2);
            this.txtAddress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress.Location = new System.Drawing.Point(205, 79);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(600, 54);
            this.txtAddress.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.Location = new System.Drawing.Point(541, 417);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(264, 50);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "KAYDET";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // CompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 498);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompanyView";
            this.Padding = new System.Windows.Forms.Padding(11, 14, 11, 14);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CompanyView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTaxNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblOwner;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblNace;
        private System.Windows.Forms.Label lblProductionStart;
        private System.Windows.Forms.Label lblIsRegistered;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtTaxNo;
        private System.Windows.Forms.TextBox txtOwner;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.DateTimePicker dtProductionStart;
        private System.Windows.Forms.CheckBox chkIsRegistered;
        private System.Windows.Forms.ComboBox cmbNace;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Button btnSave;
    }
}