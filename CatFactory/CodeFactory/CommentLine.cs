﻿namespace CatFactory.CodeFactory
{
    /// <summary>
    /// Represents a line of comment for a programming language
    /// </summary>
    public class CommentLine : Line
    {
        /// <summary>
        /// Initializes a new instance of <see cref="CommentLine"/> class
        /// </summary>
        public CommentLine()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CommentLine"/> class
        /// </summary>
        /// <param name="tabs">Tabs</param>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public CommentLine(int tabs, string content, params string[] values)
            : base(tabs, content, values)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="CommentLine"/> class
        /// </summary>
        /// <param name="content">Line content</param>
        /// <param name="values">An object array that contains zero or more objects to format</param>
        public CommentLine(string content, params string[] values)
            : base(content, values)
        {
        }
    }
}
