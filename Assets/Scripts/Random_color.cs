using UnityEngine;


public class Random_color : MonoBehaviour
{
    #region Variables
    public float Pos = 1;
    public float number = 2;
    #endregion
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()

    {
        GetComponent<Renderer>().materials[0].SetFloat("_random", Random.Range(0.9f * Pos / number, 1f * Pos / number));
        GetComponent<Renderer>().materials[0].SetFloat("_random_1", Random.Range(0.8f * Pos / number, 1f * Pos / number));
        GetComponent<Renderer>().materials[0].SetFloat("_random_2", Random.Range(0.7f * Pos / number, 0.9f * Pos / number));
        GetComponent<Renderer>().materials[0].SetFloat("_random_3", Random.Range(0.6f * Pos / number, 0.8f * Pos / number));
        GetComponent<Renderer>().materials[0].SetFloat("_random_4", Random.Range(0.5f * Pos / number, 0.7f * Pos / number));
        GetComponent<Renderer>().materials[0].SetFloat("_random_5", Random.Range(0.4f * Pos / number, 0.6f * Pos / number));
        GetComponent<Renderer>().materials[0].SetFloat("_random_6", Random.Range(0.3f * Pos / number, 0.5f * Pos / number));
        GetComponent<Renderer>().materials[0].SetFloat("_random_7", Random.Range(0.2f * Pos / number, 0.4f * Pos / number));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
