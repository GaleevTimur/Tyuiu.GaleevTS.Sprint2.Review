using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.GaleevTS.Sprint2.TaskReview.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            bool res;
            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1) 
            {
                if (y <= x / 2)
                {
                    res = true;
                }
                else
                {
                    res = false;
                }
                
            }
            else
            {
                res = false;
            }
            return res;
        }
    }
}
