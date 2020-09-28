using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class JudgScript : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject highScoreText;
    public int score = 0;
    public int highScore;
    public bool gameOverBool;

    GameObject playerObject;

    // Start is called before the first frame update
    void Start()
    {
        playerObject = GameObject.Find("Player");
        highScore = PlayerPrefs.GetInt("HIGHSCORE", 0);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.tag == "Wall")
        {
            if(score > highScore)
            {
                highScore = score;
                PlayerPrefs.SetInt("HIGHSCORE", highScore);
                PlayerPrefs.Save();
            }
            Debug.Log("wall当たった");

            highScoreText.GetComponent<Text>().text = "HighScore: " + highScore.ToString();

            playerObject.GetComponent<PlayerScript>().DestroyMe();

            gameOverCanvas.SetActive(true);
            gameOverBool = true;
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger");

        if (other.gameObject.tag == "Item")
        {
            Debug.Log("item当たった");
            score++;
            Destroy(other.gameObject);
        }
    }


}
