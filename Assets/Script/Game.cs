using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Game : MonoBehaviour 
{
	[Header("Setup_Basic")]
	public Color player1Color = Color.green;			//The colour that player 1's tank will be when the game starts.
	public Color player2Color = Color.red;				//The colour that player 2's tank will be when the game starts.
	public bool oneHitKill = false;						//Will a projectile instantly kill its target?
	public bool canDamageOwnTank = true;				//Can a tank damage itself by shooting a projectile?
	public int respawnDelay = 1;						//The amount of time a player will wait between dying and respawning.
	public int maxScore = 5;							//The score that when a player reaches, will end the game.
	public int maxProjectileBounces = 4;				//The maximum amount of times a projectile can bounce off walls.
    public int maxKey = 5;                              //The number of key you can win the game
    public int remainkey = 5;
    [Space(10)] //初始值，若要更改直接於物件中修改即可
    [Header("Setup_Player")]
	public int tankStartHealth = 2;						//The health the player tanks will get when the game starts.
	public int tankStartDamage = 1;						//The damage the player tanks will get when the game starts.
	public float tankStartMoveSpeed = 70;				//The move speed the player tanks will get when the game starts.
	public float tankStartTurnSpeed = 100;              //The turn speed the player tanks will get when the game starts.

    [Space(10)] 
    [Header("Setup_ProjectTile")]
    public float tankStartProjectileSpeed = 130;	    //The projectile speed the player tanks will get when the game starts.
	public int tankStartReloadSpeed = 1;	            //The reload speed the player tanks will get when the game starts.
    public float tankStartTimeGetProjectile = 5;        //The time you can get projectile
    public int tankStartMaxProjectile = 5;              //The max projectile you can store

    [Space(10)]
    [Header("Setup_Bomb")]
    public float tankStartBombDamage = 130;        //The bomb damage
    public float tankStartBombReloadSpeed = 1;	   //The bomb reload speed the player tanks will get when the game starts.
    public float tankStartTimeGetBomb = 5;         //The time you can get bomb
    public float tankStartMaxBomb = 5;             //The max bomb you can store

    [Space(10)]
    [Header("Setup_Light")]
    public float tankStartLightEletricity = 100;    //The tank's start light's eletricity

    [Header("Tanks")]
	public Tank player1Tank;							//Player 1's tank. 
	public Tank player2Tank;                            //Player 2's tank.
    public Tank player3Tank;                            //Player 1's tank. 
    public Tank player4Tank;

    [Header("Scores")]
	public int player1Score;	//team1						
	public int player2Score;	//team2						

	//[Header("Spawn Points")]
	//public List<GameObject> spawnPoints = new List<GameObject>();	//A list of all the spawn points, which the players can spawn at.

	[Header("Prefabs")]
	public GameObject wallPrefab;						//The wall prefab, which will be spawned at the start of the game to make up the level.

	[Header("Components")]
	//public UI ui;										//The UI.cs script, located in the GameManager game object.

	private string mapToLoad;							//The name of the map that is going to be loaded.
    
    void Awake()
    {
        player1Tank.SetStartValues();
        player2Tank.SetStartValues();
    }


	void Start ()
	{
        Debug.Log("11");
        //Load The Map
    /*    mapToLoad = PlayerPrefs.GetString("MapToLoad");									
		TextAsset map = Resources.Load<TextAsset>("Maps/" + mapToLoad) as TextAsset;
		LoadMap(map.text);*/

		//Tank Bools
		player1Tank.canMove = true;
		player1Tank.canShoot = true;

		player2Tank.canMove = true;
		player2Tank.canShoot = true;

		//Tank Start Values
	/*	player1Tank.SetStartValues();
		player2Tank.SetStartValues();*/
        Debug.Log("11");
      //  ui.SetupHealthBars();
        
		//Tank Color
		/*player1Tank.GetComponent<SpriteRenderer>().color = player1Color;
		player2Tank.GetComponent<SpriteRenderer>().color = player2Color;*/

		//Set Tank Spawn Position
	//	player1Tank.transform.position = spawnPoints[0].transform.position;
	//	player2Tank.transform.position = spawnPoints[1].transform.position;
	}

	void Update ()
	{
        
        //Checking Scores
        /*if(player1Score >= maxScore){	//Does player 1 reach the score amount to win the game?
			WinGame(0);					//Player 1 wins the game.
		}		
		if(player2Score >= maxScore){	//Does player 2 reach the score amount to win the game?
			WinGame(1);					//Player 2 wins the game.
		}*/
    }

	//Called when a player's score reaches the maxScore.
	//The "playerId" value, is the id of the player that won the game.
   /*	void WinGame (int playerId)
	{
		//Disable movement and shooting for the tanks.
		player1Tank.canMove = false;
		player1Tank.canShoot = false;

		player2Tank.canMove = false;
		player2Tank.canShoot = false;

		ui.SetWinScreen(playerId);	//Call the SetWinScreen function in UI.cs, and send over the winning player's id.
	}*/
	
}
