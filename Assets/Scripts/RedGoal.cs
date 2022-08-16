using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RedGoal : MonoBehaviour
{
    public float blueScore;
    public Text blueScoreText;


    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "BlueBall")
        {
            blueScore += 1;
            blueScoreText.text = blueScore.ToString();

            Destroy(collision.gameObject, 0.1f);
        }

        if (collision.transform.tag == "GoldBall")
        {
            blueScore += 2;
            blueScoreText.text = blueScore.ToString();

            Destroy(collision.gameObject, 0.1f);
        }
    }
}
