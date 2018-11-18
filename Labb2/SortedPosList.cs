using System;
using System.Collections.Generic;

namespace Labb2
{
    public class SortedPosList
    {
        List<Position> positionList = new List<Position>();

        public Position this [int key]
        {
            get
            {
                return positionList[key];
            }
        }
        public SortedPosList()
        {
        }

        public override string ToString()
        {
            return string.Join("," , positionList);
        }

        public int Count()
        {
            return positionList.Count;
        }

        public void Add(Position pos)
        {
            positionList.Add(pos);
            positionList.Sort((p1, p2) => p1.Length().CompareTo(p2.Length()));
        }
        public bool Remove(Position pos)
        {
            if (positionList.Contains(pos))
            {
                positionList.Remove(pos);
                return true;
            }
            else
            {
                return false;
            }
        }
        public SortedPosList Clone()
        {
            SortedPosList newPosList = new SortedPosList();
            newPosList.positionList = new List<Position>();
            foreach (Position pos in positionList)
            {
                Position newPos = pos.Clone();
                newPosList.positionList.Add(newPos);   
            }
            return newPosList;
        }
        public SortedPosList CircleContent(Position centerPos, double radius)
        {
            SortedPosList inCircle = new SortedPosList();

            foreach (Position pos in positionList)
            {
                if (pos % centerPos <= radius)
                {
                    inCircle.Add(pos);
                }
            }

            return inCircle;
        }

        public static SortedPosList operator +(SortedPosList sp1, SortedPosList sp2)
        {
            SortedPosList newList = new SortedPosList();
            foreach (Position pos in sp1.positionList)
            {
                newList.Add(pos);           
            }
            foreach(Position pos in sp2.positionList)
            {
                newList.Add(pos);
            }
            return newList;
        }
    }
}
