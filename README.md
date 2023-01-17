# 29-prj01-recap-fwesenauer
Thema: Winter, Spiel an Winter anpassen

Konzept: Ein Lebkuchenmännchen muss in einer Schneelandschaft Zuckerstangen sammeln, trifft es dabei allerdings auf Stechbeeren wird es vergiftet und verliert für 5 Sekunden an Geschwindigkeit. Fährt es über den Stern, so wird es jedoch schneller. Man muss in 90 Sekunden mindestens 10 der Zuckerstangen in den Weihnachtssocken füllen um das Spiel zu gewinnen.

Einsammelobjekt:
![Present](https://user-images.githubusercontent.com/72736373/212928002-dc63eeb7-6c02-4a38-a265-a061af45b16c.png)

Hindernis:
![Obstacle](https://user-images.githubusercontent.com/72736373/212928077-fd79dd78-59a9-4eff-9516-c14366d0cecc.png)

Player:
![Player](https://user-images.githubusercontent.com/72736373/212928135-b3401c13-471c-4fd2-832f-c9ba4aba8508.png)

Socken als "Goal":
![Goal](https://user-images.githubusercontent.com/72736373/212928213-8e5e6bbd-8178-442d-9caa-5887f9c5eedc.png)


Dieses Recap Projekt (2D, Top-Down) inkludiert die Wiederholung folgender Punkte:
Anwendung von Klassen, Methoden (eigene und vorimplementierte Methoden), Variablen, If-Statements,
Collision, Trigger

Ein Objekt (Player) wird über Pfeiltasten(rauf,runter,links,rechts) bzw. wasd gesteuert. Das Objekt sollte immer in der Mitte des Screens sein. 
Der Player kann andere Objekte (Pakete) einsammeln und abliefern. Der Player kann immer nur ein Paket "mitnehmen" und muss es irgendwo abliefern.
Erst nach Lieferung kann ein weiteres Paket aufgesammelt werden. 
Es sollten immer wieder an unterschiedlichen Stellen Pakete auftauchen die wieder eingesammelt werden können.  
 
Pakete finden und liefern
*Pakete aufheben wenn man über diese fährt
*Pakete abliefern wenn man über Delivery Spot fährt
*Ein Paket kann zu einer Zeit transportiert werden
*Wird ein Paket abgeliefert, taucht wieder ein neues irgendwo auf

Player Status ändern und anzeigen. (Mind.1: z.B.: Paket aufgehoben, fährt schneller, … ).
Hindernisse einbauen

Optionale Features umgesetzt:
Schneller werden wenn man über Speed Up fährt
Langsamer werden wenn man gegen ein Hindernis fährt
Timer
Gewinnlogik

Probleme: Mein Pick Up Object (Zuckerstange) wird beim aufsammeln größer, ich komm aber nicht drauf wie ich des verhindern kann...
