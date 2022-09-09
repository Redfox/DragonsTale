using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PartySlot : MonoBehaviour, IDropHandler {
 
    public int slot;

    public void OnDrop(PointerEventData eventData) {
        if (eventData.pointerDrag != null) {
            eventData.pointerDrag.GetComponent<RectTransform>().transform.SetParent(GetComponent<RectTransform>());
            var go = eventData.pointerDrag;
            go.name = go.name.Replace("(Clone)", "");
            if(slot == 1)
                PlayerParty.slot1 = go;
            if(slot == 2)
                PlayerParty.slot2 = go;
        }
    }
}
