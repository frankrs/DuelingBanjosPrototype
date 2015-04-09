using UnityEngine;
using System.Collections;
using Photon;
using UnityEngine.UI;
//using ExitGames;

public class LobbySetup : Photon.PunBehaviour {

	public UIStuff uIStuff;

	// Use this for initialization
	void Start () {
		PhotonNetwork.ConnectUsingSettings("1.0");
	}
	
	// Update is called once per frame
	void Update () {
		uIStuff.connectionStateUI.text = PhotonNetwork.connectionState.ToString();
		if(PhotonNetwork.inRoom){
		uIStuff.room.text = PhotonNetwork.room.ToString();
		}
	}




	//void OnConnectedToPhoton(){
	void OnJoinedLobby(){
		PhotonNetwork.JoinOrCreateRoom("playroom",null,null);
		//PhotonNetwork.JoinLobby();
	}

	void OnJoinedRoom(){
		PhotonNetwork.LoadLevel(1);
	}

}



[System.Serializable]
public class UIStuff {
	public Text connectionStateUI;
	public Text room;
}