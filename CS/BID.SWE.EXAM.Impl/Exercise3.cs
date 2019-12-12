using System;
using BID.SWE1.Exam.Impl;
using BID.SWE1.Exam.Interfaces;
using static BID.SWE.EXAM.Impl.Bewegung;

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
            Bewegung[] myArray = new Bewegung[2];

            myArray[0] = new Laufen();
            myArray[1] = new Springen();

            return myArray;
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

    public class Bewegung
    {

        public string position()
        {
            string myPosition = "Position";
            return myPosition;
        }

        public string Move(int x)
        {
            string myMove = "Moved " + x + " Values";
            return myMove;
        }
        public class Laufen : Bewegung
        {

        }

        public class Springen : Bewegung
        {

        }
    }
}