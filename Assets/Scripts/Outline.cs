using UnityEngine;

public class outline : MonoBehaviour
{
    void OnMouseOver()
    {
        GetComponent<Renderer>().materials[0].SetFloat("_outline", 0.03f);
    }
    void OnMouseExit()
    {
        GetComponent<Renderer>().materials[0].SetFloat("_outline", 0.0f);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
