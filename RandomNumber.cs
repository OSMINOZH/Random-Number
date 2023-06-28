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
        private int townCode = 0, countNumbers = 0, howManyNumbers = 0;
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
        private void HideAllChoices(bool toHide, bool hideAll, string typeBox)
        {
            if (hideAll)
            {
                if (typeBox == "fed")
                {
                    FedDistrictComboBox.Items
                }
                else if (typeBox == "reg")
                {

                }
            }
            else if ()

        }
        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void CodeSwitcher(string fedDistrictC, string regionC, string typeNumberC)
        {
            switch (fedDistrictC)
            {
                case "Не выбран":

                    break;
                case "Центральный ФО":   





//Белгородская область
//Брянская область
//Владимирская область
//Воронежская область
//Ивановская область
//Калужская область
//Костромская область
//Курская область
//Липецкая область
//Московская область
//Орловская область
//Рязанская область
//Смоленская область
//Тамбовская область
//Тверская область
//Тульская область
//Ярославская область

                    break;
                case "Северо-Западный ФО":

                    break;
                case "Южный ФО":

                    break;
                case "Северо-Кавказский ФО":

                    break;
                case "Приволжский ФО":

                    break;
                case "Уральский ФО":

                    break;
                case "Сибирский ФО":

                    break;
                case "Дальневосточный ФО":

                    break;
            }
            switch (regionC)
            {
                case "Не выбран":

                    break;
                case "Белгородская область":

                    break;
                case "Брянская область":

                    break;
                case "Владимирская область":

                    break;
                case "Воронежская область":

                    break;
                case "Ивановская область":

                    break;
                case "Калужская область":

                    break;
                case "Костромская область":

                    break;
                case "Курская область":

                    break;
                case "Липецкая область":

                    break;
                case "Московская область":

                    break;
                case "Москва":

                    break;
                case "Орловская область":

                    break;
                case "Рязанская область":

                    break;
                case "Смоленская область":

                    break;
                case "Тамбовская область":

                    break;
                case "Тверская область":

                    break;
                case "Тульская область":

                    break;
                case "Ярославская область":

                    break;
                case "Республика Карелия":

                    break;
                case "Республика Коми":

                    break;
                case "Архангельская область":

                    break;
                case "Ненецкий автономный округ":

                    break;
                case "Вологодская область":

                    break;
                case "Калининградская область":

                    break;
                case "Ленинградская область":

                    break;
                case "Мурманская область":

                    break;
                case "Новгородская область":

                    break;
                case "Псковская область":

                    break;
                case "Республика Адыгея":

                    break;
                case "Республика Калмыкия":

                    break;
                case "Республика Крым":

                    break;
                case "Краснодарский край":

                    break;
                case "Астраханская область":

                    break;
                case "Волгоградская область":

                    break;
                case "Ростовская область":

                    break;
                case "Республика Дагестан":

                    break;
                case "Республика Ингушетия":

                    break;
                case "Кабардино-Балкарская Республика":

                    break;
                case "Карачаево-Черкесская Республика":

                    break;
                case "Республика Северная Осетия-Алания":

                    break;
                case "Чеченская Республика":

                    break;
                case "Ставропольский край":

                    break;
                case "Республика Башкортостан":

                    break;
                case "Республика Марий Эл":

                    break;
                case "Республика Мордовия":

                    break;
                case "Республика Татарстан":

                    break;
                case "Удмуртская Республика":

                    break;
                case "Чувашская Республика":

                    break;
                case "Пермский край":

                    break;
                case "Кировская область":

                    break;
                case "Нижегородская область":

                    break;
                case "Оренбургская область":

                    break;
                case "Пензенская область":

                    break;
                case "Санкт-Петербург":

                    break;
                case "Самарская область":

                    break;
                case "Саратовская область":

                    break;
                case "Ульяновская область":

                    break;
                case "Курганская область":

                    break;
                case "Свердловская область":

                    break;
                case "Тюменская область":

                    break;
                case "Ханты-Мансийский автономный округ":

                    break;
                case "Ямало-Ненецкий автономный округ":

                    break;
                case "Челябинская область":

                    break;
                case "Республика Алтай":

                    break;
                case "Республика Тыва":

                    break;
                case "Республика Хакасия":

                    break;
                case "Алтайский край":

                    break;
                case "Красноярский край":

                    break;
                case "Иркутская область":

                    break;
                case "Кемеровская область":

                    break;
                case "Новосибирская область":

                    break;
                case "Омская область":

                    break;
                case "Томская область":

                    break;
                case "Республика Бурятия":

                    break;
                case "Республика Саха (Якутия)":

                    break;
                case "Забайкальский край":

                    break;
                case "Амурская область":

                    break;
                case "Приморский край":

                    break;
                case "Хабаровский край":

                    break;
                case "Еврейская автономная область":

                    break;
                case "Магаданская область":

                    break;
                case "Сахалинская область":

                    break;
                case "Чукотский автономный округ":

                    break;
                case "Камчатский край":

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
            CodeSwitcher(FedDistrictComboBox.Text, RegionComboBox.Text, TypeNumberComboBox.Text);



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
