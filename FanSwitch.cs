
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class FanSwitch : UdonSharpBehaviour
{
    public Animator[] fanObjects;

    void Start()
    {
        
    }

    public override void Interact()
    {
        foreach (Animator fan in fanObjects)
        {
            fan.enabled = !fan.enabled;
        }
    }
}

