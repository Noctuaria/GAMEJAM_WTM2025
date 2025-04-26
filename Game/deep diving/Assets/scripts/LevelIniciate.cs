using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelIniciate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       ManagerSound.Reproduir(ManagerSound.bgm.Found);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
