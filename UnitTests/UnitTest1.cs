﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codility.ArrayClosestAscenders;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Sample_ArrayClosestAscenders()
        {
          //  For example, given the following array A:
          //    A[0] = 4     A[1]  = 3    A[2]  = 1
          //    A[3] = 4     A[4]  = -1   A[5]  = 2 
          //    A[6] = 1     A[7]  = 5    A[8]  = 7 
          //  the function should return the following array R:
          //    R[0] = 7     R[1]  = 1    R[2]  = 1
          //    R[3] = 4     R[4]  = 1    R[5]  = 2 
          //    R[6] = 1     R[7]  = 1    R[8]  = 0 

            int[] A = new int[] { 4, 3, 1, 4, -1, 2, 1, 5, 7 };
            int[] R = Program.ArrayClosestAscenders(A);

            int[] expectedR = new int[] { 7, 1, 1, 4, 1, 2, 1, 1, 0 };
            CollectionAssert.AreEqual(expectedR, R);
        }
    }
}
