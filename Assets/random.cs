using UnityEngine;


public class MyRandomThing : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().materials[0].SetFloat("_random", Random.Range(0.9f, 1f));
        GetComponent<Renderer>().materials[0].SetFloat("_random_1", Random.Range(0.8f, 1f));
        GetComponent<Renderer>().materials[0].SetFloat("_random_2", Random.Range(0.7f, 0.9f));
        GetComponent<Renderer>().materials[0].SetFloat("_random_3", Random.Range(0.6f, 0.8f));
        GetComponent<Renderer>().materials[0].SetFloat("_random_4", Random.Range(0.5f, 0.7f));
        GetComponent<Renderer>().materials[0].SetFloat("_random_5", Random.Range(0.4f, 0.6f));
        GetComponent<Renderer>().materials[0].SetFloat("_random_6", Random.Range(0.3f, 0.5f));
        GetComponent<Renderer>().materials[0].SetFloat("_random_7", Random.Range(0.2f, 0.4f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
