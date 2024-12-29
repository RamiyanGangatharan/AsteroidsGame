# **Asteroids Game Development Log**
#### _A 2D game inspired by the classic Asteroids, developed in Unity._

**Developer**: Ramiyan Gangatharan <br>
**Start Date**: December 27, 2024  <br>
**Last Updated**: December 29, 2024  <br>

---

## **Table of Contents**
1. [Project Overview](#project-overview)
2. [Progress Summary](#progress-summary)
3. [Game Plan](#game-plan)
4. [Learning and Reflections](#learning-and-reflections)
5. [Visual Progress](#visual-progress)
6. [Acknowledgments](#acknowledgments)

---

## **PROJECT OVERVIEW**
This document tracks the development of an Asteroids-inspired 2D game using Unity Engine. 

---

## **PROGRESS SUMMARY**
### Current Status: **Stage I (Core Setup)** - *100% Complete*  

---

## **GAME PLAN**

_note: dates are formatted as YYYY-MM-DD_

### **Stage I: Core Setup (100%)**
| Task                                       | Status       | Target Date         | Notes                         |
|--------------------------------------------|--------------|---------------------|-------------------------------|
| Unity Project Setup                        | ✅ Completed  | 2024/12/28   |                               |
| Create 2D Scene with a Black Background    | ✅ Completed  | 2024/12/28   |                               |
| Create a Functioning Main Menu             | ✅ Completed | 2024/12/29     | Using UI Toolkit              |
| Create a Functioning Pause Screen      | ✅ Completed | 2024/12/29    |                               |
| Create a Functioning Game Over Screen      | ✅ Completed | 2024/12/29    |                               |
| Design and Add a Spaceship Sprite          | ✅ Completed | 2024/12/29    | Researching free assets       |
| Implement Player Movement                  | ✅ Completed | 2024/12/29    | Forward thrust and rotation   |
| Add Player Colliders and Rigidbody         | ✅ Completed | 2024/12/29    |                               |
| Implement Screen Wrapping for the Player   | ✅ Completed | 2024/12/29    |                               |

#### Stage Notes:
- Understanding Physics: Grasping the physics concepts in Unity proved to be challenging as I have never taken a physics class, but I got information from ChatGPT, which helped clarify my understanding of the mechanics involved.

- Screen Wrapping: I successfully implemented screen wrapping using orthographic coordinates, though I’m still unfamiliar with what orthographic projection entails. This feature allows my character to seamlessly exit one side of the screen and reappear on the opposite side. However, I noticed that my character is now limited to the bounds of the camera view which is a good thing.

- Menu Creation: Creating menus turned out to be more straightforward than I expected. By leveraging event listeners and reusing several functions, I was able to streamline the process of returning to specific menus, resulting in a more efficient workflow.

---

### **Stage II: Basic Gameplay (0%)**
| Task                                       | Status       | Target Date         | Notes                         |
|--------------------------------------------|--------------|---------------------|-------------------------------|
| Implement Shooting Mechanics               | ⬜ Not Started | TBD    |                               |
| Destroy Bullets Leaving Camera View        | ⬜ Not Started | TBD    |                               |
| Add Asteroids                              | ⬜ Not Started | TBD    |                               |
| Create Asteroid Sprite                     | ⬜ Not Started | TBD    |                               |
| Make Asteroids Move on Random Trajectories | ⬜ Not Started | TBD    |                               |
| Implement Collision Detection              | ⬜ Not Started | TBD    |                               |
| Detect and Handle Asteroid-Bullet Collisions| ⬜ Not Started | TBD   |                               |
| Detect and Handle Asteroid-Ship Collisions | ⬜ Not Started | TBD    |                               |

#### Stage Notes:

---

### **Stage III: Gameplay Loop (0%)**
| Task                                       | Status       | Target Date         | Notes                         |
|--------------------------------------------|--------------|---------------------|-------------------------------|
| Implement Asteroid Splitting               | ⬜ Not Started | TBD    |                               |
| Add a Lives System                         | ⬜ Not Started | TBD    |                               |
| Create a Game Management System            | ⬜ Not Started | TBD    | Restart, Score, Pause         |

#### Stage Notes:

---

### **Stage IV: Visuals & Polish (0%)**
| Task                                       | Status       | Target Date         | Notes                         |
|--------------------------------------------|--------------|---------------------|-------------------------------|
| Add Particle Effects for Asteroid Hits     | ⬜ Not Started | TBD    |                               |
| Add Visual Effects for Spaceship Damage    | ⬜ Not Started | TBD    |                               |
| Display Scores and Lives on Screen         | ⬜ Not Started | TBD    |                               |
| Add Sound Effects                          | ⬜ Not Started | TBD    | Shooting, Collisions          |

#### Stage Notes:

---

### **Stage V: Testing & Debugging (0%)**
| Task                                       | Status       | Target Date         | Notes                         |
|--------------------------------------------|--------------|---------------------|-------------------------------|
| Test All Mechanics                         | ⬜ Not Started | TBD   |                               |
| Fix Edge Cases                             | ⬜ Not Started | TBD   | Screen Wrapping, Collisions   |

#### Stage Notes:

---

### **Stage VI: Advanced Features (if time permits)**
| Task                                       | Status       | Target Date         | Notes                         |
|--------------------------------------------|--------------|---------------------|-------------------------------|
| Add Power-Ups                              | ⬜ Not Started | TBD   | Shields, Multi-Shot, Speed    |
| Implement High-Score Tracking              | ⬜ Not Started | TBD   |                               |

#### Stage Notes:

---

## **LEARNING AND REFLECTIONS**

---

## **ACKNOWLEDGMENTS**
- [Asteroid Sprite](https://millionthvector.blogspot.com/p/free-sprites.html)
- [OpenGameArt.org](https://opengameart.org/)
- [Projectile Tutorial](https://youtu.be/8TqY6p-PRcs)
