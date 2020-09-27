using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreaterScript : MonoBehaviour
{
    public GameObject wallNormal;
    public GameObject wallEnemy;
    public GameObject wallSmallEnemy;
    public GameObject itemwallNormal;
    public GameObject itemwallEnemy;
    public GameObject itemwallSmallEnemy;

    float wallPositionX = 13.0f;
    Vector3 wallPositiondown;
    Vector3 wallPositionup;

    float timer = 0;
    float interval = 0.8f;
    //GameObject[] wallsArray;

    float sortWalldown;
    float sortWallup;

    //Random wallSerect;

    // Start is called before the first frame update
    void Start()
    {
        //wallsArray  = new GameObject[] { wallNormal, wallEnemy, wallSmallEnemy };
        wallPositiondown = new Vector3(wallPositionX,-4.5f,0);
        wallPositionup = new Vector3(wallPositionX, 5.5f, 0);

        wallNormal.tag = "Wall";
        wallEnemy.tag = "Wall";
        wallSmallEnemy.tag = "Wall";
        itemwallEnemy.tag = "Wall";
        itemwallNormal.tag = "Wall";
        itemwallSmallEnemy.tag = "Wall";
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        sortWalldown = Random.Range(0, 7.0f);
        sortWallup = Random.Range(0, 3.0f);

        if (timer >= interval)
        {
            if (sortWalldown <= 3.0f)
            {
                Instantiate(wallNormal, wallPositiondown, transform.rotation);
            }
            else if (sortWalldown <= 4.0f)
            {
                Instantiate(wallEnemy, wallPositiondown, transform.rotation);
            }
            else if (sortWalldown <= 5.5f)
            {
                Instantiate(wallSmallEnemy, wallPositiondown, transform.rotation);
            }
            else if (sortWalldown <= 6.0f)
            {
                Instantiate(itemwallEnemy, wallPositiondown, transform.rotation);
            }
            else if (sortWalldown <= 6.5f)
            {
                Instantiate(itemwallNormal, wallPositiondown, transform.rotation);
            }
            else if (sortWalldown <= 7.0f)
            {
                Instantiate(itemwallSmallEnemy, wallPositiondown, transform.rotation);
            }

            if (sortWallup <= 2.0f)
            {
                Instantiate(wallNormal, wallPositionup, transform.rotation);
            }
            else if (sortWallup <= 2.5f)
            {
                Instantiate(wallEnemy, wallPositionup, transform.rotation);
            }
            else if (sortWallup <= 3.0f)
            {
                Instantiate(wallSmallEnemy, wallPositionup, transform.rotation);
            }

            wallPositionX += 5.2f;
            timer = 0;
        }

    
    }
}
