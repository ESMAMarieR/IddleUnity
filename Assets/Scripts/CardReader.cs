using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CardReader : MonoBehaviour
{

    private int _currentHp;
    [SerializeField]
    private TextMeshProUGUI _hpText,_nameText,_typeText;
    [SerializeField]
    private Image _cardImage;

    [SerializeField]
    private PokemonCard _currentCard;

    [SerializeField]
    private PokemonCard[] _deck;
    
    void Start()
    {
        ReadCard(_deck[Random.Range(0,_deck.Length)]);
    }

    //a recup
    public void ReduceHp()
    {
        _currentHp += 1;
        _hpText.text = _currentHp.ToString("000");
        if( _currentHp <= 0 )
        {
            ReadCard(_deck[Random.Range(0, _deck.Length)]);
        }
    }
    
    private void ReadCard(PokemonCard newCard)
    {
        _currentCard = newCard;

        _currentHp = _currentCard.hpBase;

        _hpText.text = _currentCard.hpBase.ToString("00");
        _nameText.text = _currentCard.cardName.ToString();
        _typeText.text = _currentCard.type.ToString();

        _cardImage.sprite = _currentCard.cardImage;

       
    }

}
