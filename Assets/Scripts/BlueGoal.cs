using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlueGoal : MonoBehaviour
{
    public float redScore;
    public Text redScoreText;
    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "RedBall")
        {
            redScore += 1;
            redScoreText.text = redScore.ToString();

            Destroy(collision.gameObject, 0.1f);
        }

        if (collision.transform.tag == "GoldBall")
        {
            redScore += 2;
            redScoreText.text = redScore.ToString();

            Destroy(collision.gameObject, 0.1f);
        }
    }

}
