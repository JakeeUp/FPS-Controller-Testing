using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTest : Interactable
{
    public override void OnFocus()
    {
        print("Looking at" + gameObject.name);
    }

    public override void OnInteract()
    {
        print("Interacting with " + gameObject.name);
    }

    public override void OnLoseFocus()
    {
        print("Stopped looking at" + gameObject.name);
    }
}
