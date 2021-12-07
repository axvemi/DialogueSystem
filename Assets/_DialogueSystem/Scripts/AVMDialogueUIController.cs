using UnityEngine;
using TMPro;

namespace Axvemi.DialogueSystem
{
    /// <summary>
    /// Controller of the Dialogue UI
    /// Shows the conversation and speaker information on it
    /// </summary>
    public class AVMDialogueUIController : MonoBehaviour
    {
        [SerializeField] protected TextMeshProUGUI text = null;

        #region  MONOBEHAVIOUR
        private void Awake(){
            GetComponent<AVMDialogueHandler>().onNextLine += OnNextLine;
        }
        #endregion

        /// <summary>
        /// Called on next line.
        /// Changes what is being displayed on the Dialogue UI
        /// </summary>
        /// <param name="_line">Line being said</param>
        protected virtual void OnNextLine(AVMDialogueLine _line){
            text.SetText(_line.Line);
        }
    }
}
