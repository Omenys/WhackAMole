using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject playerPrefab;
    [SerializeField] float _timeBetweenSpawns = 3f;
    float elapsed = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        elapsed += Time.deltaTime;
        if (elapsed >= timeBetweenSpawns)
        {
            Spawn();
            elapsed = 0;
        }
    }

    // Spawn UI elements at random locations on the visible canvas
    private void Spawn()
    {
        GameObject square = Instantiate(playerPrefab, GetComponent<RectTransform>());
        RectTransform rt = square.GetComponent<RectTransform>();
        RectTransform canvasRT = GetComponent<RectTransform>();
        float width = canvasRT.sizeDelta.x;
        float height = canvasRT.sizeDelta.y;
        float randomX = Random.Range(-width / 2, width / 2);
        float randomY = Random.Range(-height / 2, height / 2);
        rt.anchoredPosition = new Vector2(randomX, randomY);
    }

    // Get and set time between spawns
    public float timeBetweenSpawns
    {
        get { return _timeBetweenSpawns; }
        set { _timeBetweenSpawns = value; }
    }
}
