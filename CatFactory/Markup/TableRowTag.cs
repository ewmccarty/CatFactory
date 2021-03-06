﻿using System.Collections.Generic;
using System.Diagnostics;

namespace CatFactory.Markup
{
    /// <summary>
    /// 
    /// </summary>
    public class TableRowTag : Tag
    {
        /// <summary>
        /// 
        /// </summary>
        public TableRowTag()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cells"></param>
        public TableRowTag(params string[] cells)
        {
            foreach (var item in cells)
            {
                Cells.Add(new TableCellTag(item));
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private List<TableCellTag> m_cells;

        /// <summary>
        /// 
        /// </summary>
        public List<TableCellTag> Cells
        {
            get
            {
                return m_cells ?? (m_cells = new List<TableCellTag>());
            }
            set
            {
                m_cells = value;
            }
        }
    }
}
