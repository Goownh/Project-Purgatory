using System;
using UnityEngine;

public class StackBook : MonoBehaviour
{
    private float totalNbBook;
    private float xPos = -6;
    private float yPos = -3;
    private float zPos = 2;
    public GameObject book;
    public Endings endings;
    
    public void AddBook(int nbBook)
    {
        totalNbBook += nbBook;
        for (int i = nbBook; i > 0; i--)
        {
            GameObject bookPos = (GameObject)Instantiate(book);
            bookPos.transform.position = new Vector3(xPos, totalNbBook * 1f + yPos, zPos);
            if (bookPos.transform.position.y > 17) endings.Ending();
        }
    }
}
