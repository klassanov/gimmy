﻿using FilesHelper.Fields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static FilesHelper.Movago.MovagoEnums;

namespace FilesHelper.Movago
{
    public abstract class MovagoRecordEstremo: MovagoRecord
    {
        //public override string CodTipoRec { get => "I"; set => base.CodTipoRec = value; }
        public int CFCSOGG { get; set; }
        public TipoProgressivoScheda CFNPROGVSCH { get; set; }
        public int NumSped { get; set; }
        public DateTime DataSpeed { get; set; }
        public string AppReg { get; set; }

        protected override void AddFieldsToList()
        {
            base.AddFieldsToList();
            this.FieldsList.AddRange(
               new List<IField>()
               {
                    CreateField(CFCSOGG, 15),
                    CreateField((int) CFNPROGVSCH, 1),
                    CreateField(StrFiller,6),
                    CreateField(NumSped,10),
                    CreateField(DataSpeed),
                    CreateField(AppReg, 5),
                    CreateField(StrFiller, 254)
               }
           );
        }
    }
}
