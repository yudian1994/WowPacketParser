using WowPacketParser.Enums;
using WowPacketParser.Hotfix;

namespace WowPacketParserModule.V7_0_3_22248.Hotfix
{
    [HotfixStructure(DB2Hash.ItemAppearance, HasIndexInData = false)]
    public class ItemAppearanceEntry
    {
        public uint DisplayID { get; set; }
        public uint IconFileDataID { get; set; }
        public uint UIOrder { get; set; }
        public byte ObjectComponentSlot { get; set; }
    }
}