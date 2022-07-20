using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class StatusEffectData
    {
        public void KoreaDecode(BitReader reader)
        {
            hasValue = reader.ReadByte();
            if (hasValue == 1)
                Value = reader.ReadBytes(16);
            b_0 = reader.ReadByte();
            if (b_0 == 1)
                SourceId = reader.ReadUInt64();
            b_1 = reader.ReadByte();
            s64_0 = reader.ReadSimpleInt();
            EffectInstanceId = reader.ReadUInt32();
            InstanceId = reader.ReadUInt64();
            SkillLevel = reader.ReadByte();
            bytearraylist_0 = reader.ReadList<Byte[]>(7);
            StatusEffectId = reader.ReadUInt32();
            u32_0 = reader.ReadUInt32();
        }
    }
}
