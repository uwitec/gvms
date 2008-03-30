using System;
using System.Collections.Generic;
using System.Text;
using System.Data;


namespace MapConfigure.CustomControl
{
    class StyleListTableTemplate: DataTable
    {
        public StyleListTableTemplate()
        {
            DataColumn colSymbolColor = new DataColumn("SymbolColor", typeof(System.Drawing.Image));
            colSymbolColor.Caption = "ÑÕÉ«";

            DataColumn colValue = new DataColumn("Value", typeof(String));
            colValue.Caption = "Öµ";
            
        }
        
    }
}
