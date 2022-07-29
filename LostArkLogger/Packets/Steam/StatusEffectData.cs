using System;
using System.Collections.Generic;
namespace LostArkLogger
{
    public partial class StatusEffectData
    {
        public void SteamDecode(BitReader reader)
        {
            StatusEffectId = reader.ReadUInt32();
            hasValue = reader.ReadByte();
            if (hasValue == 1)
                Value = reader.ReadBytes(16);
            s64_0 = reader.ReadSimpleInt();
            u32_0 = reader.ReadUInt32();
            EffectInstanceId = reader.ReadUInt32();
            InstanceId = reader.ReadUInt64();
            bytearraylist_0 = reader.ReadList<Byte[]>(7);
            SourceId = reader.ReadUInt64();
            b_2 = reader.ReadByte();
            if (b_2 == 1)
                s64_1 = reader.ReadUInt64();
            b_1 = reader.ReadByte();
            SkillLevel = reader.ReadByte();
        }
    }
}
