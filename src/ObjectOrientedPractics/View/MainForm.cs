﻿using System.Windows.Forms;

namespace ObjectOrientedPractics.View
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ItemsTab.SaveItemsData();
            CustomersTab.SaveCustomersData();
        }
    }
}
