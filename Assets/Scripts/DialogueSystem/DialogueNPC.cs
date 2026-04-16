using UnityEngine;

public class DialogueNPC : MonoBehaviour
{

    public DialogueLine[] dialogueLines;

    public bool dialogueStarted = false;

    //public static PlayerController movement;    
    

    // Update is called once per frame
    
    void Update()
    {
        if(dialogueStarted && DialogueManager.instance.dialogueFinished == true)
        {
            dialogueStarted = false;
            //movement.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Eury")
        {
            if(!dialogueStarted){
            DialogueManager.instance.StartDialogue(dialogueLines);
            }
            dialogueStarted = true;
            //movement.enabled = false;
            
        
        }

        
    }

}
