
namespace RandomNumber
{
    partial class RandomNumber
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GenerateNumbersBTN = new MaterialSkin.Controls.MaterialButton();
            this.FedDistrictComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.RegionComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.TypeNumberComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.AmountMaskedTextBox = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // GenerateNumbersBTN
            // 
            this.GenerateNumbersBTN.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GenerateNumbersBTN.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.GenerateNumbersBTN.Depth = 0;
            this.GenerateNumbersBTN.HighEmphasis = true;
            this.GenerateNumbersBTN.Icon = null;
            this.GenerateNumbersBTN.Location = new System.Drawing.Point(302, 190);
            this.GenerateNumbersBTN.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.GenerateNumbersBTN.MouseState = MaterialSkin.MouseState.HOVER;
            this.GenerateNumbersBTN.Name = "GenerateNumbersBTN";
            this.GenerateNumbersBTN.NoAccentTextColor = System.Drawing.Color.Empty;
            this.GenerateNumbersBTN.Size = new System.Drawing.Size(143, 36);
            this.GenerateNumbersBTN.TabIndex = 1;
            this.GenerateNumbersBTN.Text = "Сгенерировать";
            this.GenerateNumbersBTN.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.GenerateNumbersBTN.UseAccentColor = false;
            this.GenerateNumbersBTN.UseVisualStyleBackColor = true;
            this.GenerateNumbersBTN.Click += new System.EventHandler(this.GenerateNumbersBTN_Click);
            // 
            // FedDistrictComboBox
            // 
            this.FedDistrictComboBox.AutoResize = false;
            this.FedDistrictComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.FedDistrictComboBox.Depth = 0;
            this.FedDistrictComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.FedDistrictComboBox.DropDownHeight = 174;
            this.FedDistrictComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FedDistrictComboBox.DropDownWidth = 121;
            this.FedDistrictComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.FedDistrictComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FedDistrictComboBox.FormattingEnabled = true;
            this.FedDistrictComboBox.Hint = "Фед. Округ";
            this.FedDistrictComboBox.IntegralHeight = false;
            this.FedDistrictComboBox.ItemHeight = 43;
            this.FedDistrictComboBox.Items.AddRange(new object[] {
            "Не выбран",
            "Центральный ФО",
            "Северо-Западный ФО",
            "Южный ФО",
            "Северо-Кавказский ФО",
            "Приволжский ФО",
            "Уральский ФО",
            "Сибирский ФО",
            "Дальневосточный ФО"});
            this.FedDistrictComboBox.Location = new System.Drawing.Point(6, 67);
            this.FedDistrictComboBox.MaxDropDownItems = 4;
            this.FedDistrictComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FedDistrictComboBox.Name = "FedDistrictComboBox";
            this.FedDistrictComboBox.Size = new System.Drawing.Size(221, 49);
            this.FedDistrictComboBox.StartIndex = 0;
            this.FedDistrictComboBox.TabIndex = 3;
            this.FedDistrictComboBox.SelectedIndexChanged += new System.EventHandler(this.FedDistrictComboBox_SelectedIndexChanged);
            // 
            // RegionComboBox
            // 
            this.RegionComboBox.AutoResize = false;
            this.RegionComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RegionComboBox.Depth = 0;
            this.RegionComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.RegionComboBox.DropDownHeight = 174;
            this.RegionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RegionComboBox.DropDownWidth = 121;
            this.RegionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.RegionComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RegionComboBox.FormattingEnabled = true;
            this.RegionComboBox.Hint = "Регион";
            this.RegionComboBox.IntegralHeight = false;
            this.RegionComboBox.ItemHeight = 43;
            this.RegionComboBox.Items.AddRange(new object[] {
            "Не выбран",
            "Белгородская область",
            "Брянская область",
            "Владимирская область",
            "Воронежская область",
            "Ивановская область",
            "Калужская область",
            "Костромская область",
            "Курская область",
            "Липецкая область",
            "Москва",
            "Московская область",
            "Орловская область",
            "Рязанская область",
            "Смоленская область",
            "Тамбовская область",
            "Тверская область",
            "Тульская область",
            "Ярославская область",
            "Республика Карелия",
            "Республика Коми",
            "Архангельская область",
            "Ненецкий автономный округ",
            "Вологодская область",
            "Калининградская область",
            "Ленинградская область",
            "Мурманская область",
            "Новгородская область",
            "Псковская область",
            "Республика Адыгея",
            "Республика Калмыкия",
            "Республика Крым",
            "Краснодарский край",
            "Астраханская область",
            "Волгоградская область",
            "Ростовская область",
            "Республика Дагестан",
            "Республика Ингушетия",
            "Кабардино-Балкарская Республика",
            "Карачаево-Черкесская Республика",
            "Республика Северная Осетия-Алания",
            "Чеченская Республика",
            "Ставропольский край",
            "Республика Башкортостан",
            "Республика Марий Эл",
            "Республика Мордовия",
            "Республика Татарстан",
            "Удмуртская Республика",
            "Чувашская Республика",
            "Пермский край",
            "Кировская область",
            "Нижегородская область",
            "Оренбургская область",
            "Пензенская область",
            "Санкт-Петербург",
            "Самарская область",
            "Саратовская область",
            "Ульяновская область",
            "Курганская область",
            "Свердловская область",
            "Тюменская область",
            "Ханты-Мансийский автономный округ",
            "Ямало-Ненецкий автономный округ",
            "Челябинская область",
            "Республика Алтай",
            "Республика Тыва",
            "Республика Хакасия",
            "Алтайский край",
            "Красноярский край",
            "Иркутская область",
            "Кемеровская область",
            "Новосибирская область",
            "Омская область",
            "Томская область",
            "Республика Бурятия",
            "Республика Саха (Якутия)",
            "Забайкальский край",
            "Амурская область",
            "Приморский край",
            "Хабаровский край",
            "Еврейская автономная область",
            "Магаданская область",
            "Сахалинская область",
            "Чукотский автономный округ",
            "Камчатский край"});
            this.RegionComboBox.Location = new System.Drawing.Point(233, 67);
            this.RegionComboBox.MaxDropDownItems = 4;
            this.RegionComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.RegionComboBox.Name = "RegionComboBox";
            this.RegionComboBox.Size = new System.Drawing.Size(212, 49);
            this.RegionComboBox.StartIndex = 0;
            this.RegionComboBox.TabIndex = 3;
            this.RegionComboBox.SelectedIndexChanged += new System.EventHandler(this.RegionComboBox_SelectedIndexChanged);
            // 
            // TypeNumberComboBox
            // 
            this.TypeNumberComboBox.AutoResize = false;
            this.TypeNumberComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TypeNumberComboBox.Depth = 0;
            this.TypeNumberComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.TypeNumberComboBox.DropDownHeight = 174;
            this.TypeNumberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeNumberComboBox.DropDownWidth = 121;
            this.TypeNumberComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.TypeNumberComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TypeNumberComboBox.FormattingEnabled = true;
            this.TypeNumberComboBox.Hint = "Тип номера";
            this.TypeNumberComboBox.IntegralHeight = false;
            this.TypeNumberComboBox.ItemHeight = 43;
            this.TypeNumberComboBox.Items.AddRange(new object[] {
            "Мобильный",
            "Стационарный"});
            this.TypeNumberComboBox.Location = new System.Drawing.Point(6, 122);
            this.TypeNumberComboBox.MaxDropDownItems = 4;
            this.TypeNumberComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.TypeNumberComboBox.Name = "TypeNumberComboBox";
            this.TypeNumberComboBox.Size = new System.Drawing.Size(221, 49);
            this.TypeNumberComboBox.StartIndex = 0;
            this.TypeNumberComboBox.TabIndex = 3;
            this.TypeNumberComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeNumberComboBox_SelectedIndexChanged);
            // 
            // AmountMaskedTextBox
            // 
            this.AmountMaskedTextBox.AllowPromptAsInput = true;
            this.AmountMaskedTextBox.AnimateReadOnly = false;
            this.AmountMaskedTextBox.AsciiOnly = false;
            this.AmountMaskedTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AmountMaskedTextBox.BeepOnError = false;
            this.AmountMaskedTextBox.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AmountMaskedTextBox.Depth = 0;
            this.AmountMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.AmountMaskedTextBox.HidePromptOnLeave = false;
            this.AmountMaskedTextBox.HideSelection = true;
            this.AmountMaskedTextBox.Hint = "Кол-во";
            this.AmountMaskedTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.AmountMaskedTextBox.LeadingIcon = null;
            this.AmountMaskedTextBox.Location = new System.Drawing.Point(6, 178);
            this.AmountMaskedTextBox.Mask = "";
            this.AmountMaskedTextBox.MaxLength = 32767;
            this.AmountMaskedTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.AmountMaskedTextBox.Name = "AmountMaskedTextBox";
            this.AmountMaskedTextBox.PasswordChar = '\0';
            this.AmountMaskedTextBox.PrefixSuffixText = null;
            this.AmountMaskedTextBox.PromptChar = '_';
            this.AmountMaskedTextBox.ReadOnly = false;
            this.AmountMaskedTextBox.RejectInputOnFirstFailure = false;
            this.AmountMaskedTextBox.ResetOnPrompt = true;
            this.AmountMaskedTextBox.ResetOnSpace = true;
            this.AmountMaskedTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountMaskedTextBox.SelectedText = "";
            this.AmountMaskedTextBox.SelectionLength = 0;
            this.AmountMaskedTextBox.SelectionStart = 0;
            this.AmountMaskedTextBox.ShortcutsEnabled = true;
            this.AmountMaskedTextBox.Size = new System.Drawing.Size(221, 48);
            this.AmountMaskedTextBox.SkipLiterals = true;
            this.AmountMaskedTextBox.TabIndex = 4;
            this.AmountMaskedTextBox.TabStop = false;
            this.AmountMaskedTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AmountMaskedTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.AmountMaskedTextBox.TrailingIcon = null;
            this.AmountMaskedTextBox.UseSystemPasswordChar = false;
            this.AmountMaskedTextBox.ValidatingType = null;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // RandomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 233);
            this.Controls.Add(this.AmountMaskedTextBox);
            this.Controls.Add(this.TypeNumberComboBox);
            this.Controls.Add(this.RegionComboBox);
            this.Controls.Add(this.FedDistrictComboBox);
            this.Controls.Add(this.GenerateNumbersBTN);
            this.Name = "RandomNumber";
            this.Text = "Рандомизация номера";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialButton GenerateNumbersBTN;
        private MaterialSkin.Controls.MaterialComboBox FedDistrictComboBox;
        private MaterialSkin.Controls.MaterialComboBox RegionComboBox;
        private MaterialSkin.Controls.MaterialComboBox TypeNumberComboBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox AmountMaskedTextBox;
        private System.Windows.Forms.Timer timer1;
    }
}

