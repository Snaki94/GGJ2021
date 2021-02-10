using UnityEngine;
using Zenject;

namespace GGJ2021
{
    public class AbilitySystem : IAbilitySystem
    {
        private const int MANA_TRESHOLD = 2;
        
        [Inject]
        private ITurnSystem turnSystem;

        private int currentMana;

        public void ResetMana()
        {
            currentMana = 0;
        }

        public void AddMana()
        {
            currentMana++;
            EnableAbilitiesIfReady();
        }

        private void EnableAbilitiesIfReady()
        {
            if (currentMana >= MANA_TRESHOLD)
            {
                turnSystem.GetCurrentPlayer().PlayerController.ShowAbilityPanel();
            }
        }
    }
}