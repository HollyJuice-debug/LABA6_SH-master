using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_6_Sh.ViewModels
{
    public class GrpViewModel : BaseViewModel
    {
        private DataTable grpDataTable = new DataTable();

        public DataTable GrpDataTable
        {
            get { return grpDataTable; }
            set
            {
                grpDataTable = value;
                OnPropertyChanged(nameof(grpDataTable));
            }
        }
    }
}
