using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Box : MonoBehaviour, IInteractable
{

    public void Interact()
    {
        TextBox();
    }

    public void TextBox()
    {
        Debug.Log("Despite everything, it's still you.");
    }
       

}


