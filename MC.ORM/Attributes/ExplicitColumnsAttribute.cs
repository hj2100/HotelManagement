﻿using System;


namespace MC.ORM
{
    /// <summary>
    ///     Represents the attribute which decorates a poco class to state all columns must be explicitly mapped using either a
    ///     <seealso cref="ColumnAttribute" /> or <seealso cref="ResultColumnAttribute" />.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class ExplicitColumnsAttribute : Attribute
    {
    }
}
