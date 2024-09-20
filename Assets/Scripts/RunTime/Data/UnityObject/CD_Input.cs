using RunTime.Data.ValueObject;
using UnityEngine;

namespace RunTime.Data.UnityObject
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "picked_Game/CD_Input", order = 0)]
    public class CD_Input : ScriptableObject
    {
        public InputData Data;
    }
}