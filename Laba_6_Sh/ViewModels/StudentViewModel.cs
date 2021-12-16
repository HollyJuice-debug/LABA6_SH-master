using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class StudentViewModel:BaseViewModel
    {
        private DataTable studentDataTable = new DataTable();

        public DataTable StudentDataTable
        {
            get { return studentDataTable; }
            set
            {
                studentDataTable = value;
                OnPropertyChanged(nameof(studentDataTable));
            }
        }
    }
}
