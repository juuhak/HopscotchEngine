﻿using System;
using System.Collections.Generic;
using Geometry;
using Geometry.Hitbox;
using Geometry.Tiles;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BulletTests
{
    [TestClass]
    public class TileTests
    {

        [TestMethod]
        public void TestMethod1()
        {
            //Tile tile1 = new Tile(50, 110, 0);
            //var expected = new List<Vector2>()
            //{
            //    new Vector2(0, 32),
            //    new Vector2(32, 32),
            //    new Vector2(32, 0)
            //};
            //var actual = tile1.GetCornersBetween(3, 0);

            //CollectionAssert.AreEqual(expected, actual);

            Tile tile1 = new Tile(48, 112, 0);
            Tile tile2 = new Tile(95, 32, 0);
            Tile tile3 = new Tile(120, 10, 0);

            var ex1 = 2;
            var ex2 = 1;
            var ex3 = 3;

            Assert.AreEqual(ex1, tile1.Hitbox.Count);
            Assert.AreEqual(ex2, tile2.Hitbox.Count);
            Assert.AreEqual(ex3, tile3.Hitbox.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestMethod2()
        {
            Tile tile2 = new Tile(128, 110, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod3()
        {
            Tile tile3 = new Tile(100, 110, 0);
        }
    }
}
