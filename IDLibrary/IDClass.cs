using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDLibrary
{
    public class IDClass
    {
        public static string UniqueId(string fam, int pol ,DateTime date , int rez , string sity )
        {
            string id="";
            Random rnd = new Random();
            string year= date.Year.ToString();
            int god = Convert.ToInt32(year);
            int id1;
            if (rez == 0)
            {
                if (date.Year>1900 && date.Year<1949 )
                {
                    id += "1";
                }
                else if (date.Year > 1950 && date.Year < 2000)
                {
                    id += "2";
                }
                else if (date.Year > 1800 && date.Year < 1849)
                {
                    id += "3";
                }
                else if (date.Year > 1850 && date.Year < 1899)
                {
                    id += "4";
                }
                else if (date.Year > 2000 && date.Year < 2049)
                {
                    id += "5";
                }
                else if (date.Year > 2050 && date.Year < 2099)
                {
                    id += "10";
                }

            }
            else
            {
                id = (rnd.Next(7, 10)).ToString();
               
            }
            
            id += (god % 100).ToString();

            if( date.Month == 01)
            {
                id += "01";
            }
            else if(date.Month== 02)
            {
                id += "02";
            }
            else if (date.Month == 03)
            {
                id += "03";
            }
            else if (date.Month == 04)
            {
               id += "04";
            }
            else if (date.Month == 05)
            {
                id += "05";
            }
            else if (date.Month == 06)
            {
                id += "06";
            }
            else if (date.Month == 07)
            {
               id += "07";
            }
            else if (date.Month == 08)
            {
                id += "08";
            }
            else if (date.Month == 09)
            {
                id += "09";
            }
            else if (date.Month == 10)
            {
              id+= "10";
            }
            else if (date.Month == 11)
            {
                id += "11";
            }
            else if (date.Month == 12)
            {
                id+= "12";
            }
            if (date.Day == 01)
            {
                id += "01";
            }
            


        }
    }
}
