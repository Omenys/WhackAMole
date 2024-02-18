using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    TMP_Text myText;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        myText = FindObjectOfType<TMP_Text>();
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
