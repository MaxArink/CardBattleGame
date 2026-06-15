//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;

//public class HorizontalCardHolder : MonoBehaviour
//{
//    [SerializeField] private Card _selectedCard;
//    [SerializeReference] private Card _hoveredCard;

//    [SerializeField] private GameObject _slotPrefab;
//    private RectTransform _rect;

//    [Header("Spawn Settings")]
//    [SerializeField] private int _cardsToSpawn = 7;
//    public List<Card> cards;

//    bool isCrossing = false;
//    [SerializeField] private bool tweenCardReturn = true;

//    void Start()
//    {
//        for (int i = 0; i < _cardsToSpawn; i++)
//        {
//            Instantiate(_slotPrefab, transform);
//        }

//        _rect = GetComponent<RectTransform>();
//        cards = GetComponentsInChildren<Card>().ToList();

//        int cardCount = 0;

//        foreach (Card pCard in cards)
//        {

//        }

//        StartCoroutine(Frame());

//        IEnumerator Frame()
//        {
//            yield return new WaitForSecondsRealtime(.1f);
//            for (int i = 0; i < cards.Count; i++)
//            {
//                if (cards[i].cardVisual != null)
//                    cards[i].cardVisual.UpdateIndex(transform.childCount);
//            }
//        }
//    }

//    private void BeginDrag(Card pCard)
//    {
//        _selectedCard = pCard;
//    }

//    private void EndDrag(Card pCard) 
//    { 
//        _selectedCard = pCard; 
//    }

//    private void CardPointerEnter(Card pCard)
//    {
//        _hoveredCard = pCard;
//    }

//    void CardPointerExit(Card card)
//    {
//        _hoveredCard = null;
//    }
//}
