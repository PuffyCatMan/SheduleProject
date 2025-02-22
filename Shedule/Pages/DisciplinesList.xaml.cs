﻿using LearningProcessesAPIClient.api;
using LearningProcessesAPIClient.model;
using Shedule.Utils;
using Shedule.ViewPages;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Shedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для Disciplines.xaml
    /// </summary>
    public partial class DisciplinesList : Page
    {
        public DisciplinesList()
        {
            InitializeComponent();
            sss();
        }

        public async Task sss()
        {
            await AppUtils.ProcessClientLibraryRequest(async () =>
            {
                var result = await LearningProcessesAPI.getAllSubjects();

                DisciplinesListView.ItemsSource = result;
                totalCount.Content = DisciplinesListView.Items.Count;
            });
        }
        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        public async Task deleteSubject(Subject subject)
        {
            //LearningProcessesAPI.updateTeacher();
            await AppUtils.ProcessClientLibraryRequest(async () =>
            {
                List<Subject> list = (List<Subject>)DisciplinesListView.ItemsSource;
                var result = await LearningProcessesAPI.deleteSubject(subject.Id);
                list.Remove(subject);
                //TeacherListView.Items.Remove(teacher);
                DisciplinesListView.Items.Refresh();
                totalCount.Content = DisciplinesListView.Items.Count;
            });

            //MessageBox.Show(result.Count + "");
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Это действие приведёт к удалению, без возможности восстановления.\nПродолжить?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (MessageBoxResult.Yes == result)
            {
                deleteSubject((Subject)((Button)sender).DataContext);
            }

        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new AddSubjectsView(sss));
        }

        private void search_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            DisciplinesListView.Items.Filter = x => ((Subject)x).Name.ToString().IndexOf(search_box.Text, StringComparison.OrdinalIgnoreCase) >= 0;
            DisciplinesListView.Items.Refresh();
            totalCount.Content = DisciplinesListView.Items.Count;
        }

        private void DisciplinesListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (DisciplinesListView.SelectedItem != null)
            {
                MainWindow.Instance.MainFrame.Navigate(new SubjectsView((Subject)DisciplinesListView.SelectedItem));
            }
        }
    }
}
