using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPointController : MonoBehaviour
{
	private int checkpoint = 0;

	private int goalcount = 0;

    // Start is called before the first frame update
    void Start()
    {
		
    }

    // Update is called once per frame
    void Update()
    {

    }

	void OnTriggerEnter(Collider other){
		/*if (other.gameObject.tag == "checkpoint1"){
				if (checkpoint == 0){
				checkpoint = 1;
			}
		}
		if (other.gameObject.tag == "checkpoint2"){
			if (checkpoint == 1){
				checkpoint = 2;
			}
		}
		if (other.gameObject.tag == "checkpoint3"){
			if (checkpoint == 2){
				checkpoint = 3;
			}
		}
		if (other.gameObject.tag == "checkpoint4"){
			if (checkpoint == 3){
				checkpoint = 4;
			}
		}
		if (other.gameObject.tag == "checkpoint5"){
			if (checkpoint == 4){
				checkpoint = 5;
			}
		}
		if (other.gameObject.tag == "checkpoint6"){
			if (checkpoint == 5){
				checkpoint = 6;
			}
		}
		if (other.gameObject.tag == "checkpoint7"){
			if (checkpoint == 6){
				checkpoint = 7;
			}
		}
		if (other.gameObject.tag == "checkpoint8"){
			if (checkpoint == 7){
				checkpoint = 8;
			}
		}
		if (other.gameObject.tag == "checkpoint9"){
			if (checkpoint == 8){
				checkpoint = 9;
			}
		}
		if (other.gameObject.tag == "checkpoint10"){
			if (checkpoint == 9){
				checkpoint = 10;
			}
		}
		if (other.gameObject.tag == "checkpoint11"){
			if (checkpoint == 10){
				checkpoint = 11;
			}
		}
		if (other.gameObject.tag == "checkpoint12"){
			if (checkpoint == 11){
				checkpoint = 12;
			}
		}
		if (other.gameObject.tag == "checkpoint13"){
			if (checkpoint == 12){
				checkpoint = 13;
			}
		}
		if (other.gameObject.tag == "checkpoint14"){
			if (checkpoint == 13){
				checkpoint = 14;
			}
		}*/

		for (int i = 1; i <= 14; i++){
			if (other.gameObject.tag == "checkpoint" + i){
				if (checkpoint == i - 1){
					checkpoint = i;
				}
			}
		}

		if (other.gameObject.tag == "goal"){
			if (checkpoint == 14){
				goalcount = 1;
			}
		}
		if (goalcount == 1){
			Debug.Log ("ゴール");
		}
	}
}
