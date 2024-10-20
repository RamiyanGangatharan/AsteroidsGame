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
This project is a remake of the classic **Asteroids** game, built using **Unity**. The goal is to explore 
game development, improve C# proficiency, and gain hands-on experience with Unity's 2D physics and game engine 
mechanics. This project is an ongoing learning experience, with plans for continuous updates and improvements.

## Getting Started
**Clone the repository**:
   ```bash 
   git clone https://github.com/RamiyanGangatharan/AsteroidsGame.git
```

## Requirements
- Unity 6 or higher (project migrated from an earlier version)
- TextMeshPro package (included in Unity's Package Manager)

## Current Features
- **Player Movement**: 
   - `[W]` for thrust
   - `[Q]` to rotate clockwise
   - `[E]` to rotate counterclockwise
- **Basic Physics**: Ship uses Unity's 2D physics engine with a rigid body and colliders.
- **UI Placeholders**: TextMeshPro placeholders for displaying score and lives.
- **Shooting Mechanics**: Implemented a basic shooting system to look like a laser cannon on the ship

## Current File Directory
- **Assets**
    - **Scripts**
        - **Core**
            - BoundaryController.cs
            - GameManager.cs
            - MainMenu.cs
            - PlayerManager.cs
        - **Player**
            - PlayerMovement.cs
            - PlayerShip.cs
            - PlayerShooting.cs
            - PlayerGraphic.cs
        - **Projectile**
            - Projectile.cs
            - ProjectileGraphic.cs
- **TextMeshPro**

---

# Development Log

### October 19, 2024: Reading Week
#### Main Objectives:
- Implement the shooting mechanic for the player
    - Colliders
    - `SPACEBAR` to shoot
    - Physics for correct velocity and mass when fired
        - **Note:** No recoil, as it reduces gameplay fun

***NOTE: I updated Unity Engine to version 6***

Implementing projectiles in the game helped me learn how to load and unload objects using `Destroy()`. I realized I was 
coding redundantly and had to break this habit. I started by creating a `Projectile` class to manage object creation and 
variable assignment. Afterward, I designed the projectile graphic—a tapered line (thick to thin) — and made it disappear, 
simulating decay after 1 second to improve performance.

---

### October 15 - October 18, 2024: Planning Phase
The previous log was a "feasibility demo", where I coded core functions to determine if I could handle the project solo. 
Based on the demo, I believe I can manage it on my own, challenging myself to learn something new. I will add proper 
planning documents later.

---

### October 12 - October 13, 2024: Learning and Refactoring
I cleaned up the project by deleting unnecessary files and refactoring the codebase after studying Unity’s 2D physics system. 
I then created a basic player model by attaching a `RigidBody2D` for physics, a collider for interactions, and a `LineRenderer`
for visual enhancements. To prevent the ship from leaving the camera view, I added boundary colliders. Additionally, I rewrote 
the movement logic based on Unity documentation rather than tutorials.

The current challenges are divided into two categories:
1. **Technical:** Creating asteroid models using `LineRenderer`, implementing shootable bullets, and managing their interactions 
with asteroid colliders.
2. **Personal:** Balancing the project with third-year college responsibilities and managing the scope as a solo developer to 
avoid feeling overwhelmed.

---

### October 11, 2024: Project Kickoff
I initialized the project with the goal of creating a functional prototype and began by developing a simple player model 
(a triangle) with basic physics using Unity's 2D physics system for movement and rotation. However, I encountered challenges 
due to using an outdated engine version, leading me to migrate the project to Unity 2022.3.50f1. I started rebuilding the 
project, focusing on learning from Unity documentation instead of relying solely on tutorials. The current issues include 
clunky controls and inaccurate thrust and rotation values, which I plan to address next.