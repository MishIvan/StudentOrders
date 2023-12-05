using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace Graduates
{
    internal class DBHelper : IDisposable
    {
        private string m_errorMessage; // сообщение об ошибке
        private OleDbConnection m_connection; // объект соединения
        public string errorMessage { get {return m_errorMessage;} }
        public DBHelper()
        {
            m_errorMessage = string.Empty;
            m_connection = new OleDbConnection(AppSettings.Default.ConnectionString);
            try
            {
                m_connection.Open();
            }
            catch(Exception ex)
            {
                m_errorMessage = ex.Message;
            }
            
        }
        public bool isOpen() { return m_connection.State == System.Data.ConnectionState.Open; }
        public void Dispose() 
        {
            if (isOpen()) m_connection.Close();
        }
    }
}
