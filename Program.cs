using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace peloton
{
    class Program
    {
        static void Main(string[] args)
        {
            var filename = "in.txt";
            try
            {

                filename = ProcessInput(args);

                string line;
                int counter = 0;
                var corredors = new List<String>();
                var first = true;

                System.IO.StreamReader file = new System.IO.StreamReader(@filename);
                while ((line = file.ReadLine()) != null)
                {
                    if (counter == 0)
                    {
                        if (!int.TryParse(line, out counter))
                        {
                            throw new PelotonException("Malformed file");
                        }
                    }
                    else
                    {
                        corredors.Add(line);
                        counter--;
                        if (counter == 0)
                        {
                            if (first==false) Console.WriteLine("--");
                            first = false;

                            corredors = ProcessCarrera(corredors);
                            corredors.ForEach(Console.WriteLine);
                            corredors = new List<String>();
                        }
                    }
                }
                file.Close();
            }
            catch (FileNotFoundException _)
            {
                Console.WriteLine($"Inexistent file {filename}");
            }
            catch (PelotonException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static string ProcessInput(string[] args)
        {
            var filename = "in.txt";

            if (args.Length > 1)
            {
                throw new PelotonException("Please enter only ONE filename as parameter");
            }

            if (args.Length == 1)
            {
                filename = args[0];
            }

            return filename;
        }

        static List<String> ProcessCarrera(List<String> corredors)
        {
            var ordenats = new List<String>();
            corredors.ForEach(ordenats.Add);

            // ordenats = ordenats.Distinct().ToList();
            // ordenats.Sort();

            ordenats = (from ord in ordenats
                        orderby ord ascending
                        select ord).Distinct().ToList();

            int posicio = 1;
            int quants = 0;

            var actual = DateTime.Parse(ordenats[0], System.Globalization.CultureInfo.CurrentCulture);

            foreach (var ordenat in ordenats)
            {
                var data = DateTime.Parse(ordenat, System.Globalization.CultureInfo.CurrentCulture);
                if (data > actual.AddSeconds(1.0))
                {
                    posicio += quants;
                    quants = 0;
                }

                corredors = corredors.Select(
                    c =>
                    {
                        if (c == ordenat)
                        {
                            quants++;
                            return posicio.ToString();
                        }
                        return c;
                    }).ToList();

                actual = data;

            }

            return corredors;
        }
    }
}
