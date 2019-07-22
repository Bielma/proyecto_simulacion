using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerWalk : MonoBehaviour
{
    public int playerSpeed = 10;
    private Rigidbody rb;
    private int count;
    public Text countText;
    public Text winText;
    public AudioSource m_audio;
    private int numItemns = 9;
    //public AudioCLip m_pickUpSound;
    // Start is called before the first frame update
    void Start()
    {
          rb = GetComponent<Rigidbody>();
        count = 0;
        countText.text = "Count: " + count.ToString();
        winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1")){
            transform.position = transform.position + Camera.main.transform.forward * playerSpeed * Time.deltaTime;
        }
    }
      private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("PickUp"));
        {
            other.gameObject.SetActive(false);  
            count = count + 1;
            countText.text = "Count: " + count.ToString();
            m_audio.Play();
            if(count >= numItemns)
            {
                winText.text = "Felicidades, has recogido todos!";
            }
        }
    }
}
