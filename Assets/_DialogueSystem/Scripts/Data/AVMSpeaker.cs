using UnityEngine;

namespace Axvemi.DialogueSystem
{
    /// <summary>
    /// Scriptable Object for the speaker assets
    /// </summary>
    [CreateAssetMenu(fileName = "Speaker", menuName = "Axvemi/DialogueSystem/Speaker")]
    public class AVMSpeaker : ScriptableObject
    {
        public string SpeakerName = string.Empty;
    }
}
