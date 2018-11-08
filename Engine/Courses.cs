using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;


namespace AdoEngine
{
    public class Courses : MainData
    {
        public override DataTable GetAll()
        {
            return GetDataTable(GetCommand("Courses_getAll"));
        }

        public override DataTable GetByStudentID(int stdID)
        {
            SqlCommand Command = GetCommand("Courses_getByStudent");
            string[] ParamsName = { "@stdID" };
            ArrayList ParamsValue = new ArrayList() { stdID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByCourseID(int CourseID)
        {
            SqlCommand Command = GetCommand("Courses_getByID");
            string[] ParamsName = { "@CourseID" };
            ArrayList ParamsValue = new ArrayList() { CourseID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByInstructorID(int InstID)
        {
            SqlCommand Command = GetCommand("Courses_getByIntructor");
            string[] ParamsName = { "@InstID" };
            ArrayList ParamsValue = new ArrayList() { InstID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override  void AddItem(int CourseID, string CourseName, string CourseDesc, int InstID)
        {
            SqlCommand Command = GetCommand("Courses_addCourse");
            string[] ParamsName = { "@CourseID",  "@CourseName", "@CourseDesc", "@InstID"};
            ArrayList ParamsValue = new ArrayList() { CourseID, CourseName, CourseDesc, InstID };

            Command = AddParameters(Command, 4, ParamsName, ParamsValue);

            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }

        public override void RemoveItem(int CourseID)
        {
            SqlCommand Command = GetCommand("Courses_removeByCourseID");
            string[] ParamsName = { "@CourseID" };
            ArrayList ParamsValue = new ArrayList() { CourseID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);


            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }

        public void RemoveItemByInstructorID(int InstID)
        {
            SqlCommand Command = GetCommand("Courses_removeByInstructorID");
            string[] ParamsName = { "@InstID" };
            ArrayList ParamsValue = new ArrayList() { InstID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }
    }
}
