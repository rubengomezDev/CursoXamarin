using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLitePCL;

namespace AppPractica1Contacto.Model
{
    public class Database
    {
        readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Contacto>().Wait();

        }

        public Task<int> SavePerson(Contacto contacto)
        {
            return _database.InsertAsync(contacto);

        }

        public Task<List<Contacto>> GetPeopleAsync()
        {
            return _database.Table<Contacto>().ToListAsync();

        }
    }
}
