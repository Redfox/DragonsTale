using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems; 

public class CursorPointer : MonoBehaviour, IPointerClickHandler
{
    public string name;

    public Texture2D cursorTexture;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log(name);
        SceneManager.LoadScene("BattleScene");
    }

    void OnMouseOver() {
        Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
    }

    void OnMouseExit() {
        Cursor.SetCursor(null, hotSpot, cursorMode);
    }
}
