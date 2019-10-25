/*
		 * (Santiago Garcia II)
		 * (SpawnManager.cs)
		 * (Assignment 8)
		 * (creates a singleton )
	*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    
    public class SimpleSingleton : MonoBehaviour
    {
        public GameObject worldspacetext;

        public static SimpleSingleton instance;

        void Awake()
        {
         
            instance = worldspacetext.SetActive(false);
        }

       
        void DisplayPrompt()
        {
            worldspacetext.SetActive(true);
           
        }

        
        void UsageExample()
        {
           
            SimpleSingleton.instance.DisplayPrompt();
           
        }
        
    }
}
