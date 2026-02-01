using UnityEngine;

public class Raycast : MonoBehaviour
{
    #region Variables
    
    private RaycastHit hit;
    private GameObject currentObject;
    #endregion

    void Update(){
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            if (Physics.Raycast(transform.position, fwd))
            {
                currentObject = hit.transform.gameObject;
            }
        }
    }
}
