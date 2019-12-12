using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise1 : IExercise1
    {
        public object Method1()
        {
            return new CellPrinter();
        }

    }

    public class CellPrinter : ICellPrinter
    {
        public string PrintPostion(int x, int y)
        {
            string sumstring = string.Empty;

            sumstring = "Cell is on Position X:" + x + " Y:" + y;

            return sumstring;
        }

        public string PrintState(bool alive, DateTime date, string color)
        {
            string sumstring = string.Empty;
            if (alive)
            {
                sumstring = "Cell" + color + "born on" + "date" + "is alive";
            }
            else
            {
                sumstring = "Cell" + color + "born on" + "date" + "is not alive";
            }

            return sumstring;
        }
    }
}
