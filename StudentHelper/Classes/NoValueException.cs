﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace StudentHelper
{
    public class NoValueException : Exception
    {
        public NoValueException(string message) : base(message)
        {
            MessageBox.Show(message);
        }
    }
}