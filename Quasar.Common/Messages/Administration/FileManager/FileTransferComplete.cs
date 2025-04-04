﻿using ProtoBuf;
using Quasar.Common.Messages.other;

namespace Quasar.Common.Messages.Administration.FileManager
{
    [ProtoContract]
    public class FileTransferComplete : IMessage
    {
        [ProtoMember(1)]
        public int Id { get; set; }

        [ProtoMember(2)]
        public string FilePath { get; set; }
    }
}
