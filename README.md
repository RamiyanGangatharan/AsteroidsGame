# Asteroids Game

This is a simplified version of the classic *Asteroids* game, developed using Unity. The project focuses on creating a fun, small-scale 2D space shooter with minimal complexity.

## Features

- **Player-controlled spaceship**: Move, rotate, and shoot.
- **Asteroids**: Large asteroids split into smaller ones when hit.
- **Shooting mechanics**: Fire projectiles to destroy asteroids.
- **Screen wrapping**: Objects reappear on the opposite edge of the screen.
- **Simple score system**: Points are earned for destroying asteroids (optional).

## How to Play

1. **Controls**:
   - Use the arrow keys to rotate and thrust the spaceship.
   - Press the spacebar to shoot.
2. **Objective**:
   - Destroy all asteroids without crashing into them.
   - Large asteroids split into smaller ones, increasing the challenge.

## Project Structure

### Assets
- **Scenes**:
  - `GameScene`: The main gameplay scene.
- **Scripts**:
  - `PlayerController`: Handles player movement and shooting.
  - `AsteroidBehavior`: Handles asteroid movement and splitting.
- **Prefabs**:
  - `Player`: The player spaceship.
  - `Asteroid`: Large and smaller asteroids.
  - `Bullet`: Projectiles fired by the player.
- **Sprites**:
  - Placeholder sprites for the spaceship, asteroids, and bullets.

### Scripts Overview

#### PlayerController.cs
Manages the player's movement and shooting mechanics.

#### AsteroidBehavior.cs
Controls the movement of asteroids, their splitting behavior, and interactions with bullets.

### Key Mechanics

- **Player Movement**:
  - Forward thrust and rotation are controlled via `Rigidbody2D` physics.
- **Shooting**:
  - Bullets are instantiated at the spaceship's position and move forward.
- **Asteroid Splitting**:
  - When a large asteroid is hit, it splits into smaller ones (if available).
- **Screen Wrapping**:
  - Objects that leave the screen reappear on the opposite side.

## Requirements

- Unity Editor (Version 2020.3 or newer recommended)
- Basic knowledge of Unity and C#

## Setup Instructions

1. Clone or download this repository.
2. Open the project in Unity.
3. Load the `GameScene` from the `Scenes` folder.
4. Play the game by pressing the Play button in Unity.

## Future Improvements

- Add a scoring system with UI.
- Implement lives and game-over logic.
- Introduce power-ups (e.g., shields, multi-shot).
- Add sound effects and background music.

## License

This project is open-source and available for personal or educational use.

## **DEVELOPER LOGS**

### **Game Plan**

#### **Stage I: Core Setup**
- [x] Unity Project Setup
- [x] Create 2D Scene with a black background
- [ ] Create a functioning main menu
- [ ] Create a functioning Game Over screen
- [ ] Design and add a spaceship sprite
- [ ] Implement player movement (forward thrust and rotation)
- [ ] Add player colliders and rigidbody components
- [ ] Implement screen wrapping for the player

#### **Stage II: Basic Gameplay**
- [ ] Implement shooting mechanics
   - [ ] Destroy bullets that leave the camera view
- [ ] Add asteroids
   - [ ] Create an asteroid sprite
   - [ ] Make asteroids move on random trajectories
- [ ] Implement collision detection
   - [ ] Detect and handle asteroid-bullet collisions
   - [ ] Detect and handle asteroid-spaceship collisions

#### **Stage III: Gameplay Loop**
- [ ] Implement asteroid splitting upon destruction
- [ ] Add a lives system
- [ ] Create a game management system:
   - [ ] Restart the game after all lives are lost
   - [ ] Track and display both score and lives
   - [ ] Add pause/unpause and restart functionality

#### **Stage IV: Visuals & Polish**
- [ ] Add simple particle effects for asteroid hits and splits
- [ ] Add visual effects when the spaceship takes damage
- [ ] Display scores and lives on the screen
- [ ] Add sound effects for shooting, collisions, and explosions

#### **Stage V: Finishing Touches - Testing**
- [ ] Test and debug all mechanics
- [ ] Fix edge cases (e.g., improper screen wrapping, collision issues)

#### **Stage VI: Advanced Features (if time permits)**
- [ ] Add power-ups (e.g., shields, multi-shot, speed boost)
- [ ] Implement high-score tracking and display


#### December 28 2023

