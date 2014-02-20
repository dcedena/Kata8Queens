using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Kata8Queens_Classes
{
    public class Board
    {
        public int CountRows = 8;
        public int CountColumns = 8;

        private List<List<Cell>> _cells;

        #region Error Management
        private Exception _error;
        public Exception GetError()
        {
            return _error;
        }

        private void ClearError()
        {
            _error = null;
        }

        private void SetError(Exception err)
        {
            _error = err;
        }
        #endregion

        public Board()
        {
            Initialization();
        }

        private void Initialization()
        {
            this._cells = new List<List<Cell>>();
            
            for(int r=0;r<CountRows;r++)
            {
                this._cells.Add(new List<Cell>());
                for(int c=0;c<CountColumns;c++)
                {
                    this._cells[this._cells.Count - 1].Add(new Cell(r, c));
                }
            }
        }

        public bool SetEmpty(int numRow, int numColumn)
        {
            ClearError();
            try
            {
                _cells[numRow][numColumn] = new Cell(numRow, numColumn, Cell.CellType.Empty);
                return true;
            }
            catch (Exception err)
            {
                SetError(err);
                return false;
            }
        }
        
        public bool SetQueen(int numRow, int numColumn)
        {
            ClearError();
            try
            {
                bool result = true;

                bool okInRow = ExistAnotherQueenInRow(numRow);
                bool okInColumn = ExistAnotherQueenInColumn(numColumn);
                bool okInDiagonalTopLeft = ExistAnotherQueenInDiagonal_TopLeftToBottomRight(numRow, numColumn);
                bool okInDiagonalTopRight = ExistAnotherQueenInDiagonal_TopRightToBottomLeft(numRow, numColumn);

                if(!okInRow && !okInColumn && !okInDiagonalTopLeft && !okInDiagonalTopRight)
                {
                    _cells[numRow][numColumn] = new Cell(numRow, numColumn, Cell.CellType.QUEEN);
                    result = true;
                }
                else
                    result = false;

                return result;
            }
            catch (Exception err)
            {
                SetError(err);
                return false;
            }
        }

        private bool ExistAnotherQueenInRow(int numRow)
        {
            bool result = false;
            for(int c=0;c<CountColumns;c++)
            {
                if(_cells[numRow][c].IsQueenType())
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private bool ExistAnotherQueenInColumn(int numColumn)
        {
            bool result = false;
            for (int r = 0; r < CountRows; r++)
            {
                if (_cells[r][numColumn].IsQueenType())
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        private bool ExistAnotherQueenInDiagonal_TopLeftToBottomRight(int numRow, int numColumn)
        {
            bool result = false;

            // Comprobar en la diagonal la existencia de una reina.
            Cell cellInitial = GetCell_DiagonalTopLeft(numRow, numColumn);
            Cell cellFinal = GetCell_DiagonalBottomRight(numRow, numColumn);

            int countCells = 0;
            // Recorrer de cellInitial a cellFinal en diagonal
            int r = cellInitial.Row;
            for (int c = cellInitial.Column; c <= cellFinal.Column; c++)
            {
                if (_cells[r][c].IsQueenType())
                {
                    result = true;
                    break;
                }
                r++;
                countCells++;
            }

            return result;
        }

        private bool ExistAnotherQueenInDiagonal_TopRightToBottomLeft(int numRow, int numColumn)
        {
            bool result = false;

            // Comprobar en la diagonal la existencia de una reina.
            Cell cellInitial = GetCell_DiagonalTopRight(numRow, numColumn);
            Cell cellFinal = GetCell_DiagonalBottomLeft(numRow, numColumn);

            int countCells = 0;
            // Recorrer de cellInitial a cellFinal en diagonal
            int r = cellInitial.Row;
            for (int c = cellInitial.Column; c >= cellFinal.Column; c--)
            {
                if (_cells[r][c].IsQueenType())
                {
                    result = true;
                    break;
                }
                r++;
                countCells++;
            }

            return result;
        }

        public Cell GetCell_DiagonalTopLeft(int numRow, int numColumn)
        {
            #region Obtener Esquina Superior Izquierda
            int initialRow = -1;
            int initialColumn = -1;

            if ((numRow > 0) && (numColumn > 0))
            {
                initialRow = numRow;
                initialColumn = numColumn;

                while((initialRow > 0) && (initialColumn > 0))
                {
                    initialRow--;
                    initialColumn--;
                }
            }

            Cell result = null;
            if ((initialRow == -1) || (initialColumn == -1))
                result = new Cell(numRow, numColumn);
            else
                result = new Cell(initialRow, initialColumn);

            return result;
            #endregion
        }

        public Cell GetCell_DiagonalBottomRight(int numRow, int numColumn)
        {
            #region Obtener Esquina Inferior Derecha
            int initialRow = CountRows;
            int initialColumn = CountColumns;

            if ((numRow < CountRows - 1) && (numColumn < CountColumns - 1))
            {
                initialRow = numRow;
                initialColumn = numColumn;

                while ((initialRow < CountRows - 1) && (initialColumn < CountColumns - 1))
                {
                    initialRow++;
                    initialColumn++;
                }
            }

            Cell result = null;
            if ((initialRow == CountRows) || (initialColumn == CountColumns))
                result = new Cell(numRow, numColumn);
            else
                result = new Cell(initialRow, initialColumn);

            return result;
            #endregion
        }

        public Cell GetCell_DiagonalTopRight(int numRow, int numColumn)
        {
            #region Obtener Esquina Superior Derecha
            int initialRow = -1;
            int initialColumn = CountColumns;

            if((numRow > 0) && (numColumn < CountColumns - 1))
            {
                initialRow = numRow;
                initialColumn = numColumn;

                while ((initialRow > 0) && (initialColumn < CountColumns - 1))
                {
                    initialRow--;
                    initialColumn++;
                }
            }

            Cell result = null;
            if((initialRow == -1) || (initialColumn == CountColumns))
                result = new Cell(numRow, numColumn);
            else
                result = new Cell(initialRow, initialColumn);

            return result;
            #endregion
        }

        public Cell GetCell_DiagonalBottomLeft(int numRow, int numColumn)
        {
            #region Obtener Esquina Inferior Izquierda
            int initialRow = CountRows;
            int initialColumn = -1;

            if((numRow < CountRows - 1) && (numColumn > 0))
            {
                initialRow = numRow;
                initialColumn = numColumn;

                while((initialRow < CountRows - 1) && (initialColumn > 0))
                {
                    initialRow++;
                    initialColumn--;
                }
            }

            Cell result = null;
            if((initialRow == CountRows) || (initialColumn == -1))
                result = new Cell(numRow, numColumn);
            else
                result = new Cell(initialRow, initialColumn);

            return result;
            #endregion
        }

        public Cell GetCell(int numRow, int numColumn)
        {
            return _cells[numRow][numColumn];
        }

        public void PrintBoard()
        {
            for (int r = 0; r < this.CountRows; r++)
            {
                for (int c = 0; c < this.CountColumns; c++)
                {
                    Debug.Write(" " + (_cells[r][c].IsQueenType() ? "Q" : "·") + " ");
                }
                Debug.WriteLine("");
            }
            Debug.WriteLine("________________________");
        }

        public int GetQueensCount()
        {
            int count = 0;
            for (int r = 0; r < this.CountRows; r++)
            {
                for (int c = 0; c < this.CountColumns; c++)
                {
                    if (this.GetCell(r, c).IsQueenType())
                        count++;
                }
            }
            return count;
        }
    }
}
