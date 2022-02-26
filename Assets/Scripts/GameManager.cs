using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject game;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreateObjects", 1, 2.5f);
    }

    // Update is called once per frame
    void CreateObjects()
    {
        Instantiate(game, new Vector3(17.2f, 0.2098873f, -6.061493f), Quaternion.identity);
    }
}
