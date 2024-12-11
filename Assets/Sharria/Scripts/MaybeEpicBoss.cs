using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Sharria { 
    public enum BossStates
    {
        StartState, Melee, Range, Ultimate, DefenceMelee, DefenceRange, Death
    }

    public class MaybeEpicBoss : MonoBehaviour{

        private bool isDefendingMelee;
        private bool isDefendingRange;
        private bool isRangeSetUp;
        private bool isUltimateSetUp;
        private bool onRangecooldown;
        private bool onMeleeCooldown;
        private bool onUltimateCooldown;


        BossStates currentState = BossStates.StartState;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
