using System.IO;


namespace MobLibrary1
{
    public class TxtMethods
    {
        static string writePath = @"..\..\bin\Debug\TXT.txt";

        public static string ReadTxT()
        {
            using (StreamReader sr = new StreamReader(writePath))
            {
                return sr.ReadToEnd();
            };
        }

        public static void ReadTxTtoList()
        {
            using (StreamReader sr = new StreamReader(writePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    ListCreator.Creator(line);
                }
            }
        }

        public static void WriteTxT(string str)
        {
            using (FileStream file = new FileStream(writePath, FileMode.Append))
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.Write(str);
                };
            };
        }

        public static void ReCreateTxT()
        {
            using (FileStream file = new FileStream(writePath, FileMode.Create))
            {

            };
        }
    }
}
