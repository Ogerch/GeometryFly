using UnityEngine;

public class Rotation : MonoBehaviour
{

    public float vitesseRotation = 0.01f;




    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,vitesseRotation);
        // transform.Rotate(Vector3.forward * vitesseRotation, Space.Self);
    }
}
