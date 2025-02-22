﻿using LearningProcessesAPIClient;
using LearningProcessesAPIClient.api;
using LearningProcessesAPIClient.model;
using Shedule.Utils;
using System;
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

namespace Shedule.ViewPages
{
    /// <summary>
    /// Логика взаимодействия для TeachersList.xaml
    /// </summary>
    public partial class AddTeachersView : Page
    {
        public delegate Task Updater();
        public event Updater UpdateParent;
        public AddTeachersView(Updater updater)
        {
            InitializeComponent();
            loadDepartments();
            UpdateParent += updater;
        }

        public async Task loadDepartments()
        {
            await AppUtils.ProcessClientLibraryRequest(async () =>
            {
                var departments = await LearningProcessesAPI.getAllDepartments();
                departmentsCB.ItemsSource = departments;
            });

        }

        private void save_butt_Click(object sender, RoutedEventArgs e)
        {
            save();
        }

        private async Task save()
        {
            await AppUtils.ProcessClientLibraryRequest(async () =>
            {
                var result = await LearningProcessesAPI.createTeacher(name.Text, surname.Text, patronymic.Text, Convert.ToInt32(departmentsCB.SelectedValue));
                MessageBox.Show("Преподаватель успешно добавлен", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                UpdateParent?.Invoke();
            });
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
