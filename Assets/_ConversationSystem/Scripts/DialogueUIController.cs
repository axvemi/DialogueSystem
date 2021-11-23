using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Axvemi.DialogueSystem
{
    /// <summary>
    /// Controller of the Dialogue UI
    /// Shows the conversation and speaker information on it
    /// </summary>
    public class DialogueUIController : MonoBehaviour
    {
        [SerializeField] private Image panel = null;
        [SerializeField] private Image speakerImage = null;
        [SerializeField] private TextMeshProUGUI text = null;

        #region  MONOBEHAVIOUR
        private void Awake(){
            GetComponent<DialogueHandler>().onNextLine += OnNextLine;
        }
        #endregion

        /// <summary>
        /// Called on next line.
        /// Changes what is being displayed on the Dialogue UI
        /// </summary>
        /// <param name="_line">Line being said</param>
        private void OnNextLine(DialogueLine _line){
            text.SetText(_line.Line);

            panel.color = _line.Speaker.Color;
            speakerImage.sprite = _line.Speaker.Sprite;
        }
    }
}
