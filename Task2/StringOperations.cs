﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    /// <summary>
    /// Provides additional tools for handling with strings
    /// </summary>

    public static class StringOperations
    {
        /// <summary>
        /// Concatenates two strings that contain symbols from 'a' to 'z' in alphabetical order with removing duplicate symbols
        /// </summary>
        /// <param name="firstString">The first string for concatenation</param>
        /// <param name="secondString">The second string for concatenation</param>
        /// <returns>Alphabetically sorted string without duplicate symbols</returns>
        /// <exception cref="NullReferenceException"></exception>
        public static string Longest(string firstString, string secondString)
        {
            if (firstString == null || secondString == null) throw new NullReferenceException();

            firstString = String.Concat(firstString, secondString);
            if (!firstString.All(Char.IsLetter) || secondString.Any(Char.IsUpper)) return null;

            string answer = new String(firstString.Distinct().ToArray());
            char[] result = answer.ToCharArray();
            Array.Sort(result);
            return new String(result);
        }
    }
}
