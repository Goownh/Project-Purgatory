using UnityEngine;

public class Endings : MonoBehaviour
{
    public GameObject goodEndingCanvas;
    public GameObject badEndingCanvas;

    public void Ending()
    {
        BadEndings();
        //GoodEndings();
    }

    public void BadEndings()
    {
        badEndingCanvas.SetActive(true);
    }
    public void GoodEndings()
    {
        goodEndingCanvas.SetActive(true);
    }
}
