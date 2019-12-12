using System;
using BID.SWE1.Exam.Impl;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new MyMap();
        }

        public object Method2()
        {
            throw new NotImplementedException();
        }

    }

    public class MyMap : Map
    {
        public override int AddNewCells(int year)
        {
            return year;
        }

        public override string GetMapName()
        {
            string mapname = "BID-Map";
            return mapname;
        }

        public override float GetMapSize(float amount)
        {
            float result;
            result = amount * amount;
            return result;
        }
    }
}