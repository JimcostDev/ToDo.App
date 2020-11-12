using System;
using System.Collections.Generic;
using System.Text;

namespace ToDo.App.Data
{
    public class DatabaseContext
    {
        private readonly SQLiteAsyncConnection Connection;

        public DatabaseContext(string dbPath)
        {
            Connection = new SQLiteAsyncConnection(dbPath);

            Connection.CreateTableAsync<ToDoItem>().Wait();
        }
    }
}
