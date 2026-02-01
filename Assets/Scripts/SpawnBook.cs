using UnityEngine;

public class SpawnBook : MonoBehaviour
{
    private GameObject currentBook;
    //private Raycast ray;

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
