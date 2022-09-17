using Core.Entities;
using Core.Models;
using Infrastructure.Data;
using Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;

namespace MovieShop.Controllers
{
    public class DatabaseController : Controller
    {

        private readonly List<string> tables;
        private readonly MVCDbContext cont;
        private DatabaseModel model;

        public DatabaseController(MVCDbContext cont)
        {
            this.cont = cont;
            
            Console.WriteLine("Contructor");
        }

        [Route("Database")]
        public IActionResult Index(string dbname)
        {
            model = new DatabaseModel();
            model.columns = new List<string>();
            model.rows = new List<List<string>>();

            if (dbname != null)
                model.dbname = dbname;
            else
                model.dbname = "None";

            InitTables();
            if (dbname != null) InitValues();
            return View(model);
        }

        private void InitTables()
        {
            SqlConnection con = new SqlConnection(MVCDbContext.MvcConnectionString);
            con.Open();
            DataTable dt = con.GetSchema("Tables");
            List<string> tables = new List<string>();
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[2];
                tables.Add(tablename);
            }
            model.tables = tables;
            con.Close();
        }

        private async void InitValues()
        {
            BaseRepositoryAsync<Movie> b = new BaseRepositoryAsync<Movie>(cont);
            IEnumerable<Movie> l = await b.GetAllAsync();
            List<List<string>> rows = new List<List<string>>();

            foreach (Movie m in l)
            {
                List<string> row = new List<string>();
                PropertyInfo[] pi = m.GetType().GetProperties();
                foreach (PropertyInfo p in pi)
                {
                    row.Add(p.GetValue(m).ToString());
                }
                rows.Add(row);
            }

            List<string> ColumnNames = new List<string>();
            PropertyInfo[] info = typeof(Movie).GetProperties();
            for (int i = 0; i < info.Length; i++)
                ColumnNames.Add(info[i].Name);

            model.columns = ColumnNames;
            model.rows = rows;
        }
    }
}
