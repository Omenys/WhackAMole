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

        GameObject square = Instantiate(squarePrefab, transform);
        float x = Random.Range(0, GetComponent<RectTransform>().rect.width);
        float y = Random.Range(0, GetComponent<RectTransform>().rect.height);
        square.transform.position = new Vector2(x, y);
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
