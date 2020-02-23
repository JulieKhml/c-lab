using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// http://horo.tochka.net/ua/horoscopes/sign/
// https://www.chinahighlights.ru/kakoy-god-kakogo-zhivotnogo/

namespace Khmil_lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int myAge = DateTime.Today.Year - dateTimePicker1.Value.Year;
            year_old.Text = myAge.ToString();
            if (myAge < 0 || myAge > 135)
            { // CurrentYear - YourBirthDate
                year_old.Text = "Не можливо обрахувати";
                MessageBox.Show("Не вірна вибрана дата народження або менше 0 років або більше 135 років.");
            }

            if (dateTimePicker1.Value.Day == DateTime.Today.Day && dateTimePicker1.Value.Month == DateTime.Today.Month)
            {
                MessageBox.Show("З днем народження))). Це приємне повідомлення.");
            }

            chinese_zodiac_signs.Text = ChineseZodiac(dateTimePicker1.Value);
            west_zodiac_signs.Text = WestZodiac(dateTimePicker1.Value);
        }
        private string ChineseZodiac(DateTime date)
        {
            string[] zodiacSigns = {
                "Щур",
                "Бик",
                "Тигр",
                "Кролик",
                "Дракон",
                "Змія",
                "Кінь",
                "Вівці",
                "Мавпа",
                "Півень",
                "Собака",
                "Свиня"
            };

            const int ZodiacStartYear = 4; //1960
            const int Months = 12;

            int remainder = (date.Year - ZodiacStartYear) % Months;

            return zodiacSigns[remainder];
        }

        private string WestZodiac(DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                    if (date.Day <= 20)
                    { return "Козеріг"; }
                    else
                    { return "Водолій"; }
                case 2:
                    if (date.Day <= 18)
                    { return "Водолій"; }
                    else
                    { return "Риби"; }
                case 3:
                    if (date.Day <= 20)
                    { return "Риби"; }
                    else
                    { return "Овен"; }
                case 4:
                    if (date.Day <= 20)
                    { return "Овен"; }
                    else
                    { return "Тельці"; }
                case 5:
                    if (date.Day <= 21)
                    { return "Тельці"; }
                    else
                    { return "Близнюки"; }
                case 6:
                    if (date.Day <= 21)
                    { return "Близнюки"; }
                    else
                    { return "Рак"; }
                case 7:
                    if (date.Day <= 22)
                    { return "Рак"; }
                    else
                    { return "Лев"; }
                case 8:
                    if (date.Day <= 23)
                    { return "Лев"; }
                    else
                    { return "Діва"; }
                case 9:
                    if (date.Day <= 23)
                    { return "Діва"; }
                    else
                    { return "Терези"; }
                case 10:
                    if (date.Day <= 23)
                    { return "Терези"; }
                    else
                    { return "Скорпіон"; }
                case 11:
                    if (date.Day <= 22)
                    { return "Скорпіон"; }
                    else
                    { return "Стрілець"; }
                case 12:
                    if (date.Day <= 21)
                    { return "Стрілець"; }
                    else
                    { return "Козеріг"; }
                default:
                    return "Ваш знак зодіаку не знайшли! Спробуйте ще раз!";
            }
        }
    }
}
