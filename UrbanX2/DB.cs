using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


public class DB
{
    DataSet ds;
    public DB()
    {
        ds = new DataSet();
    }
    /// <summary>
    ///  this will Return only one column and one row
    /// </summary>
   
    /// <returns></returns>
    public string QueryScalar(string Query)
    {
        string str;
        MySqlConnection mySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["ConString"].ToString());
        MySqlCommand mySqlCommand = new MySqlCommand(Query, mySqlConnection);
        mySqlConnection.Open();
        try
        {
            try
            {
                str = mySqlCommand.ExecuteScalar().ToString();
            }
            finally
            {
                mySqlCommand.Dispose();
                mySqlConnection.Close();
                mySqlConnection.Dispose();
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return str;
    }

}



