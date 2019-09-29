﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulletClassLibrary
{
    public class Triangle
    {
        List<Point> corners;

        public List<Point> Corners { get => corners; set => corners = checkValue(value); }

        public Triangle(Point c1, Point c2, Point c3)
        {
            if (c1 != c2 && c2 != c3 && c3 != c1)
            {
                corners = new List<Point>() { c1, c2, c3 };
            }
            else throw new Exception("Triangle must have three different corners.");
        }

        public bool Contains(Point point)
        {
            double first, second, third;
            bool hasNeg, hasPos;

            first = sign(point, corners[0], corners[1]);
            second = sign(point, corners[1], corners[2]);
            third = sign(point, corners[2], corners[0]);

            hasNeg = (first <= 0) || (second <= 0) || (third <= 0);
            hasPos = (first >= 0) || (second >= 0) || (third >= 0);

            return !(hasNeg && hasPos);
        }

        private double sign(Point check, Point corner1, Point corner2)
        {
            return (check.X - corner2.X) * (corner1.Y - corner2.Y) - (corner1.X - corner2.X) * (check.Y - corner2.Y);
        }

        private List<Point> checkValue(List<Point> value)
        {
            if (value.Count != 3 || value[0] == value[1] || value[1] == value[2] || value[2] == value[0])
                throw new ArgumentOutOfRangeException("TRIangle contains exactly THREE corners.");
            return value;
        }
    }
}