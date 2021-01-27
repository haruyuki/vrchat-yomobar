
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MirrorSwitchSingle : UdonSharpBehaviour
{
    public GameObject Mirror;
    public GameObject offSwitch;
    public GameObject onSwitch;

    public override void Interact()
    {
        if (Mirror.activeSelf) // If Mirror is on
        {
            Mirror.SetActive(false);
            offSwitch.SetActive(true);
            onSwitch.SetActive(false);
        }
        else // If Mirror is off
        {
            Mirror.SetActive(true);
            offSwitch.SetActive(false);
            onSwitch.SetActive(true);
        }
    }
}
