using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NameManager : MonoBehaviour
{
    public static NameManager Instance;
    public string playerName;
    // Start is called before the first frame update
    void Start()
    {
        if(Instance == null){
            Instance = this;
            DontDestroyOnLoad(this);
        }else{
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame(){
        SceneManager.LoadScene(1);
    }

    public void ReadNameInput(string pname){
        playerName=pname;
    }
}
