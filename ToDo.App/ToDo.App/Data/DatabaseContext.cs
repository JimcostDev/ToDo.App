using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.App.Models;

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
        //Saving an item
        public async Task<int> InsertItemAsync(ToDoItem item)
        {
            return await Connection.InsertAsync(item);
        }
        //return ListView
        public async Task<List<ToDoItem>> GetItemsAsync()
        {
            return await Connection.Table<ToDoItem>().ToListAsync();
        }
    }
}
