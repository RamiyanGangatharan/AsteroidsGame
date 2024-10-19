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

## Getting Started
**Clone the repository**:
   ```bash 
   git clone https://github.com/RamiyanGangatharan/AsteroidsGame.git
```

## Requirements
- Unity **2022.3.50f1** or higher (project migrated from an earlier version)
- TextMeshPro package (included in Unity's Package Manager)

## Current Features
- **Player Movement**: 
   - [W] for thrust
   - [Q] to rotate clockwise
   - [E] to rotate counterclockwise
- **Basic Physics**: Ship uses Unity's 2D physics engine with a rigid body and colliders.
- **UI Placeholders**: TextMeshPro placeholders for displaying score and lives.

---

## Development Log

### October 20 2024: Asteroids
#### Main Objectives for today:
- get the asteroid system started
	- Colliders
	- the ability to have asteroids break apart when shot at
	- physics to emulate space asteroids and have them with a small amount of velocity to move around in space

### October 19 2024: Reading Week
#### Main Objectives for today:
- implement the shooting mechanic for the player
	- Colliders
	- SPACEBAR to shoot
	- physics attached to it so it has the right velocity and mass when it is being fired
		- NOTE: no recoil as that is no fun in game

### October 15 2024 - October 18 2024: Planning Phase
The last log was what I call a "feasability demo" where I wanted to see (by coding the core functions) how doable it is as a solo developer. After that demo, I think I am able to do it by myself, to challenge myself into learning something new. I will update this log with proper planning documents later on.
 
### October 12 2024 - October 13 2024: Learning and Refactoring
I deleted unnecessary files to clean up the project and refactored the initial codebase after studying Unity’s 2D physics system. Following this, I created a basic player model by attaching a RigidBody2D for physics, a collider for interactions, and a LineRenderer to enhance the ship's visual appearance. To prevent the ship from falling out of the camera view, I implemented colliders as boundaries. Additionally, I rewrote the core movement logic, relying on Unity documentation rather than tutorials.

Currently, the issues I am facing can be divided into two categories. The first involves technical challenges, such as creating asteroid models with the LineRenderer, implementing shootable bullets, and managing the shooting mechanics, particularly how bullets interact with the asteroid colliders. The second category pertains to the human aspect of the project: balancing this endeavor with my third-year college responsibilities and managing the project's scope to avoid feeling overwhelmed as a solo developer.


### October 11 2024: Project Kickoff
I initialized the project with the goal of creating a functional prototype and began by developing a simple player model (a triangle) that incorporated basic physics using Unity's 2D physics system for movement and rotation. However, I encountered challenges due to using an outdated engine version, prompting me to migrate the project to Unity 2022.3.50f1. I started rebuilding it, focusing on reading the Unity documentation instead of solely relying on tutorials. Currently, I am facing issues with clunky controls and inaccurate thrust and rotation values, which I plan to address next.

---


# Licence

Copyright &copy; 2024 Ramiyan Gangatharan

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.