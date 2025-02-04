using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryManager : MonoBehaviour
{
    public GameObject Scene_1;
    public GameObject Scene_2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void NoblePhantasmScene()
    {
        Scene_2.SetActive(true);
        Scene_1.SetActive(false);
    }

}
