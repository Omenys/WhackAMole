using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject playerPrefab;

    // Start is called before the first frame update
    void Start()
    {

        Instantiate(playerPrefab, new Vector3(0f, 0f, 0f), Quaternion.identity, transform);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
