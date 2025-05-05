using System.Data;

namespace OCSSCESa
{


    partial class DSStudents
    {
        partial class ResultDataTable
        {
        }

        partial class StudentCodeInfoDataTable
        {
        }

        private DataTable votersData;

        public DSStudents(string dataSetName, DataTable votersData) : base(dataSetName)
        {
            this.votersData = votersData;
        }

        partial class StudentInfoTblDataTable
        {
        }
    }

}
