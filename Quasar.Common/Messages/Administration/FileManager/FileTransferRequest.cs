﻿using ProtoBuf;
using Quasar.Common.Messages.other;

namespace Quasar.Common.Messages
{
    [ProtoContract]
    public class FileTransferRequest : IMessage
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string RemotePath { get; set; }
    }
}
