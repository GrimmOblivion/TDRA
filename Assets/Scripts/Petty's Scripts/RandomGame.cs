using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomGame : MonoBehaviour {
	public int Player1Hp = 20;
	public int Player2Hp = 20;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		//check Players health, for death
		//end game
		//dont keep beating up a corpse
		if (Player1Hp <= 0){
			//Player 2 wins
			Debug.Log("Player 2 wins!!!");
			return;		}

		if (Player2Hp <= 0){
			//Player 1 wins
			Debug.Log("Player 1 wins!!!");
			return;		}
		
		Debug.Log ("Player 1 Health: " + Player1Hp);
		Debug.Log ("Player 2 Health: " + Player2Hp);
		//we roll 2d6 and store their values
		int p1DieRoll = Random.Range (1, 7);
		int p1DieRoll2 = Random.Range (1, 7);
		//create a variable sum to combine our two dice values
		int p1sum = p1DieRoll + p1DieRoll2;
		Debug.Log ("Player 1 rolled a " + p1sum);

		int p2DieRoll = Random.Range (1, 7);
		int p2DieRoll2 = Random.Range (1, 7);
		int p2sum = p2DieRoll + p2DieRoll2;
		Debug.Log ("Player 2 rolled a " + p2sum);

		//Block
		//id player 2 rolls an 8 or 9,  players 1's roll doesnt matter
		if (p2sum == 8) {
			p1sum = 0;}
		if(p2sum == 9){
			p1sum = 0;}

		if (p1sum == 8) {
			p2sum = 0;}
		if(p1sum == 9){
			p2sum = 0;}

		//Players 1 Rolls
		//if our sum is exactly to 2 then jump kick
		if (p1sum == 1){
			Debug.Log ("Player 1: You are a God and yeah, Ima just leave...");  }
		if (p1sum == 2) {
			Debug.Log ("Player 1: Jump Kick: Deal 10 damage, skip your next turn");
			//ignore skiping turns because that sounds hard
			Player2Hp -= 10;}
		if (p1sum == 3) {
			//ignore skiping turns because that sounds hard
			Debug.Log ("Player 1: Shin Kick: Deal 2 damage Player that is hit skips their turn");
			Player2Hp -= 2;}
		if (p1sum == 4){
			Debug.Log ("Player 1: Drop Kick: Deal 5 damage");
			Player2Hp -= 5;}
		if (p1sum == 5){
			Debug.Log ("Player 1: Karate Chop: Deal 4 damage");
			Player2Hp -= 4;}
		if (p1sum == 6){
			Debug.Log ("Player 1: Hay Maker: Deal 3 damage");
			Player2Hp -= 3;}
		if (p1sum == 7){
			Debug.Log ("Player 1: Punch: Deal 2 damage");
			Player2Hp -= 2;}
		if (p1sum == 8){
			Debug.Log ("Player 1: Block: Take no damage");
		}
		if (p1sum == 9){
			Debug.Log ("Player 1: Block: Take no damage");
		}
		if (p1sum == 10){
			Debug.Log ("Player 1: Miss: You dont hit the enemy");}
		if (p1sum == 11){
			Debug.Log ("Player 1: Reversal: You take 2 damage");
			Player2Hp -= 2;}
		if (p1sum == 12){
			Debug.Log ("Player 1: Round House Kick: Deal 6 damage");
			Player2Hp -= 6;}	

		//Player 2 rolls
		if (p2sum == 1){
			Debug.Log ("Player 2: You are a God and yeah, Ima just leave...");  }
		if (p2sum == 2) {
			Debug.Log ("Player 2: Jump Kick: Deal 10 damage, skip your next turn");
			Player1Hp -= 10;}
		if (p2sum == 3) {
			Debug.Log ("Player 2: Shin Kick: Deal 2 damage Player that is hit skips their turn");
			Player1Hp -= 2;}
		if (p2sum == 4){
			Debug.Log ("Player 2: Drop Kick: Deal 5 damage");
			Player1Hp -= 5;}
		if (p2sum == 5){
			Debug.Log ("Player 2: Karate Chop: Deal 4 damage");
			Player1Hp -= 4;}
		if (p2sum == 6){
			Debug.Log ("Player 2: Hay Maker: Deal 3 damage");
			Player1Hp -= 3;}
		if (p2sum == 7){
			Debug.Log ("Player 2: Punch: Deal 2 damage");
			Player1Hp -= 2;}
		if (p2sum == 8){
			Debug.Log ("Player 2: Block: Take no damage");
		}
		if (p2sum == 9){
			Debug.Log ("Player 2: Block: Take no damage");
		}
		if (p2sum == 10){
			Debug.Log ("Player 2: Miss: You dont hit the enemy");}
		if (p2sum == 11){
			Debug.Log ("Player 2: Reversal: You take 2 damage");
			Player1Hp -= 2;}
		if (p2sum == 12) {
			Debug.Log ("Player 2: Round House Kick: Deal 6 damage"); 
			Player1Hp -= 6;}			
	}
	}