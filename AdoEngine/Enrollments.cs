using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AdoEngine
{
    public class Enrollments : MainData
    {
        public override DataTable GetAll()
        {
            return GetDataTable(GetCommand("Enrollments_GetAll"));
        }

        public override DataTable GetByStudentID(int stdID)
        {
            SqlCommand Command = GetCommand("Enrollments_GetByStudent");
            string[] ParamsName = { "@stdID" };
            ArrayList ParamsValue = new ArrayList() { stdID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByCourseID(int CourseID)
        {
            SqlCommand Command = GetCommand("Enrollments_GetByCourse");
            string[] ParamsName = { "@CourseID" };
            ArrayList ParamsValue = new ArrayList() { CourseID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByInstructorID(int InstID)
        {
            SqlCommand Command = GetCommand("Enrollments_GetByInstructor");
            string[] ParamsName = { "@InstID" };
            ArrayList ParamsValue = new ArrayList() { InstID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override void AddItem(int CourseID, int stdID)
        {
            SqlCommand Command = GetCommand("Enrollments_addEnrollment");
            string[] ParamsName = { "@CourseID", "@stdID" };
            ArrayList ParamsValue = new ArrayList() { CourseID, stdID };

            Command = AddParameters(Command, 2, ParamsName, ParamsValue);

            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }

        public override void RemoveItem(int stdID)
        {
            SqlCommand Command = GetCommand("Enrollments_removeByStudentID");
            string[] ParamsName = { "@stdID" };
            ArrayList ParamsValue = new ArrayList() { stdID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }
    }
}
