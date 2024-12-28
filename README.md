# **Asteroids Game**

A simplified version of the classic *Asteroids* game, developed using Unity. This project focuses on creating a fun, small-scale 2D space shooter with minimal complexity.  

For detailed development notes, please refer to [`devlogs.md`](./devlogs.md).  

---

## **Features**

- **Player-Controlled Spaceship**: Navigate, rotate, and shoot asteroids.
- **Asteroids**: Large asteroids split into smaller ones when hit.
- **Shooting Mechanics**: Fire projectiles to destroy asteroids.
- **Screen Wrapping**: Objects wrap around the edges of the screen.
- **Future Additions**: A scoring system and UI enhancements.

---

## **How to Play**

### **Controls**
- **Movement**: Use the arrow keys to rotate and thrust the spaceship.
- **Shooting**: Press the spacebar to shoot bullets.

### **Objective**
- Destroy all asteroids while avoiding collisions.
- Large asteroids split into smaller fragments, making the challenge progressively harder.

---

## **Project Structure**

### **Folders**
- **Scenes**:
  - `GameScene`: The primary gameplay scene.
- **Scripts**:
  - `PlayerController.cs`: Manages player movement and shooting.
  - `AsteroidBehavior.cs`: Handles asteroid movement and splitting.
- **Prefabs**:
  - `Player`: The spaceship prefab.
  - `Asteroid`: Prefabs for large and small asteroids.
  - `Bullet`: Prefab for projectiles.
- **Sprites**:
  - Placeholder assets for spaceship, asteroids, and bullets.

### **Scripts Overview**
#### `PlayerController.cs`
- Handles player movement (rotation, thrust) and shooting mechanics.

#### `AsteroidBehavior.cs`
- Manages asteroid movement, splitting logic, and interactions with bullets.

---

## **Key Mechanics**

- **Player Movement**: Controlled with `Rigidbody2D` for realistic physics. Includes forward thrust and rotation.
- **Shooting**: Instantiates bullets that travel forward from the spaceship's position.
- **Asteroid Splitting**: Large asteroids split into smaller fragments upon being hit.
- **Screen Wrapping**: Objects exiting one edge of the screen reappear on the opposite side.

---

## **Requirements**

- Unity Editor (2020.3 LTS or newer recommended).
- Basic knowledge of Unity and C# scripting.

---

## **Setup Instructions**

1. Clone or download this repository.
2. Open the project in Unity.
3. Load the `GameScene` from the `Scenes` folder.
4. Press the **Play** button in Unity to start the game.

---

## **Future Improvements**

- Implement a scoring system with an on-screen UI.
- Add a lives system and game-over functionality.
- Introduce power-ups like shields or multi-shot upgrades.
- Add sound effects and background music.
- Include high-score tracking and leaderboard features.

---

## **License**

This project is open-source and available for personal or educational use.  
Feel free to modify or expand upon it while crediting the original source.
