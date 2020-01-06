using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameMaster : MonoBehaviour
{
    [Header("Difficulty")]
    public AnimationCurve difficultyScale;

    void Awake()
    {
        #region DontDestoryOnLoad
        GameObject[] objs = GameObject.FindGameObjectsWithTag("GameMaster");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
        #endregion
    }
    void Start()
    {

    }


    void Update()
    {

    }

    public void GameOver()
    {
        Debug.Log("DIED");
    }

    public void LowerTime()
    {
        Debug.Log("TIme Lowered");
    }
}
