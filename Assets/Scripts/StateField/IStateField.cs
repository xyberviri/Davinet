﻿using LiteNetLib.Utils;

public interface IStateField
{
    void Write(NetDataWriter writer);
    void Read(NetDataReader reader);
    void Pass(NetDataReader reader);

    bool IsDirty { get; set; }
}