using NaughtyAttributes;
using UnityEngine;

namespace RunTime.Commands.Level
{
    public class OnLevelDestroyerCommand
    {
        private Transform _LevelHolder; 
        public OnLevelDestroyerCommand(Transform levelHolder)
        {
            _LevelHolder = levelHolder;
        }
        
        public void Execute()
        {
            if (_LevelHolder.transform.childCount <= 0) return;
            Object.Destroy(_LevelHolder.transform.GetChild(0).gameObject);
        }
    }
}