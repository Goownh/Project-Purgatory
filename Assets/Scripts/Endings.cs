using UnityEngine;

public class Endings : MonoBehaviour
{
    #region Variables
    
    public GameObject goodEndingCanvas;
    public GameObject badEndingCanvas;
    #endregion

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
