using UnityEngine;

public class Mole : MonoBehaviour
{
    Score myScore;
    [SerializeField] float _delay = 2.0f;

    // Get and set delay timer
    public float delay
    {
        get { return _delay; }
        set { _delay = value; }
    }

    // Start is called before the first frame update
    void Start()
    {
        myScore = FindObjectOfType<Score>();
        DestroyTimed();
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Destroy image on click
    public void DestroySelf()
    {
        Destroy(gameObject);
        myScore.AddPoints(1);
    }

    // Destroy image after set time
    public void DestroyTimed()
    {
        Destroy(gameObject, delay);
    }


}
