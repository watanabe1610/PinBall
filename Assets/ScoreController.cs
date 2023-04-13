using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    Material myMaterial;

    private int score = 0;

    private GameObject scoreText;

    // Start is called before the first frame update
    void Start()
    {
        this.scoreText = GameObject.Find("ScoreText");

        this.myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        this.scoreText.GetComponent<Text>().text = "score" + this.score;
    }

    private void OnCollisionEnter(Collision other )
    {
        if(other.gameObject.tag == "SmallStarTag" || other.gameObject.tag == "SmallCloudTag")
        {
            this.score += 10;
        }
        else if(other.gameObject.tag == "LargeStarTag" || other.gameObject.tag == "LargeCloudTag")
        {
            this.score += 20;
        }
    }
    
}
