# Asteroids Game in Unity

## Table of Contents
- [Overview](#overview)
- [Current Features](#current-features)
- [Planned Features](#planned-features)
- [Requirements](#requirements)
- [Getting Started](#getting-started)
- [Development Log](#development-log)
- [License](#license)

---

## Overview
This project is a remake of the classic **Asteroids** game, built using **Unity**. The goal is to explore game development, improve C# proficiency, and gain hands-on experience with Unity's 2D physics and game engine mechanics. This project is an ongoing learning experience, with plans for continuous updates and improvements.

## Current Features
- **Player Movement**: 
   - [W] for thrust
   - [Q] to rotate clockwise
   - [E] to rotate counterclockwise
- **Basic Physics**: Ship uses Unity's 2D physics engine with a rigid body and colliders.
- **UI Placeholders**: TextMeshPro placeholders for displaying score and lives.

## Planned Features and To-Do List

### Core Gameplay Mechanics
- [ ] **Asteroids Mechanics**
   - [ ] Random asteroid spawning with different sizes.
   - [ ] Asteroids split into smaller pieces when hit by projectiles.
   - [ ] Asteroid wrapping when they move out of the screen bounds.

- [ ] **Projectile Firing**
   - [ ] Implement a firing mechanism for the player ship.
   - [ ] Create projectile prefabs that can destroy asteroids.
   - [ ] Add projectile cooldown to prevent spamming.

### Game Systems
- [ ] **Score System**
   - [ ] Increment score when an asteroid is destroyed.
   - [ ] Update UI to display the current score.

- [ ] **Lives System**
   - [ ] Deduct lives when the player’s ship is hit by an asteroid.
   - [ ] Display remaining lives in the UI.

- [ ] **Game Over & Restart**
   - [ ] Display a game-over screen when the player runs out of lives.
   - [ ] Implement restart functionality to reset the game.

- [ ] **High Score Tracking**
   - [ ] Record high scores and display them on the game over screen.
   - [ ] Persist high scores between game sessions.

### Additional Features
- [ ] **Power-Ups (Optional)**
   - [ ] Add occasional power-ups like shields or multi-shot abilities.
   
- [ ] **Sound Effects and Music**
   - [ ] Add sound effects for shooting, asteroid collisions, and explosions.
   - [ ] Add background music to enhance gameplay atmosphere.

- [ ] **Visual Improvements**
   - [ ] Improve ship and asteroid visuals beyond placeholder models.
   - [ ] Add particle effects for explosions and thrust.

## Long-Term Goals (Stretch Features)
- [ ] **Level Progression**
   - [ ] Add multiple levels with increasing difficulty as the player destroys all asteroids.
   
- [ ] **Multiplayer Mode**
   - [ ] Consider implementing local multiplayer with two ships on screen.

- [ ] **Mobile Support**
   - [ ] Explore touch controls and optimization for mobile devices.

## Requirements
- Unity **2022.3.50f1** or higher (project migrated from an earlier version)
- TextMeshPro package (included in Unity's Package Manager)

## Getting Started
**Clone the repository**:
   ```bash 
   git clone https://github.com/RamiyanGangatharan/AsteroidsGame.git
```
---

## Development Log

### 11/10/2024: Project Kickoff
- Initialized the project.
- Created the player model (a simple triangle for now) with basic physics.
- Used Unity's 2D physics system to apply movement and rotation.
- Encountered issues with using an outdated engine version.
- Migrated the project to Unity 2022.3.50f1 and began rebuilding without relying on tutorials.


### 11/10/2024 - 13/10/2024: Learning and Refactoring
- Deleted unnecessary files to clean up the project.
- Studied Unity’s 2D physics system and refactored the initial codebase.
- Created a player model:
	- Attached: 
		- A RigidBody2D
		- A collider
		- A LineRenderer for the ship's appearance.
- Prevented the ship from falling out of the camera view by implementing colliders as boundaries.
- Rewrote the core movement logic based on Unity documentation instead of tutorials.

# Licence

Copyright &copy; 2024 Ramiyan Gangatharan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.