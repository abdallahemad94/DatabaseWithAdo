using AdoEngine;
using System;
using System.Data;
using System.Windows.Forms;

namespace DatabaseWithAdo
{
    public partial class Form1 : Form
    {
        private MainData Data;
        private string TableSelected;

        public Form1()
        {
            InitializeComponent();
            PopulateTablesComboBox();
            HideFilterOptions();
        }


        /// <summary>
        /// Uses the Database schema to fill the Tables Combo Box with availabe tables in the database
        /// </summary>
        private void PopulateTablesComboBox()
        {
            TablesComboBox.Items.Add("None");
            TablesComboBox.SelectedIndex = 0;

            foreach (DataRow row in Main.GetSchema("Tables").Rows)
            {
                TablesComboBox.Items.Add(row[2]);
            }
        }

        /// <summary>
        /// Clear all shown data and leave the data grid view blank
        /// </summary>
        private void ClearDataGridView()
        {
            DataGridView.Columns.Clear();
            DataGridView.Rows.Clear();
        }

        /// <summary>
        /// Represent Data from a given source table to the user
        /// </summary>
        /// <param name="data">An instance of the DataTable class to project its data to the user</param>
        private void UpdateDataGridView(DataTable data)
        {
            ClearDataGridView();
            foreach (DataColumn col in data.Columns)
            {
                DataGridView.Columns.Add(col.ColumnName, col.ColumnName);
            }

            foreach (DataRow row in data.Rows)
            {
                DataGridView.Rows.Add(row.ItemArray);
            }
        }

        /// <summary>
        /// Show Available Filter options for a given data table
        /// </summary>
        private void ShowFilterOptions()
        {
            ClearDataGridView();
            FilterByLabel.Visible = true;
            FilterByComboBox.Visible = true;
            FilterByComboBox.SelectedIndex = 0;
            ViewButton.Text = "View All Data";
            ViewButton.Visible = true;
            FilterIDBox.Text = "";
        }

        /// <summary>
        /// Hide all filter options
        /// </summary>
        private void HideFilterOptions()
        {
            ClearDataGridView();
            FilterByLabel.Visible = false;
            FilterByComboBox.Visible = false;
            ViewButton.Visible = false;
            FilterIDLabel.Visible = false;
            FilterIDBox.Visible = false;
        }

        /// <summary>
        /// Show the available options for a selected filter 
        /// </summary>
        /// <param name="filter">the filter to be used</param>
        private void SelectFilter(string filter)
        {
            FilterIDLabel.Text = string.Format("{0}:", filter);
            FilterIDLabel.Visible = true;
            FilterIDBox.Visible = true;
            FilterIDBox.Text = "";
            ViewButton.Visible = true;
            ViewButton.Text = "Filter Data";
            ClearDataGridView();
        }

        /// <summary>
        /// Hide all the available options for all filters
        /// </summary>
        private void UnSelectFilter()
        {
            FilterIDLabel.Visible = false;
            FilterIDBox.Visible = false;
            FilterIDBox.Text = "";
            ViewButton.Visible = true;
            ViewButton.Text = "View All Data";
            ClearDataGridView();
        }

        /// <summary>
        /// Show the main options for inserting data to a table
        /// </summary>
        public void ShowMainInsertOptions()
        {
            InsertIDLabel.Visible = true;
            InsertNamelabel.Visible = true;
            InsertIDBox.Visible = true;
            InsertNameBox.Visible = true;
            InsertButton.Visible = true;
            DeleteIDBox.Visible = true;
            DeleteIDLable.Visible = true;
            DeleteButton.Visible = true;
        }

        /// <summary>
        /// Show options for inserting data in the students table
        /// </summary>
        public void StudentInsertOptions()
        {
            InsertIDLabel.Text = "Student ID:";
            DeleteIDLable.Text = "Student ID:";
            InsertNamelabel.Text = "Student Name:";
            HideCourseInsertOptions();
        }

        /// <summary>
        /// show options for inserting data in the instructors table
        /// </summary>
        public void InstructorInsertOptions()
        {
            InsertIDLabel.Text = "Instructor ID:";
            DeleteIDLable.Text = "Instructor ID:";
            InsertNamelabel.Text = "Instructor Name:";
            HideCourseInsertOptions();
        }

        /// <summary>
        /// show options for inserting data in the enrollments table
        /// </summary>
        public void EnrollmentsInsertOptions()
        {
            InsertIDLabel.Text = "Course ID:";
            InsertNamelabel.Text = "student ID:";
            DeleteIDLable.Text = "Student ID:";
            HideCourseInsertOptions();
        }

        /// <summary>
        /// show options for inserting data in the courses table
        /// </summary>
        public void ShowCourseInsertOptions()
        {
            InsertIDLabel.Text = "Course ID:";
            InsertNamelabel.Text = "Course Name:";
            InsertCourseDescLabel.Visible = true;
            InsertCourseInstLabel.Visible = true;
            InsertCourseDescBox.Visible = true;
            InsertCourseInstBox.Visible = true;
            InsertButton.Location = new System.Drawing.Point(228, 235);
        }

        /// <summary>
        /// hide options for inserting data to the courses table
        /// </summary>
        public void HideCourseInsertOptions()
        {
            InsertCourseDescLabel.Visible = false;
            InsertCourseInstLabel.Visible = false;
            InsertCourseDescBox.Visible = false;
            InsertCourseInstBox.Visible = false;
            InsertButton.Location = new System.Drawing.Point(228, 183);
        }

        /// <summary>
        /// hide all options for inserting data in a table
        /// </summary>
        public void HideInsertOptions()
        {
            InsertIDLabel.Visible = false;
            InsertNamelabel.Visible = false;
            InsertCourseDescLabel.Visible = false;
            InsertCourseInstLabel.Visible = false;
            InsertIDBox.Visible = false;
            InsertNameBox.Visible = false;
            InsertCourseDescBox.Visible = false;
            InsertCourseInstBox.Visible = false;
            InsertButton.Visible = false;
            DeleteIDBox.Visible = false;
            DeleteIDLable.Visible = false;
            DeleteButton.Visible = false;
        }

        /// <summary>
        /// returns true if the givin id is integer false otherwise
        /// </summary>
        /// <returns>Bool</returns>
        private bool CheckID(TextBox box)
        {
            if (FilterIDBox.Text != "")
            {
                try
                {
                    int ID = Convert.ToInt32(box.Text);
                    return true;
                }
                catch (Exception ex)
                {
                    ValueError.SetError(box, ex.ToString());
                    return false;
                }
            }
            else
            {
                ValueError.SetError(box, "ID Value is empty");
                return false;
            }
        }

        /// <summary>
        /// filter a specifc Data where the given ID is true
        /// </summary>
        /// <param name="Id">The ID used to filter the data</param>
        /// <returns>filtered Datatable</returns>
        private DataTable GetDataTable(int Id)
        {
            string SelectedFilter = FilterByComboBox.SelectedItem.ToString();
            switch (SelectedFilter)
            {
                case "Student":
                    return Data.GetByStudentID(Id);

                case "Course":
                    return Data.GetByCourseID(Id);

                case "Instructor":
                    return Data.GetByInstructorID(Id);

                default:
                    return null;
            }
        }

        /// <summary>
        /// insert given data to a selected table
        /// </summary>
        private void InsertData()
        {
            string table = TablesComboBox.SelectedItem.ToString();
            if (CheckID(InsertIDBox))
            {
                ValueError.Clear();
                switch (table)
                {
                    case "Students":
                        int stdid = Convert.ToInt32(InsertIDBox.Text.ToString());
                        string stdname = InsertNameBox.Text.ToString();
                        Data.AddItem(stdid, stdname);
                        break;

                    case "Courses":
                        int courseid = Convert.ToInt32(InsertIDBox.Text.ToString());
                        string coursename = InsertNameBox.Text.ToString();
                        string coursedesc = InsertCourseDescBox.Text.ToString();
                        int courseinst = Convert.ToInt32(InsertCourseInstBox.Text.ToString());
                        Data.AddItem(courseid, coursename, coursedesc, courseinst);
                        break;

                    case "Instructors":
                        int instid = Convert.ToInt32(InsertIDBox.Text.ToString());
                        string instname = InsertNameBox.Text.ToString();
                        Data.AddItem(instid, instname);
                        break;

                    case "Enrollments":
                        int courseEnroll = Convert.ToInt32(InsertIDBox.Text.ToString());
                        int stdEnroll = Convert.ToInt32(InsertNameBox.Text.ToString());
                        Data.AddItem(courseEnroll, stdEnroll);
                        break;
                }
            }
        }

        /// <summary>
        /// delete given data from a selected table
        /// </summary>
        public void DeleteData()
        {
            string table = TablesComboBox.SelectedItem.ToString();
            if (CheckID(DeleteIDBox))
            {
                ValueError.Clear();
                switch (table)
                {
                    case "Students":
                        int stdid = Convert.ToInt32(DeleteIDBox.Text.ToString());
                        Data.RemoveItem(stdid);
                        break;

                    case "Courses":
                        int courseid = Convert.ToInt32(DeleteIDBox.Text.ToString());
                        Data.RemoveItem(courseid);
                        break;

                    case "Instructors":
                        int instid = Convert.ToInt32(DeleteIDBox.Text.ToString());
                        Data.RemoveItem(instid);
                        break;

                    case "Enrollments":
                        int stdEnroll = Convert.ToInt32(DeleteIDBox.Text.ToString());
                        Data.RemoveItem(stdEnroll);
                        break;
                }
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            InsertData();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteData();
        }

        private void ComboBoxTableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TableSelected = TablesComboBox.SelectedItem.ToString();
            switch (TableSelected)
            {
                case "None":
                    Data = null;
                    HideFilterOptions();
                    HideInsertOptions();
                    break;

                case "Students":
                    Data = new Students();
                    ShowFilterOptions();
                    StudentInsertOptions();
                    ShowMainInsertOptions();
                    break;

                case "Courses":
                    Data = new Courses();
                    ShowFilterOptions();
                    ShowCourseInsertOptions();
                    break;

                case "Instructors":
                    Data = new Instructors();
                    ShowFilterOptions();
                    InstructorInsertOptions();
                    ShowMainInsertOptions();
                    break;

                case "Enrollments":
                    Data = new Enrollments();
                    ShowFilterOptions();
                    EnrollmentsInsertOptions();
                    ShowMainInsertOptions();
                    break;
            }
        }

        private void FilterByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterBy = FilterByComboBox.SelectedItem.ToString();
            switch (FilterBy)
            {
                case "None":
                    UnSelectFilter();
                    break;

                case "Student":
                    SelectFilter("StdID");
                    break;

                case "Course":
                    SelectFilter("CourseID");
                    break;

                case "Instructor":
                    SelectFilter("InstID");
                    break;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ClearDataGridView();

            if (FilterByComboBox.SelectedItem.ToString() == "None")
            {
                UpdateDataGridView(Data.GetAll());
            }

            else if (CheckID(FilterIDBox))
            {
                ValueError.Clear();
                int id = Convert.ToInt32(FilterIDBox.Text);
                DataTable dataTable = GetDataTable(id);
                UpdateDataGridView(dataTable);
            }
        }
    }
}