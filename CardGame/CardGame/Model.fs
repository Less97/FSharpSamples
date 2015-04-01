module Model
    
   type Suits = Club | Spades | Diamond | Heart
   type Numbers = One | Two | Three | Four | Five | Six | Seven | Eight | Nine | Ten | Jack | Queen | King | Ace

   type Card =  Numbers * Suits

   type Deck = Card list
   type Hand = Card list