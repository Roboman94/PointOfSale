using System.Collections.Generic;
using System.IO;

namespace PointOfSaleMidTerm
{
    #region MAIN
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = LoadProductDb();
            POSController pc = new POSController(products);
            pc.RunApp();
        }
        //public static void WriteMC(List<MovieCharacter> characters, string filename, char separator)
        //{
        //    StreamWriter writer = new StreamWriter(filename);
        //    foreach (MovieCharacter actor in characters)
        //    {
        //        writer.WriteLine($"{actor.name}{separator}{actor.good}{separator}{actor.role}{separator}{actor.age}{separator}{actor.salary}");
        //    }
        //    writer.Close();
        //}
        #endregion
        public static List<Product> LoadProductDb()
        {
            string pdbFilename = "../../../ProductData.txt";
            char separator = '|';

            List<Product> products = new List<Product>();
            StreamReader reader = new StreamReader(pdbFilename);
            string line = reader.ReadLine();
            while (line != null)
            {
                string[] prod = line.Split(separator);
                Product m = new Product(
                    prod[0]
                    , prod[1]
                    , prod[2]
                    , double.Parse(prod[3])
                    , double.Parse(prod[4])
                    );
                products.Add(m);
                line = reader.ReadLine();
            }
            reader.Close();
            return products;
        }
    }

}