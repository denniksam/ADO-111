using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Sales.Logging
{
    internal class DbLogger : ILogger
    {
        private readonly SqlConnection _connection;
        public DbLogger(String connectionString) 
        {
            _connection = new(connectionString);
            _connection.Open(); 
        }
        public void Log(string message)
        {
            this.Log(message, LogLevel.Debug);
        }

        public void Log(string message, LogLevel level)
        {
            this.Log(message, level, "", "");
        }

        public void Log(string message, LogLevel level, string className, string methodName)
        {
            this.Log(message, level, className, methodName, null);
        }

        public void Log(string message, LogLevel level, string className, string methodName, object? info)
        {
            String sql = "INSERT INTO Logs([logDT],[message],[level],[className],[methodName],[info]) " +
                "VALUES(CURRENT_TIMESTAMP, @message, @level, @className, @methodName, @info)";
            using SqlCommand cmd = new(sql, _connection);
            cmd.Parameters.AddWithValue("@message", message);
            cmd.Parameters.AddWithValue("@level", level.ToString().ToUpper()[0]);
            cmd.Parameters.AddWithValue("@className", className=="" ? DBNull.Value : className);
            cmd.Parameters.AddWithValue("@methodName", methodName == "" ? DBNull.Value : methodName);
            cmd.Parameters.AddWithValue("@info", info is null ? DBNull.Value : info);
            try { cmd.ExecuteNonQuery(); }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
