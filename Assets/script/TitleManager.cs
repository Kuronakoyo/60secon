using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TitleManager : MonoBehaviour
{
    public GameObject sexy;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("sound");
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator sound()
    {
        yield return new WaitForSeconds(1);
        SoundManager.Instance.Play_SE(0, 0);

        sexy.SetActive(true);
        yield return new WaitForSeconds(1);
    }
 
}
