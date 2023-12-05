using MMABooksEFClasses;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BITS
{
    public class BarrelDB
    {
        //public static List<Barrel> GetBarrels()
        //{
        //    List<Barrel> barrels = new List<Barrel>();
        //    MySqlConnection connection = new MySqlConnection(ConfigDB.GetMySqlConnectionString());
        //    string selectStatement = "SELECT brew_container_id, treatment "
        //                           + "FROM barrel "
        //                           + "ORDER BY brew_container_id";
        //    MySqlCommand selectCommand =
        //        new MySqlCommand(selectStatement, connection);
        //    try
        //    {
        //        connection.Open();
        //        MySqlDataReader reader = selectCommand.ExecuteReader();
        //        while (reader.Read())
        //        {
        //            B s = new State();
        //            s.StateCode = reader["StateCode"].ToString();
        //            s.StateName = reader["StateName"].ToString();
        //            states.Add(s);
        //        }
        //        reader.Close();
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        connection.Close();
        //    }
        //    return states;
        //}
    }
}
