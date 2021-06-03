﻿using LearningProcessesAPIClient.api;
using LearningProcessesAPIClient.model;
using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace Shedule.ViewPages
{
    /// <summary>
    /// Логика взаимодействия для SpecialitiesSubjectView.xaml
    /// </summary>
    public partial class SpecialitiesSubjectView : Page
    {
        public delegate void Updater();
        public event Updater UpdateParent;
        public SpecialitiesSubjectView(SpecialitySubject subject,Updater updater)
        {
            InitializeComponent();
            DataContext = subject;
            loadSubject();
            UpdateParent += updater;
        }
        public async Task loadSubject()
        {
            var specialities = await LearningProcessesAPI.getAllSubjects();
            nameCB.ItemsSource = specialities;
        }
        private void edit_butt_Click(object sender, RoutedEventArgs e)
        {
            code.IsEnabled = true;
            nameCB.IsEnabled = true;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private async void save_butt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                code.GetBindingExpression(TextBox.TextProperty).UpdateSource();
                nameCB.GetBindingExpression(ComboBox.SelectedValueProperty).UpdateSource();
                SpecialitySubject specialitySubject = (SpecialitySubject)DataContext;
                var result = await LearningProcessesAPI.updateSpicialitySubject(specialitySubject.Id, specialitySubject);
                specialitySubject.Subject = result.Subject;
                MessageBox.Show("Данные успешно обновлены", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                UpdateParent?.Invoke();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
