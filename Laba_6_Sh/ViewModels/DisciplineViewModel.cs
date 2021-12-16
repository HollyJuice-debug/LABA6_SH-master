using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class DisciplineViewModel : BaseViewModel
    {
        private DataTable disciplineDataTable = new DataTable();

        public DataTable DisciplineDataTable
        {
            get { return disciplineDataTable; }
            set
            {
                disciplineDataTable = value;
                OnPropertyChanged(nameof(disciplineDataTable));
            }
        }
    }
}
