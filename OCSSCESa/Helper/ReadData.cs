using System;
using System.Data;
using System.Threading.Tasks;

namespace OCSSCESa.Helper
{
    public sealed class ReadData
    {
        private static readonly Lazy<ReadData> _instance = new Lazy<ReadData>(() => new ReadData());

        private DataTable _studentData = new DataTable();
        private CRUD _crud = new CRUD();
        private bool _isInitialized = false;

        public event EventHandler DataLoading;
        public event EventHandler DataLoaded;


        private ReadData() { }

        public static ReadData Instance => _instance.Value;

        public async Task InitializeAsync()
        {
            if (!_isInitialized)
            {
                await LoadStudentData();
                _isInitialized = true;
            }
        }


        private async Task LoadStudentData()
        {
            try
            {
                DataLoading?.Invoke(this, EventArgs.Empty);

                string query = "SELECT studentId, fName, mName, lName, suffix, birthdate, age, gender, " +
                              "civilStatus, address, contactNumber, yearLevel FROM studentInfoTbl";

                DataTable students = await Task.Run(() => _crud.ReadData(query, false));
                _studentData = students ?? null;

                DataLoaded?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during database operation: " + ex.Message);
                _studentData = null;
            }
        }

        

        public DataTable StudentData
        {
            get
            {
                if (!_isInitialized)
                {
                    throw new InvalidOperationException("ReadData has not been initialized. Call InitializeAsync first.");
                }
                return _studentData;
            }
        }

        public async Task RefreshData()
        {
            await LoadStudentData();
        }
    }
}