using UnityEngine;
using Unity.Cinemachine;

public class End : MonoBehaviour
{
    
    public GameObject eury, orph;
    public CinemachineCamera vcam;
    
    public Transform spawnPoint;

    private bool triggered = false;

    void Start()
    {
        eury.gameObject.SetActive(true);   
        orph.gameObject.SetActive(false);   
        vcam.Follow = eury.transform;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(triggered == false)
        {
            if (collision.CompareTag("Eury"))
        {
            //sc.SwitchAvatar();
            eury.gameObject.SetActive(false);   
            orph.gameObject.SetActive(true); 
            vcam.Follow = orph.transform;
            orph.transform.position = spawnPoint.position;

            
        }


        if (collision.CompareTag("Orph"))
        {
            //sc.SwitchAvatar();
            orph.gameObject.SetActive(false); 
            eury.gameObject.SetActive(true);   
            vcam.Follow = eury.transform;
            eury.transform.position = spawnPoint.position;
            
        }
        }
        
    }


}
