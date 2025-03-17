﻿using ProtoBuf;
using Quasar.Common.Messages.other;

namespace Quasar.Common.Messages.Monitoring.Clipboard
{
    [ProtoContract]
    public class DoGetAddress : IMessage
    {
        [ProtoMember(1)]
        public string Type { get; set; }
    }
}
