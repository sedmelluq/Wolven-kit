using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W.Editors;

namespace WolvenKit.CR2W.Types
{
    class CParticleEmitter : CVector
    {
        public SParticleEmitterSomething something;

        public CParticleEmitter(CR2WFile cr2w) : base(cr2w)
        {
            something = new SParticleEmitterSomething(cr2w) { Name = "something", Type = "SParticleEmitterSomething" };
        }

        public override void Read(BinaryReader file, uint size)
        {
            base.Read(file, size);
            something.Read(file, size);
        }

        public override void Write(BinaryWriter file)
        {
            base.Write(file);
            something.Write(file);
        }

        public override CVariable Create(CR2WFile cr2w)
        {
            return new CParticleEmitter(cr2w);
        }

        public override List<IEditableVariable> GetEditableVariables()
        {
            return new List<IEditableVariable>(variables)
            {
                something
            };
        }
    }
}
