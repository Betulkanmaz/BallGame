using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GolAtma : MonoBehaviour
{
    public AudioClip golsound;
    public Ball top;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other) { 
        if (golsound != null && other.gameObject.CompareTag("Top")) 
        {

            top.transform.position = new Vector3(78.6f, 195.24f, 586.4f);
            top.GetComponent<Rigidbody>().velocity = Vector3.zero;
            audioSource.PlayOneShot(golsound, 0.7f); 
        } 
    }
}
