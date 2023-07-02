using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI : MonoBehaviour 
{
	//UI
	//[Header("Health Bars")]
	//public Slider p1HealthBar;		//The health bar that is above player 1.
	//public Slider p2HealthBar;		//The health bar that is above player 2.

	//[Header("Win Screen")]
	//public GameObject winScreen;	//The screen that pops up once a player has won the game.
	//public Text winText;			//The text on the win screen that says which player has won.

	[Header("Other")]
	public Text scoreText;			//The text at the top of the screen which displays the score.
    public Text remain;             //The remain key in the field
    public Text timer;              //Timer


    [Header("Components")]
	public Game game;

    private float time;
    private float origin_time = 300;

	//Called by the Game.cs script. This sets the values of the health bars to be the same as the tank's health.
	/*public void SetupHealthBars ()
	{
		p1HealthBar.maxValue = game.player1Tank.maxHealth;
		p2HealthBar.maxValue = game.player2Tank.maxHealth;
	}*/

	void Update ()
	{
        /*	if(game.player1Tank != null){	//If player 1's tank exists.
                p1HealthBar.transform.position = game.player1Tank.transform.position + new Vector3(0, 2, 0);	//Sets the health bar to be just above player 1's tank.
                p1HealthBar.value = game.player1Tank.health;													//Sets the value of the health bar to be the same as the tank's.
            }
            if(game.player2Tank != null){	//If player 2's tank exists.
                p2HealthBar.transform.position = game.player2Tank.transform.position + new Vector3(0, 2, 0);	//Sets the health bar to be just above player 2's tank.
                p2HealthBar.value = game.player2Tank.health;													//Sets the value of the health bar to be the same as the tank's.
            }	*/

        //Sets the score text to display the scores of the tank's, with their corresponding colors.
        scoreText.text = game.player1Score.ToString() + ":" + game.player2Score.ToString();
        remain.text ="Reamin: " + game.remainkey.ToString();
        time += Time.deltaTime;
        origin_time -= time;
        timer.text = "Remain Time:"+ origin_time.ToString();
        origin_time = 500;
            //"<b>SCORE</b>\n<b><color=" + ToHex(game.player1Color) + ">" + game.player1Score.ToString() + "</color></b> - <b><color=" + ToHex(game.player2Color) + ">" + game.player2Score.ToString() + "</color></b>";
    }

	//Called by Game.cs, when a player has reached the score required to win the game. It opens the win screen and
	//sets the text to display the winner which is sent through the "winner" value.
	/*public void SetWinScreen (int winner)
	{
		winScreen.active = true;

		if(winner == 0){
			winText.text = "<b><color=" + ToHex(game.player1Color) + ">PLAYER 1</color></b>\nWins The Game";
		}else{
			winText.text = "<b><color=" + ToHex(game.player2Color) + ">PLAYER 2</color></b>\nWins The Game";
		}
	}*/

	//Convers an RGB color to a HEX value, and returns it as a string.
	string ToHex (Color color)
	{
		return string.Format("#{0:X2}{1:X2}{2:X2}", ToByte(color.r), ToByte(color.g), ToByte(color.b));
	}

	//Converts a float to a byte. Used by the ToHex() function.
	byte ToByte (float num)
	{
		num = Mathf.Clamp01(num);
		return (byte)(num * 255);
	}

	//Called when a player wins and the HOME button is pressed, or if escape is pressed.
/*	public void GoToMenu ()
	{
		Application.LoadLevel(0);	//Loads the menu level.
	}*/
}
