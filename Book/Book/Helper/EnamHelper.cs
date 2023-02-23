using libary.Enums;
using System;

namespace libary.Helper
{
    public static class EnamHelper


    {
        public static T ReadEnum <T>(string caption)
            where T : Enum
        {
            
            foreach (var item in Enum.GetValues(typeof(T)))
            {
                //int id = Convert.ToInt32(item);
                Type uType = Enum.GetUnderlyingType(typeof(T));

                var id=Convert.ChangeType( item,uType);

                Console.WriteLine($"{id.ToString().PadLeft(2, ' ')}.{item}");
            }
            string income;
        L1:
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(caption);
            Console.ForegroundColor = oldColor;

            income = Console.ReadLine();

            if (!Enum.TryParse(typeof(T), income, out object value) || !Enum.IsDefined(typeof(T), value))
            {
                goto L1;
            }

            return (T)value;


        }
    }
}
