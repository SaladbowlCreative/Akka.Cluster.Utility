﻿using System;

namespace Akka.Cluster.Utility
{
    public interface IIdGenerator
    {
        Type IdType { get; }
        void Initialize(object[] args);
        object GenerateId();
    }
}