﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Fields
{
    public class StringField:Field<string>
    {       
        public StringField(string rawValue, int length): base(rawValue, length)
        {           
        }

        public override string FormattedValue => RawValue.PadRight(Length, SpacePadChar);
    }
}
