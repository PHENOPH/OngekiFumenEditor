﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OngekiFumenEditor.Base.OngekiObjects.ConnectableObject
{
    public abstract class ConnectableObjectBase : OngekiMovableObjectBase
    {
        public abstract int RecordId { get; set; }

        public override string ToString() => $"id:{RecordId} {base.ToString()}";

        public override void Copy(OngekiObjectBase fromObj, OngekiFumen fumen)
        {
            base.Copy(fromObj, fumen);

            if (fromObj is not ConnectableObjectBase from)
                return;

            RecordId = from.RecordId;
        }
    }
}
