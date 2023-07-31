﻿using System;
using System.Collections.Generic;
using MaterialSkin.Controls;
using System.Windows.Forms;
using System.IO;
using MySqlConnector;
using OfficeOpenXml;

namespace RandomNumber
{
    public partial class RandomNumber : MaterialForm
    {
        public RandomNumber()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }
        private MySqlConnection connection;
        private string fedDistrict, region, typeNumber;                         // USED TO GENERATE NUMBERS ONLY
        private int townCode = 0, countNumbers = 0, howManyNumbers = 0;    // USED TO GENERATE NUMBERS ONLY
        private bool prefixOn = false;
        private List<string> finalNumbers = new List<string>();
        private List<long> codeFull = new List<long>();
        private List<string> utc = new List<string>();
        private List<string> regions = new List<string>();
        private List<string> finalUtc = new List<string>();
        private List<string> finalRegions = new List<string>();
        private int index = 0;
        private string projectName;
        private bool maxNumberExist = false;
        private void AddItems(string typeBox)
        {
            if (typeBox == "fed")
            {
                // FedList Add Items
                List<string> fedList = new List<string>();
                fedList.Add("Центральный ФО"); // FedList Add Items
                fedList.Add("Не выбран");
                fedList.Add("Северо-Западный ФО");
                fedList.Add("Южный ФО");
                fedList.Add("Северо-Кавказский ФО");
                fedList.Add("Приволжский ФО");
                fedList.Add("Уральский ФО");
                fedList.Add("Сибирский ФО");
                fedList.Add("Дальневосточный ФО");
                // cycle to Fill comboBox 
                for (int i = 0; i <= fedList.Count; i++)
                {
                    RegionComboBox.Items.Add(fedList[i]);
                }
            }
            else if (typeBox == "reg")
            {
                // RegList Add Items
                List<string> regList = new List<string>();
                regList.Add("Не выбран"); // RegList Add Items
                regList.Add("Белгородская область");
                regList.Add("Брянская область");
                regList.Add("Владимирская область");
                regList.Add("Воронежская область");
                regList.Add("Ивановская область");
                regList.Add("Калужская область");
                regList.Add("Костромская область");
                regList.Add("Курская область");
                regList.Add("Липецкая область");
                regList.Add("Московская область");
                regList.Add("Орловская область");
                regList.Add("Рязанская область");
                regList.Add("Смоленская область");
                regList.Add("Тамбовская область");
                regList.Add("Тверская область");
                regList.Add("Тульская область");
                regList.Add("Ярославская область");
                regList.Add("Республика Карелия");
                regList.Add("Республика Коми");
                regList.Add("Архангельская область");
                regList.Add("Ненецкий автономный округ");
                regList.Add("Вологодская область");
                regList.Add("Калининградская область");
                regList.Add("Ленинградская область");
                regList.Add("Мурманская область");
                regList.Add("Новгородская область");
                regList.Add("Псковская область");
                regList.Add("Республика Адыгея");
                regList.Add("Республика Калмыкия");
                regList.Add("Республика Крым");
                regList.Add("Краснодарский край");
                regList.Add("Астраханская область");
                regList.Add("Волгоградская область");
                regList.Add("Ростовская область");
                regList.Add("Республика Дагестан");
                regList.Add("Республика Ингушетия");
                regList.Add("Кабардино-Балкарская Республика");
                regList.Add("Карачаево-Черкесская Республика");
                regList.Add("Республика Северная Осетия-Алания");
                regList.Add("Чеченская Республика");
                regList.Add("Ставропольский край");
                regList.Add("Республика Башкортостан");
                regList.Add("Республика Марий Эл");
                regList.Add("Республика Мордовия");
                regList.Add("Республика Татарстан");
                regList.Add("Удмуртская Республика");
                regList.Add("Чувашская Республика");
                regList.Add("Пермский край");
                regList.Add("Кировская область");
                regList.Add("Нижегородская область");
                regList.Add("Оренбургская область");
                regList.Add("Пензенская область");
                regList.Add("Самарская область");
                regList.Add("Саратовская область");
                regList.Add("Ульяновская область");
                regList.Add("Курганская область");
                regList.Add("Свердловская область");
                regList.Add("Тюменская область");
                regList.Add("Ханты-Мансийский автономный округ");
                regList.Add("Ямало-Ненецкий автономный округ");
                regList.Add("Челябинская область");
                regList.Add("Республика Алтай");
                regList.Add("Республика Тыва");
                regList.Add("Республика Хакасия");
                regList.Add("Алтайский край");
                regList.Add("Красноярский край");
                regList.Add("Иркутская область");
                regList.Add("Кемеровская область");
                regList.Add("Новосибирская область");
                regList.Add("Омская область");
                regList.Add("Томская область");
                regList.Add("Республика Бурятия");
                regList.Add("Республика Саха (Якутия)");
                regList.Add("Забайкальский край");
                regList.Add("Амурская область");
                regList.Add("Приморский край");
                regList.Add("Хабаровский край");
                regList.Add("Еврейская автономная область");
                regList.Add("Магаданская область");
                regList.Add("Сахалинская область");
                regList.Add("Чукотский автономный округ");
                regList.Add("Камчатский край");
                // cycle to Fill comboBox 
                for (int i = 0; i <= regList.Count; i++)
                {
                    RegionComboBox.Items.Add(regList[i]);
                }

            }
        }
        private void HideChoices(bool toHide, string choices)
        {
            if (toHide)
            {
                switch (choices)
                {
                    case "all":
                        RegionComboBox.Items.Clear();
                        FedDistrictComboBox.Items.Clear();
                        break;
                    case "fed":
                        FedDistrictComboBox.Items.Clear();
                        break;
                    case "reg":
                        RegionComboBox.Items.Clear();
                        break;
                }
            }
            else if (!toHide)
            {
                switch (choices)
                {
                    case "all":
                        CodeSwitcher("all", "all", "");
                        break;
                    case "fed":
                        CodeSwitcher("all", "", "");
                        break;
                    case "reg":
                        CodeSwitcher("", "all", "");
                        break;
                }
            }
        }
        private void CodeSwitcher(string fedDistrictC, string regionC, string typeNumberC)
        {
            switch (fedDistrictC) // Сделать блокирование comboboxRegion и появление при изменении валидного значения в comboboxFed
            {
                case "all":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Не выбран");
                    FedDistrictComboBox.Items.Add("Центральный ФО");         // UTC3
                    FedDistrictComboBox.Items.Add("Северо - Западный ФО");   // UTC3 (Калининград UTC2)
                    FedDistrictComboBox.Items.Add("Южный ФО");               // UTC3 (Астраханская область UTC4)
                    FedDistrictComboBox.Items.Add("Северо - Кавказский ФО"); // UTC3 
                    FedDistrictComboBox.Items.Add("Приволжский ФО");         // разные UTC
                    FedDistrictComboBox.Items.Add("Уральский ФО");           // UTC5
                    FedDistrictComboBox.Items.Add("Сибирский ФО");           // разные UTC
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");     // разные UTC
                    break;
                case "Не выбран":
                    HideChoices(false, "reg");
                    break;
                case "Центральный ФО":
                    //utc = 3; // UTC +3
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Белгородская область");
                    RegionComboBox.Items.Add("Брянская область");
                    RegionComboBox.Items.Add("Владимирская область");
                    RegionComboBox.Items.Add("Воронежская область");
                    RegionComboBox.Items.Add("Ивановская область");
                    RegionComboBox.Items.Add("Калужская область");
                    RegionComboBox.Items.Add("Костромская область");
                    RegionComboBox.Items.Add("Курская область");
                    RegionComboBox.Items.Add("Липецкая область");
                    RegionComboBox.Items.Add("Московская область");
                    RegionComboBox.Items.Add("Орловская область");
                    RegionComboBox.Items.Add("Рязанская область");
                    RegionComboBox.Items.Add("Смоленская область");
                    RegionComboBox.Items.Add("Тамбовская область");
                    RegionComboBox.Items.Add("Тверская область");
                    RegionComboBox.Items.Add("Тульская область");
                    RegionComboBox.Items.Add("Ярославская область");
                    break;
                case "Северо-Западный ФО":
                    //utc = 3; // UTC +3 (Калининград UTC +2)
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Республика Карелия");
                    RegionComboBox.Items.Add("Республика Коми");
                    RegionComboBox.Items.Add("Архангельская область");
                    RegionComboBox.Items.Add("Ненецкий автономный округ");
                    RegionComboBox.Items.Add("Вологодская область");
                    RegionComboBox.Items.Add("Калининградская область");
                    RegionComboBox.Items.Add("Ленинградская область");
                    RegionComboBox.Items.Add("Мурманская область");
                    RegionComboBox.Items.Add("Новгородская область");
                    RegionComboBox.Items.Add("Псковская область");
                    break;
                case "Южный ФО":
                    //utc = 3; // UTC +3 (Астраханская область UTC +4)
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Республика Адыгея");
                    RegionComboBox.Items.Add("Республика Калмыкия");
                    RegionComboBox.Items.Add("Республика Крым");
                    RegionComboBox.Items.Add("Краснодарский край");
                    RegionComboBox.Items.Add("Астраханская область");
                    RegionComboBox.Items.Add("Волгоградская область");
                    RegionComboBox.Items.Add("Ростовская область");
                    break;
                case "Северо-Кавказский ФО":
                    //utc = 3; // UTC +3 
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Республика Дагестан");
                    RegionComboBox.Items.Add("Республика Ингушетия");
                    RegionComboBox.Items.Add("Кабардино - Балкарская Республика");
                    RegionComboBox.Items.Add("Карачаево - Черкесская Республика");
                    RegionComboBox.Items.Add("Республика Северная Осетия-Алания");
                    RegionComboBox.Items.Add("Чеченская Республика");
                    RegionComboBox.Items.Add("Ставропольский край");
                    break;
                case "Приволжский ФО":
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Республика Башкортостан");
                    RegionComboBox.Items.Add("Республика Марий Эл");
                    RegionComboBox.Items.Add("Республика Мордовия");
                    RegionComboBox.Items.Add("Республика Татарстан");
                    RegionComboBox.Items.Add("Удмуртская Республика");
                    RegionComboBox.Items.Add("Чувашская Республика");
                    RegionComboBox.Items.Add("Пермский край");
                    RegionComboBox.Items.Add("Кировская область");
                    RegionComboBox.Items.Add("Нижегородская область");
                    RegionComboBox.Items.Add("Оренбургская область");
                    RegionComboBox.Items.Add("Пензенская область");
                    RegionComboBox.Items.Add("Самарская область");
                    RegionComboBox.Items.Add("Саратовская область");
                    RegionComboBox.Items.Add("Ульяновская область");
                    break;
                case "Уральский ФО":
                    //utc = 5; // UTC +5 
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Курганская область");
                    RegionComboBox.Items.Add("Свердловская область");
                    RegionComboBox.Items.Add("Тюменская область");
                    RegionComboBox.Items.Add("Ханты - Мансийский автономный округ");
                    RegionComboBox.Items.Add("Ямало - Ненецкий автономный округ");
                    RegionComboBox.Items.Add("Челябинская область");
                    break;
                case "Сибирский ФО":
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Республика Алтай");
                    RegionComboBox.Items.Add("Республика Тыва");
                    RegionComboBox.Items.Add("Республика Хакасия");
                    RegionComboBox.Items.Add("Алтайский край");
                    RegionComboBox.Items.Add("Красноярский край");
                    RegionComboBox.Items.Add("Иркутская область");
                    RegionComboBox.Items.Add("Кемеровская область");
                    RegionComboBox.Items.Add("Новосибирская область");
                    RegionComboBox.Items.Add("Омская область");
                    RegionComboBox.Items.Add("Томская область");
                    break;
                case "Дальневосточный ФО":
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Республика Бурятия");
                    RegionComboBox.Items.Add("Республика Саха (Якутия)");
                    RegionComboBox.Items.Add("Забайкальский край");
                    RegionComboBox.Items.Add("Амурская область");
                    RegionComboBox.Items.Add("Приморский край");
                    RegionComboBox.Items.Add("Хабаровский край");
                    RegionComboBox.Items.Add("Еврейская автономная область");
                    RegionComboBox.Items.Add("Магаданская область");
                    RegionComboBox.Items.Add("Сахалинская область");
                    RegionComboBox.Items.Add("Чукотский автономный округ");
                    RegionComboBox.Items.Add("Камчатский край");
                    break;
            } // Добавлены UTC по округам
            switch (regionC)
            {
                case "all": // Adds all regions
                    break;
                case "Не выбран":
                    break;
                case "Белгородская область":

                    //Центральный ФО");
                    break;
                case "Брянская область":

                    //Центральный ФО");
                    break;
                case "Владимирская область":

                    //Центральный ФО");
                    break;
                case "Воронежская область":

                    //Центральный ФО");
                    break;
                case "Ивановская область":

                    //Центральный ФО");
                    break;
                case "Калужская область":
                    //Центральный ФО");
                    break;
                case "Костромская область":

                    //Центральный ФО");
                    break;
                case "Курская область":

                    //Центральный ФО");
                    break;
                case "Липецкая область":

                    //Центральный ФО");
                    break;
                case "Московская область":

                    //Центральный ФО");
                    break;
                case "Москва":

                    //Центральный ФО");
                    break;
                case "Орловская область":

                    //Центральный ФО");
                    break;
                case "Рязанская область":

                    //Центральный ФО");
                    break;
                case "Смоленская область":

                    //Центральный ФО");
                    break;
                case "Тамбовская область":

                    //Центральный ФО");
                    break;
                case "Тверская область":

                    //Центральный ФО");
                    break;
                case "Тульская область":

                    //Центральный ФО");
                    break;
                case "Ярославская область":

                    //Центральный ФО");
                    break;
                case "Республика Карелия":

                    //Северо-Западный ФО");
                    break;
                case "Республика Коми":

                    //Северо-Западный ФО");
                    break;
                case "Архангельская область":

                    //Северо-Западный ФО");
                    break;
                case "Ненецкий автономный округ":

                    //Северо-Западный ФО");
                    break;
                case "Вологодская область":

                    //Северо-Западный ФО");
                    break;
                case "Калининградская область":
                    //utc = 2; // UTC +2
                    //Северо-Западный ФО");
                    break;
                case "Ленинградская область":

                    //Северо-Западный ФО");
                    break;
                case "Мурманская область":

                    //Северо-Западный ФО");
                    break;
                case "Новгородская область":

                    //Северо-Западный ФО");
                    break;
                case "Псковская область":

                    //Северо-Западный ФО");
                    break;
                case "Республика Адыгея":

                    //Южный ФО");
                    break;
                case "Республика Калмыкия":

                    //Южный ФО");
                    break;
                case "Республика Крым":

                    //Южный ФО");
                    break;
                case "Краснодарский край":

                    //Южный ФО");
                    break;
                case "Астраханская область":
                    //utc = 4;
                    //Южный ФО");
                    break;
                case "Волгоградская область":

                    //Южный ФО");
                    break;
                case "Ростовская область":

                    //Южный ФО");
                    break;
                case "Республика Дагестан":

                    //Северо-Кавказский ФО");
                    break;
                case "Республика Ингушетия":

                    //Северо-Кавказский ФО");
                    break;
                case "Кабардино-Балкарская Республика":

                    //Северо-Кавказский ФО");
                    break;
                case "Карачаево-Черкесская Республика":

                    //Северо-Кавказский ФО");
                    break;
                case "Республика Северная Осетия-Алания":

                    //Северо-Кавказский ФО");
                    break;
                case "Чеченская Республика":

                    //Северо-Кавказский ФО");
                    break;
                case "Ставропольский край":

                    //Северо-Кавказский ФО");
                    break;
                case "Республика Башкортостан":
                    //utc = 5;
                    //Приволжский ФО");
                    break;
                case "Республика Марий Эл":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Республика Мордовия":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Республика Татарстан":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Удмуртская Республика":
                    //utc = 4;
                    //Приволжский ФО");
                    break;
                case "Чувашская Республика":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Пермский край":
                    //utc = 5;
                    //Приволжский ФО");
                    break;
                case "Кировская область":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Нижегородская область":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Оренбургская область":
                    //utc = 5;
                    //Приволжский ФО");
                    break;
                case "Пензенская область":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Санкт-Петербург":
                    //utc = 3;
                    //Приволжский ФО");
                    break;
                case "Самарская область":
                    //utc = 4;
                    //Приволжский ФО");
                    break;
                case "Саратовская область":
                    //utc = 4;
                    //Приволжский ФО");
                    break;
                case "Ульяновская область":
                    //utc = 4;
                    //Приволжский ФО");
                    break;
                case "Курганская область":

                    //Уральский ФО");
                    break;
                case "Свердловская область":

                    //Уральский ФО");
                    break;
                case "Тюменская область":

                    //Уральский ФО");
                    break;
                case "Ханты-Мансийский автономный округ":

                    //Уральский ФО");
                    break;
                case "Ямало-Ненецкий автономный округ":

                    //Уральский ФО");
                    break;
                case "Челябинская область":

                    //Уральский ФО");
                    break;
                case "Республика Алтай":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Республика Тыва":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Республика Хакасия":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Алтайский край":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Красноярский край":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Иркутская область":
                    //utc = 8;
                    //Сибирский ФО");
                    break;
                case "Кемеровская область":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Новосибирская область":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Омская область":
                    //utc = 6;
                    //Сибирский ФО");
                    break;
                case "Томская область":
                    //utc = 7;
                    //Сибирский ФО");
                    break;
                case "Республика Бурятия":
                    //utc = 8;
                    //Дальневосточный ФО");
                    break;
                case "Республика Саха (Якутия)":
                    //utc = 9;
                    //Дальневосточный ФО");
                    break;
                case "Забайкальский край":
                    //utc = 9;
                    //Дальневосточный ФО");
                    break;
                case "Амурская область":
                    //utc = 9;
                    //Дальневосточный ФО");
                    break;
                case "Приморский край":
                    //utc = 10;
                    //Дальневосточный ФО");
                    break;
                case "Хабаровский край":
                    //utc = 10;
                    //Дальневосточный ФО");
                    break;
                case "Еврейская автономная область":
                    //utc = 10;
                    //Дальневосточный ФО");
                    break;
                case "Магаданская область":
                    //utc = 11;
                    //Дальневосточный ФО");
                    break;
                case "Сахалинская область":
                    //utc = 11;
                    //Дальневосточный ФО");
                    break;
                case "Чукотский автономный округ":
                    //utc = 12;
                    //Дальневосточный ФО");
                    break;
                case "Камчатский край":
                    //utc = 12;
                    //Дальневосточный ФО");
                    break;
            }      // Добавлены UTC по регионам
            switch (typeNumberC)
            {
                case "Мобильный":
                    typeNumber = "Мобильный";
                    break;
                case "Стационарный":
                    typeNumber = "Стационарный";
                    break;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (FedDistrictComboBox.SelectedItem.ToString() == "Не выбран") { GenerateNumbersBTN.Enabled = false; RegionComboBox.Enabled = false; }
            else { GenerateNumbersBTN.Enabled = true; RegionComboBox.Enabled = true; }

            // TEMPORARY //
            if (TypeNumberComboBox.SelectedItem.ToString() == "Стационарный") GenerateNumbersBTN.Enabled = false;
            else if (FedDistrictComboBox.SelectedItem.ToString() != "Не выбран") GenerateNumbersBTN.Enabled = true;
        }
        private void FedDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodeSwitcher(FedDistrictComboBox.Text, "", "");
        }
        private void TypeNumberComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodeSwitcher("", "", TypeNumberComboBox.Text);
        }
        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodeSwitcher("", RegionComboBox.Text, "");
        }
        private void ShowInputBox()
        {
            using (InputBoxForm inputBox = new InputBoxForm())
            {
                if (inputBox.ShowDialog() == DialogResult.OK)
                {
                    // Получаем текст, введенный пользователем
                    projectName = inputBox.inputText;
                    MessageBox.Show("Генерация началась");

                    fedDistrict = FedDistrictComboBox.SelectedItem.ToString();
                    region = RegionComboBox.SelectedItem.ToString();
                    typeNumber = TypeNumberComboBox.SelectedItem.ToString();
                    howManyNumbers = Convert.ToInt32(AmountMaskedTextBox.Text);
                    if (region == "Не выбран") GenerateNumbers("fed", fedDistrict); // Fed or Region switcher
                    else GenerateNumbers("region", region);
                }
                else if (inputBox.ShowDialog() == DialogResult.Cancel)
                {
                    MessageBox.Show("Введите название проекта");
                }
            }
        }
        private void GenerateNumbersBTN_Click(object sender, EventArgs e)
        {
            ShowInputBox();
        }
        private void GenerateNumbers(string regionORfed, string selectName) // maybe async start in future !!!
        {
            codeFull.Clear();
            finalNumbers.Clear();
            utc.Clear();
            regions.Clear();
            finalUtc.Clear();
            finalRegions.Clear();

            if (connection == null)
            {
                string connectionString = "server=127.0.0.1;port=3306;database=workdb;uid=root;pwd=root;";
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }

            string query = $"SELECT codeFull, utc, region FROM operators WHERE {regionORfed} = '{selectName}'";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@selectName", selectName);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        codeFull.Add((long)reader["codeFull"]);
                        utc.Add((string)reader["utc"]);
                        regions.Add((string)reader["region"]);
                    }
                }
            }

            foreach (long number in codeFull)
            {
                //utcAdd($"SELECT utc FROM operators WHERE codeFull ={number}");
                //operatorNameAdd($"SELECT operatorName FROM operators WHERE codeFull ={number}");
                long maxNumber = number + 1;
                long curNumber = number;
                //int numberSymbCount = curNumber.ToString().Length;
                for (int numberSymbCount = curNumber.ToString().Length; numberSymbCount < 10; numberSymbCount++) maxNumber *= 10;
                for (int numberSymbCount = curNumber.ToString().Length; numberSymbCount < 10; numberSymbCount++) curNumber *= 10;
                for (; curNumber < maxNumber; curNumber++) // j<9999999 // 9999999 is max numbers in phone number by single 3-symbols code // probly j.lenght would work same
                {
                    //utcAdd($"SELECT utc FROM operators WHERE codeFull ={number}");
                    finalNumbers.Add($"{curNumber.ToString()}");
                    finalUtc.Add(utc[index]);
                    finalRegions.Add(regions[index]);
                    if (finalNumbers.Count == howManyNumbers) break;
                }
                if (finalNumbers.Count == howManyNumbers) break;
                index++;
            }
            LoadWriteBunchData(); // function to write data to the output file with multiple columns
        } // 25.07.2023 СНИЗУ ЗАКОНЧИЛ
        private void LoadWriteBunchData()
        {
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                // Determine the maximum number of elements in the lists.
                int maxCount = Math.Max(finalNumbers.Count, Math.Max(codeFull.Count, Math.Max(finalUtc.Count, finalRegions.Count)));

                for (int i = 0; i < maxCount; i++)
                {
                    string number = (i < finalNumbers.Count) ? finalNumbers[i] : string.Empty;
                    long code = (i < codeFull.Count) ? codeFull[i] : 0;
                    string timeZone = (i < finalUtc.Count) ? finalUtc[i] : string.Empty;
                    string regionValue = (i < finalRegions.Count) ? finalRegions[i] : string.Empty;

                    writer.WriteLine($"{number}\t{timeZone}\t{regionValue}\t{fedDistrict}\t{projectName}");
                }
            }
            if(divideCheckbox.CheckState==CheckState.Unchecked) ConvertToExcel("output.txt", $"{projectName}.xlsx", 1000000); // лимит в 1 млн номеров одновременно
            else if (divideCheckbox.CheckState == CheckState.Checked) ConvertToExcel("output.txt", $"{projectName}.xlsx", 50000);
        }
        private void ConvertToExcel(string txtFilePath, string excelFilePath, int maxRows)
        {
            // Read the content of the .txt file
            string[] lines = File.ReadAllLines(txtFilePath);

            int totalRows = lines.Length; // Общее количество строк в текстовом файле
            int currentRow = 0; // Счетчик текущей строки в текстовом файле
            int fileNumber = 1; // Счетчик номера Excel файла

            while (currentRow < totalRows)
            {
                // Create a new Excel package for each file
                using (ExcelPackage package = new ExcelPackage())
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets.Add($"{projectName}_{fileNumber}");

                    // Записываем строки в Excel файл
                    for (int row = 1; row <= maxRows && currentRow < totalRows; row++)
                    {
                        string line = lines[currentRow];
                        string[] cells = line.Split('\t');

                        // Loop through each cell in the line and add the value to the Excel worksheet
                        for (int col = 0; col < cells.Length; col++)
                        {
                            worksheet.Cells[row, col + 1].Value = cells[col];
                        }

                        currentRow++;
                    }

                    // Save the Excel package to a file
                    string newFilePath = Path.Combine(Path.GetDirectoryName(excelFilePath), $"{Path.GetFileNameWithoutExtension(excelFilePath)}_{fileNumber}.xlsx");
                    FileInfo excelFile = new FileInfo(newFilePath);
                    package.SaveAs(excelFile);
                }

                fileNumber++;
            }
        }

    }
}