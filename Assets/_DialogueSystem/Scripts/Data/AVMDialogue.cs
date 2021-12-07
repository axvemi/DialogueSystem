using UnityEngine;

namespace Axvemi.DialogueSystem
{
    /// <summary>
    /// Scriptable Object for the Dialogue assets
    /// </summary>
    [CreateAssetMenu(fileName = "Dialogue", menuName = "Axvemi/DialogueSystem/Dialogue")]
    public class AVMDialogue : ScriptableObject
    {
        public AVMDialogueLine[] Lines = null;

    }

    /// <summary>
    /// Dialogue line
    /// </summary>
    [System.Serializable]
    public class AVMDialogueLine{
        public string Line = string.Empty;
        public AVMSpeaker Speaker = null;
    }
}
