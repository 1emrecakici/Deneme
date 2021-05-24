using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace Login.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnection();
    }
}
