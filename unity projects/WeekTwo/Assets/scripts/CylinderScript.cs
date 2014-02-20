using UnityEngine;
using System.Collections;

public class CylinderScript : MonoBehaviour {

	string currentRoom;

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World");
		currentRoom = "home";

	}
	
	// Update is called once per frame
	void Update () {


		if (currentRoom == "home"){
			GetComponent<TextMesh>().text = "Exhausted, you throw your bags onto the bed.";
			GetComponent<TextMesh>().text += "\nYou get a text, he wants to talk.";
			GetComponent<TextMesh>().text += "\nPress [R] to read text.";
		
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			
				currentRoom = "readText";
			}


		else if (currentRoom == "readText") {
			GetComponent<TextMesh>().text = "'Hey can we talk? I kind of need to vent'";
			GetComponent<TextMesh>().text += "\nHear him out [Y]";
			GetComponent<TextMesh>().text += "\nTell him no [N]";

		if (Input.GetKeyDown (KeyCode.Y)) {
				currentRoom = "talk";
			}

		if (Input.GetKeyDown (KeyCode.N)) {
				currentRoom = "tryToSleep";
			}

		}

		else if ( currentRoom == "talk") {
			GetComponent<TextMesh>().text = "He comes in with two full glasses of scotch";
			GetComponent<TextMesh>().text += "\nAccept the drink [A]";
			GetComponent<TextMesh>().text += "\nRespectfully deny [D]";

			if (Input.GetKeyDown (KeyCode.A)) {
				currentRoom = "drinks";
			}

			if (Input.GetKeyDown (KeyCode.D)) {
				currentRoom = "deny";
			}
		}

		else if (currentRoom == "drinks") {
			GetComponent<TextMesh>().text = "Ask him what he wants to talk about [Z]";
			GetComponent<TextMesh>().text += "\nTake a sip from your drink [S]";

			if (Input.GetKeyDown (KeyCode.Z)) {
				currentRoom = "talkOne";
			}

			if (Input.GetKeyDown (KeyCode.S)) {
				currentRoom = "talkTwo";
			}
		}

		else if (currentRoom == "deny") {
			GetComponent<TextMesh>().text = "Ask him what he wants to talk about [Z]";
			GetComponent<TextMesh>().text += "\nTake a sip from your drink [S]";
			
			if (Input.GetKeyDown (KeyCode.Z)) {
				currentRoom = "talkOne";
			}
			
			if (Input.GetKeyDown (KeyCode.S)) {
				currentRoom = "talkTwo";
			}
		}

		else if (currentRoom == "talkOne") {
			GetComponent<TextMesh>().text = "'So I want to hear about your experiences with other men.";
			GetComponent<TextMesh>().text += "\nDon't worry I'm not trying to hook up with you.'";
			GetComponent<TextMesh>().text += "\nTell him about that one time [T]";
			GetComponent<TextMesh>().text += "\nTell him you have to go to bed [B]";

			if (Input.GetKeyDown (KeyCode.T)) {
				currentRoom = "telling";
			}

			if (Input.GetKeyDown (KeyCode.B)){
				currentRoom = "tryToSleep";
			}
		
		}

		else if (currentRoom == "talkTwo") {
			GetComponent<TextMesh>().text = "'So I've been meaning to ask you about your experiences";
			GetComponent<TextMesh>().text += "\nDon't worry I'm not trying to hook up with you.'";
			GetComponent<TextMesh>().text += "\nTell him about that one time [T]";
			GetComponent<TextMesh>().text += "\nTell him you have to go to bed [B]";

			if (Input.GetKeyDown (KeyCode.T)) {
				currentRoom = "telling";
			}
			
			if (Input.GetKeyDown (KeyCode.B)){
				currentRoom = "tryToSleep";
			}

		
		}

		else if (currentRoom == "telling") {
			GetComponent<TextMesh>().text = "You tell him, uncomfortable not because of what you say,";
			GetComponent<TextMesh>().text += "\nbut because of his gaze. A dog on the hunt.";
			GetComponent<TextMesh>().text += "\n'I want to help you with this.'";
			GetComponent<TextMesh>().text += "\nTell him you have to sleep [V]";
			GetComponent<TextMesh>().text += "\nReflect his advances [I]";

			if (Input.GetKeyDown (KeyCode.V)){
				currentRoom = "tryToSleepTwo";
			}

			if (Input.GetKeyDown (KeyCode.I)){
				currentRoom = "reflect";
			}

		}

		else if (currentRoom == "reflect") {
			GetComponent<TextMesh>().text = "You dodge, but he throws again.";
			GetComponent<TextMesh>().text += "\n'What would you do with a man?'";
			GetComponent<TextMesh>().text += "\nTell him you have to sleep [V]";
			GetComponent<TextMesh>().text += "\nAnswer honestly [H]";

			if (Input.GetKeyDown (KeyCode.V)){
				currentRoom = "tryToSleepTwo";
			}
			
			if (Input.GetKeyDown (KeyCode.H)){
				currentRoom = "honest";
			}

		}

		else if (currentRoom == "honest") {
			GetComponent<TextMesh>().text = "You're upfront, but growing more uncomfortable.";
			GetComponent<TextMesh>().text += "\n'You know I'm about to leave Chad (your roommate),";
			GetComponent<TextMesh>().text += "\nbut I wanted to make sure we can hang out after that.'";
			GetComponent<TextMesh>().text += "\nTell him you have to sleep [V]";
			GetComponent<TextMesh>().text += "\nAssure him you will [W]";

			if (Input.GetKeyDown (KeyCode.V)){
				currentRoom = "tryToSleepTwo";
			}
			
			if (Input.GetKeyDown (KeyCode.W)){
				currentRoom = "will";
			}

		}

		else if (currentRoom == "will") {
			GetComponent<TextMesh>().text = "He grins and continues to stare.";
			GetComponent<TextMesh>().text += "\n'You know you should show more skin around here,";
			GetComponent<TextMesh>().text += "\nyou know you're hot.'";
			GetComponent<TextMesh>().text += "\nTell him you have to sleep [V]";
			GetComponent<TextMesh>().text += "\nShow that you're flattered [F]";

			if (Input.GetKeyDown (KeyCode.V)){
				currentRoom = "tryToSleepTwo";
			}
			
			if (Input.GetKeyDown (KeyCode.F)){
				currentRoom = "flattered";
			}
			
		}

		else if ( currentRoom == "flattered" ){
			GetComponent<TextMesh>().text = "He licks his lips, his ego bigger with each word.";
			GetComponent<TextMesh>().text += "\n'Can I watch you?'";
			GetComponent<TextMesh>().text += "\nYou tell him you have to sleep [C]";
			GetComponent<TextMesh>().text += "\nYou tell him to stop and that you need to sleep [B]";

			if (Input.GetKeyDown (KeyCode.C)){
				currentRoom = "tryToSleepThree";
			}
			
			if (Input.GetKeyDown (KeyCode.B)){
				currentRoom = "tryToSleep";
			}
		}

		else if ( currentRoom == "tryToSleep") {
			GetComponent<TextMesh>().text = "You tell him you have to sleep.";
			GetComponent<TextMesh>().text += "\nA few hours go by, you hear knocking on your door,";
			GetComponent<TextMesh>().text += "\nthen a rattle of the doorhandle.";
			GetComponent<TextMesh>().text += "\nYou turn over and close your eyes, it stops.";
		

		}

		else if ( currentRoom == "tryToSleepTwo") {
			GetComponent<TextMesh>().text = "You hear three forceful knocks. The lock on";
			GetComponent<TextMesh>().text += "\nyour door is being picked, but he's too drunk.";
			GetComponent<TextMesh>().text += "\nAfter ten minutes it stops.";
			GetComponent<TextMesh>().text += "\nThis wasn't the last time.";
		}

		else if ( currentRoom == "tryToSleepThree") {
			GetComponent<TextMesh>().text = "You receive a text.";
			GetComponent<TextMesh>().text += "\nRead it [X]";
			GetComponent<TextMesh>().text += "\nGo to sleep [L]";

			if (Input.GetKeyDown (KeyCode.X)){
				currentRoom = "textSleep";
			}
			
			if (Input.GetKeyDown (KeyCode.L)){
				currentRoom = "tryToSleepTwo";
			}
		
		}

		else if ( currentRoom == "textSleep" ) {
			GetComponent<TextMesh>().text = "'Can I pleasure you?'";
			GetComponent<TextMesh>().text += "\n'Leave your door unlocked so I can sneak in ;)'";
			GetComponent<TextMesh>().text += "\nThree knocks filled with anticipation, he waits.";
			GetComponent<TextMesh>().text += "\nHe begins picking the lock, the booze saves you, again.";
			GetComponent<TextMesh>().text += "\nYou know this won't be the last time.";
		
		}




	}
}
