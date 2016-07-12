using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP.NET._1607.Day1.Task4.Suhov
{
    public static class CheckSortingType
    {
        public static string CheckType(int numb)
        {
            if (IsMono(numb))
                return "Mono";
            else
            if (IsDecrease(numb))
                return "Desreasingr";
            else
            if (IsIncrease(numb))
                return "Increasing";
            else
            if (IsIncreaseUnStr(numb))
                return "IncreaseLax";
            else
            if (IsDecreaseUnStr(numb))
                return "DesreaseLax";
            else
                return "NoSort";
        }
        private static bool IsMono(int numb)
        {
            string strnum = numb.ToString();
            for (int i = 0; i < strnum.Length - 1; i++)
            {
                if (strnum[i] != strnum[i + 1])
                    return false;
            }
            return true;
        }
        private static bool IsIncreaseUnStr(int numb)
        {
            string strnum = numb.ToString();
            for (int i = 0; i < strnum.Length - 1; i++)
            {
                if (strnum[i] <= strnum[i + 1])
                    continue;
                else
                    return false;
            }
            return true;
        }
        private static bool IsDecreaseUnStr(int numb)
        {
            string strnum = numb.ToString();
            for (int i = 0; i < strnum.Length - 1; i++)
            {
                if (strnum[i] >= strnum[i + 1])
                    continue;
                else
                    return false;
            }
            return true;
        }
        private static bool IsDecrease(int numb)
        {
            string strnum = numb.ToString();
            for (int i = 0; i < strnum.Length - 1; i++)
            {
                if (strnum[i] < strnum[i + 1] || strnum[i] == strnum[i + 1]) return false;
            }
            return true;
        }
        private static bool IsIncrease(int numb)
        {
            string strnum = numb.ToString();
            for (int i = 0; i < strnum.Length - 1; i++)
            {
                if (strnum[i] > strnum[i + 1] || strnum[i] == strnum[i + 1]) return false;
            }
            return true;
        }
    }
}
