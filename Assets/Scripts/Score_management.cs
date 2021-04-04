using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score_management : MonoBehaviour
{
    int score = 0;
    TMP_Text score_board; 
    // Start is called before the first frame update
    void Start()
    {
        score_board = GetComponent<TMP_Text>();
        score_board.text = score.ToString();
    }

    // Update is called once per frame
    public void increase_score(int value)
    {
        score += value;
        score_board.text = score.ToString();
    }
}
