using UnityEngine;

public enum ObsTypes
{
    Solid,
    Fade,
}
public class Obstacle : MonoBehaviour
{
    float speed = 20f;
    public ObsTypes type;
    GameMaster GameMaster;
    // Start is called before the first frame update
    void Start()
    {
        GameMaster = GameObject.FindObjectOfType(typeof(GameMaster)) as GameMaster;
    }

    // Update is called once per frame
    void Update()
    {
        MoveForward();
        if (transform.position.z < -8f)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (type == ObsTypes.Solid)
            {
                GameMaster.GameOver();
            }
            if (type == ObsTypes.Fade)
            {
                GameMaster.LowerTime();
            }
        }

    }

    void MoveForward()
    {
        transform.Translate(-Vector3.forward * speed * Time.deltaTime);
    }
}
