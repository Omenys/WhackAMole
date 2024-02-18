using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TMP_Text myText;
    int score;
    [SerializeField] GameObject squarePrefab;

    // Start is called before the first frame update
    void Start()
    {
        myText = FindObjectOfType<TMP_Text>();
        Instantiate(squarePrefab, transform);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddPoints(int amount)
    {
        score += amount;
        myText.text = score.ToString();
    }
}
