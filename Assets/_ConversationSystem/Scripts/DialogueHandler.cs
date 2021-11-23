using UnityEngine;
using System;

namespace Axvemi.DialogueSystem
{
    /// <summary>
    /// Handler of the conversation and the conversation flow
    /// </summary>
    public class DialogueHandler : MonoBehaviour
    {
        /// <summary>
        /// Dialogue being used in the DialogueHandler
        /// </summary>
        public Dialogue ActiveDialogue = null;
        [HideInInspector] public int ActualLine = 0;

        #region ACTIONS
        public Action<Dialogue> onDialogueStarted;
        public Action<Dialogue> onDialogueFinished;
        public Action<DialogueLine> onNextLine;
        #endregion


        #region CONVERSATION
        /// <summary>
        /// Starts the dialogue with the current assigned dialogue
        /// </summary>
        public void StartDialogue(){
            if(ActiveDialogue == null) return;
            ActualLine = 0;

            onDialogueStarted?.Invoke(ActiveDialogue);
            onNextLine?.Invoke(ActiveDialogue.Lines[ActualLine]);

            Debug.Log("Dialogue started");
        }


        /// <summary>
        /// Goes to the next line of the conversation.
        /// If there are not more lines triggers end of the conversation
        /// </summary>
        public void NextLine(){
            ActualLine++;
            if(ActualLine > ActiveDialogue.Lines.Length - 1){
                onDialogueFinished?.Invoke(ActiveDialogue);
                Debug.Log("Dialogue finished");
            }
            else{
                onNextLine?.Invoke(ActiveDialogue.Lines[ActualLine]);
            }
        }
        #endregion     
    
    }
}
