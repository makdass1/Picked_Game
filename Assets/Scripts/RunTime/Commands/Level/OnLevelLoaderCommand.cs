using UnityEngine;

namespace RunTime.Commands.Level
{
    public class OnLevelLoaderCommand
    {
        public Transform _levelHolder;
        public OnLevelLoaderCommand(Transform levelHolder)
        {
            _levelHolder = levelHolder;
        }
    
        public void Execute(byte levelIndex)
        { 
            Object.Instantiate(Resources.Load<GameObject>(path:$"Prefabs/LevelPrefabs/Level {levelIndex}"),_levelHolder,true);   
          
        }
    }
}