using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gmaps.model
{
    class GraphManager
    {
        List<City> info;

        public GraphManager()
        {
            info = new List<City>();
        }

        public List<City> Info
        {
            get => info;
        }

        public void GenerateGraph(string path)
        {

            string[] lines = System.IO.File.ReadAllLines(path);
            if (lines.Length > 0)
            {

                for (int i = 1; i < 50 ; i++)
                {
                    //This will ignore commas between double quotes in the CSV file
                    string[] dataLine = Regex.Split(lines[i], ",(?=(?:[^\"]*\"[^\"]*\")*[^\"]*$)");


                    for (int j = 0; j < dataLine.Length; j++)
                    {
                        if (info.Count == 0)
                        {
                            info.Add(new City(dataLine[0],1));
                        }
                        else
                        {
                            bool found = false;

                            for (int k = 0; k < info.Count && !found; k++)
                            {
                                if (info[k].Name == dataLine[0])
                                {
                                    info[k].Population++;
                                    found = true;
                                }
                            }

                            if (!found)
                            {
                                info.Add(new City(dataLine[0],1));
                            }

                        }

                    }
                }

            }

        }

    }
}
