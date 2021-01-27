
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class MirrorSwitch : UdonSharpBehaviour
{
    public GameObject currentMirrorSwitch;
    public GameObject otherMirrorSwitch;
    public GameObject currentMirror;
    public GameObject otherMirror;

    public override void Interact()
    {
        if (currentMirrorSwitch.activeSelf) // If the current Mirror is currently on (i.e player wants to turn off mirror)
        {
            currentMirrorSwitch.SetActive(false);
            currentMirror.SetActive(false);
        }

        else if (otherMirrorSwitch.activeSelf) // If the other Mirror is currently on (i.e player wants to switch from other Mirror to this one)
        {
            currentMirrorSwitch.SetActive(true);
            otherMirrorSwitch.SetActive(false);
            currentMirror.SetActive(true);
            otherMirror.SetActive(false);
        }

        else if (!currentMirrorSwitch.activeSelf && !otherMirrorSwitch.activeSelf)  // If both this Mirror and other Mirror are off (i.e player wants to turn on this Mirror)
        {
            currentMirrorSwitch.SetActive(true);
            currentMirror.SetActive(true);
        }
    }
}
