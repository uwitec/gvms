using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace MapConfigure.LayerProperties
{
    class FieldsStructTableTemplate : System.Data.DataTable
    {
        public FieldsStructTableTemplate()
        {
            DataColumn colFieldName = new DataColumn("FieldName", typeof(String));
            colFieldName.Caption = "字段名称";

            DataColumn colFieldLength = new DataColumn("FieldLength", typeof(Int32));
            colFieldLength.Caption = "字段长度";

            DataColumn colFieldType = new DataColumn("FieldType", typeof(String));
            colFieldType.Caption = "字段类型";

            this.Columns.AddRange(new DataColumn[] { colFieldName, colFieldLength, colFieldType });
        }
    }
}
