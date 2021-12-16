using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class TeacherViewModel: BaseViewModel
    {
        private DataTable teacherDataTable = new DataTable();

        public DataTable TeacherDataTable
        {
            get { return teacherDataTable; }
            set
            {
                teacherDataTable = value;
                OnPropertyChanged(nameof(teacherDataTable));
            }
        }
    }
}
