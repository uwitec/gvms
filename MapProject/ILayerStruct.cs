using System;
using System.Collections.Generic;
using System.Text;

namespace MapProject
{   
    public interface ILayerStruct
    {   
        string DataSetName { get;set;}

        string AliasName { get;set;}

        string FileName { get;set;}

        double MaxLevel { get;set;}

        double MinLevel { get;set;}

        short LayerType { get;set;}

        bool Visible { get;set;}
    }
}
