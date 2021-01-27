
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class PressBottle : UdonSharpBehaviour
{
    public Animator bottle;

    public override void Interact()
    {
        bottle.SetBool("startAnimation", true);
        
    }

    public void stopAnimation()
    {
        bottle.SetBool("startAnimation", false);
    }
}
