using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager instance;

    [SerializeField] private int playerScore;
    [SerializeField] private GameObject ballPrefab;

    [SerializeField] private GameObject[] ballPosition;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
        
        // Set ball on table
        SetBalls(BallColors.White, 0);
        SetBalls(BallColors.Red, 1);
        SetBalls(BallColors.Yellow, 2);
        SetBalls(BallColors.Green, 3);
        SetBalls(BallColors.Brown, 4);
        SetBalls(BallColors.Blue, 5);
        SetBalls(BallColors.Pink, 6);
        SetBalls(BallColors.Black, 7);
    }

    void SetBalls(BallColors colors, int pos)
    {
        GameObject ball = Instantiate(ballPrefab, ballPosition[pos].transform.position, Quaternion.identity);
        Ball b = ball.GetComponent<Ball>();
        b.SerColorAndPoint(colors);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
