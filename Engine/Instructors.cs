using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AdoEngine
{
    public class Instructors : MainData
    {
        public override DataTable GetAll()
        {
            return GetDataTable(GetCommand("Instructors_getAll"));
        }

        public override DataTable GetByStudentID(int stdID)
        {
            SqlCommand Command = GetCommand("Instructors_getByStudent");
            string[] ParamsName = { "@stdID" };
            ArrayList ParamsValue = new ArrayList() { stdID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByCourseID(int CourseID)
        {
            SqlCommand Command = GetCommand("Instructors_getByCourse");
            string[] ParamsName = { "@CourseID" };
            ArrayList ParamsValue = new ArrayList() { CourseID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override DataTable GetByInstructorID(int InstID)
        {
            SqlCommand Command = GetCommand("Instructors_getByID");
            string[] ParamsName = { "@InstID" };
            ArrayList ParamsValue = new ArrayList() { InstID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            return GetDataTable(Command);
        }

        public override void AddItem(int InstID, string InstName)
        {
            SqlCommand Command = GetCommand("Instrucors_addInstructor");
            string[] ParamsName = { "@InstID",  "@InstName"};
            ArrayList ParamsValue = new ArrayList() { InstID, InstName };

            Command = AddParameters(Command, 2, ParamsName, ParamsValue);

            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }

        public override void RemoveItem(int InstID)
        {
            SqlCommand Command = GetCommand("Instructors_removeByID");
            string[] ParamsName = { "@InstID" };
            ArrayList ParamsValue = new ArrayList() { InstID };

            Command = AddParameters(Command, 1, ParamsName, ParamsValue);

            Command.Connection.Open();
            Command.ExecuteNonQuery();
            Command.Connection.Close();
        }
    }
}
