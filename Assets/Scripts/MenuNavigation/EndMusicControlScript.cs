using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMusicControlScript : MonoBehaviour
{
    public static EndMusicControlScript instance;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (instance == null)
        {
            instance = this;
        }   
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}