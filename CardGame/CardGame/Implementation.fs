
module Implementation
    open Model
    open System
    let private Cards = [One ; Two ; Three ; Four ; Five ; Six ; Seven ; Eight ; Nine ; Ten ; Jack ; Queen ; King ; Ace]
    let private Suits = [Heart; Diamond; Club; Spades]

    let initialDeck = 
        let deck = seq {
            for j in Suits do
                for i in Cards do
                    yield (i,j)
        }
        List.ofSeq(deck) 


    
    let shuffleSupport (list:Deck) =
        let rnd = System.Random(DateTime.Now.Second)
        let loc = rnd.Next(0,list.Length)
        let first = seq{
            for i = 0 to loc do
                yield list.Item(i)
            }
        let second = seq{
            for j = loc+1 to list.Length-1 do
                yield list.Item(j)
            }
        List.ofSeq(second) @ List.ofSeq(first) 
        
           
    
    let Shuffle (d:Deck) = 
        let mutable deck = d;
        for i = 0 to 100 do
            deck <- (shuffleSupport deck)
        deck
        
       

        
        
  


            
                
            
        

               

                 
        
        

   

                