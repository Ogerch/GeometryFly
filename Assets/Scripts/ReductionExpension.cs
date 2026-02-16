using UnityEngine;

public class ReductionExpension : MonoBehaviour
{

    public float reduction = 0.005f;

    public float nouvelleTaille;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        float nouvelleTaille = transform.localScale.x - reduction;
        transform.localScale = new Vector3(nouvelleTaille, nouvelleTaille, nouvelleTaille);

        if (nouvelleTaille > 3)
        {

            reduction = reduction * -1;
        }
        else if (nouvelleTaille < 1)
        {
            reduction = reduction * -1;
        }





    }
}
