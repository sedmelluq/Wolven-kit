using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class SParticleEmitterSomething : CVariable
    {
        public CVariable[] fields;
        public CBuffer<CFloat> p000, p018, p034, p04C, p08C, p098, p118, p124, p134, p164, p170, p17C, p1AC, p1D0, p1E8, p1FC, p208;
        public CBuffer<CVector3D> p00C, p024, p040, p058, p070, p080, p108, p14C, p158, p188, p194, p1A0, p1C4, p1DC, p218;
        public CBuffer<CVector2D> p064, p1B8;
        public CFloat p1F4, p1F8, p214;
        public CUInt32 p030, p140, p144, p148, p224, p238, p23C, p240, p244, p24C, p258, p25C;
        public CInt32 p228, p254;
        public CUInt8 p07C, p0A4, p0A5, p100, p101, p102, p103, p104, p105, p106, p114, p130, p248, p249, p250;
        public CVector3D p0A8;
        public CUInt64 p230;
        public CMatrix4x4 p0C0;

        public SParticleEmitterSomething(CR2WFile cr2w) : base(cr2w)
        {
            fields = new CVariable[] {
                p000 = CBuffers.CreateFloatBuffer(cr2w, "p000"),
                p00C = CBuffers.CreateVector3DBuffer(cr2w, "p00C"),
                p018 = CBuffers.CreateFloatBuffer(cr2w, "p018"),
                p024 = CBuffers.CreateVector3DBuffer(cr2w, "p024"),
                p030 = new CUInt32(cr2w) { Name = "p030", Type = "CUInt32" },
                p034 = CBuffers.CreateFloatBuffer(cr2w, "p034"),
                p040 = CBuffers.CreateVector3DBuffer(cr2w, "p040"),
                p04C = CBuffers.CreateFloatBuffer(cr2w, "p04C"),
                p058 = CBuffers.CreateVector3DBuffer(cr2w, "p058"),
                p064 = CBuffers.CreateVector2DBuffer(cr2w, "p064"),
                p070 = CBuffers.CreateVector3DBuffer(cr2w, "p070"),
                p07C = new CUInt8(cr2w) { Name = "p07C", Type = "CUInt8" },
                p080 = CBuffers.CreateVector3DBuffer(cr2w, "p080"),
                p08C = CBuffers.CreateFloatBuffer(cr2w, "p08C"),
                p098 = CBuffers.CreateFloatBuffer(cr2w, "p098"),
                p0A4 = new CUInt8(cr2w) { Name = "p0A4", Type = "CUInt8" },
                p0A5 = new CUInt8(cr2w) { Name = "p0A5", Type = "CUInt8" },
                p0A8 = new CVector3D(cr2w) { Name = "p0A8", Type = "CVector3D" },
                p0C0 = new CMatrix4x4(cr2w) { Name = "p0C0", Type = "CMatrix4x4" },
                p108 = CBuffers.CreateVector3DBuffer(cr2w, "p108"),
                p114 = new CUInt8(cr2w) { Name = "p114", Type = "CUInt8" },
                p118 = CBuffers.CreateFloatBuffer(cr2w, "p118"),
                p124 = CBuffers.CreateFloatBuffer(cr2w, "p124"),
                p130 = new CUInt8(cr2w) { Name = "p130", Type = "CUInt8" },
                p134 = CBuffers.CreateFloatBuffer(cr2w, "p134"),
                p140 = new CUInt32(cr2w) { Name = "p140", Type = "CUInt32" },
                p144 = new CUInt32(cr2w) { Name = "p144", Type = "CUInt32" },
                p148 = new CUInt32(cr2w) { Name = "p148", Type = "CUInt32" },
                p14C = CBuffers.CreateVector3DBuffer(cr2w, "p14C"),
                p158 = CBuffers.CreateVector3DBuffer(cr2w, "p158"),
                p164 = CBuffers.CreateFloatBuffer(cr2w, "p164"),
                p170 = CBuffers.CreateFloatBuffer(cr2w, "p170"),
                p17C = CBuffers.CreateFloatBuffer(cr2w, "p17C"),
                p188 = CBuffers.CreateVector3DBuffer(cr2w, "p188"),
                p194 = CBuffers.CreateVector3DBuffer(cr2w, "p194"),
                p1A0 = CBuffers.CreateVector3DBuffer(cr2w, "p1A0"),
                p1AC = CBuffers.CreateFloatBuffer(cr2w, "p1AC"),
                p1B8 = CBuffers.CreateVector2DBuffer(cr2w, "p1B8"),
                p1C4 = CBuffers.CreateVector3DBuffer(cr2w, "p1C4"),
                p1D0 = CBuffers.CreateFloatBuffer(cr2w, "p1D0"),
                p1DC = CBuffers.CreateVector3DBuffer(cr2w, "p1DC"),
                p1E8 = CBuffers.CreateFloatBuffer(cr2w, "p1E8"),
                p1F4 = new CFloat(cr2w) { Name = "p1F4", Type = "CFloat" },
                p1F8 = new CFloat(cr2w) { Name = "p1F8", Type = "CFloat" },
                p1FC = CBuffers.CreateFloatBuffer(cr2w, "p1FC"),
                p208 = CBuffers.CreateFloatBuffer(cr2w, "p208"),
                p214 = new CFloat(cr2w) { Name = "p214", Type = "CFloat" },
                p218 = CBuffers.CreateVector3DBuffer(cr2w, "p218"),
                p100 = new CUInt8(cr2w) { Name = "p100", Type = "CUInt8" },
                p101 = new CUInt8(cr2w) { Name = "p101", Type = "CUInt8" },
                p102 = new CUInt8(cr2w) { Name = "p102", Type = "CUInt8" },
                p103 = new CUInt8(cr2w) { Name = "p103", Type = "CUInt8" },
                p104 = new CUInt8(cr2w) { Name = "p104", Type = "CUInt8" },
                p105 = new CUInt8(cr2w) { Name = "p105", Type = "CUInt8" },
                p106 = new CUInt8(cr2w) { Name = "p106", Type = "CUInt8" },
                p230 = new CUInt64(cr2w) { Name = "p230", Type = "CUInt64" },
                p238 = new CUInt32(cr2w) { Name = "p238", Type = "CUInt32" },
                p23C = new CUInt32(cr2w) { Name = "p23C", Type = "CUInt32" },
                p240 = new CUInt32(cr2w) { Name = "p240", Type = "CUInt32" },
                p244 = new CUInt32(cr2w) { Name = "p244", Type = "CUInt32" },
                p248 = new CUInt8(cr2w) { Name = "p248", Type = "CUInt8" },
                p249 = new CUInt8(cr2w) { Name = "p249", Type = "CUInt8" },
                p24C = new CUInt32(cr2w) { Name = "p24C", Type = "CUInt32" },
                p250 = new CUInt8(cr2w) { Name = "p250", Type = "CUInt8" },
                p254 = new CInt32(cr2w) { Name = "p254", Type = "CInt32" },
                p224 = new CUInt32(cr2w) { Name = "p224", Type = "CUInt32" },
                p228 = new CInt32(cr2w) { Name = "p228", Type = "CInt32" },
                p258 = new CUInt32(cr2w) { Name = "p258", Type = "CUInt32" },
                p25C = new CUInt32(cr2w) { Name = "p25C", Type = "CUInt32" }
            };
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new SParticleEmitterSomething(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(fields);
        }

        public override void Read(BinaryReader file, uint size)
        {
            foreach (var variable in fields)
            {
                variable.Read(file, size);
            }
        }

        public override void Write(BinaryWriter file)
        {
            foreach (var variable in fields)
            {
                variable.Write(file);
            }
        }

        public override CVariable Copy(CR2WCopyAction context)
        {
            return CR2WReaderExtensions.CopyViaBuffer(this, base.Copy(context));
        }
    }
}
