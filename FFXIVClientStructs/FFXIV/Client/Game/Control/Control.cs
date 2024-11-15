using FFXIVClientStructs.FFXIV.Client.Game.Character;
using FFXIVClientStructs.FFXIV.Common.Math;

namespace FFXIVClientStructs.FFXIV.Client.Game.Control;

// Client::Game::Control::Control
[GenerateInterop]
[StructLayout(LayoutKind.Explicit, Size = 0x7655)]
public unsafe partial struct Control {
    [FieldOffset(0x00)] public CameraManager CameraManager;
    [FieldOffset(0x180)] public TargetSystem TargetSystem;

    [FieldOffset(0x7603)] public bool IsWalking;
    [FieldOffset(0x7668)] public uint LocalPlayerEntityId;
    [FieldOffset(0x7670)] public BattleChara* LocalPlayer;
    [FieldOffset(0x7680)] public Matrix4x4 ViewProjectionMatrix;

    [StaticAddress("4C 8D 35 ?? ?? ?? ?? 48 8B 09", 3)]
    public static partial Control* Instance();

    [StaticAddress("48 8B 2D ?? ?? ?? ?? 75", 3, true)]
    public static partial BattleChara* GetLocalPlayer(); // g_Client::Game::Control::Control_LocalPlayer
}
