using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerInv : MonoBehaviour {
    [SerializeField] GameObject[] invObjects = new GameObject[5];
    [SerializeField] int[] invCounts = new int[5];
    //public GameObject[] invObjs = new GameObject[5];

    void Start() {
        for (int i = 0; i < 5; i++) {
            invObjects[i] = GameObject.Find("Slot " + i);
            invCounts[i] = 0;
        }
        if (invObjects[4] != null) {
            Debug.Log("All good!");
        }
    }

    public void UpdateInv(string name) {
        bool check = true;
        int i = 0;
        while (check && i < 5) {
            int numCheck = invCounts[i];
            //GameObject tempObj = invObjects[i, 0].gameObject;
            if (numCheck == 0) {
                invCounts[i] = 1;
                invObjects[i].GetComponent<InvName>().UpdateName(name);
                //invObjects[i].GetComponent<InvName>().UpdateImage();
                check = false;
            } else if(invObjects[i].GetComponent<InvName>().GetName() == name) {
                int temp = invCounts[i];
                temp++;
                invCounts[i] = temp;
            }
            i++;
        }
    }
}
