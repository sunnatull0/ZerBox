using System.Collections;
using UnityEngine;

public class RocketController : MonoBehaviour
{
    public Transform[] positions;
    public GameObject rockprefab;
    public float waitTime, waittime2;
    void Start()
    {
        StartCoroutine(Spawn());
    }

    private void Spawning()
    {
        Instantiate(rockprefab, positions[Random.Range(0, positions.Length)].position, rockprefab.transform.rotation);
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(waitTime, waittime2));
            Instantiate(rockprefab, positions[Random.Range(0, positions.Length)].position, rockprefab.transform.rotation);
        }
    }

}
