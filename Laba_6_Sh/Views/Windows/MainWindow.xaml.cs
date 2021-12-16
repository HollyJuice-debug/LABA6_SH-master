using FirebirdSql.Data.FirebirdClient;
using Laba_6_Sh.ViewModels;
using System;
using System.Configuration;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Laba_6_Sh
{
    public partial class MainWindow : Window
    {
        private FbConnection connection;
        private MainViewModel mainViewModel;

        private Views.Pages.Grp grpPage;
        private Views.Pages.Teacher teacherPage;
        private Views.Pages.Discipline disciplinePage;
        private Views.Pages.Student studentPage;

        public MainWindow()
        {
            InitializeComponent();
            connection = new FbConnection(ConfigurationManager.ConnectionStrings["HFDB"].ConnectionString);
            mainViewModel = new MainViewModel();

            grpPage = new Views.Pages.Grp();
            teacherPage = new Views.Pages.Teacher();
            disciplinePage = new Views.Pages.Discipline();
            studentPage = new Views.Pages.Student();

            mainViewModel.FrameCurrentPage = disciplinePage;
            DataContext = mainViewModel;
            PageComboBox.SelectedIndex = 0;
            FillDataGrid();
        }

        public async Task<MainWindow> Create()
        {
            await connection.OpenAsync();
            return this;
        }

        private async void FillDataGrid()
        {
            grpPage.grpViewModel.GrpDataTable = await grpPage.grpDataBaseService.GetAllDataTable(connection, "Grp");
            teacherPage.teacherViewModel.TeacherDataTable = await teacherPage.teacherDataBaseService.GetAllDataTable(connection, "Teacher");
            disciplinePage.disciplineViewModel.DisciplineDataTable = await disciplinePage.disciplineDataBaseService.GetAllDataTable(connection, "Discipline");
            studentPage.studentViewModel.StudentDataTable = await studentPage.studentDataBaseService.GetAllDataTable(connection, "Student");
        }

        private async void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                await grpPage.grpDataBaseService.UpdateBD(grpPage.grpViewModel.GrpDataTable);
                await teacherPage.teacherDataBaseService.UpdateBD(teacherPage.teacherViewModel.TeacherDataTable);
                await disciplinePage.disciplineDataBaseService.UpdateBD(disciplinePage.disciplineViewModel.DisciplineDataTable);
                await studentPage.studentDataBaseService.UpdateBD(studentPage.studentViewModel.StudentDataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;


            switch (selectedItem.Content.ToString())
            {
                case "Группа":
                    mainViewModel.FrameCurrentPage = grpPage;
                    break;
                case "Студент":
                    mainViewModel.FrameCurrentPage = studentPage;
                    break;
                case "Преподаватель":
                    mainViewModel.FrameCurrentPage = teacherPage;
                    break;
                case "Дисциплина":
                    mainViewModel.FrameCurrentPage = disciplinePage;
                    break;
            }
        }

    }
}
