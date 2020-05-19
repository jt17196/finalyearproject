using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Prompts : MonoBehaviour {

    public Text generated;


    private int bfantasy;
    private int bromance;
    private int bcomedy;
    private int bhorror;
    private int bmusic;
    private int bmystery;
    private int baction;
    private int bdystopia;
    private int bwestern;
    private int bscifi;

    public void Randomprompt()
    {



        string[] none = new string[] 
        {

        //65 prompts
        "Bored at college you start tapping inaudibly under your seat. You find a note stuck to the bottom of it.",
        "A story of forbidden love set in a world where gender doesn’t exist, but other dividing factors and prejudices do.",
        "After living your whole life as an atheist, you die and arrive at The Pearly Gates confronted by St. Peter.",
        "Describe being a pollen grain on a flying bee. Flowers are ahead but a plastic bag suddenly intercepts your flight.",
        "Green smoke swirled inside the only jar among the empty bottles. Its label read: Don’t open. Or do. It’s up to you.",
        "Write about a character who can no longer recognise faces or objects. Describe their normal journey to work.",
        "An evacuee living in Cornwall to escape the Blitz finds the family they never had in a wild tribe of pixies.",
        "The stars were shining brightly when the child climbed out of bed, and tiptoed to the window.",
        "The Onkidonk of Erleigh Reach has left Baracu. They carry the Cron of Gal, their Javlik, and the stolen Neamosst.",
        "An urchin child accidentally murders the King’s religious minister. The King’s advisor takes him in.",
        "Being chased through time and space, your only escape is to find portal after portal, wherever they might appear.",
        "They took off their hat, along with their hand.",
        "You wake up. Everyone has disappeared apart from you and your best friend. What does the world feel like?",
        "You fall asleep a second after noticing your dream catcher fell and cracked on the floor. A trapped dream escapes.",
        "Write about a world in which humans have evolved to be able to communicate without spoken language.",
        "Write about a world where eyes are a gateway to other dimensions, and eye colour determines the dimension within.",
        "A child writes about a fantasy world and one night is transported there. They have until dawn to find a way out.",
        "They looked back through the portal and then at the new horizon before them. The two worlds were so different.",
        "They knew that jumping forward from this vast red rock would be their final jump; a step to their new home.",
        "What if when we die, we start our lives again in an alternate reality?",
        "An unemployed millennial chooses daring quests and giant slaying over yet another Thursday sitting in the job centre.",
        "A soldier has to rethink their strategy after a spelling error proves it wasn’t a dragoon terrorising the local villa.",
        "Today your kingdom was prophesized to crumble. Everything changes, but not quite how you thought.",
        "On the eve of your coronation you receive a gift: a severed hand clutching a scroll sealed with your enemy’s crest.",
        "By all means point your gun at me if it helps you to relax – it’s not like you’re actually going to use it.",
        "It was strange walking in through the front gate. Usually I’d be breaking in to a place like this.",
        "Make each person in your family into a deity of a new pantheon – and construct the full mythology around them.",
        "The tree in your backyard kneels down and begins a conversation.",
        "Most men die once. But my father isn’t like most men.",
        "Everyone is named alphabetically according to social class. Your name is Z---- (slums). You meet A---- (royalty).",
        "Hidden by the shadow of an oak tree, You wait. Your quarry comes into view just as a hand grabs you from behind.",
        "A teen looks in their bedroom mirror. Nothing is reflected back at them except darkness.",
        "You have exclusive use of a private jet and unlimited means. Where do you go? What if you can’t come back?",
        "The Death Houses, where the sick and destitute spent their last days, had been pulled down years ago.",
        "The camera could steal people’s souls. On the walls, the portraits wailed and begged for freedom.",
        "I try to lift my wrists, but the straps are too tight. I watch them take her away: my baby, born for their purpose.",
        "As our eyes met for the first time I imagined how it would feel to peel away their skin with my fingers.",
        "Since your sibling died you’ve heard their voice in your head, then other people begin to mistake you for them.",
        "I spotted the first mark on Sunday; a tiny purple bruise on my knee. By Tuesday my whole leg had turned black.",
        "You’re lying on a cold metal table in a morgue. And you’re awake.",
        "Yesterday I stopped screaming – all that was left was the silence.",
        "You come home to find an old-fashioned phone sitting in the middle of your table. No wires lead to it. It rings.",
        "Friends take a shortcut through a dark wood each telling a scary story as, unbeknownst to them, something follows.",
        "The apocalypse has come and gone, and society is rebuilding. How will the main character handle civilisation?",
        "Stretching out, the bony hand clasped and ripped at the air, desperate to wrench them into its abyss.",
        "Like clockwork, the scrabbling in the attic stopped and the screaming started.",
        "At first, they thought that nothing had happened at all. Then they looked down and saw the blood, and screamed.",
        "They live in the old asylum now, mumbling incoherently. No one had believed their story – how wrong they all were.",
        "I woke again with that desperate feeling of panic. It had happened again: the bloody blade lay beside me.",
        "A sadistic serial murderer is on the hunt, but what happens when fate has them choose a victim who feels no pain?",
        "’14th Century’ read the sign by the pub. Odd. The building looked old, but definitely hadn’t been here yesterday.",
        "The face stared out at me; wide-eyed and hollow-cheeked and instantly unforgettable.",
        "The crying at night doesn’t stop. Living alone, on an abandoned rig in the North Sea, I am afraid.",
        "The lights of every house in the town were on that night, except for one…",
        "A parent raises their child to fend for themself; they become a cannibal.",
        "The archaeologists were amazed to find a perfectly preserved human in that ice cave – but why did it have my face?",
        "An abandoned storage locker has been emanating a sickly sweet smell for weeks. What’s inside?",
        "Your villain has to go to therapy to discuss their issues. Write about what transpires during the session.",
        "You find yourself lost in the woods. You see arrows on the floor leading you further into the trees.",
        "They thought the employees in costume at the theme park were only pretending – they could not have been more wrong.",
        "You awake alone and get ready for work. You go to unlock the door and notice a strange pair of shoes by the doormat.",
        "Late one night you hear a knock at the door. You open it to see Death waiting. Death offers you a bargain…",
        "What if you fabricated a past only to start suffering the emotional and physical trauma associated with that life?",
        "Still life paintings at a holiday villa depict familiar scenes from your past. But you’ve never been here before.",
        "You never open the door when they’re knocking. Never.",
        //"Half-starved, I almost didn’t notice m fries weren’t fries at all… but something far more sinister.",
        //"An incurable virus has been stolen from a top security research lab and been placed in a town’s drinking water.",
        //"I pressed my palm to the glass. My breath caught as my reflection gripped my hand & bared its teeth in a grin.",
        //"Its evil red eyes burned into mine. I froze with cold terror as I realised the face staring back at me was my own.",
        //"The savage way the new lodgers gorged themselves at our welcome dinner told me that we, like our home, were theirs now.",
        //"As we walked through the wood the trees leaned inwards, and my hands became sticky not with sap… but with blood.",
        //"Your bare feet pound the forest floor as you realise you are not the hunted, you are the hunter.",
        //"You find a duffel bag beside the road and stop to investigate. What’s in it? What happens next?",
        //"Imagine living in the dark deep past, when only a few million people exist on the entire planet. And monsters.",
        //"I expected the knock at the door would come eventually, but I didn’t expect it to happen at midnight.",
        //"You get a call in the middle of the night: it’s a lawyer. You’ve inherited an estate, but there’s a catch.",
        //"I seldom found time for reflection but now, alone at sea; I'm inundated with re-emerging memories from my past.",
        //"They lived alone, so they were alarmed to see flowers and a sweating glass of champagne on the table when they arrived home.",
        //"A band goes on a tour in 1982. In every new town oddities occur that seem to be connected to the band somehow.",
        //"Five people meet over dinner. All their deaths are scheduled for two weeks’ time. Some want to die, some do not.",
        //"An innocent tweet about your breakfast spirals out of control, when a strange police squad arrests you for treason.",
        //"The door to the yoga studio was wide open when it should have been closed. But I had locked it myself last night.",
        //"Imagine your protagonist finds a loved one acting completely out of character, for no explicable reason. Why is it?",
        //"As the elevator door is about to close, you lock eyes with someone on the other side – someone from the past.",
        //"The protagonist lives a normal life until they adopt a cat, unaware that it ran away from its previous owner – the devil.",
        //"We all have deep, dark secrets. Something we saw, did, or heard. Write about that thing you’ve never told anyone.",
        //"The proprietor of the trattoria was puzzled by the customer who arrived every Tuesday at exactly 12.30.",
        //"You stand accused of killing the Queen. The only person who can vouch for you is her ghost. No one can see her.",
        //"You’re preparing for bed, you glance outside & there’s a car you don’t recognise. Then your doorbell rings….",
        //"A character needs help, but there’s a catch: they need to keep their goal a total secret from the helper.",
        //"If only, they thought, they had spelled my name right in my obituary, then this might have been a brighter day.",
        //"You wake, uneasy. There’s a soft, regular sound coming from downstairs. The baby is gone, your home altered…",
        //"Whilst walking your dog in the snow, you notice the tracks it leaves behind are human footprints.",
        //"You come to work one day to find all emails & social media accounts logged in to another person. Who are they?",
        //"A local take-away doesn’t have a menu or serve food, but weird customers come and go. You get a job to investigate.",
        //"I don’t know what made me follow them. They looked just like any other couple…",
        //"A mirror in the protagonist’s new house allows them to see into the life of someone murdered there fifty years ago.",
        //"If the people of the town had not been so eager to avoid eye contact they might’ve had an idea of what was coming.",
        //"The skull I’d placed in the kitchen window to deter unwanted visitors may not have helped.",
        //"Playing the message for the second time, they shivered. They hadn’t been known by that name for years.",
        //"In a train station, you see someone interesting and steal their bag and ticket. Where will your new items take you?",
        //"Nobody at the funeral was sure what had killed him, but they all had theories.",
        //"Write about a murder in a bouncy castle.",
        //"You suspect your partner is an online troll. How do you find out for sure, and what do you do?",
        //"The week before your home is due to be repossessed, your new boss calls you with an intriguing offer.",
        //"You are alone. Where are you? You are curious, fearless. What will you do? You can explore. What will you find?",
        //"What kind of person brings a toddler to a funeral? And who the hell leaves one there?",
        //"A man you faintly recognise is glaring at you as though he wished you dead. Who is he and why is he so angry?",
        //"Only one box was left in the attic. I had no idea what it was – or even if I had packed it up and put it there.",
        //"It had been stupid of me to even suggest it, but they committed a sin when they agreed. Everything had changed.",
        //"You wake up after a successful date, in a room decorated almost identically to your own.",
        //"People either fall for me or try to kill me. Little did I know that today, it would be both.",
        //"A beautiful letter to ‘the current occupant’ arrives. Inside is a red, silk handkerchief and an address on a card.",
        //"It all began the day I found myself on my knees cleaning out a dead man’s fridge.",
        //"You are mistaken for a member of a cult when you accidentally imitate their secret greeting.",
        //"A detective finally hunts down a notorious killer, only to realise upon their arrest that they agree with the killer's motive.",
        //"The knife had missed by an inch. This had to be the last time. Gently she took it from him, holding her breath.",
        //"In a bookshop, you see a book with your name on the spine. Your picture is on the book jacket. YOu did not write it.",
        //"Alone, the protagonist waits. Today, after twenty five years, they will finally meet their daughter.",
        //"Every year on the same day a new letter comes: ‘They're alive, and they’re waiting for you.’",
        //"I saw them across the room, their arm around a new lover. The first person I ever loved. The first person I’d ever kill.",
        //"Mother had been dead for eleven years when I saw her on a packed train.",
        //"The pizza chef was dead, smothered in mozzarella and tomatoes. Was it murder? Or had he topped himself?",
        //"I stood there waiting for the door to open, my heart thumping, my eyes burning. I knew it was the only way.",
        //"While checking the post you find that a letter has been sent to you from your deceased partner. What does it say?",
        //"You awaken encircled by eleven skeletons, your hand stamped with the number 12. What does this mean? Are you next?",
        //"The wind blew hard, and as the waves crept further up the beach the evidence slowly disappeared from the sand.",
        //"You stumble across your headstone at your local cemetery. Someone has written your epitaph. What does it say?",
        //"Then, very faintly, from the house next door, came the sound of breaking glass.",
        //"You sail back to land after a storm. No one remember who you are – neither spouse, nor friends, nor children.",
        //"A murder at a secluded crime writing retreat leads to some unusual methods of detecting the killer.",
        //"They had the party all planned out; a night of luxury, games, and twisted schemes.",
        //"The car sped away; they’d left me for dead by the roadside. Stupid of them, when I was alive and furious.",
        //"Every morning I had to hide my ex’s shoes; because every morning they came back from the grave and reappeared under my bed.",
        //"Recount the story of a family name, as told by the ghosts who bore it.",
        //"You awake with a jellyfish tattoo on your palm. Turning on the news, everyone has one. You set out to find out why.",
        //"Your spouse disappears for two weeks, then returns with a newborn.",
        //"The moonlight is so bright it wakes you. Looking out your window, you see the taxidermist working.",
        //"The protagonist investigates a murder, only to find out they were the one who committed it.",
        //"You’re a valet driver parking a car. Inside you find a crumpled note with your own address on it. What do you do?",
        //"They took the same seat they always did. This time, there was someone with them.",
        //"I knew it was over the day they shouted for mushrooms.",
        //"Two days after the proposal, they found a card at their doorstep, written in messy handwriting: ‘DON’T MARRY THEM.’",
        //"In order to merge their businesses, two wealthy people are forced into an unwanted arranged marriage.",
        //"An unattached billionaire wants to find a worthwhile heir, so they pretend to be broke.",
        //"Write a story from the point of view of a 100 year old mirror.",
        //"The street lamp seemed brighter with them standing underneath. She looked at me and there was just the two of us.",
        //"We’d matched on Tinder, and arranged to meet. I was happy until I saw the slogan on their t-shirt.",
        //"The babysitter was late, her shoes hurt and she wasn’t a bit hungry after finishing the girls leftovers.",
        //"They’ve never met outside of a dream, but they are in love. One is the Moon and one the Sun.",
        //"I climbed to the top of the mountain, and then I knew I would be free.",
        //"They began to run, faster and faster, as quickly as their short legs could carry them. There was no turning back now.",
        //"Carefully you lift the quill and open the small vial of ink. This is the most difficult letter to write…",
        //"Two gay puffins want to adopt an egg. Will the RSPB help them in their quest for responsible parenthood?",
        //"A blind person falls in love with the scent of a train passenger. How do they find them?",
        //"The protagonist nervously awaits their turn for an interview but discovers the interviewer is an ex-lover. What happens next?",
        //"Your estranged sibling unexpectedly dies and would like you to become guardian to their child.",
        //"“I love you”, they said, but it came out like a scream. Mucus glistened from their nose and mouth. “You’re crazy.”",
        //"The lead can’t use the word love or an equivalent. What terms/actions do they use instead to express this feeling?",
        //"Someone is arrested for a murder they didn’t commit. Their lover becomes a lawyer to clear them.",
        //"The protaginist finds notes in books they borrows from library. They searches for the sender.",
        //"They were the last person you expected to see standing there. It had been twelve long years. What do you do?",
        //"“Give me one good reason why I should wear a dress.” They stuck their chin out defiantly. “You’re the bride.”",
        //"Two people connect on a singles app. A virtual romance begins, despite living locally they haven’t met…",
        //"Chaos ensues when a charming newcomer moves into a retirement block.",
        //"You should have called them 5 years ago but didn’t. You dial the number now; they pick up…",
        //"The congregation stifled giggles as it grew clear that what the vicar was reading aloud was definitely not the intended sermon.",
        //"As I hung desperately onto the barrier, watching your train depart, I realised that I’d made a huge mistake.",
        //"They was standing outside the building again, cap low, head down.",
        //"A couple react to a tragic event – it doesn’t involve them but it alters their relationship in a significant way.",
        //"The blind one's ideas are as seductive as they are unsettling.",
        //"Write about the storm that started the day they disappeared.",
        //"Write a dystopian romance about someone whose memory has been extracted trying to find their way back to the truth.",
        //"They were beginning to wish they had not worn their buttoned-up camel-haired coat on such a warm day.",


        };

        string[] fantasy = new string[] {
            
         //8 prompts
        "A counterfeiter’s coins or a forger’s fake works of art have magical properties.",
        "A neglected god or goddess attempts to reclaim his or her former glory.",
        "People are spontaneously combusting.",
        "People are committing surprising acts in their sleep.",
        "This might cure the current plague—if it can be found.",
        "A smuggler, mercenary, or thief takes down or helps take down an oppressive ruler or regime.",
        "An attempt to rescue a friend, family member, or lover will put a larger mission or cause in jeopardy.",
        "A peasant girl, who may be good or evil, believes that a divine figure in a vision told her to lead an army to victory."


        };

        string[] romance = new string[] {

            //20 prompts
            "A fortuneteller falls in love with their client who has their palm read every month.",
            "It wasn't love at first sight. But now you were starting to see them in a new light…",
            "Someone with anxiety falls in love with someone extremely adventurous.",
            "The lives of two people are changed forever when they coincidentally meet and enagge in a weekend-long affair.",
            "They lived in a world where PDA is forbidden. One day, they slipped up and held hands on the street.",
            "Two characters who are perfect for one another are foiled by bad timing.",
            "Two mortal enemies fall in love when they're trapped in an elevator together and begin to see the other person's perspective.",
            "Valentine's Day at the retirement home.",
            "Well, that was a New Year's Eve kiss you won't forget anytime soon.",
            "You have the ability to make anyone fall in love with you.You've just fallen in love for the first time. Do you use your power?",
            "You never would have guessed that in 48 hours you'd be married.",
            "You've been bumping into the same stranger for months. Finally you decide to say hello.",
            "They might have aged 50 years, but when they held yours, those hands felt exactly like they did the first time.",
            "In the future, romantic attraction is literal: each person is fitted with an electromagnetic bracelet which, they claim, will pull you to your soulmate.It's the day they turn the magnets on, and you're waiting.",
            "Write a romantic comedy. Difficulty: both lovers are emotionally mature and have excellent communication skills.",
            "You meet your doppleganger of the opposite sex and find you are strangely attracted to each other.",
            "Cupid offers to shoot an arrow into the person you love.He warns you that if the person already has a pre - existing affection towards you, it will disappear when the arrow strikes.",
            "Everyday, you return to your apartment and say “Honey, I’m home. Oh wait, that’s right, I live alone.” But one day, a voice replies, “I picked some pizza.”",
            "At a friend's urging, you begrudgingly attend a Valentine's Day speed dating event.",
            "Couples’ therapy — what a nice way to spend your anniversary."
        };


        string[] comedy = new string[] {

            //20 prompts
            "The dog ate my homework.",
            "A sudden BANG! and puff of smoke emerged from a garage in a quiet suburban neighbourhood.",
            "In the midst of writer's block, an author goes to sit at a bus station looking for inspiration. They get more than they bargained for.",
            "It was the highest stakes game of rock-paper-scissors ever played.",
            "It was the kind of Friday that gave new meaning to the phrase TGIF.",
            "Make the absurd absolutely and completely normal.",
            "That night, the action backstage was even more dramatic than the story unfolding onstage.",
            "When an elderly person went to their local mall, they had no idea they'd wind up saving the world.",
            "You decide to buy a big school bus and to travel your country. You post an ad asking if anyone would like to join you.You're surprised by the number of people who show up.",
            "You had the greenest grass around.No one's could be greener. Right...?",
            "You have a writer's block breakthrough at the worst possible moment.",
            "You were ready to write the worst Amazon review ever.",
            "You'd never had a bus ride quite like that.",
            "You're in a waiting room at a clinic that promises to cure writer's block.",
            "Forget Ferris Bueller, you were detemined to make this the best day off. Ever.",
            "You're on a blind date — with your sworn enemy.",
            "You open your closet one morning.Something clatters out. You pick it up. The skeletons in your closet have been made real.",
            "You accidentally run over a bunny on your way to work. It turns out that it's the Easter Bunny.",
            "A tiny mouse must zealously guard his tiny cube of cheese from the menacing outside world.",
            "Every morning you receive a package delivered to your door, containing an item that you end up needing later that day."
        };


        string[] horror = new string[] {

            //25 prompts
            "A musician practices. When she finishes a piece, she hears someone clapping for her, although she lives alone.",
            "Frightening events in a small town lead its citizens to dig up the grave of a deceased inhabitant.",
            "Someone gets on the elevator by himself and is never seen by his friends or family again.",
            "The Furies—the vengeance deities of classic mythology—are back in business again.",
            "A collector buys an unpublished manuscript by an obscure writer that describes a terrible historical event a year before it occurred.The collector learns the writer wrote many unpublished stories…",
            "Creating a hybrid of a human and this particular animal turns out to be a bad idea.",
            "A person has the ability to make other people very ill.",
            "The dead walk out of the sea.",
            "An individual begins seeing and hearing from someone who looks just like her – and learns she had a twin who died at birth.",
            "A killer places an advertisement for a willing victim and finds one.",
            "A basement contains jars filled with unusual specimens.",
            "A person finds new photos of herself on her cell phone that she didn’t take.",
            "The spirit of a brutalized slave or prisoner of war wants revenge on his tormentor’s descendants.",
            "A couple vacationing in a remote area begins having the same nightmares.",
            "All of the circus performers were killed in the train wreck.",
            "The television switches to another station of its own accord and plays footage of something horrible that happened long before the technology existed to record it.",
            "A spouse or sibling dies.He or she begins to take over the body of the surviving spouse or sibling.",
            "Weekend adventurers explore a cave and can’t find their way out again.Then they encounter something terrible…",
            "Authorities go through the cluttered apartment of a deceased man who lived alone with no known friends or relatives for decades and find something disturbing.",
            "A group of teenagers trolls everyone else in an online group by telling made-up stories about terrible things they’ve done. Things then get out of hand.",
            "It’s bad luck in the theatre to call the Shakespeare play Macbeth by name, but someone in the company keeps doing it anyway… and the superstition proves true.",
            "Every exhibit in this carnival sideshow is fake.Except this one thing.",
            "An individual develops a terror of water – drinking it, touching it, or even being near it.There’s actually a good reason why.",
            "The grandfather clock starts running backwards.",
            "People in this neighborhood begin having freak accidents that involve normal appliances and machinery, such as blenders, weed whackers, and garage doors."

        };



        string[] music = new string[] {

        //7 prompts
        "That summer, everybody was listening to that song. It was playing everywhere.",
        "The protagonist’s significant other is a musician—always on the road. When rumors of trysts with groupies arise, the protagonist decides to follow the tour bus and see what’s really going on.",
        "She waves her wand and the music rises and falls—deep lulls and glorious crescendos, trills from the wind section and a deep hum from the brass.",
        "The new school you moved to thinks that music is a waste of time. There are no music classes, no choir classes, no music played at sports events, and no one is allowed to listen to music on their electronic devices while on school grounds or on the bus. ",
        "Your music teacher has acquired a musical instrument that the aborigines used in Australia called a didgeridoo. Only one student is going to be allowed to learn the instrument. You want to be that student. ",
        "It sounded like violin music, and it was coming from the basement...",
        "You find a musical instrument, unlike any other. Where has it come from? More importantly, how does it sound?",


        };

        string[] mystery = new string[] {

        //22 prompts
        "As you're paying for your groceries, you mention to the clerk, There's a mess in aisle 16. They give you a puzzled look and reply, There is no aisle 16.",
        "The detective didn't realize they were being foiled by a competiting detective.",
        "The first day you opened your own office as a private investigator, you didn't expect it to be busy. You were wrong.",
        "You're shaking hands with a stranger at a networking event when you ask for their name. I have no name, they reply.",
        "A genius serial killer has been killing successfully for a decade. His only weakness is that he can never, ever lie. He finally gets caught and is facing trial for all murders in court. Yet, he walks, acquitted of all charges.",
        "20 years after your daughter was abducted a detective finds you to reopen the case. The detective turns out to be your daughter.",
        "You hire two private investigators to investigate each other. One month later both come to you to present their findings.",
        "You are legally allowed to commit murder once, but you must fill out the proper paperwork and your proposed victim will be notified of your intentions.",
        "'...and that's why dividing by three is illegal.'",
        "You were the oldest person still living in the town and you remembered things no one else did.",
        "They say a picture is worth a thousand words but you knew the one you'd just taken was worth a million.",
        "You open a book and note with a letterhead falls out. At the top it says: If you are reading this, you have been chosen.",
        "A crime’s been committed, and the only clues left behind are a half-eaten apple and a bobby pin.",
        "You go to your regular coffee shop and order the usual. They slide something else across the counter instead.",
        "As you’re taking down a painting, you notice something odd engraved on the back.",
        "You’ve been having dreams about cruise ships for months now, and you’re desperately trying to figure out what they mean.",
        "You never thought you'd visit a palm reader. But now you were starting to think it might be the only place you'd get answers.",
        "A crime has been committed, and the only clues left behind are a flashlight and a copy of 'Moby-Dick.'",
        "You recently moved to a new house. Every day, on your walk home past a park, you notice an empty swing swinging.",
        "You had developed a habit of sleepwalking. But you weren't alone now — it seemed like the whole town had started sleepwalking at night, too.",
        "You receive a bizarre voicemail from an unknown number.",
        "You discover a trap door in your home that you never knew about."


        };

        string[] action = new string[]{

            //8 prompts
            "The mob has taken down your lover and imprisoned your family. Now it's time to get even!",
            "You are on the run from the police after being wrongfully accused for murder.Your only way of avoiding life in prison is to clear your name by finding the person who did this.",
            "You are a police officer involved in a high speed car chase.Go into extreme detail including all of the cars that get into accidents during your chase and how you attempt to catch the bad guys.",
            "The bad guy almost always loses. Put yourself in the role of a bad guy during a big adventurous heist.",
            "After a big explosion, you need to help rescue multiple people out of a burning building.",
            "Imagine that you are one of the Titanic passengers and you must avoid the many trials and tribulations of a sinking ship.",
            "In a strange turn of events, you have found out that both of your parents are secret spies and that you have been thrown right into the middle of it.",
            "You are a hot - shot fighter pilot looking to take down an enemy battallion."
        };

        string[] dystopia = new string[]{
            //25 prompts
            "In a post-apocalyptic world, where a person’s five senses are taken away and earned back through monetary credits earned through indentured servitude to the privileged class.",
            "A society in which a family’s wealth dictates how many of its own children that they can keep.",
            "A futuristic world where everyone’s thoughts and dreams are constantly monitored so they can be taken and used by the wealthy privileged class to remain in power.",
            "A world so dependent on technology, that the human race has stopped being a social mammal, and this unbreakable solitude now puts them at risk for extinction.",
            "When Earth is ravished by a series of climate-related catastrophes, the survivors have no choice but to fight over the small plot of land that is still fit for human survival.",
            "Artificial intelligence and augmented reality have become a staple in day-to-day with life, so much so that the average person spends 24 hours a day in a virtual state.What happens when they find out the AI discovered a way more useful use of this technology and entertaining the people in it.",
            "In a future world that prides itself on optimal efficiency, each person is given the exact path they are to live down to the very day starting with the day they’re born.",
            "A world with limited resources after an intergalactic war destroys most of the planet, forces, and citizens to self-police population growth.The law says for every person born into a family one must die.",
            "Earth loses an intergalactic war to a hostile invading species within the enslaved the survivors to help them extract every last resource out of the planet.",
            "In this world, thoughts are crimes.Artificial intelligence is judge, jury, and executioner.",
            "After the last great world war, all religion was banned. This included all religious works and artifacts.But what happens if one Bible still remains?",
            "In this society, the only currency anyone has his life expectancy. The ruling class oppresses the masses of poor citizens by forcing them to trade days of life for the basic goods and services needed for survival.",
            "In a society that is focused on gene manipulation and the furthering of the human species, any people with less than desired DNA is either made infertile and sent into slavery or eradicated at birth.",
            "The human race is overtaken by alien hostiles, they are forced to live in a quasi-vegetative state offset by augmented reality while their bodies slowly decay as they are used as human carbon batteries.",
            "All learning is banned from society.The Internet is totally rewritten and all books are destroyed.The only thing society has is the propaganda given to it by its oppressive ruling class.",
            "In a world, where it is been determined, that the optimal age for existence is 28, humans are perpetually cloned at that age and granted existence until they turn 29.",
            "Society has gotten over the automated, and the richest class has gotten richer and richer while everyone else has fallen into squalor.To deal with the boredom and help entertain the ruling class,  poor citizens turned in use as pets.",
            "In a society 100% under state control, humans are selected at random to face off against each other in a 24 hour broadcasted deathmatch.",
            "A weaponized biologic is used to control everyone’s actions as it empowers its creators to instantly activate it inside of any one person killing them within 24 hours.",
            "In a world where disease is left unchecked, the only ones privileged enough for Medicare and the cures are the controlling class of Aristocrats.",
            "A world where all money is done away with, instead, people must pay their way with an intellectual or physical contribution to society.What happens when a system of deciding the value of contributions is rigged?",
            "Women have come to power over 3000 years ago, slowly the value of men has declined.To the point where their only value and reason for existence is procreation of more women.",
            "In a twisted futuristic world, society’s darkest minds are connected to an Augmented Reality machine to have their machinations come to life as entertainment for the rest of society. When these virtual reality horror shows come to life the world will never be the same.",
            "A world that no longer believes in prisons, instead these prisoners are used as human prey in a dark and twisted hunting game.",
            "Sports, as we know them, are long gone, they have been replaced by darker, deadlier versions of their past games. The new death games are meant to be a social release for the masses to avoid unleashing true demons on themselves.But what if the games were really a way to desensitize and train people to act the very way the games were said to prevent."
        };

        string[] western = new string[]{
            //5 prompts
            "You’re a sheriff in an old, western town. One day, something very peculiar happens.",
            "Write a story that takes place in the old west. Use at least 5 of the following words: howdy, y’all, longhorns, ranch, horse, lasso, cactus, corral, wild, flea - bitten",
            "A few miles from where you live is an old western town. The mayor wants to have it torn down. You think it has historical value. Convince him why you think the old town should remain standing.",
            "Describe the everyday life as one of the following: rattlesnake, armadillo, jackrabbit, tarantula, coyote, roadrunner, scorpion",
            "Write a story about a day in the life of a cowboy or cowgirl.This can be real or fictional, serious or funny, normal or wild."
        };

        string[] scifi = new string[]{
            //25 prompts
            "You find out you’re a DNA experiment combining as many recessive genes into one person as possible. That’s why you’ve always felt so different from everyone else.",
            "A man takes a vacation to another dimension only to find that everything he was trying to get away from, he’s brought with him.",
            "Couchsurfing on another planet goes wrong.",
            "A marathon runner illegally trains on a planet with stonger-than-Earth gravity to gain an advantage over his competition in the inter-universe Olympics.",
            "“It’s not really a fly. If you swat it, they’ll just fine you and send two more.”",
            "You think you’re chasing the last vestige of a prehistoric Earth creature, but it turns out to be an alien.",
            "A woman disappears for three years and returns with psychic powers.",
            "“If I can’t save her from the creaux, then no one else matters.”",
            "The solar system is an ecologically closed spacecraft hurtling makind toward its ultimate destiny.",
            "“We’re headed to Madam Maxime’s at the edge of the universe.”",
            "An existentially bored man who lives in a smart house—where everything is done for him—pines for the Wild West where men had to fend for themselves.",
            "A corporate analyst who investigates failed colonization projects encounters the strangest case of his career.It’s a ghost colony with no record of anything catastrophic or any indication of what went wrong.The people are simply gone...",
            "“I learned to stop time traveling today.I was doing it just to hurt myself.”",
            "An orphan girl, desperate to make anything last, snaps pictures with a camera she found among ship wreckage.She finds she can enter the still - life photos without aging.",
            "“We were always on the same page, even when it came to splitting for separate planets.”",
            "A social worker in an impoverished planetary colony discovers a cheap way to manufacture housing for the homeless, but the housing material is on a corporate reserve.",
            "A hobo finds the secret to true love tonic.",
            "An old woman, fed up with the alien soldiers she’s forced to house, kills one who puts his muddy boots on her coffee table for the last time.",
            "Women on Calisto colony are legally permitted only two children each. One man decides that one wife and two children aren’t enough.",
            "Tired of stalled space exploration advancements, a scientist convinces the public that a meteor is on a collision course with Earth.In designing the fake “evidence,” it turns out the meteor isn’t a hoax.But now no one believes him.",
            "A neurologist discovers that the human brain is wired to learn planetary physics during infancy.Is this proof that humans weren’t always Earth-dwelling?",
            "Everyone on Earth falls asleep at the same time, except one man.",
            "“You can see my love from space.”",
            "Each child a woman births is a vote for that world’s continuation.",
            "A girl’s dead brother contacts her through dreams claiming the afterlife is just another dimension."
        };




        string noneprompt =
            "General: \n" +
            none[Random.Range(0, none.Length)];

        string fantasyprompt =
            "Fantasy: \n" +
            fantasy[Random.Range(0, fantasy.Length)];

        string romanceprompt =
           "Romance: \n" +
           romance[Random.Range(0, romance.Length)];

        string comedyprompt =
            "Comedy: \n" +
           comedy[Random.Range(0, comedy.Length)];

        string horrorprompt =
            "Horror: \n" +
           horror[Random.Range(0, horror.Length)];

        string musicprompt =
            "Music: \n" +
           music[Random.Range(0, music.Length)];

        string mysteryprompt =
            "Mystery: \n" +
           mystery[Random.Range(0, mystery.Length)];

        string actionprompt =
                    "Action: \n" +
                   action[Random.Range(0, action.Length)];

        string dystopiaprompt =
            "Dystopia: \n" +
           dystopia[Random.Range(0, dystopia.Length)];

        string westernprompt =
            "Western: \n" +
           western[Random.Range(0, western.Length)];

        string scifiprompt =
            "Scifi: \n" +
           scifi[Random.Range(0, scifi.Length)];


        string[] prompts = new string[] {};
        List<string> myList = new List<string>();
        myList.Add(noneprompt);

        bfantasy = PlayerPrefs.GetInt("Bought Fantasy");
        bromance = PlayerPrefs.GetInt("Bought Romance");
        bcomedy = PlayerPrefs.GetInt("Bought Comedy");
        bhorror = PlayerPrefs.GetInt("Bought Horror");
        bmusic = PlayerPrefs.GetInt("Bought Music");
        bmystery = PlayerPrefs.GetInt("Bought Mystery");
        baction = PlayerPrefs.GetInt("Bought Action");
        bdystopia = PlayerPrefs.GetInt("Bought Dystopia");
        bwestern = PlayerPrefs.GetInt("Bought Western");
        bscifi = PlayerPrefs.GetInt("Bought Scifi");

        if (bfantasy == 1)
        {
            myList.Add(fantasyprompt);     
        }

        if (bromance == 1)
        {
            myList.Add(romanceprompt);
        }

        if (bcomedy == 1)
        {
            myList.Add(comedyprompt);
        }

        if (bhorror == 1)
        {
            myList.Add(horrorprompt);
        }

        if (bmusic == 1)
        {
            myList.Add(musicprompt);
        }

        if (bmystery == 1)
        {
            myList.Add(mysteryprompt);
        }
        if (baction == 1)
        {
            myList.Add(actionprompt);
        }

        if (bdystopia == 1)
        {
            myList.Add(dystopiaprompt);
        }

        if (bwestern == 1)
        {
            myList.Add(westernprompt);
        }

        if (bscifi == 1)
        {
            myList.Add(scifiprompt);
        }

        prompts = myList.ToArray();



        string generate = prompts[Random.Range(0, prompts.Length)];



        generated.text = generate;
    }
}
