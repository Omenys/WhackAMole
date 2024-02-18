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
    private void Spawn()
    {
        GameObject square = Instantiate(playerPrefab, GetComponent<RectTransform>());
        int r = Random.Range(-5, 5);
        square.transform.position = new Vector3(r, r, r);
        //Destroy(square.gameObject);
    }
}


/* GameObject g = Instantiate(playerPrefab, transform.position, Quaternion.identity);
int r = Random.Range(-5, 5);
g.transform.position = new Vector3(r, r, r);
//Destroy(g.gameObject); */