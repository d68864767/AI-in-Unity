Project Title

This project includes a simple NPC chase AI in a Unity game. The NPC will chase the player when the player is within a certain distance.
Getting Started

These instructions will get you a copy of the project up and running on your local machine for development and testing purposes.
Prerequisites

You need to have Unity installed on your machine. You can download it from the official Unity website.
Installation

1. Clone the repository to your local machine.
2. Open the project in Unity.
3. Open the MainScene.unity file to view the main game scene.
Usage

The game includes a player and an NPC. The player can be moved using the WASD or arrow keys. The NPC will start chasing the player when the player is within a certain distance.

The player's movement is controlled by the PlayerController.cs script, and the NPC's behavior is controlled by the NPCChaseAI.cs script.

The PlayerController.cs script uses the Input.GetAxis method to get input from the player and moves the player's position accordingly.

The NPCChaseAI.cs script calculates the distance to the player and moves the NPC towards the player if the player is within the chase distance.
Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.
License

MIT
