# Endless-Runner
 <h1 align="center">Endless runner</h1>
<h2>Overview</h2>

This Unity 3D project demonstrates how to create an endless runner game where the player continuously moves forward, collects points, and avoids obstacles. The game world appears infinite, even though it’s achieved through object pooling and reusing building blocks.

<h2>Features</h2>
Infinite tile generation
Obstacle spawning
Player controller
Instructions
Platform Setup:
Create a new GameObject called “TilePrefab.”
Inside “TilePrefab,” create a cube (GameObject -> 3D Object -> Cube).
Adjust the cube’s position to (0, 0, 0) and scale it to (8, 0.4, 20) to create the main platform.
Optionally, add rails to the sides using additional cubes.
Create three obstacle variations (“Obstacle1,” “Obstacle2,” and “Obstacle3”) within “TilePrefab.”
Customize the obstacles (e.g., height, shape, color).
Tag all obstacle objects with the “Finish” tag for collision detection.
Object Pooling and Activation:
Implement the SC_PlatformTile script to handle object pooling and obstacle activation.
The script should have references to the start and end points of the platform and an array of obstacle prefabs.
Randomly activate obstacles as the player progresses.
Player Controller:
Create a player controller script (e.g., PlayerController.cs).
Use Unity’s Input System to handle player input (e.g., jump, crouch).
Move the player forward constantly (e.g., using transform.Translate).

