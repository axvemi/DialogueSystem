using UnityEngine;

namespace Axvemi.DialogueSystem
{
    /// <summary>
    /// Controller for the Dialogue Handler. For testing purposes.
    /// </summary>
    public class DialogueController : MonoBehaviour
    {
        private void Start(){
            GetComponent<DialogueHandler>().StartDialogue();
        }
        private void Update(){
            if(Input.GetKeyDown(KeyCode.Space)){
                GetComponent<DialogueHandler>().NextLine();
            }
        }
    }
}
