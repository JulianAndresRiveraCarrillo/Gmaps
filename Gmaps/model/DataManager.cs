using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace Gmaps.model
{
    class DataManager
    {
        private DataTable table;
        public DataTable Table
        {
            get => table;
        }

        public void createTable(string filePath)
        {
            table = new DataTable();

            string[] text = System.IO.File.ReadAllLines(filePath);

            if (text.Length > 0)
            {
                string first = text[0].ToString().Replace("\""," ").Trim();

                string[] lines = Regex.Split(first, ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                foreach (string header in lines)
                {
                    table.Columns.Add(new DataColumn(header));
                }

                for (int i = 1; i < text.Length; i++)
                {
                    string[] data = Regex.Split(text[i].ToString().Replace("\"", " ").Trim(), ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    DataRow row = table.NewRow();

                    for (int j = 0; j < 11; j++)
                    {
                        try
                        {
                            row[j] = data[j];
                        }
                        catch(Exception)
                        {
                            Console.WriteLine("ERROR!");
                        }
                    }

                    table.Rows.Add(row);
                }
            }
        }

        public void filterByType(string path, string filter)//Se filtra en el atributo capital: primary, admin, minor.
        {                                                                                                       
            table.Clear();

            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {

                for (int i = 1; i < text.Length; i++)
                {

                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[8].ToString().Replace("\""," ").Trim().Equals(filter))
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j];
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }

                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }

        public void filterByRank(string path, long min, long max)//se filtra en el atributo population.
        {
            table.Clear();

            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {

                for (int i = 1; i < text.Length; i++)
                {

                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        string temp = data[9].ToString().Replace("\"", " ").Trim();
                        long aux = 0;
                        long.TryParse(temp, out aux);

                        if (aux > min && aux < max)
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j];
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }

                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }
        public void filterByWord(string path, string filter)//Se filtra en el atributo country.
        {
            table.Clear();

            string[] text = System.IO.File.ReadAllLines(path);

            if (text.Length > 1)
            {

                for (int i = 1; i < text.Length; i++)
                {

                    string[] data = Regex.Split(text[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");

                    if (data.Length > 0)
                    {
                        if (data[4].ToString().Replace("\"", " ").Trim().Equals(filter));
                        {
                            DataRow row = table.NewRow();
                            for (int j = 0; j < data.Length; j++)
                            {
                                try
                                {
                                    row[j] = data[j];
                                }
                                catch (Exception)
                                {
                                    Console.WriteLine("ERROR!");
                                }
                            }

                            table.Rows.Add(row);
                        }
                    }
                }
            }
        }
    }
}
