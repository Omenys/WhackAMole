using UnityEngine;

public class Player : MonoBehaviour
{
    Score myScore;

    // Start is called before the first frame update
    void Start()
    {
        myScore = FindObjectOfType<Score>();
    }

    // Update is called once per frame
    void Update()
    {
        /* if (Input.GetButtonDown("Jump"))
         {
             myScore.AddPoints(1);
         }
        */
    }

    public void DestroySelf()
    {
        Destroy(gameObject);
        myScore.AddPoints(1);
    }
}
