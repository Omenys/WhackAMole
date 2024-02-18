using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject playerPrefab;
    [SerializeField] float timeBetweenSpawns;
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
}


/* GameObject g = Instantiate(playerPrefab, transform.position, Quaternion.identity);
int r = Random.Range(-5, 5);
g.transform.position = new Vector3(r, r, r);
//Destroy(g.gameObject); */