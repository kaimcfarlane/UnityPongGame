using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
  private int playerScore;
  private int computerScore;
  public Ball ball;
  public Text TextPlayerScore;
  public Text TextComputerScore;
  public Paddle playerPaddle;
  public Paddle ComputerPaddle;



  public void PlayerScores() {
      playerScore++;
      ResetRound();
      this.TextPlayerScore.text = playerScore.ToString();
    }

  public void ComputerScores() {
      computerScore++;
      ResetRound();
      this.TextComputerScore.text = computerScore.ToString();
  }

  private void ResetBall() {
      this.ball.ResetPosition();
  }

  public void ResetRound() {
    this.ball.ResetPosition();
      this.ball.AddStartingForce();
      this.playerPaddle.ResetPosition();
      this.ComputerPaddle.ResetPosition();
  }


}
