using System;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    public GameObject currentObject;
    public bool inputTrue;

    private void OnMouseDown()
    {
        currentObject = new GameObject("");
    }
}
