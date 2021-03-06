﻿
namespace MC.ORM.Core
{
    public class AnsiString
    {
        /// <summary>
        ///     The string value
        /// </summary>
        public string Value { get; private set; }

        /// <summary>
        ///     Constructs an AnsiString
        /// </summary>
        /// <param name="str">The C# string to be converted to ANSI before being passed to the DB</param>
        public AnsiString(string str)
        {
            Value = str;
        }
    }
}
