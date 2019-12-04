using System.Collections.Generic;

namespace KettlebellLib
{

    public class KettlebellKeeper
    {
        public static List<Kettlebell> kettlebells = new List<Kettlebell>();

        public static void Add(Kettlebell kettlebell)
        {
            kettlebells.Add(kettlebell);
        }
    }

    public class Kettlebell
    {
        public Kettlebell(string manufacturerName, double kg, bool rubberCover, double height, double caseDiameter, double handleDiameter)
        {
            ManufacturerName = manufacturerName;
            Kg = kg;
            Height = height;
            CaseDiameter = caseDiameter;
            HandleDiameter = handleDiameter;
            RubberCover = rubberCover;
        }



        public string ManufacturerName { get; }
        public string Color { get; }

        public bool RubberCover { get; }

        public double Kg { get; }
        public double Height { get; }
        public double CaseDiameter { get; }
        public double HandleDiameter { get; }
        public double Price
        {
            get
            {
                if (RubberCover == true)
                {
                    return Markup * (Kg + Height + CaseDiameter + HandleDiameter + 15);
                }
                else
                {
                    return Markup * (Kg + Height + CaseDiameter + HandleDiameter + 1);
                }
            }
        }

        int Markup
        {
            get
            {
                if (ManufacturerName == "Powerfull")
                {
                    return 10;
                }
                else if (ManufacturerName == "WolfKett")
                {
                    return 20;
                }
                else
                {
                    return 5;
                }
            }
        }

        public override string ToString()
        {
            return $@" ManufacturerName {ManufacturerName}, RubberCover {RubberCover}, Height {Height}, CaseDiameter {CaseDiameter}, HandleDiameter {HandleDiameter}, Kg = {Kg} Price {Price} UAH

             ───▐▀▄──────▄▀▌───▄▄▄▄▄▄▄
             ───▌▒▒▀▄▄▄▄▀▒▒▐▄▀▀▒██▒██▒▀▀▄
             ──▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄
             ──▌▒▒▒▒▒▒▒▒▒▒▒▒▒▄▒▒▒▒▒▒▒▒▒▒▒▒▒▀▄
             ▀█▒▒█▌▒▒█▒▒▐█▒▒▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌
             ▀▌▒▒▒▒▒▀▒▀▒▒▒▒▒▀▀▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▐ ▄▄
             ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄█▒█
              ▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█▀
             ──▐▄▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▄▌
             ────▀▄▄▀▀▀▀▄▄▀▀▀▀▀▀▄▄▀▀▀▀▀▀▄▄▀";
        }


        //public class KettlebellKeeper : IEnumerable
        //{
        //    Kettlebell[] kettlebells;

        //    public KettlebellKeeper(int CountIndex)
        //    {
        //        kettlebells = new Kettlebell[CountIndex];
        //    }

        //    public Kettlebell this[int index]
        //    {
        //        get
        //        {
        //            return kettlebells[index];
        //        }
        //        set
        //        {
        //            kettlebells[index] = value;
        //        }
        //    }

        //    public IEnumerator GetEnumerator()
        //    {
        //        return /*new KettlebellEnumerator(kettlebells);*/ kettlebells.GetEnumerator();
        //    }
        //}
    }
}
