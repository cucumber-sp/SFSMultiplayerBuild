using ProtoBuf;
using System.Collections.Generic;
using SFSMultiplayerBuild.Types.Structs;

namespace SFSMultiplayerBuild.Types;

[ProtoContract]
public class PartSave
{
    [ProtoMember(1)]
    public int Id { get; set; }

    [ProtoMember(2)] public string PartName { get; set; } = "null";
    
    [ProtoMember(3)]
    public Vector2 Position { get; set; }
    
    [ProtoMember(4)]
    public Vector3 Orientation { get; set; }
    
    [ProtoMember(5)]
    public float Temperature { get; set; } = float.NegativeInfinity;
    
    [ProtoMember(6)]
    public Dictionary<string, double>? NumberVariables { get; set; }
    
    [ProtoMember(7)]
    public Dictionary<string, bool>? BoolVariables { get; set; }
    
    [ProtoMember(8)]
    public Dictionary<string, string>? TextVariables { get; set; }
    
    [ProtoMember(9)]
    public Burnmark Burns { get; set; }
}