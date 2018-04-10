# ECO WARRIERS - PROJECT 2

<h1> Video demonstration </h1>
Please click to watch overview video [TO DO].
[![HelloWorld](http://img.youtube.com/vi/POaRp7FoeCI/0.jpg)](https://www.youtube.com/watch?v=POaRp7FoeCI)



<h1> Project Description </h1>
An interactive-educational game built in <b>Unity3D</b> to demonstrate the importance of preserving water and various techniques of water Harvesting. The players starts with a <i>Village Scene</i>, which is suffering from a severe drought. The player has to finish the various scenes in the game in order to bring back the water to the village and return to its pristine state. Players can start with scenes in any order. These three scenes are enumerated below and are discussed in detail later in this report:

#### 1. Cloud-Seeding Scene
#### 2. Desert/Semi-arid land Scene
#### 3. Pipeline Puzzle Scene [MAY Change LATER]


<h1> Contributers </h1>
<ul>
  <li>Bouligny, Jonathan </li>
  <li>Datta, Prerit</li>
  <li>Pardeshi, Amitsingh</li>
</ul>
 

<h1> Technologies Used </h1>

<ul>
  <li>Unity </li>
  <li>Oculus Rift Controller</li>
  <li>C# Scripts</li>
</ul>
 


<h1> Challenges Faced </h1>

<ul>
  <li> <b>Integration with oculus hardware </b>  - This was the biggest challenge that we faced as a team as we had a limited access to the Oculus hardware during the development process. Also, during the testing phase of the project, we had to re-do and adjust various settings in all of our scenes in order to make it work seamlessly with the Oculus Display, which was really time consuming. </br>
  
  <li> <b> Learning Curve </b> - Never having used Unity before, the learning curve was steep and we had to spend lot of time getting ourselves acquianted with the Unity Environment and the API.</li>
  <li> <b> Colloboration </b> - We ran into several issues while using GitHub for collaboration intially. One of the primary issue being the large project size and constant updates needed as one made changes at their end. We ended up using Unity's <i>Collaboration</i> which circumvented the problem of change managements due to its simplicity and seamless integration with the Unity Enviroment </li>
  
<li> <b> Oculus API version Incompatibility </b> - Oculus API had certain incompatibility issues with the current version of Unity. Especially with the Mac, which made working with it more difficult. Such as the errors mentioned <a href="https://forums.oculusvr.com/developer/discussion/58002/development-on-macos-high-sierra">here</a>
  </li>
</ul>


<h1> From Initial Design to the Actual Game </h1>
The Team initially brainstormed about certain ideas so as to what the game should look like. Initially we decided to have a total of 5 levels, which we later narrowed down to 4 to reduce complexity:

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/Design2.png)

We also discussed, how the overall transition should look like between the scenes:

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/Design1.png)




<h1>Player Controllers</h1>
Each scene can be controlled using Oculus controls or W,A,S,D/ Arrows keys for the PC version of the Game.

Use oculus Rift controller to operate the player movement.
<ul>
  <li>Joy Stick to move player in all direction</li>
</ul>

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/oculus-touch-teardown.jpg)

Use Keyboard to operate the plane on PC.
<ul>
  <li>WASD - To Move player</li>
</ul>

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/wasd.png)



<h1>Scenes/Level Descriptions</h1>
<h3>Cloud-Seeding Level</h3>
Use the plane to spray the chemicals on the clouds to make induce artificial rain. Once the player seeds a certain number of clouds within the given countdown time, the player wins the level. T
<br>
The Scene displays certain statistics to the player such as:
<ul>
  <li>Time Remaining</li>
   <li>Players Health</li>
   <li>Chemical Tank Reading</li>
   <li>Clouds seeded</li>
</ul>

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/cloud_step1.PNG)

<br></br>
Release Chemicals

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/cloud_step2.PNG)


<h3>Building the Aquaduct & Cleaning the Lake Level</h3>
Player will have to solve the puzzle by arranging the pipeline pieces to build an aquaduct that will transport water from river stream to a lake. In the second step, player will have to clean the garbage from the lake to make it clean. This can done by clicking on certain objects present in the lake (such as a bottle). The player accumulates points upon collecting and thereby removing those objects from the water. Once player has reached preconfigured number of points, then the level is completed.
<br>
Initial Scene where player can see four puzzle pieces which can be used to build an aquaduct. In addition, the player can see.
<ul>
  <li>Time Remaining</li>
   <li>Score</li>
</ul>

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/Aqua_Step1.PNG)


<br></br>
After the Aquaduct is built:

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/aqua_step3.PNG)

<br></br>
Now, the Player has to clean the lake:

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/aqua_step4.PNG)

<br><br>

<h3>Surviving in a Desert: Desert/Semi-arid land Scene</h3>
The player start at a random point in the Desert/semi-arid land scene. The aim of the scene is to look to for certain visual cues that can help someone find water if they happen to be in a desert. For example, the cactus is an indication of the presence of water. Similary, the cliffs collect water when it rains. Also, insects and bugs always have a way of finding nearby water sources.Reference: <a href="https://www.wikihow.com/Find-Water-in-the-Desert"> here </a> <br/>

The player has to collect "Magical blue orbs" before it gets dark. As soon as the player collects the orb, the hidden water source in the vicinity of that orb is unlocked (becomes visible). The player wins, once they collect all the three magical orbs in the scene.
<br>
In the scene, a Player can see:
<ul>
  <li>Daylight Remaining</li>
   <li>Items Remaining</li>
</ul>

A magic-orb in the scene:
![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/orb.png)


<br>
Insects going up an ant-hill:

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/anthill.png)

A water sources is unlocked after orb is collected:
![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/Dessert_Step2.PNG)

<br></br>
After the level is cleared:

![alt text](https://github.com/pardeshiamitsingh/EcoWarriers/blob/master/snapshots/dessert_step4.PNG)


<h1>Assets/References Used</h1>
<h4>Textures Used:</h4>
https://www.textures.com/download/3dscans0016/126285?q=sand 

https://www.textures.com/download/soilcracked0157/66844?q=sand

https://www.textures.com/download/rockblocky0072/91987?q=rock 

https://www.textures.com/download/rocksmootherosion0012/90696?q=rock 

https://www.textures.com/download/soilmud0004/9525?q=mud 

<h4>Ant Model: </h4>
https://www.turbosquid.com/3d-models/3d-model-formica-rufa-ant/388875

<h4>Bull Skull: </h4>

https://assetstore.unity.com/packages/3d/characters/animals/bull-skull-5846 

<h4>Scripts</h4>
http://twiik.net/articles/simplest-possible-day-night-cycle-in-unity-5 

<h4>Sounds:</h4>
(Collect item):
https://freesound.org/people/YOH/sounds/169375/ 

(Stream sound):
https://freesound.org/people/InspectorJ/sounds/339324/ 
