﻿using Microsoft.Http2.Protocol.Framing;

namespace Microsoft.Http2.Protocol.IO
{
    internal class QueueEntry : IQueueItem
    {
        private readonly Frame _frame;
      
        public QueueEntry(Frame frame)
        {
            _frame = frame;
        }

        public bool IsFlush { get { return _frame == null; } }

        public Frame Frame { get { return _frame; } }

        public byte[] Buffer { get { return (_frame != null) ? _frame.Buffer : null; } }
    }
}