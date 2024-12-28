# Asteroids Game

This is a simplified version of the classic *Asteroids* game, developed using Unity. The project focuses on creating a fun, small-scale 2D space shooter with minimal complexity.

please refer to `devlogs.md` for any details from development.

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
