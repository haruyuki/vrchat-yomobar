
using UdonSharp;
using UnityEngine;
using VRC.SDKBase;
using VRC.Udon;

public class ChairsToggle : UdonSharpBehaviour
{
    public MeshCollider[] Colliders;
    public GameObject offSwitch;
    public GameObject onSwitch;
    private bool isToggledOn;

    void Start()
    {
        isToggledOn = false;
    }

    public override void Interact()
    {
        foreach (MeshCollider collider in Colliders)
        {
            collider.enabled = !collider.enabled;
        }

        isToggledOn = Colliders[0].enabled;
        if (isToggledOn)
        {
            offSwitch.SetActive(false);
            onSwitch.SetActive(true);
        }
        else
        {
            offSwitch.SetActive(true);
            onSwitch.SetActive(false);
        }
    }
}
