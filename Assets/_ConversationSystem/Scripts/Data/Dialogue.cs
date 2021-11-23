using UnityEngine;

namespace Axvemi.DialogueSystem
{
    /// <summary>
    /// Scriptable Object for the Dialogue assets
    /// </summary>
    [CreateAssetMenu(fileName = "Dialogue", menuName = "Axvemi/DialogueSystem/Dialogue")]
    public class Dialogue : ScriptableObject
    {
        public DialogueLine[] Lines = null;

    }

    /// <summary>
    /// Dialogue line
    /// </summary>
    [System.Serializable]
    public class DialogueLine{
        public string Line = string.Empty;
        public Speaker Speaker = null;
    }
}
