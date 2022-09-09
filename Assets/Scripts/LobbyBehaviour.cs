using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyBehaviour : MonoBehaviour
{
    public List<GameObject> characters = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {
        int rnd = getRand(null);
        ShowChar(characters[rnd], "RandomChar1");

        int rnd2 = getRand(rnd);
        ShowChar(characters[rnd2], "RandomChar2");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int getRand(int? lastRand) {
        int rnd = (int)Random.Range(0f, characters.Count -1);
        if(rnd == lastRand) {
            return getRand(lastRand);
        }

        return rnd;
    }

    private void ShowChar(GameObject character, string go) {
        GameObject go2 = Instantiate(character, new Vector3(0, 0, 0), Quaternion.identity);
        go2.transform.parent = GameObject.Find(go).transform;
        go2.transform.position = GameObject.Find(go).transform.position;
    }
}
