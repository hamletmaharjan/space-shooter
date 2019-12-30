using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject hazard;

	public int hazardCount;

	public float spawnWait;
	public float startWait;

	public Vector3 spawnValue;

	void Start(){
		StartCoroutine (SpawnWaves ());
	}

	IEnumerator SpawnWaves(){

		yield return new WaitForSeconds (startWait);

		for(int i=0; i<hazardCount; i++){

			Vector3 spawnPosition = new Vector3 (Random.Range(-spawnValue.x,spawnValue.x),spawnValue.y,spawnValue.z);
			Quaternion spawnRotation = Quaternion.identity;

			Instantiate (hazard, spawnPosition, spawnRotation);

			yield return new WaitForSeconds (spawnWait);
		}
	}

}
