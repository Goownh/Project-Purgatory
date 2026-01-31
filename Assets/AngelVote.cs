using System;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    #region Variables

    private Camera _mainCamera;
    private bool angelMoveBool;
    public GameObject Perso;
    public float direction;
    #endregion

    private void Awake()
    {
        _mainCamera = Camera.main;
        angelMoveBool = false;
    }

    void OnMouseDown()
    {
        angelMoveBool = true;
        OnBecameInvisible();
    }

    void OnBecameInvisible()
    {
        StackBook.AddBook(1);
    }
    private void AngelMove(float x)
    {
        Perso.transform.position = new Vector3(Perso.transform.position.x+x, Perso.transform.position.y, Perso.transform.position.z);
    }

    void Update()
    {
        if (angelMoveBool) AngelMove(direction); 
    }
}