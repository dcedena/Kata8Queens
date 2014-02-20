using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Kata8Queens_Classes;
using NUnit.Framework;
using System.Diagnostics;

namespace Kata8Queens_Test
{
    [TestFixture]
    public class TestFixture1
    {
        [Test]
        public void Test_CreateBasicBoard()
        {
            Board b = new Board();

            Assert.IsTrue(b.CountRows == 8);
            Assert.IsTrue(b.CountColumns == 8);
        }

        [Test]
        public void Test_CreateBasicBoard_AllCells_ARE_Empty()
        {
            Board b = new Board();

            for (int r = 0; r < b.CountRows; r++)
            {
                for (int c = 0; c < b.CountColumns; c++)
                {
                    Assert.IsTrue(b.GetCell(r, c).IsEmptyType());
                }
            }
        }

        [Test]
        public void Test_CreateBasicBoard_AllCells_NOT_ARE_Queen()
        {
            Board b = new Board();

            for (int r = 0; r < b.CountRows; r++)
            {
                for (int c = 0; c < b.CountColumns; c++)
                {
                    Assert.IsFalse(b.GetCell(r, c).IsQueenType());
                }
            }
        }

        [Test]
        public void Test_SetEmpty_IsEmpty()
        {
            Board b = new Board();
            b.GetCell(0, 0).SetEmptyType();

            Assert.IsTrue(b.GetCell(0, 0).IsEmptyType());
        }

        [Test]
        public void Test_SetQueen_IsQueen()
        {
            Board b = new Board();
            b.GetCell(0, 0).SetQueenType();

            Assert.IsTrue(b.GetCell(0, 0).IsQueenType());
        }

        [Test]
        public void Test_009_SetEmpty_IsNotQueen()
        {
            Board b = new Board();
            b.GetCell(0, 0).SetEmptyType();

            Assert.IsFalse(b.GetCell(0, 0).IsQueenType());
        }

        [Test]
        public void Test_SetQueen_IsNotEmpty()
        {
            Board b = new Board();
            b.GetCell(0, 0).SetQueenType();

            Assert.IsFalse(b.GetCell(0, 0).IsEmptyType());
        }

        [Test]
        public void Test_PrintBoard()
        {
            Board b = new Board();

            b.PrintBoard();
        }

        [Test]
        public void Test_SetQueens_PrintBoard()
        {
            Board b = new Board();

            b.SetQueen(0, 0);
            b.SetQueen(1, 2);

            b.PrintBoard();
        }

        [Test]
        public void Test_SetQueen_R0_C0_Comprobar_SecondSetQueen_R0_C1_Bad()
        {
            Board b = new Board();

            bool ok = b.SetQueen(0, 0);
            Assert.IsTrue(ok);
            b.PrintBoard();

            ok = b.SetQueen(0, 1);
            Assert.IsFalse(ok);
            b.PrintBoard();
        }

        [Test]
        public void Test_SetQueen_R0_C0_Comprobar_SecondSetQueen_R1_C0_Bad()
        {
            Board b = new Board();

            bool ok = b.SetQueen(0, 0);
            Assert.IsTrue(ok);
            b.PrintBoard();

            ok = b.SetQueen(1, 0);
            Assert.IsFalse(ok);
            b.PrintBoard();
        }

        [Test, Description("TLBR = TopLeftBottomRight")]
        public void Test_Check_InitialCell_DiagonalTLBR_All()
        {
            Board b = new Board();
            #region Comprobar Fila 0
            Cell cell_r0c0 = b.GetCell_DiagonalTopLeft(0, 0); Assert.AreEqual("R0C0", cell_r0c0.ToString());
            Cell cell_r0c1 = b.GetCell_DiagonalTopLeft(0, 1); Assert.AreEqual("R0C1", cell_r0c1.ToString());
            Cell cell_r0c2 = b.GetCell_DiagonalTopLeft(0, 2); Assert.AreEqual("R0C2", cell_r0c2.ToString());
            Cell cell_r0c3 = b.GetCell_DiagonalTopLeft(0, 3); Assert.AreEqual("R0C3", cell_r0c3.ToString());
            Cell cell_r0c4 = b.GetCell_DiagonalTopLeft(0, 4); Assert.AreEqual("R0C4", cell_r0c4.ToString());
            Cell cell_r0c5 = b.GetCell_DiagonalTopLeft(0, 5); Assert.AreEqual("R0C5", cell_r0c5.ToString());
            Cell cell_r0c6 = b.GetCell_DiagonalTopLeft(0, 6); Assert.AreEqual("R0C6", cell_r0c6.ToString());
            Cell cell_r0c7 = b.GetCell_DiagonalTopLeft(0, 7); Assert.AreEqual("R0C7", cell_r0c7.ToString());
            #endregion
            #region Comprobar Fila 1
            Cell cell_r1c0 = b.GetCell_DiagonalTopLeft(1, 0); Assert.AreEqual("R1C0", cell_r1c0.ToString());
            Cell cell_r1c1 = b.GetCell_DiagonalTopLeft(1, 1); Assert.AreEqual("R0C0", cell_r1c1.ToString());
            Cell cell_r1c2 = b.GetCell_DiagonalTopLeft(1, 2); Assert.AreEqual("R0C1", cell_r1c2.ToString());
            Cell cell_r1c3 = b.GetCell_DiagonalTopLeft(1, 3); Assert.AreEqual("R0C2", cell_r1c3.ToString());
            Cell cell_r1c4 = b.GetCell_DiagonalTopLeft(1, 4); Assert.AreEqual("R0C3", cell_r1c4.ToString());
            Cell cell_r1c5 = b.GetCell_DiagonalTopLeft(1, 5); Assert.AreEqual("R0C4", cell_r1c5.ToString());
            Cell cell_r1c6 = b.GetCell_DiagonalTopLeft(1, 6); Assert.AreEqual("R0C5", cell_r1c6.ToString());
            Cell cell_r1c7 = b.GetCell_DiagonalTopLeft(1, 7); Assert.AreEqual("R0C6", cell_r1c7.ToString());
            #endregion
            #region Comprobar Fila 2
            Cell cell_r2c0 = b.GetCell_DiagonalTopLeft(2, 0); Assert.AreEqual("R2C0", cell_r2c0.ToString());
            Cell cell_r2c1 = b.GetCell_DiagonalTopLeft(2, 1); Assert.AreEqual("R1C0", cell_r2c1.ToString());
            Cell cell_r2c2 = b.GetCell_DiagonalTopLeft(2, 2); Assert.AreEqual("R0C0", cell_r2c2.ToString());
            Cell cell_r2c3 = b.GetCell_DiagonalTopLeft(2, 3); Assert.AreEqual("R0C1", cell_r2c3.ToString());
            Cell cell_r2c4 = b.GetCell_DiagonalTopLeft(2, 4); Assert.AreEqual("R0C2", cell_r2c4.ToString());
            Cell cell_r2c5 = b.GetCell_DiagonalTopLeft(2, 5); Assert.AreEqual("R0C3", cell_r2c5.ToString());
            Cell cell_r2c6 = b.GetCell_DiagonalTopLeft(2, 6); Assert.AreEqual("R0C4", cell_r2c6.ToString());
            Cell cell_r2c7 = b.GetCell_DiagonalTopLeft(2, 7); Assert.AreEqual("R0C5", cell_r2c7.ToString());
            #endregion
            #region Comprobar Fila 3
            Cell cell_r3c0 = b.GetCell_DiagonalTopLeft(3, 0); Assert.AreEqual("R3C0", cell_r3c0.ToString());
            Cell cell_r3c1 = b.GetCell_DiagonalTopLeft(3, 1); Assert.AreEqual("R2C0", cell_r3c1.ToString());
            Cell cell_r3c2 = b.GetCell_DiagonalTopLeft(3, 2); Assert.AreEqual("R1C0", cell_r3c2.ToString());
            Cell cell_r3c3 = b.GetCell_DiagonalTopLeft(3, 3); Assert.AreEqual("R0C0", cell_r3c3.ToString());
            Cell cell_r3c4 = b.GetCell_DiagonalTopLeft(3, 4); Assert.AreEqual("R0C1", cell_r3c4.ToString());
            Cell cell_r3c5 = b.GetCell_DiagonalTopLeft(3, 5); Assert.AreEqual("R0C2", cell_r3c5.ToString());
            Cell cell_r3c6 = b.GetCell_DiagonalTopLeft(3, 6); Assert.AreEqual("R0C3", cell_r3c6.ToString());
            Cell cell_r3c7 = b.GetCell_DiagonalTopLeft(3, 7); Assert.AreEqual("R0C4", cell_r3c7.ToString());
            #endregion
            #region Comprobar Fila 4
            Cell cell_r4c0 = b.GetCell_DiagonalTopLeft(4, 0); Assert.AreEqual("R4C0", cell_r4c0.ToString());
            Cell cell_r4c1 = b.GetCell_DiagonalTopLeft(4, 1); Assert.AreEqual("R3C0", cell_r4c1.ToString());
            Cell cell_r4c2 = b.GetCell_DiagonalTopLeft(4, 2); Assert.AreEqual("R2C0", cell_r4c2.ToString());
            Cell cell_r4c3 = b.GetCell_DiagonalTopLeft(4, 3); Assert.AreEqual("R1C0", cell_r4c3.ToString());
            Cell cell_r4c4 = b.GetCell_DiagonalTopLeft(4, 4); Assert.AreEqual("R0C0", cell_r4c4.ToString());
            Cell cell_r4c5 = b.GetCell_DiagonalTopLeft(4, 5); Assert.AreEqual("R0C1", cell_r4c5.ToString());
            Cell cell_r4c6 = b.GetCell_DiagonalTopLeft(4, 6); Assert.AreEqual("R0C2", cell_r4c6.ToString());
            Cell cell_r4c7 = b.GetCell_DiagonalTopLeft(4, 7); Assert.AreEqual("R0C3", cell_r4c7.ToString());
            #endregion
            #region Comprobar Fila 5
            Cell cell_r5c0 = b.GetCell_DiagonalTopLeft(5, 0); Assert.AreEqual("R5C0", cell_r5c0.ToString());
            Cell cell_r5c1 = b.GetCell_DiagonalTopLeft(5, 1); Assert.AreEqual("R4C0", cell_r5c1.ToString());
            Cell cell_r5c2 = b.GetCell_DiagonalTopLeft(5, 2); Assert.AreEqual("R3C0", cell_r5c2.ToString());
            Cell cell_r5c3 = b.GetCell_DiagonalTopLeft(5, 3); Assert.AreEqual("R2C0", cell_r5c3.ToString());
            Cell cell_r5c4 = b.GetCell_DiagonalTopLeft(5, 4); Assert.AreEqual("R1C0", cell_r5c4.ToString());
            Cell cell_r5c5 = b.GetCell_DiagonalTopLeft(5, 5); Assert.AreEqual("R0C0", cell_r5c5.ToString());
            Cell cell_r5c6 = b.GetCell_DiagonalTopLeft(5, 6); Assert.AreEqual("R0C1", cell_r5c6.ToString());
            Cell cell_r5c7 = b.GetCell_DiagonalTopLeft(5, 7); Assert.AreEqual("R0C2", cell_r5c7.ToString());
            #endregion
            #region Comprobar Fila 6
            Cell cell_r6c0 = b.GetCell_DiagonalTopLeft(6, 0); Assert.AreEqual("R6C0", cell_r6c0.ToString());
            Cell cell_r6c1 = b.GetCell_DiagonalTopLeft(6, 1); Assert.AreEqual("R5C0", cell_r6c1.ToString());
            Cell cell_r6c2 = b.GetCell_DiagonalTopLeft(6, 2); Assert.AreEqual("R4C0", cell_r6c2.ToString());
            Cell cell_r6c3 = b.GetCell_DiagonalTopLeft(6, 3); Assert.AreEqual("R3C0", cell_r6c3.ToString());
            Cell cell_r6c4 = b.GetCell_DiagonalTopLeft(6, 4); Assert.AreEqual("R2C0", cell_r6c4.ToString());
            Cell cell_r6c5 = b.GetCell_DiagonalTopLeft(6, 5); Assert.AreEqual("R1C0", cell_r6c5.ToString());
            Cell cell_r6c6 = b.GetCell_DiagonalTopLeft(6, 6); Assert.AreEqual("R0C0", cell_r6c6.ToString());
            Cell cell_r6c7 = b.GetCell_DiagonalTopLeft(6, 7); Assert.AreEqual("R0C1", cell_r6c7.ToString());
            #endregion
            #region Comprobar Fila 7
            Cell cell_r7c0 = b.GetCell_DiagonalTopLeft(7, 0); Assert.AreEqual("R7C0", cell_r7c0.ToString());
            Cell cell_r7c1 = b.GetCell_DiagonalTopLeft(7, 1); Assert.AreEqual("R6C0", cell_r7c1.ToString());
            Cell cell_r7c2 = b.GetCell_DiagonalTopLeft(7, 2); Assert.AreEqual("R5C0", cell_r7c2.ToString());
            Cell cell_r7c3 = b.GetCell_DiagonalTopLeft(7, 3); Assert.AreEqual("R4C0", cell_r7c3.ToString());
            Cell cell_r7c4 = b.GetCell_DiagonalTopLeft(7, 4); Assert.AreEqual("R3C0", cell_r7c4.ToString());
            Cell cell_r7c5 = b.GetCell_DiagonalTopLeft(7, 5); Assert.AreEqual("R2C0", cell_r7c5.ToString());
            Cell cell_r7c6 = b.GetCell_DiagonalTopLeft(7, 6); Assert.AreEqual("R1C0", cell_r7c6.ToString());
            Cell cell_r7c7 = b.GetCell_DiagonalTopLeft(7, 7); Assert.AreEqual("R0C0", cell_r7c7.ToString());
            #endregion
        }

        [Test, Description("TLBR = TopLeftBottomRight")]
        public void Test_Check_FinalCell_DiagonalTLBR_All()
        {
            Board b = new Board();
            #region Comprobar Fila 0
            Cell cell_r0c0 = b.GetCell_DiagonalBottomRight(0, 0); Assert.AreEqual("R7C7", cell_r0c0.ToString());
            Cell cell_r0c1 = b.GetCell_DiagonalBottomRight(0, 1); Assert.AreEqual("R6C7", cell_r0c1.ToString());
            Cell cell_r0c2 = b.GetCell_DiagonalBottomRight(0, 2); Assert.AreEqual("R5C7", cell_r0c2.ToString());
            Cell cell_r0c3 = b.GetCell_DiagonalBottomRight(0, 3); Assert.AreEqual("R4C7", cell_r0c3.ToString());
            Cell cell_r0c4 = b.GetCell_DiagonalBottomRight(0, 4); Assert.AreEqual("R3C7", cell_r0c4.ToString());
            Cell cell_r0c5 = b.GetCell_DiagonalBottomRight(0, 5); Assert.AreEqual("R2C7", cell_r0c5.ToString());
            Cell cell_r0c6 = b.GetCell_DiagonalBottomRight(0, 6); Assert.AreEqual("R1C7", cell_r0c6.ToString());
            Cell cell_r0c7 = b.GetCell_DiagonalBottomRight(0, 7); Assert.AreEqual("R0C7", cell_r0c7.ToString());
            #endregion
            #region Comprobar Fila 1
            Cell cell_r1c0 = b.GetCell_DiagonalBottomRight(1, 0); Assert.AreEqual("R7C6", cell_r1c0.ToString());
            Cell cell_r1c1 = b.GetCell_DiagonalBottomRight(1, 1); Assert.AreEqual("R7C7", cell_r1c1.ToString());
            Cell cell_r1c2 = b.GetCell_DiagonalBottomRight(1, 2); Assert.AreEqual("R6C7", cell_r1c2.ToString());
            Cell cell_r1c3 = b.GetCell_DiagonalBottomRight(1, 3); Assert.AreEqual("R5C7", cell_r1c3.ToString());
            Cell cell_r1c4 = b.GetCell_DiagonalBottomRight(1, 4); Assert.AreEqual("R4C7", cell_r1c4.ToString());
            Cell cell_r1c5 = b.GetCell_DiagonalBottomRight(1, 5); Assert.AreEqual("R3C7", cell_r1c5.ToString());
            Cell cell_r1c6 = b.GetCell_DiagonalBottomRight(1, 6); Assert.AreEqual("R2C7", cell_r1c6.ToString());
            Cell cell_r1c7 = b.GetCell_DiagonalBottomRight(1, 7); Assert.AreEqual("R1C7", cell_r1c7.ToString());
            #endregion
            #region Comprobar Fila 2
            Cell cell_r2c0 = b.GetCell_DiagonalBottomRight(2, 0); Assert.AreEqual("R7C5", cell_r2c0.ToString());
            Cell cell_r2c1 = b.GetCell_DiagonalBottomRight(2, 1); Assert.AreEqual("R7C6", cell_r2c1.ToString());
            Cell cell_r2c2 = b.GetCell_DiagonalBottomRight(2, 2); Assert.AreEqual("R7C7", cell_r2c2.ToString());
            Cell cell_r2c3 = b.GetCell_DiagonalBottomRight(2, 3); Assert.AreEqual("R6C7", cell_r2c3.ToString());
            Cell cell_r2c4 = b.GetCell_DiagonalBottomRight(2, 4); Assert.AreEqual("R5C7", cell_r2c4.ToString());
            Cell cell_r2c5 = b.GetCell_DiagonalBottomRight(2, 5); Assert.AreEqual("R4C7", cell_r2c5.ToString());
            Cell cell_r2c6 = b.GetCell_DiagonalBottomRight(2, 6); Assert.AreEqual("R3C7", cell_r2c6.ToString());
            Cell cell_r2c7 = b.GetCell_DiagonalBottomRight(2, 7); Assert.AreEqual("R2C7", cell_r2c7.ToString());
            #endregion
            #region Comprobar Fila 3
            Cell cell_r3c0 = b.GetCell_DiagonalBottomRight(3, 0); Assert.AreEqual("R7C4", cell_r3c0.ToString());
            Cell cell_r3c1 = b.GetCell_DiagonalBottomRight(3, 1); Assert.AreEqual("R7C5", cell_r3c1.ToString());
            Cell cell_r3c2 = b.GetCell_DiagonalBottomRight(3, 2); Assert.AreEqual("R7C6", cell_r3c2.ToString());
            Cell cell_r3c3 = b.GetCell_DiagonalBottomRight(3, 3); Assert.AreEqual("R7C7", cell_r3c3.ToString());
            Cell cell_r3c4 = b.GetCell_DiagonalBottomRight(3, 4); Assert.AreEqual("R6C7", cell_r3c4.ToString());
            Cell cell_r3c5 = b.GetCell_DiagonalBottomRight(3, 5); Assert.AreEqual("R5C7", cell_r3c5.ToString());
            Cell cell_r3c6 = b.GetCell_DiagonalBottomRight(3, 6); Assert.AreEqual("R4C7", cell_r3c6.ToString());
            Cell cell_r3c7 = b.GetCell_DiagonalBottomRight(3, 7); Assert.AreEqual("R3C7", cell_r3c7.ToString());
            #endregion
            #region Comprobar Fila 4
            Cell cell_r4c0 = b.GetCell_DiagonalBottomRight(4, 0); Assert.AreEqual("R7C3", cell_r4c0.ToString());
            Cell cell_r4c1 = b.GetCell_DiagonalBottomRight(4, 1); Assert.AreEqual("R7C4", cell_r4c1.ToString());
            Cell cell_r4c2 = b.GetCell_DiagonalBottomRight(4, 2); Assert.AreEqual("R7C5", cell_r4c2.ToString());
            Cell cell_r4c3 = b.GetCell_DiagonalBottomRight(4, 3); Assert.AreEqual("R7C6", cell_r4c3.ToString());
            Cell cell_r4c4 = b.GetCell_DiagonalBottomRight(4, 4); Assert.AreEqual("R7C7", cell_r4c4.ToString());
            Cell cell_r4c5 = b.GetCell_DiagonalBottomRight(4, 5); Assert.AreEqual("R6C7", cell_r4c5.ToString());
            Cell cell_r4c6 = b.GetCell_DiagonalBottomRight(4, 6); Assert.AreEqual("R5C7", cell_r4c6.ToString());
            Cell cell_r4c7 = b.GetCell_DiagonalBottomRight(4, 7); Assert.AreEqual("R4C7", cell_r4c7.ToString());
            #endregion
            #region Comprobar Fila 5
            Cell cell_r5c0 = b.GetCell_DiagonalBottomRight(5, 0); Assert.AreEqual("R7C2", cell_r5c0.ToString());
            Cell cell_r5c1 = b.GetCell_DiagonalBottomRight(5, 1); Assert.AreEqual("R7C3", cell_r5c1.ToString());
            Cell cell_r5c2 = b.GetCell_DiagonalBottomRight(5, 2); Assert.AreEqual("R7C4", cell_r5c2.ToString());
            Cell cell_r5c3 = b.GetCell_DiagonalBottomRight(5, 3); Assert.AreEqual("R7C5", cell_r5c3.ToString());
            Cell cell_r5c4 = b.GetCell_DiagonalBottomRight(5, 4); Assert.AreEqual("R7C6", cell_r5c4.ToString());
            Cell cell_r5c5 = b.GetCell_DiagonalBottomRight(5, 5); Assert.AreEqual("R7C7", cell_r5c5.ToString());
            Cell cell_r5c6 = b.GetCell_DiagonalBottomRight(5, 6); Assert.AreEqual("R6C7", cell_r5c6.ToString());
            Cell cell_r5c7 = b.GetCell_DiagonalBottomRight(5, 7); Assert.AreEqual("R5C7", cell_r5c7.ToString());
            #endregion
            #region Comprobar Fila 6
            Cell cell_r6c0 = b.GetCell_DiagonalBottomRight(6, 0); Assert.AreEqual("R7C1", cell_r6c0.ToString());
            Cell cell_r6c1 = b.GetCell_DiagonalBottomRight(6, 1); Assert.AreEqual("R7C2", cell_r6c1.ToString());
            Cell cell_r6c2 = b.GetCell_DiagonalBottomRight(6, 2); Assert.AreEqual("R7C3", cell_r6c2.ToString());
            Cell cell_r6c3 = b.GetCell_DiagonalBottomRight(6, 3); Assert.AreEqual("R7C4", cell_r6c3.ToString());
            Cell cell_r6c4 = b.GetCell_DiagonalBottomRight(6, 4); Assert.AreEqual("R7C5", cell_r6c4.ToString());
            Cell cell_r6c5 = b.GetCell_DiagonalBottomRight(6, 5); Assert.AreEqual("R7C6", cell_r6c5.ToString());
            Cell cell_r6c6 = b.GetCell_DiagonalBottomRight(6, 6); Assert.AreEqual("R7C7", cell_r6c6.ToString());
            Cell cell_r6c7 = b.GetCell_DiagonalBottomRight(6, 7); Assert.AreEqual("R6C7", cell_r6c7.ToString());
            #endregion
            #region Comprobar Fila 7
            Cell cell_r7c0 = b.GetCell_DiagonalBottomRight(7, 0); Assert.AreEqual("R7C0", cell_r7c0.ToString());
            Cell cell_r7c1 = b.GetCell_DiagonalBottomRight(7, 1); Assert.AreEqual("R7C1", cell_r7c1.ToString());
            Cell cell_r7c2 = b.GetCell_DiagonalBottomRight(7, 2); Assert.AreEqual("R7C2", cell_r7c2.ToString());
            Cell cell_r7c3 = b.GetCell_DiagonalBottomRight(7, 3); Assert.AreEqual("R7C3", cell_r7c3.ToString());
            Cell cell_r7c4 = b.GetCell_DiagonalBottomRight(7, 4); Assert.AreEqual("R7C4", cell_r7c4.ToString());
            Cell cell_r7c5 = b.GetCell_DiagonalBottomRight(7, 5); Assert.AreEqual("R7C5", cell_r7c5.ToString());
            Cell cell_r7c6 = b.GetCell_DiagonalBottomRight(7, 6); Assert.AreEqual("R7C6", cell_r7c6.ToString());
            Cell cell_r7c7 = b.GetCell_DiagonalBottomRight(7, 7); Assert.AreEqual("R7C7", cell_r7c7.ToString());
            #endregion
        }

        [Test, Description("TRBL = TopRightBottomLeft")]
        public void Test_Check_InitialCell_DiagonalTRBL_All()
        {
            Board b = new Board();
            #region Comprobar Fila 0
            Cell cell_r0c0 = b.GetCell_DiagonalTopRight(0, 0); Assert.AreEqual("R0C0", cell_r0c0.ToString());
            Cell cell_r0c1 = b.GetCell_DiagonalTopRight(0, 1); Assert.AreEqual("R0C1", cell_r0c1.ToString());
            Cell cell_r0c2 = b.GetCell_DiagonalTopRight(0, 2); Assert.AreEqual("R0C2", cell_r0c2.ToString());
            Cell cell_r0c3 = b.GetCell_DiagonalTopRight(0, 3); Assert.AreEqual("R0C3", cell_r0c3.ToString());
            Cell cell_r0c4 = b.GetCell_DiagonalTopRight(0, 4); Assert.AreEqual("R0C4", cell_r0c4.ToString());
            Cell cell_r0c5 = b.GetCell_DiagonalTopRight(0, 5); Assert.AreEqual("R0C5", cell_r0c5.ToString());
            Cell cell_r0c6 = b.GetCell_DiagonalTopRight(0, 6); Assert.AreEqual("R0C6", cell_r0c6.ToString());
            Cell cell_r0c7 = b.GetCell_DiagonalTopRight(0, 7); Assert.AreEqual("R0C7", cell_r0c7.ToString());
            #endregion
            #region Comprobar Fila 1
            Cell cell_r1c0 = b.GetCell_DiagonalTopRight(1, 0); Assert.AreEqual("R0C1", cell_r1c0.ToString());
            Cell cell_r1c1 = b.GetCell_DiagonalTopRight(1, 1); Assert.AreEqual("R0C2", cell_r1c1.ToString());
            Cell cell_r1c2 = b.GetCell_DiagonalTopRight(1, 2); Assert.AreEqual("R0C3", cell_r1c2.ToString());
            Cell cell_r1c3 = b.GetCell_DiagonalTopRight(1, 3); Assert.AreEqual("R0C4", cell_r1c3.ToString());
            Cell cell_r1c4 = b.GetCell_DiagonalTopRight(1, 4); Assert.AreEqual("R0C5", cell_r1c4.ToString());
            Cell cell_r1c5 = b.GetCell_DiagonalTopRight(1, 5); Assert.AreEqual("R0C6", cell_r1c5.ToString());
            Cell cell_r1c6 = b.GetCell_DiagonalTopRight(1, 6); Assert.AreEqual("R0C7", cell_r1c6.ToString());
            Cell cell_r1c7 = b.GetCell_DiagonalTopRight(1, 7); Assert.AreEqual("R1C7", cell_r1c7.ToString());
            #endregion
            #region Comprobar Fila 2
            Cell cell_r2c0 = b.GetCell_DiagonalTopRight(2, 0); Assert.AreEqual("R0C2", cell_r2c0.ToString());
            Cell cell_r2c1 = b.GetCell_DiagonalTopRight(2, 1); Assert.AreEqual("R0C3", cell_r2c1.ToString());
            Cell cell_r2c2 = b.GetCell_DiagonalTopRight(2, 2); Assert.AreEqual("R0C4", cell_r2c2.ToString());
            Cell cell_r2c3 = b.GetCell_DiagonalTopRight(2, 3); Assert.AreEqual("R0C5", cell_r2c3.ToString());
            Cell cell_r2c4 = b.GetCell_DiagonalTopRight(2, 4); Assert.AreEqual("R0C6", cell_r2c4.ToString());
            Cell cell_r2c5 = b.GetCell_DiagonalTopRight(2, 5); Assert.AreEqual("R0C7", cell_r2c5.ToString());
            Cell cell_r2c6 = b.GetCell_DiagonalTopRight(2, 6); Assert.AreEqual("R1C7", cell_r2c6.ToString());
            Cell cell_r2c7 = b.GetCell_DiagonalTopRight(2, 7); Assert.AreEqual("R2C7", cell_r2c7.ToString());
            #endregion
            #region Comprobar Fila 3
            Cell cell_r3c0 = b.GetCell_DiagonalTopRight(3, 0); Assert.AreEqual("R0C3", cell_r3c0.ToString());
            Cell cell_r3c1 = b.GetCell_DiagonalTopRight(3, 1); Assert.AreEqual("R0C4", cell_r3c1.ToString());
            Cell cell_r3c2 = b.GetCell_DiagonalTopRight(3, 2); Assert.AreEqual("R0C5", cell_r3c2.ToString());
            Cell cell_r3c3 = b.GetCell_DiagonalTopRight(3, 3); Assert.AreEqual("R0C6", cell_r3c3.ToString());
            Cell cell_r3c4 = b.GetCell_DiagonalTopRight(3, 4); Assert.AreEqual("R0C7", cell_r3c4.ToString());
            Cell cell_r3c5 = b.GetCell_DiagonalTopRight(3, 5); Assert.AreEqual("R1C7", cell_r3c5.ToString());
            Cell cell_r3c6 = b.GetCell_DiagonalTopRight(3, 6); Assert.AreEqual("R2C7", cell_r3c6.ToString());
            Cell cell_r3c7 = b.GetCell_DiagonalTopRight(3, 7); Assert.AreEqual("R3C7", cell_r3c7.ToString());
            #endregion
            #region Comprobar Fila 4
            Cell cell_r4c0 = b.GetCell_DiagonalTopRight(4, 0); Assert.AreEqual("R0C4", cell_r4c0.ToString());
            Cell cell_r4c1 = b.GetCell_DiagonalTopRight(4, 1); Assert.AreEqual("R0C5", cell_r4c1.ToString());
            Cell cell_r4c2 = b.GetCell_DiagonalTopRight(4, 2); Assert.AreEqual("R0C6", cell_r4c2.ToString());
            Cell cell_r4c3 = b.GetCell_DiagonalTopRight(4, 3); Assert.AreEqual("R0C7", cell_r4c3.ToString());
            Cell cell_r4c4 = b.GetCell_DiagonalTopRight(4, 4); Assert.AreEqual("R1C7", cell_r4c4.ToString());
            Cell cell_r4c5 = b.GetCell_DiagonalTopRight(4, 5); Assert.AreEqual("R2C7", cell_r4c5.ToString());
            Cell cell_r4c6 = b.GetCell_DiagonalTopRight(4, 6); Assert.AreEqual("R3C7", cell_r4c6.ToString());
            Cell cell_r4c7 = b.GetCell_DiagonalTopRight(4, 7); Assert.AreEqual("R4C7", cell_r4c7.ToString());
            #endregion
            #region Comprobar Fila 5
            Cell cell_r5c0 = b.GetCell_DiagonalTopRight(5, 0); Assert.AreEqual("R0C5", cell_r5c0.ToString());
            Cell cell_r5c1 = b.GetCell_DiagonalTopRight(5, 1); Assert.AreEqual("R0C6", cell_r5c1.ToString());
            Cell cell_r5c2 = b.GetCell_DiagonalTopRight(5, 2); Assert.AreEqual("R0C7", cell_r5c2.ToString());
            Cell cell_r5c3 = b.GetCell_DiagonalTopRight(5, 3); Assert.AreEqual("R1C7", cell_r5c3.ToString());
            Cell cell_r5c4 = b.GetCell_DiagonalTopRight(5, 4); Assert.AreEqual("R2C7", cell_r5c4.ToString());
            Cell cell_r5c5 = b.GetCell_DiagonalTopRight(5, 5); Assert.AreEqual("R3C7", cell_r5c5.ToString());
            Cell cell_r5c6 = b.GetCell_DiagonalTopRight(5, 6); Assert.AreEqual("R4C7", cell_r5c6.ToString());
            Cell cell_r5c7 = b.GetCell_DiagonalTopRight(5, 7); Assert.AreEqual("R5C7", cell_r5c7.ToString());
            #endregion
            #region Comprobar Fila 6
            Cell cell_r6c0 = b.GetCell_DiagonalTopRight(6, 0); Assert.AreEqual("R0C6", cell_r6c0.ToString());
            Cell cell_r6c1 = b.GetCell_DiagonalTopRight(6, 1); Assert.AreEqual("R0C7", cell_r6c1.ToString());
            Cell cell_r6c2 = b.GetCell_DiagonalTopRight(6, 2); Assert.AreEqual("R1C7", cell_r6c2.ToString());
            Cell cell_r6c3 = b.GetCell_DiagonalTopRight(6, 3); Assert.AreEqual("R2C7", cell_r6c3.ToString());
            Cell cell_r6c4 = b.GetCell_DiagonalTopRight(6, 4); Assert.AreEqual("R3C7", cell_r6c4.ToString());
            Cell cell_r6c5 = b.GetCell_DiagonalTopRight(6, 5); Assert.AreEqual("R4C7", cell_r6c5.ToString());
            Cell cell_r6c6 = b.GetCell_DiagonalTopRight(6, 6); Assert.AreEqual("R5C7", cell_r6c6.ToString());
            Cell cell_r6c7 = b.GetCell_DiagonalTopRight(6, 7); Assert.AreEqual("R6C7", cell_r6c7.ToString());
            #endregion
            #region Comprobar Fila 7
            Cell cell_r7c0 = b.GetCell_DiagonalTopRight(7, 0); Assert.AreEqual("R0C7", cell_r7c0.ToString());
            Cell cell_r7c1 = b.GetCell_DiagonalTopRight(7, 1); Assert.AreEqual("R1C7", cell_r7c1.ToString());
            Cell cell_r7c2 = b.GetCell_DiagonalTopRight(7, 2); Assert.AreEqual("R2C7", cell_r7c2.ToString());
            Cell cell_r7c3 = b.GetCell_DiagonalTopRight(7, 3); Assert.AreEqual("R3C7", cell_r7c3.ToString());
            Cell cell_r7c4 = b.GetCell_DiagonalTopRight(7, 4); Assert.AreEqual("R4C7", cell_r7c4.ToString());
            Cell cell_r7c5 = b.GetCell_DiagonalTopRight(7, 5); Assert.AreEqual("R5C7", cell_r7c5.ToString());
            Cell cell_r7c6 = b.GetCell_DiagonalTopRight(7, 6); Assert.AreEqual("R6C7", cell_r7c6.ToString());
            Cell cell_r7c7 = b.GetCell_DiagonalTopRight(7, 7); Assert.AreEqual("R7C7", cell_r7c7.ToString());
            #endregion
        }

        [Test, Description("TRBL = TopRightBottomLeft")]
        public void Test_Check_FinalCell_DiagonalTRBL_All()
        {
            Board b = new Board();
            #region Comprobar Fila 0
            Cell cell_r0c0 = b.GetCell_DiagonalBottomLeft(0, 0); Assert.AreEqual("R0C0", cell_r0c0.ToString());
            Cell cell_r0c1 = b.GetCell_DiagonalBottomLeft(0, 1); Assert.AreEqual("R1C0", cell_r0c1.ToString());
            Cell cell_r0c2 = b.GetCell_DiagonalBottomLeft(0, 2); Assert.AreEqual("R2C0", cell_r0c2.ToString());
            Cell cell_r0c3 = b.GetCell_DiagonalBottomLeft(0, 3); Assert.AreEqual("R3C0", cell_r0c3.ToString());
            Cell cell_r0c4 = b.GetCell_DiagonalBottomLeft(0, 4); Assert.AreEqual("R4C0", cell_r0c4.ToString());
            Cell cell_r0c5 = b.GetCell_DiagonalBottomLeft(0, 5); Assert.AreEqual("R5C0", cell_r0c5.ToString());
            Cell cell_r0c6 = b.GetCell_DiagonalBottomLeft(0, 6); Assert.AreEqual("R6C0", cell_r0c6.ToString());
            Cell cell_r0c7 = b.GetCell_DiagonalBottomLeft(0, 7); Assert.AreEqual("R7C0", cell_r0c7.ToString());
            #endregion
            #region Comprobar Fila 1
            Cell cell_r1c0 = b.GetCell_DiagonalBottomLeft(1, 0); Assert.AreEqual("R1C0", cell_r1c0.ToString());
            Cell cell_r1c1 = b.GetCell_DiagonalBottomLeft(1, 1); Assert.AreEqual("R2C0", cell_r1c1.ToString());
            Cell cell_r1c2 = b.GetCell_DiagonalBottomLeft(1, 2); Assert.AreEqual("R3C0", cell_r1c2.ToString());
            Cell cell_r1c3 = b.GetCell_DiagonalBottomLeft(1, 3); Assert.AreEqual("R4C0", cell_r1c3.ToString());
            Cell cell_r1c4 = b.GetCell_DiagonalBottomLeft(1, 4); Assert.AreEqual("R5C0", cell_r1c4.ToString());
            Cell cell_r1c5 = b.GetCell_DiagonalBottomLeft(1, 5); Assert.AreEqual("R6C0", cell_r1c5.ToString());
            Cell cell_r1c6 = b.GetCell_DiagonalBottomLeft(1, 6); Assert.AreEqual("R7C0", cell_r1c6.ToString());
            Cell cell_r1c7 = b.GetCell_DiagonalBottomLeft(1, 7); Assert.AreEqual("R7C1", cell_r1c7.ToString());
            #endregion
            #region Comprobar Fila 2
            Cell cell_r2c0 = b.GetCell_DiagonalBottomLeft(2, 0); Assert.AreEqual("R2C0", cell_r2c0.ToString());
            Cell cell_r2c1 = b.GetCell_DiagonalBottomLeft(2, 1); Assert.AreEqual("R3C0", cell_r2c1.ToString());
            Cell cell_r2c2 = b.GetCell_DiagonalBottomLeft(2, 2); Assert.AreEqual("R4C0", cell_r2c2.ToString());
            Cell cell_r2c3 = b.GetCell_DiagonalBottomLeft(2, 3); Assert.AreEqual("R5C0", cell_r2c3.ToString());
            Cell cell_r2c4 = b.GetCell_DiagonalBottomLeft(2, 4); Assert.AreEqual("R6C0", cell_r2c4.ToString());
            Cell cell_r2c5 = b.GetCell_DiagonalBottomLeft(2, 5); Assert.AreEqual("R7C0", cell_r2c5.ToString());
            Cell cell_r2c6 = b.GetCell_DiagonalBottomLeft(2, 6); Assert.AreEqual("R7C1", cell_r2c6.ToString());
            Cell cell_r2c7 = b.GetCell_DiagonalBottomLeft(2, 7); Assert.AreEqual("R7C2", cell_r2c7.ToString());
            #endregion
            #region Comprobar Fila 3
            Cell cell_r3c0 = b.GetCell_DiagonalBottomLeft(3, 0); Assert.AreEqual("R3C0", cell_r3c0.ToString());
            Cell cell_r3c1 = b.GetCell_DiagonalBottomLeft(3, 1); Assert.AreEqual("R4C0", cell_r3c1.ToString());
            Cell cell_r3c2 = b.GetCell_DiagonalBottomLeft(3, 2); Assert.AreEqual("R5C0", cell_r3c2.ToString());
            Cell cell_r3c3 = b.GetCell_DiagonalBottomLeft(3, 3); Assert.AreEqual("R6C0", cell_r3c3.ToString());
            Cell cell_r3c4 = b.GetCell_DiagonalBottomLeft(3, 4); Assert.AreEqual("R7C0", cell_r3c4.ToString());
            Cell cell_r3c5 = b.GetCell_DiagonalBottomLeft(3, 5); Assert.AreEqual("R7C1", cell_r3c5.ToString());
            Cell cell_r3c6 = b.GetCell_DiagonalBottomLeft(3, 6); Assert.AreEqual("R7C2", cell_r3c6.ToString());
            Cell cell_r3c7 = b.GetCell_DiagonalBottomLeft(3, 7); Assert.AreEqual("R7C3", cell_r3c7.ToString());
            #endregion
            #region Comprobar Fila 4
            Cell cell_r4c0 = b.GetCell_DiagonalBottomLeft(4, 0); Assert.AreEqual("R4C0", cell_r4c0.ToString());
            Cell cell_r4c1 = b.GetCell_DiagonalBottomLeft(4, 1); Assert.AreEqual("R5C0", cell_r4c1.ToString());
            Cell cell_r4c2 = b.GetCell_DiagonalBottomLeft(4, 2); Assert.AreEqual("R6C0", cell_r4c2.ToString());
            Cell cell_r4c3 = b.GetCell_DiagonalBottomLeft(4, 3); Assert.AreEqual("R7C0", cell_r4c3.ToString());
            Cell cell_r4c4 = b.GetCell_DiagonalBottomLeft(4, 4); Assert.AreEqual("R7C1", cell_r4c4.ToString());
            Cell cell_r4c5 = b.GetCell_DiagonalBottomLeft(4, 5); Assert.AreEqual("R7C2", cell_r4c5.ToString());
            Cell cell_r4c6 = b.GetCell_DiagonalBottomLeft(4, 6); Assert.AreEqual("R7C3", cell_r4c6.ToString());
            Cell cell_r4c7 = b.GetCell_DiagonalBottomLeft(4, 7); Assert.AreEqual("R7C4", cell_r4c7.ToString());
            #endregion
            #region Comprobar Fila 5
            Cell cell_r5c0 = b.GetCell_DiagonalBottomLeft(5, 0); Assert.AreEqual("R5C0", cell_r5c0.ToString());
            Cell cell_r5c1 = b.GetCell_DiagonalBottomLeft(5, 1); Assert.AreEqual("R6C0", cell_r5c1.ToString());
            Cell cell_r5c2 = b.GetCell_DiagonalBottomLeft(5, 2); Assert.AreEqual("R7C0", cell_r5c2.ToString());
            Cell cell_r5c3 = b.GetCell_DiagonalBottomLeft(5, 3); Assert.AreEqual("R7C1", cell_r5c3.ToString());
            Cell cell_r5c4 = b.GetCell_DiagonalBottomLeft(5, 4); Assert.AreEqual("R7C2", cell_r5c4.ToString());
            Cell cell_r5c5 = b.GetCell_DiagonalBottomLeft(5, 5); Assert.AreEqual("R7C3", cell_r5c5.ToString());
            Cell cell_r5c6 = b.GetCell_DiagonalBottomLeft(5, 6); Assert.AreEqual("R7C4", cell_r5c6.ToString());
            Cell cell_r5c7 = b.GetCell_DiagonalBottomLeft(5, 7); Assert.AreEqual("R7C5", cell_r5c7.ToString());
            #endregion
            #region Comprobar Fila 6
            Cell cell_r6c0 = b.GetCell_DiagonalBottomLeft(6, 0); Assert.AreEqual("R6C0", cell_r6c0.ToString());
            Cell cell_r6c1 = b.GetCell_DiagonalBottomLeft(6, 1); Assert.AreEqual("R7C0", cell_r6c1.ToString());
            Cell cell_r6c2 = b.GetCell_DiagonalBottomLeft(6, 2); Assert.AreEqual("R7C1", cell_r6c2.ToString());
            Cell cell_r6c3 = b.GetCell_DiagonalBottomLeft(6, 3); Assert.AreEqual("R7C2", cell_r6c3.ToString());
            Cell cell_r6c4 = b.GetCell_DiagonalBottomLeft(6, 4); Assert.AreEqual("R7C3", cell_r6c4.ToString());
            Cell cell_r6c5 = b.GetCell_DiagonalBottomLeft(6, 5); Assert.AreEqual("R7C4", cell_r6c5.ToString());
            Cell cell_r6c6 = b.GetCell_DiagonalBottomLeft(6, 6); Assert.AreEqual("R7C5", cell_r6c6.ToString());
            Cell cell_r6c7 = b.GetCell_DiagonalBottomLeft(6, 7); Assert.AreEqual("R7C6", cell_r6c7.ToString());
            #endregion
            #region Comprobar Fila 7
            Cell cell_r7c0 = b.GetCell_DiagonalBottomLeft(7, 0); Assert.AreEqual("R7C0", cell_r7c0.ToString());
            Cell cell_r7c1 = b.GetCell_DiagonalBottomLeft(7, 1); Assert.AreEqual("R7C1", cell_r7c1.ToString());
            Cell cell_r7c2 = b.GetCell_DiagonalBottomLeft(7, 2); Assert.AreEqual("R7C2", cell_r7c2.ToString());
            Cell cell_r7c3 = b.GetCell_DiagonalBottomLeft(7, 3); Assert.AreEqual("R7C3", cell_r7c3.ToString());
            Cell cell_r7c4 = b.GetCell_DiagonalBottomLeft(7, 4); Assert.AreEqual("R7C4", cell_r7c4.ToString());
            Cell cell_r7c5 = b.GetCell_DiagonalBottomLeft(7, 5); Assert.AreEqual("R7C5", cell_r7c5.ToString());
            Cell cell_r7c6 = b.GetCell_DiagonalBottomLeft(7, 6); Assert.AreEqual("R7C6", cell_r7c6.ToString());
            Cell cell_r7c7 = b.GetCell_DiagonalBottomLeft(7, 7); Assert.AreEqual("R7C7", cell_r7c7.ToString());
            #endregion
        }

        [Test]
        public void Test_SetQueen_InCell()
        {
            Board b = new Board();

            b.SetQueen(1, 1);

            Assert.IsTrue(b.GetCell(0, 0).IsEmptyType());
            Assert.IsTrue(b.GetCell(1, 1).IsQueenType());
            Assert.IsTrue(b.GetCell(0, 0).IsEmptyType());
        }

        [Test]
        public void Test_SetQueen_R3_C3_SecondSetQueen_R2_C4_CellPosition_To_TopRight_InvalidPosition()
        {
            Board b = new Board();

            bool ok = b.SetQueen(3, 3);
            Assert.IsTrue(ok);
            b.PrintBoard();

            ok = b.SetQueen(2, 4);
            Assert.IsFalse(ok);
            b.PrintBoard();

        }

        [Test]
        public void Test_SetQueen_R3_C3_SecondSetQueen_R1_C1_CellPosition_To_TopLeft_InvalidPosition()
        {
            Board b = new Board();

            bool ok = b.SetQueen(3, 3);
            Assert.IsTrue(ok);
            b.PrintBoard();

            ok = b.SetQueen(1, 1);
            Assert.IsFalse(ok);
            b.PrintBoard();

        }

        [Test]
        public void Test_SetQueen_R3_C3_SecondSetQueen_R6_C0_CellPosition_To_BottomLeft_InvalidPosition()
        {
            Board b = new Board();

            bool ok = b.SetQueen(3, 3);
            Assert.IsTrue(ok);
            b.PrintBoard();

            ok = b.SetQueen(6, 0);
            Assert.IsFalse(ok);
            b.PrintBoard();
        }

        [Test]
        public void Test_SetQueen_R3_C3_SecondSetQueen_R7_C7_CellPosition_To_BottomRight_InvalidPosition()
        {
            Board b = new Board();

            bool ok = b.SetQueen(3, 3);
            Assert.IsTrue(ok);
            b.PrintBoard();

            ok = b.SetQueen(7, 7);
            Assert.IsFalse(ok);
            b.PrintBoard();
        }
    
        [Test]
        public void Test_SetQueen_RellenarTablerosDondeSePuedanPonerLasReinas_Secuencialmente()
        {
            Board b = new Board();

            for (int rI = 0; rI < b.CountRows; rI++)
            {
                for (int cI = 0; cI < b.CountColumns; cI++)
                {
                    b = new Board();
                    Debug.WriteLine("__________________ RI" + rI + "CI" + cI + "_________________");

                    int I_ROW = rI;
                    int I_COL = cI;

                    b.SetQueen(I_ROW, I_COL);
                    for (int r = 0; r < b.CountRows; r++)
                    {
                        for (int c = 0; c < b.CountColumns; c++)
                        {
                            if ((r == I_ROW) && (c == I_ROW))
                            {
                                Debug.Write(" R" + r + "C" + c + ",");
                                continue;
                            }
                            if (b.SetQueen(r, c))
                                Debug.Write(" R" + r + "C" + c);
                            else
                                Debug.Write("!R" + r + "C" + c);

                            Debug.Write(",");
                        }
                        Debug.WriteLine("");
                    }
                    b.PrintBoard();
                    Debug.WriteLine("Queens: " + b.GetQueensCount());
                    Debug.WriteLine("_______________________________________________");
                }
            }
        }
    }
}