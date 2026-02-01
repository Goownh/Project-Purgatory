using UnityEngine;

public class PlayerVote : MonoBehaviour
{
    #region Variables

    private bool MoveBool;
    public GameObject perso;
    public float direction;
    public StackBook stack;
    #endregion

    private void Awake()
    {
        MoveBool = false;
    }

    void OnMouseDown()
    {
        if(!MoveBool) Invoke("AddBook", 1f);
        MoveBool = true;
    }

    void AddBook()
    {
        stack.AddBook(1);
        MoveBool = false;
        perso.transform.position = new Vector3(0, 0, 0);
    }

    private void Move(float x)
    {
        perso.transform.position = new Vector3(perso.transform.position.x+x, perso.transform.position.y, perso.transform.position.z);
    }

    void Update()
    {
        if (MoveBool) Move(direction); 
    }
}