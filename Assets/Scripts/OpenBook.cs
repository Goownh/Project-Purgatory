using UnityEngine;

public class OpenBook : MonoBehaviour
{
    #region Variables

    private GameObject currentBook;
    private Raycast ray;
    #endregion

    public void OnMouseDown()
    {
        if (currentBook == null /*&& ray.currentObject == ""*/)
        {
            CreateNewBook();
        } 
    }

    public void CreateNewBook()
    {
        new GameObject("CurrentBook");
    }
    public void GoodEndings()
    {
        
    }
}
