
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class InteractTeleport : UdonSharpBehaviour
{
    private VRCPlayerApi _playerLocal;
    public Transform teleportLocation;

    void Start()
    {
        _playerLocal = Networking.LocalPlayer;
    }

    public override void Interact()
    {
        _playerLocal.TeleportTo(teleportLocation.position, _playerLocal.GetRotation());
    }
}
