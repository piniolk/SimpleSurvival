using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInv : MonoBehaviour {
    [SerializeField] GameObject[] invObjects = new GameObject[5];
    [SerializeField] int[] invCounts = new int[5];
    bool fullInvCheck = false;
    //public GameObject[] invObjs = new GameObject[5];

    void Start() {
        for (int i = 0; i < 5; i++) {
            invObjects[i] = GameObject.Find("Slot " + i);
            invCounts[i] = 0;
        }
       /* if (invObjects[4] != null) {
            Debug.Log("All good!");
        }*/
    }

    public void UpdateInv(string name, string pathLoc) {
        bool check = true;
        int i = 0;
        while (check && i < 5) {
            //GameObject tempObj = invObjects[i, 0].gameObject;
            if (invCounts[i] == 0) {
                invCounts[i] = 1;
                invObjects[i].GetComponent<InvName>().UpdateName(name);
                invObjects[i].GetComponent<InvName>().UpdateImage(pathLoc);
                invObjects[i].GetComponent<InvName>().UpdateCount(invCounts[i]);
                check = false;
            } else if (invObjects[i].GetComponent<InvName>().GetName() == name) {
                int temp = invCounts[i];
                temp++;
                invCounts[i] = temp;
                invObjects[i].GetComponent<InvName>().UpdateCount(invCounts[i]);
                check = false;
            }
            i++;
        }
        if(i == 5) {
            fullInvCheck = true; 
        }
    }

    public bool CheckIfInInv(string name) {
        bool check = false;
        for (int i = 0; i < 5; i++) {
            if (invObjects[i].GetComponent<InvName>().GetName() == name) {
                check = true;
            }
        }
        return check;
    }

    public bool CheckInvIfFull() {
        return fullInvCheck;
    }
}
