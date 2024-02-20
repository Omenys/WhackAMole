using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TMP_Text myText;
    int score;
    [SerializeField] GameObject squarePrefab;
    Spawner spawner;
    float mole_decay = 1f;


    // Start is called before the first frame update
    void Start()
    {
        myText = FindObjectOfType<TMP_Text>();

        // Spawn images
        GameObject square = Instantiate(squarePrefab, transform);
        float x = Random.Range(0, GetComponent<RectTransform>().rect.width);
        float y = Random.Range(0, GetComponent<RectTransform>().rect.height);
        square.transform.position = new Vector2(x, y);

        spawner = FindObjectOfType<Spawner>();
    }

    // Update is called once per frame
    void Update()
    {
        IncreaseDifficulty();
        foreach (Mole mole in FindObjectsOfType<Mole>())
        {
            mole.delay = mole_decay;
        }
    }

    // Update points
    public void AddPoints(int amount)
    {
        score += amount;
        myText.text = score.ToString();
    }

    // Increases difficulty based on player score
    public void IncreaseDifficulty()
    {
        if (score >= 0 && score < 10)
        {
            spawner.timeBetweenSpawns = 2f;
            mole_decay = 1.5f;
        }
        else if (score >= 10 && score < 20)
        {
            spawner.timeBetweenSpawns = 1f;
            mole_decay = 1.25f;
        }
        else if (score >= 20 && score < 50)
        {
            spawner.timeBetweenSpawns = 0.75f;
            mole_decay = 1.0f;
        }
        else if (score >= 50 && score < 75)
        {
            spawner.timeBetweenSpawns = 0.50f;
            mole_decay = 0.75f;
        }
        else if (score >= 75)
        {
            spawner.timeBetweenSpawns = 0.25f;
            mole_decay = 0.75f;
        }
    }
}
