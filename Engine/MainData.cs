using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;

namespace AdoEngine
{
    public abstract class MainData
    {
        /// <summary>
        /// create a sql command object for a given procedure
        /// </summary>
        /// <param name="procedure"></param>
        /// <returns></returns>
        protected SqlCommand GetCommand(string procedure)
        {
            SqlConnection Conn = new SqlConnection("data source =.; database=School; integrated security=SSPI");
            SqlCommand Command = new SqlCommand(procedure, Conn) { CommandType = CommandType.StoredProcedure };
            return Command;
        }

        /// <summary>
        /// add a sql parameter to a given command object
        /// </summary>
        /// <param name="Command"></param>
        /// <param name="NoOfParams"></param>
        /// <param name="ParamsName"></param>
        /// <param name="ParamsValue"></param>
        /// <returns></returns>
        protected SqlCommand AddParameters(SqlCommand Command, int NoOfParams, string[] ParamsName, ArrayList ParamsValue)
        {
            SqlParameter param = null;
            for (int i = 0; i < NoOfParams; i++)
            {
                param = new SqlParameter(ParamsName[i], ParamsValue[i]) { Direction = ParameterDirection.Input };
                Command.Parameters.Add(param);
            }
            return Command;
        }

        /// <summary>
        /// return the result of executing a given command as a DataTable object
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        protected DataTable GetDataTable(SqlCommand command)
        {
            command.Connection.Open();
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable datatable = new DataTable();
            datatable.Load(dataReader);
            command.Connection.Close();
            return datatable;
        }

        public virtual DataTable GetAll() { return new DataTable(); }
        public virtual DataTable GetByStudentID(int stdID) { throw new NotImplementedException(); }
        public virtual DataTable GetByCourseID(int CourseID) { throw new NotImplementedException(); }
        public virtual DataTable GetByInstructorID(int InstID) { throw new NotImplementedException(); }
        public virtual void AddItem(int id, string name) { throw new NotImplementedException(); }
        public virtual void AddItem(int id1, int id2) { throw new NotImplementedException(); }
        public virtual void AddItem(int id1, string name, string desc, int id2) { throw new NotImplementedException(); }
        public virtual void RemoveItem(int id) { throw new NotImplementedException(); }
    }
}
