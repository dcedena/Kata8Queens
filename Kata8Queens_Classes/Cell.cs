using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata8Queens_Classes
{
    public class Cell
    {
        public enum CellType
        {
            Empty,
            QUEEN
        }

        #region Atributos
        private CellType _cellType;

        public readonly int Column;
        public readonly int Row;

        public string Texto = "";

        #endregion

        #region CONSTRUCTORS
        public Cell()
        {
            _cellType = Kata8Queens_Classes.Cell.CellType.Empty;
            this.Column = 0;
            this.Row = 0;
        }

        public Cell(int row, int column) : this()
        {
            this.Row = row;
            this.Column = column;
        }

        public Cell(int row, int column, CellType cellType) : this(row, column)
        {
            this._cellType = cellType;
        }
        #endregion

        #region FUNCTIONS
        public override string ToString()
        {
            return "R" + Row + "C" + Column;
        }

        public bool IsEmptyType()
        {
            return (this._cellType == CellType.Empty);
        }

        public bool IsQueenType()
        {
            return (this._cellType == CellType.QUEEN);
        }

        public void SetEmptyType()
        {
            this._cellType = CellType.Empty;
        }

        public void SetQueenType()
        {
            this._cellType = CellType.QUEEN;
        }
        #endregion
    }
}