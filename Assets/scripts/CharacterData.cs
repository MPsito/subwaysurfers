using UnityEngine;

[CreateAssetMenu(fileName = "characterData", menuName = "Scriptable Objects/characterData")]
public class CharacterData : ScriptableObject
{
    public string jumpAnimationName = "Jump";
    public string moveAnimationName = "Move";
    public string rollAnimationName = "Roll";
    public string loseAnimationName = "Lose";
    public string runAnimationName = "Run";
    public string flyAnimationName = "Fly";
}
