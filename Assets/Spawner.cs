using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(playerPrefab);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
