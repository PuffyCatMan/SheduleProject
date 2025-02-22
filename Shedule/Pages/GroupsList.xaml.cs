﻿using LearningProcessesAPIClient.api;
using LearningProcessesAPIClient.model;
using Shedule.Utils;
using Shedule.ViewPages;
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

namespace Shedule.Pages
{
    /// <summary>
    /// Логика взаимодействия для Groups.xaml
    /// </summary>
    public partial class GroupsList : Page
    {
        public GroupsList()
        {
            InitializeComponent();
            sss();
        }
        public async Task sss()
        {
            await AppUtils.ProcessClientLibraryRequest(async () =>
            {
                var result = await LearningProcessesAPI.getAllGroups();
                GroupsListView.ItemsSource = result;
                totalCount.Content = GroupsListView.Items.Count;
            });
            int a = 1;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double remainingSpace = GroupsListView.ActualWidth;


            if (remainingSpace > 0)
            {
                (GroupsListView.View as GridView).Columns[0].Width = Math.Ceiling(remainingSpace / 4);
                (GroupsListView.View as GridView).Columns[1].Width = Math.Ceiling(remainingSpace / 4);
                (GroupsListView.View as GridView).Columns[2].Width = Math.Ceiling(remainingSpace / 4);
                (GroupsListView.View as GridView).Columns[3].Width = Math.Ceiling(remainingSpace / 4);
            }
        }
        public async Task deleteGroup(Group group)
        {
            //LearningProcessesAPI.updateTeacher();
            await AppUtils.ProcessClientLibraryRequest(async () =>
            {
                List<Group> list = (List<Group>)GroupsListView.ItemsSource;
                var result = await LearningProcessesAPI.deleteGroup(group.Id);
                list.Remove(group);
                //TeacherListView.Items.Remove(teacher);
                GroupsListView.Items.Refresh();
                totalCount.Content = GroupsListView.Items.Count;
            });

            //MessageBox.Show(result.Count + "");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Это действие приведёт к удалению, без возможности восстановления.\nПродолжить?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (MessageBoxResult.Yes == result)
            {
            deleteGroup((Group)((Button)sender).DataContext);
            }
        }

        private void addNew_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.MainFrame.Navigate(new AddGroupsView(sss));
        }

        private void search_box_TextChanged(object sender, TextChangedEventArgs e)
        {
            GroupsListView.Items.Filter = x =>
            ((Group)x).Codename.ToString().IndexOf(search_box.Text, StringComparison.OrdinalIgnoreCase) >= 0
            || ((Group)x).Speciality.Name.ToString().IndexOf(search_box.Text, StringComparison.OrdinalIgnoreCase) >= 0
            || ((Group)x).Speciality.Codename.ToString().IndexOf(search_box.Text, StringComparison.OrdinalIgnoreCase) >= 0
            || ((Group)x).Course.ToString().IndexOf(search_box.Text, StringComparison.OrdinalIgnoreCase) >= 0
            || ((Group)x).Subgroup?.ToString().IndexOf(search_box.Text, StringComparison.OrdinalIgnoreCase) >= 0;
          
        }

        private void GroupsListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(GroupsListView.SelectedItem != null)
            {
                MainWindow.Instance.MainFrame.Navigate(new GroupsView((Group)GroupsListView.SelectedItem));
            }
        }
    }
}
