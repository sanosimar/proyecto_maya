using UnityEngine;
using System.Collections;
using SocketIO;
public class NewBehaviourScript : MonoBehaviour {

	public SocketIOComponent socket;
	// Use this for init96y7`	6747 k   lization
	void Start() {
		Debug.Log("startr: ");
		StartCoroutine (ConnectedToServer ());
		socket.On("user connected", OnUserConnected);
	}
	IEnumerator ConnectedToServer(){
		yield return new WaitForSeconds(0.5f);
		socket.Emit("user login");
		yield return new WaitForSeconds(1f);
	}
	private void OnUserConnected(SocketIOEvent evt){
		Debug.Log("Get The messagefrom server: " + evt.data);
	}
}
