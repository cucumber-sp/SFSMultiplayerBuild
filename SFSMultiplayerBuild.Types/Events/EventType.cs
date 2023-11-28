namespace SFSMultiplayerBuild.Types.Events;

public enum EventType
{
    PlayerJoined,
    PlayerLeft,
    PlayerCursorPositionChanged,
    PartsCreated,
    PartsDestroyed,
    PartsChanged,
    PartLocked,
    PartUnlocked,
    BuildCleared,
}