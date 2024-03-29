using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ElixirMaker.Config;
using ElixirMaker.Object;

namespace ElixirMaker.Manager
{
    public class GameUIManager : MonoBehaviour
    {
        [SerializeField] private Transform playerHand;
        [SerializeField] private CardSample cardSample;
        [SerializeField] private CardInspector cardInspector;
        [SerializeField] private PlayerBag playerBag;
        public void CreateCardToPlayerHand(int playerIndex, ElixirCardData currentCard)
        {
            CardSample newDisplayCard = Instantiate(cardSample, this.playerHand); //playerIndex to check what hand we wanna create card
            newDisplayCard.Init(currentCard);
        }
        public void InspectCard(int playerIndex, CardSample currentCard)
        {
            this.cardInspector.gameObject.SetActive(true);
            this.cardInspector.ShowCardInformation(currentCard);
        }
        public void UpdateBag(PlayerData player)
        {

        }
    }
}