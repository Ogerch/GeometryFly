using UnityEngine;

public class DeplacementHex : MonoBehaviour
{

    public float vitesseX = 0.1f;

    public float vitesseY = 0.005f;

    public float reductionExpension = 0.01f;

    public float randomX;

    public int randomSigneY;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        vitesseY = Random.Range(0.01f,0.003f);

        randomX = Random.Range(-7f, 7f);

        int choix = Random.Range(0, 2);

        if (choix == 0)
        {
            randomSigneY = 1;
        }
        else if (choix == 1)
        {
            randomSigneY = -1;
        }

        transform.position = new Vector2(randomX, 7 * randomSigneY);
    }

    // Update is called once per frame
    void Update()
    {


        

        // transform.Translate(0, vitesseY * randomSigneY *-1,0);
        transform.Translate(new Vector3(0, vitesseY * randomSigneY *-1, 0) , Space.World);

        if (transform.position.y > 7 || transform.position.y < -7)
        {
            randomX = Random.Range(-4f, 6f);
            int choix = Random.Range(0, 2);

            if (choix == 0)
            {
                randomSigneY = 1;
            }
            else if (choix == 1)
            {
                randomSigneY = -1;
            }
            transform.position = new Vector2(randomX, 7 * randomSigneY);
            vitesseY = Random.Range(0.01f,0.003f);
            // transform.position(new Vector3(randomX, 7 * randomSigneY, 0) , Space.World);
        }

    }
}
