using System;
using SQLite;

namespace VoiCoffee.Model
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
