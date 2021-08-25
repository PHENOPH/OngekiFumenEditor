﻿using OngekiFumenEditor.Base;
using OngekiFumenEditor.Base.OngekiObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngekiFumenEditor.Parser.CommandParserImpl
{
    [Export(typeof(ICommandParser))]
    public class BpmCommandParser : ICommandParser
    {
        public string CommandLineHeader => BPM.CommandName;

        public OngekiObjectBase Parse(CommandArgs args, OngekiFumen fumen)
        {
            var dataArr = args.GetDataArray<float>();
            var bpm = new BPM();

            bpm.TGrid.Unit = dataArr[1];
            bpm.TGrid.Grid = (int)dataArr[2];
            bpm.Value = dataArr[3];

            return bpm;
        }
    }
}