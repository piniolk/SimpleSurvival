using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpable : MonoBehaviour {
    [SerializeField] string slotName;
    [SerializeField] string pathName;
    private void OnTriggerEnter2D(Collider2D obj) {
        if (obj.gameObject.CompareTag("Player")) {
            if (!obj.GetComponent<PlayerInv>().CheckInvIfFull() || obj.GetComponent<PlayerInv>().CheckIfInInv(slotName)) {
                obj.gameObject.GetComponent<PlayerInv>().UpdateInv(slotName, pathName);
                Destroy(gameObject);
            } else {
                Debug.Log("Oops! Full Inventory.");
            }
        }
    }

    public string GetPathName() {
        return this.pathName;
    }
}
