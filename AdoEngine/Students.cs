using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AdoEngine
{
    public class Students : MainData
    {
        public override DataTable GetAll()
        {
            return GetDataTable(GetCommand("Students_getAll"));
        }

        public override DataTable GetByStudentID(int stdID)
        {
            SqlCommand Command = GetCommand("Students_getByID");
            string[] ParamsName = { "@stdID" };
            ArrayList ParamsValue = new ArrayList() { stdID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByCourseID(int CourseID)
        {
            SqlCommand Command = GetCommand("Students_getByCourse");
            string[] ParamsName = { "@CourseID" };
            ArrayList ParamsValue = new ArrayList() { CourseID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByInstructorID(int InstID)
        {
            SqlCommand Command = GetCommand("Students_getByInstructor");
            string[] ParamsName = { "@InstID" };
            ArrayList ParamsValue = new ArrayList() { InstID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override void AddItem(int stdID, string stdName)
        {
            SqlCommand Command = GetCommand("Students_addStudent");
            string[] ParamsName = { "@stdID", "@stdName" };
            ArrayList ParamsValue = new ArrayList() { stdID, stdName };

            Command = AddParameters(Command, 2, ParamsName, ParamsValue);
            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }

        public override void RemoveItem(int stdID)
        {
            SqlCommand Command = GetCommand("Students_removeByID");
            string[] ParamsName = { "@stdID" };
            ArrayList ParamsValue =new ArrayList() { stdID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }
    }
}
