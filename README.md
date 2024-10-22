## How to Start the Interview Challenge

**1. Fork this repo (optional):**  
   If you'd like to work on your own copy of this repo, click the "Fork" button at the top-right of this page to fork it to your GitHub profile.

**2. Clone the repo to your machine:**  
   Open your terminal and run the following command to clone the repository to your local machine:
   ```
   git clone https://github.com/Hossein-79/Interview-Code-Challenge
   ```
**3. Open the Unity scene:**  
   Navigate to `Assets/Challenges/Challenges.unity` and open this scene in Unity.

**4. Complete Challenge 1 in the Player script:**  
   Modify the `Player` script to implement the first challenge.

**5. Activate the Spawner object for Challenge 2:**  
   In the Unity hierarchy, activate the `Spawner` object. Then, implement the second challenge by writing the necessary code in the Spawner script.

**6. Activate the Enemy object and complete Challenge 3:**  
   In the Unity hierarchy, activate the `Enemy` object. Then, implement the third challenge by modifying the `Player` script as needed.

## Challenge 1:

- Modify the script so that the player moves towards each target in the scene based on the target's priority. The priority is a public field in the target script, with higher values indicating higher priority.
- Ensure the player is always facing the direction of movement.
- Once a target is reached, destroy it.
- If no targets remain, stop the player's movement. If the scene starts with no targets, the player should remain idle.


## Challenge 2:

- In the Unity hierarchy, activate the `Spawner` object.
- Modify spawner script to spawn new targets.
- Targets must spawn with a random delay, using two fields in the spawner script: `_minSpawnTime` and `_maxSpawnTime`. These fields define the range for the random delay.
- Ensure the player follows newly spawned targets just like existing targets.
- New targets must spawn within the camera's view range.
- **Bonus:** Implement a simple event system to notify the player when a new target is added to the scene.

## Challenge 3 (Bonus):

- In the Unity hierarchy, activate the `Enemy` object.
- Modify the player's behavior so that while following its targets, the player must also avoid the enemy.
- All previous challenge requirements must be met, except that when there are no more targets, the player should focus on avoiding the enemy.
- The enemy moves at 1/3 of the player's speed to make it possible for the player to evade
- **Bonus:** Consider adding visual or audio cues when the enemy gets too close to the player, enhancing the challenge.
