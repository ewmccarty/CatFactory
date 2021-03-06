﻿namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a line of code for a programming language
    /// </summary>
    public class CodeLine : Line
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CodeLine"/> class
        /// </summary>
        public CodeLine()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CodeLine"/> class
        /// </summary>
        /// <param name="tabs">Tabs</param>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public CodeLine(int tabs, string content, params string[] values)
            : base(tabs, content, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CodeLine"/> class
        /// </summary>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public CodeLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
