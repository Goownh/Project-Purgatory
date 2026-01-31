using System;
using UnityEngine;

public class StackBook : MonoBehaviour
{
    #region Variables

    private static int totalNbBook;
    private static float xPos = -7;
    private static float yPos = -5;
    public static GameObject book;
    #endregion

    private void Start()
    {
        print("hgv();");
    }

    public static void AddBook(int nbBook)
    {
        totalNbBook += nbBook;
        for(int i = nbBook; i > 0; i--)
        {
            GameObject bookPos = (GameObject)Instantiate(book);
            bookPos.transform.position = new Vector3(xPos, totalNbBook*5+yPos, 0);
            print(bookPos.transform.position);
        }
    }

    private void Update()
    {
       // print(totalNbBook);
    }
}
