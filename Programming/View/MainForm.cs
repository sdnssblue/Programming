﻿using Programming.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Programming.View
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            Array typeValues = Enum.GetValues(typeof(Enums));
            foreach (Enums value in typeValues)
            {
                EnumsListBox.Items.Add(value);
            }
            EnumsListBox.SelectedIndex = 0;

            Array initSeasonValues = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in initSeasonValues)
            {
                SeasonsComboBox.Items.Add(value);
            }
            SeasonsComboBox.SelectedIndex = 0;
        }


        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                ValuesListBox.Items.Clear();

                Array EnumValue;

                switch ((Enums)EnumsListBox.SelectedItem)
                {
                    case Enums.Weekday:
                        EnumValue = Enum.GetValues(typeof(Weekday));
                        break;

                    case Enums.Genre:
                        EnumValue = Enum.GetValues(typeof(Genre));
                        break;

                    case Enums.Colors:
                        EnumValue = Enum.GetValues(typeof(Colors));
                        break;

                    case Enums.EducationForm:
                        EnumValue = Enum.GetValues(typeof(EducationForm));
                        break;

                    case Enums.Smartphones:
                        EnumValue = Enum.GetValues(typeof(Smartphones));
                        break;

                    case Enums.Seasons:
                        EnumValue = Enum.GetValues(typeof(Seasons));
                        break;

                    default:
                        throw new NotImplementedException();
                }
                foreach (var value in EnumValue)
                {
                    ValuesListBox.Items.Add(value);
                }
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int) (ValuesListBox.SelectedItem)).ToString();
        }

        private void WeekdayParseButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday value;
            if (Enum.TryParse(textWeekdayTextBox, out value))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({value} - {(int)value})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Seasons.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Seasons.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }
    }
}
