using UnityEngine;

namespace GGJ2021
{
    public class AbilitySystem : IAbilitySystem
    {
        [SerializeField]
        private int manaTreshold = 2;

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
            if (currentMana >= manaTreshold)
            {
                // TODO: enable ui
            }
        }
    }
}