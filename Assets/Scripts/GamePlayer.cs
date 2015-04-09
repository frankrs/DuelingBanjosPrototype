using UnityEngine;
using System.Collections;
using Photon;
using UnityEngine.UI;

public class GamePlayer : Photon.PunBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


//	[RPC]
	public void SentIt(){
		photonView.RPC("ChangeColors",PhotonTargets.Others,Random.Range(0f,1f));
	}

	[RPC]
	public void ChangeColors(float c){
		Camera.main.backgroundColor = new Color(c,c,c,1f);
	}
}
