using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUpable : MonoBehaviour {
    [SerializeField] string slotName;
    private void OnTriggerEnter2D(Collider2D obj) {
        if (obj.gameObject.CompareTag("Player")) {
            obj.gameObject.GetComponent<PlayerInv>().UpdateInv(name);
            Destroy(gameObject);
        }
    }
}
