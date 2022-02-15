using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static WallMorphism;

public class SpawnManager : MonoBehaviour
{
    public GameObject wallPrefab;
    public Transform wallSpawnPos;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnWall", 3f, 6f);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {

        }
    }

    private void SpawnWall()
    {
        GameObject wallObj = Instantiate(wallPrefab, wallSpawnPos.position, wallPrefab.transform.rotation);
        WallMorphism wallScript = wallObj.GetComponent<WallMorphism>();

        RandomState(wallScript);
    }

    private void RandomState(WallMorphism wallScript)
    {
        int randomNumber = UnityEngine.Random.Range(0, 2);

        if (randomNumber == 0)
        {
            wallScript.wallState = WallState.Left;

        } else if (randomNumber == 1)
        {
            wallScript.wallState = WallState.Right;

        } else if (randomNumber == 2)
        {
            wallScript.wallState = WallState.Right;
        }
    }
}
