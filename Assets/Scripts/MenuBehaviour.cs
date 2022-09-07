using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBehaviour : MonoBehaviour
{
    public void StartGame() {
        SceneManager.LoadScene("EditPartyScene");
    }

    public void DaleEditParty() {
        SceneManager.LoadScene("MapScene");
    }
}
