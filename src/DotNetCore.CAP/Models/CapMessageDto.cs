﻿using System;
using DotNetCore.CAP.Infrastructure;

namespace DotNetCore.CAP.Models
{
    public class CapMessageDto
    {
        public CapMessageDto()
        {
            Id = ObjectId.GenerateNewStringId();
            Timestamp = DateTime.Now;
        }

        public CapMessageDto(object content) : this()
        {
            Content = content;
        }

        public virtual string Id { get; set; }

        public virtual DateTime Timestamp { get; set; }

        public virtual object Content { get; set; }

        public virtual string CallbackName { get; set; }
    }
}