﻿using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesHelper.Movago
{
    public class MovagoRecordIniziale : MovagoRecordEstremo
    {
        public override string CodTipoRec { get => "I"; set => base.CodTipoRec = value; }
    }
}
