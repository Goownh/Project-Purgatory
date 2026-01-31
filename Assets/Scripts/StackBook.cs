using System;
using UnityEngine;
using UnityEngine.UIElements;

public class StackBook : MonoBehaviour
{
    #region Variables

    private static float totalNbBook;
    private static float xPos = -6;
    private static float yPos = -3;
    private static float zPos = 2;
    public GameObject book;
    public Endings endings;
    
    #endregion

    private void Start()
    {
        //bookSprite = Sprite.Create(bookTexture, new Rect(0.0f, 0.0f, bookTexture.width, bookTexture.height), new Vector2(0.5f, 0.5f));
    }

    public void AddBook(int nbBook)
    {
        totalNbBook += nbBook;
        for(int i = nbBook; i > 0; i--)
        {
            GameObject bookPos = (GameObject)Instantiate(book);
            bookPos.transform.position = new Vector3(xPos, totalNbBook*1f+yPos, zPos);
            if (bookPos.transform.position.y > 17) endings.Ending();
        }
    }
    private void Update()
    {
    }
}
