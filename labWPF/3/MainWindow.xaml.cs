﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }

        private void Lb1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Lb1.SelectedIndex)
            {
                case 0:
                    InpLb.Content = "Ближайшая к Солнцу планета Солнечной системы, наименьшая из планет земной группы.\n" +
                                    "Названа в честь древнеримского бога торговли - быстрого Меркурия, поскольку она\n" +
                                    "движется по небесной сфере быстрее других планет." +
                                    "\n Масса: 3.33×10²³ кг" +
                                    "\n Средняя температура: 66,8 °C" +
                                    "\n Вторая космическая скорость: 4,25 км / с";
                    break;
                case 1:
                    InpLb.Content = "Вторая по удалённости от Солнца планета Солнечной системы, наряду с Меркурием," +
                        "\nЗемлёй и Марсом принадлежит к семейству планет земной группы. Названа в честь древнеримской\n" +
                        "богини любви Венеры. Венерианский год составляет 224,7 земных суток. Она имеет самый длинный\n" +
                        "период вращения вокруг своей оси среди всех планет" +
                        "\nМасса: 4.87×10²⁴ кг \n Средняя температура: 463 °C \n Вторая космическая скорость: 10,4 км / с";
                    break;
                case 2:
                    InpLb.Content = "Третья по удалённости от Солнца планета Солнечной системы. Самая плотная, пятая по диаметру\n" +
                        "и массе среди всех планет и крупнейшая среди планет земной группы\n" +
                        "Площадь: 510 072 000 км² \nМасса: 5.97×10²⁴ кг \nСредняя температура: 14,8 °C \nСпутники: Луна, Искусственный спутник Земли";
                    break;
                case 3:
                    InpLb.Content = "Четвёртая по удалённости от Солнца и седьмая по размерам планета Солнечной системы;\n" +
                        "масса планеты составляет 10,7% массы Земли. Названа в честь Марса - древнеримского бога войны,\n" +
                        "соответствующего древнегреческому Аресу.\n" +
                        "Масса: 6.42×10²³ кг\n Средняя температура: -63,1 °C \nВторая космическая скорость: 5,03 км / с \nСпутники: Фобос, Деймос";
                    break;
                case 4:
                    InpLb.Content = "Крупнейшая планета Солнечной системы, пятая по удалённости от Солнца.\n" +
                        " Наряду с Сатурном, Ураном и Нептуном, Юпитер классифицируется как газовый гигант.\n" +
                        "Масса: 1.9×10²⁷ кг\n Средняя температура: -108 °C\n Вторая космическая скорость: 59,5 км / с\n Спутники: Ганимед, Европа, Ио, Каллисто, Кольца Юпитера, Амальтея, Фива, Лиситея, Гималия, Метида ";
                    break;
                case 5:
                    InpLb.Content = "Шестая планета от Солнца и вторая по размерам планета в Солнечной системе после Юпитера.\n" +
                        "Сатурн, а также Юпитер, Уран и Нептун, классифицируются как газовые гиганты.\nСатурн назван в честь римского бога земледелия.\n" +
                        "Символ Сатурна - серп.\n Масса: 5.68×10²⁶ кг\n Вторая космическая скорость: 35,5 км / с\n Спутники: Кольца Сатурна, Титан, Энцелад, Мимас, Япет, Пандора, Диона, Гиперион, Тефия, Рея";
                    break;
                case 6:
                    InpLb.Content = "Планета Солнечной системы, седьмая по удалённости от Солнца, третья по диаметру и четвёртая по массе.\n" +
                        "Была открыта в 1781 году английским астрономом Уильямом Гершелем.\nНазвана в честь греческого бога неба Урана.\n" +
                        "Масса: 8.68×10²⁵ кг\n Вторая космическая скорость: 21,3 км / с\n Спутники: Умбриэль, Кольца Урана, Миранда, Титания, Ариэль, Оберон, Крессида, Пердита, Пак, Дездемона";
                    break;
                case 7:
                    InpLb.Content = "Восьмая и самая дальняя от Земли планета Солнечной системы.\nНептун также является четвёртой по диаметру и третьей по массе планетой.\n" +
                        "Масса Нептуна в 17,2 раза, а диаметр экватора в 3,9 раза больше земных.\nПланета была названа в честь римского бога морей.\n" +
                        "Масса: 1.02×10²⁶ кг\n Средняя температура: -201 °C\n Вторая космическая скорость: 23,5 км / с\n Спутники: Тритон, Кольца Нептуна, Нереида, Несо, Лариса, Протей, Таласса, Наяда, Галатея, Деспина";
                    break;

            }
        }
    }
}
