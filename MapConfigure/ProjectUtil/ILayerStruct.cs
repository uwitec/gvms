using System;
using System.Collections.Generic;
using System.Text;

namespace MapConfigure.ProjectUtil
{
    interface ILayerStruct
    {
        string Name { get;set;}

        string FileName { get;set;}

        double MaxLevel { get;set;}

        double MinLevel { get;set;}

        short LayerType { get;set;}
    }
}
