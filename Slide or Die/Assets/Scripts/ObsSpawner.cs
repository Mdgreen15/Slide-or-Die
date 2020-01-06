using UnityEngine;

[System.Serializable]
public class ObstacleArray
{
    public string name;
    public int level;
    public Vector3[] spawnPos;
    public GameObject prefab;
}
public class ObsSpawner : MonoBehaviour
{
    int highestLvl;
    public ObstacleArray[] prefabs;

    float nextActionTime = 10f;
    float period = 50f;

    float nextObs = 10f;
    float obsPeriod = 2f;

    void Start()
    {

    }

    void Update()
    {
        if (Time.time > nextActionTime)
        {
            nextActionTime = Time.time + period;
            highestLvl++;
            Debug.Log("100");
        }

        if (Time.time > nextObs)
        {
            int randomIndex = Random.Range(0, prefabs.Length);
            int choosenObs = randomIndex;
            nextObs = Time.time + obsPeriod;
            int randomNum = Random.Range(0, prefabs[choosenObs].spawnPos.Length);
            Instantiate(prefabs[choosenObs].prefab, prefabs[choosenObs].spawnPos[randomNum], Quaternion.identity);
        }
    }
}
