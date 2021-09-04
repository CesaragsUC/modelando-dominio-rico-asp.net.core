﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NerdScore.Core.Messages
{
    public abstract class Message
    {
        public  string MessageType { get; protected set; }   
        public Guid AggregateId {  get; protected set; }

        public Message()
        {
            MessageType = GetType().Name;
        }
    }
}
