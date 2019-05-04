﻿using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    public class CVector2D : CVariable
    {
        public string type = "CVector2D";
        public CFloat x, y;

        public CVector2D(CR2WFile cr2w = null)
            : base(cr2w)
        {
            x = new CFloat(null) { Name = "x", Type = "Float" };
            y = new CFloat(null) { Name = "y", Type = "Float" };
        }

        public void Read(BinaryReader file)
        {
            x.val = file.ReadSingle();
            y.val = file.ReadSingle();
        }

        public override void Read(BinaryReader file, uint size)
        {
            x.Read(file, size);
            y.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            x.Write(file);
            y.Write(file);
        }

        public override CVariable SetValue(object val)
        {
            return this;
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CVector3D(cr2w);
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            var var = base.Copy(context) as CVector2D;
            var.type = type;
            var.x.val = x.val;
            var.y.val = y.val;
            return var;
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            var vars = new List<IEditableVariable>();
            vars.Add(x);
            vars.Add(y);
            return vars;
        }

        public override string ToString()
        {
            return "CVector2D";
        }
    }
}