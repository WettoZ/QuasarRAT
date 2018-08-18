﻿using System.Collections.Generic;
using ProtoBuf;
using Quasar.Common.Video;

namespace Quasar.Common.Packets
{
    [ProtoContract]
    public class GetWebcamsResponse : IPacket
    {
        [ProtoMember(1)]
        public Dictionary<string, List<Resolution>> Webcams { get; set; }
    }
}
