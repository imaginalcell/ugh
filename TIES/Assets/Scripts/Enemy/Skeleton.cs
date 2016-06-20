using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets
{
    public class Skeleton
    {
        int moveSpeed = 3;
        int rotationSpeed = 3;
        int ArmorValue;
        int hp;

        Transform target;
        Transform mytransform;
        public WarriorClass warrior;
        public MageClass mage;
        public LevelSystem playerLevel;
        

        void Start ()
        {
            hp = 100;
            ArmorValue = 1;
            
        }
        
    }
}
