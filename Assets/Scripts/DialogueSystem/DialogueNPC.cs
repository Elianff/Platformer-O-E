using UnityEngine;

public class DialogueNPC : MonoBehaviour
{

    //public InputSystemTest actionMap { get; }

    public GameObject player;

    public DialogueLine[] dialogueLines;

    public GameObject interactInstance;

    private bool dialogueStarted = false;

    private bool visited = false;



    

    //public static PlayerController movement;    
    

    // Update is called once per frame
    
    void Update()
    {
        if(dialogueStarted && DialogueManager.instance.dialogueFinished == true)
        {
            dialogueStarted = false;
            //actionMap.m_Player.Enable();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //get a way to not overlap text
        if(collision.gameObject.tag == "Eury" && interactInstance.gameObject.tag == "EuryDialogue")
        {
            if(!dialogueStarted && !visited){
            DialogueManager.instance.StartDialogue(dialogueLines);
            }
            dialogueStarted = true;
            visited = true;
            //actionMap.m_Player.Disable();
            
        
        }

        if(collision.gameObject.tag == "Orph" && interactInstance.gameObject.tag == "OrphDialogue")
        { 
            if(!dialogueStarted && !visited){
            DialogueManager.instance.StartDialogue(dialogueLines);
            }
            dialogueStarted = true;
            visited = true;
            //actionMap.m_Player.Disable();
            
        
        }

        
    }

    

}
