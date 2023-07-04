using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;

namespace RandomNumber
{
    public partial class RandomNumber : MaterialForm
    {
        public RandomNumber()
        {
            InitializeComponent();
        }
        private string fedDistrict, region, typeNumber;
        private int townCode = 0, countNumbers = 0, howManyNumbers = 0, utc;
        private bool prefixOn = false;
        private void AddItems(string typeBox)
        {
            if(typeBox == "fed")
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
            else if(typeBox == "reg")
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
                for (int i=0; i<=regList.Count; i++)
                {
                    RegionComboBox.Items.Add(regList[i]);
                }

            }
        }
        private void HideChoices(bool toHide, string choices)
        {
            if(toHide)
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
            else if(!toHide)
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
        private void FedDistrictComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CodeSwitcher(FedDistrictComboBox.Text, "", "");
        }
        private void CodeSwitcher(string fedDistrictC, string regionC, string typeNumberC)
        {
            switch (fedDistrictC)
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
                    utc = 3; // UTC +3
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
                    utc = 3; // UTC +3 (Калининград UTC +2)
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
                    utc = 3; // UTC +3 (Астраханская область UTC +4)
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
                    utc = 3; // UTC +3 
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
                    utc = 5; // UTC +5 
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
            }
            switch (regionC)
            {
                case "all": // Adds all regions
                    HideChoices(true, "reg");
                    RegionComboBox.Items.Add("Не выбран");
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
                    RegionComboBox.Items.Add("Республика Адыгея");
                    RegionComboBox.Items.Add("Республика Калмыкия");
                    RegionComboBox.Items.Add("Республика Крым");
                    RegionComboBox.Items.Add("Краснодарский край");
                    RegionComboBox.Items.Add("Астраханская область");
                    RegionComboBox.Items.Add("Волгоградская область");
                    RegionComboBox.Items.Add("Ростовская область");
                    RegionComboBox.Items.Add("Республика Дагестан");
                    RegionComboBox.Items.Add("Республика Ингушетия");
                    RegionComboBox.Items.Add("Кабардино - Балкарская Республика");
                    RegionComboBox.Items.Add("Карачаево - Черкесская Республика");
                    RegionComboBox.Items.Add("Республика Северная Осетия-Алания");
                    RegionComboBox.Items.Add("Чеченская Республика");
                    RegionComboBox.Items.Add("Ставропольский край");
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
                    RegionComboBox.Items.Add("Курганская область");
                    RegionComboBox.Items.Add("Свердловская область");
                    RegionComboBox.Items.Add("Тюменская область");
                    RegionComboBox.Items.Add("Ханты - Мансийский автономный округ");
                    RegionComboBox.Items.Add("Ямало - Ненецкий автономный округ");
                    RegionComboBox.Items.Add("Челябинская область");
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
                case "Не выбран":
                    HideChoices(false, "fed");
                    break;
                case "Белгородская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Брянская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Владимирская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Воронежская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Ивановская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Калужская область":
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Костромская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Курская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Липецкая область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Московская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Москва":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Орловская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Рязанская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Смоленская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Тамбовская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Тверская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Тульская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Ярославская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Центральный ФО");
                    break;
                case "Республика Карелия":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Республика Коми":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Архангельская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Ненецкий автономный округ":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Вологодская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Калининградская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Ленинградская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Мурманская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Новгородская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Псковская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Западный ФО");
                    break;
                case "Республика Адыгея":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Южный ФО");
                    break;
                case "Республика Калмыкия":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Южный ФО");
                    break;
                case "Республика Крым":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Южный ФО");
                    break;
                case "Краснодарский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Южный ФО");
                    break;
                case "Астраханская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Южный ФО");
                    break;
                case "Волгоградская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Южный ФО");
                    break;
                case "Ростовская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Южный ФО");
                    break;
                case "Республика Дагестан":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Кавказский ФО");
                    break;
                case "Республика Ингушетия":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Кавказский ФО");
                    break;
                case "Кабардино-Балкарская Республика":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Кавказский ФО");
                    break;
                case "Карачаево-Черкесская Республика":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Кавказский ФО");
                    break;
                case "Республика Северная Осетия-Алания":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Кавказский ФО");
                    break;
                case "Чеченская Республика":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Кавказский ФО");
                    break;
                case "Ставропольский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Северо-Кавказский ФО");
                    break;
                case "Республика Башкортостан":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Республика Марий Эл":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Республика Мордовия":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Республика Татарстан":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Удмуртская Республика":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Чувашская Республика":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Пермский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Кировская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Нижегородская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Оренбургская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Пензенская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Санкт-Петербург":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Самарская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Саратовская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Ульяновская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Приволжский ФО");
                    break;
                case "Курганская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Уральский ФО");
                    break;
                case "Свердловская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Уральский ФО");
                    break;
                case "Тюменская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Уральский ФО");
                    break;
                case "Ханты-Мансийский автономный округ":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Уральский ФО");
                    break;
                case "Ямало-Ненецкий автономный округ":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Уральский ФО");
                    break;
                case "Челябинская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Уральский ФО");
                    break;
                case "Республика Алтай":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Республика Тыва":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Республика Хакасия":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Алтайский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Красноярский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Иркутская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Кемеровская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Новосибирская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Омская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Томская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Сибирский ФО");
                    break;
                case "Республика Бурятия":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Республика Саха (Якутия)":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Забайкальский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Амурская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Приморский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Хабаровский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Еврейская автономная область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Магаданская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Сахалинская область":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Чукотский автономный округ":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
                case "Камчатский край":
                    HideChoices(true, "fed");
                    FedDistrictComboBox.Items.Add("Дальневосточный ФО");
                    break;
            }
            switch (typeNumberC)
            {
                case "Мобильный":
                    
                    break;
                case "Стационарный":
                    
                    break;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void RegionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //CodeSwitcher(FedDistrictComboBox.Text, "", "");
        }

        private void GenerateNumbersBTN_Click(object sender, EventArgs e)
        {
            fedDistrict = FedDistrictComboBox.Text;
            region = RegionComboBox.Text;
            typeNumber = TypeNumberComboBox.Text;
            howManyNumbers = Convert.ToInt32(AmountMaskedTextBox.Text);

            GenerateNumbers();
        }

        private void NumberPrefixRBTN_Click(object sender, EventArgs e)
        {
            prefixOn = true;
        }

        private void WriteNumbers(int times, int numbers)
        {

            Logger.WriteLog($"");
        }

        private void GenerateNumbers()
        {
            for (int i = 0; i < howManyNumbers; i++)
            {
                //finalNumber = $"";
            }
        }
    }
}
