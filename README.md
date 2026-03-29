# Leb Grill

**Fast-paced restaurant simulation game focused on queue management, timing, and customer satisfaction.**

## Project Status  
**In Active Development**

Leb Grill is a portfolio project built in Unity, focusing on core gameplay systems first—particularly **queue logic, timing mechanics, and player decision-making under pressure**.

The project emphasises clean system design, iterative development, and building a solid gameplay foundation before adding polish such as animation and visual effects.

---

## Concept Overview  

Leb Grill is a restaurant simulation game where players manage a continuous flow of customers, each with unique patience levels and order expectations.

The core gameplay loop revolves around:

- Managing a **dynamic queue system**  
- Serving customers before their patience runs out  
- Prioritising orders under time pressure  
- Maintaining flow and efficiency  

The goal is to create a system that feels:

- **Readable** (clear customer states)  
- **Responsive** (tight interaction loop)  
- **Scalable** (supports increasing difficulty over time)  

At its core:  
**It’s about handling pressure, making quick decisions, and optimising flow.**

---

## Core Features (Planned & In Progress)

### 🧍 Customer System
- Queue-based spawning system  
- Individual patience timers  
- Visual state indicators (waiting, served, leaving)  
- Variation in customer behaviour (planned)

### ⏱ Queue & Timing System
- Structured queue points in world space  
- Timer-driven state changes  
- Readable positioning and spacing  
- Focus on clarity and gameplay feedback  

### 🎮 Core Gameplay Loop
- Serve → Clear → Next customer flow  
- Increasing pressure over time  
- Simple but scalable interaction system  

### 🖥 UI & HUD
- Canvas-based UI for game information  
- Separation between world space (gameplay) and UI layer  
- Readability-first design approach  

### ⚙️ Game Architecture
- Modular component-based design  
- Separation of:
  - Game world (camera space)  
  - UI (canvas space)  
- Built for iteration and expansion  

---

## Engineering Focus  

This project is being developed with a strong emphasis on **game system design and clean structure**:

- **Engine:** Unity (C#)  
- **Architecture:** Component-based (MonoBehaviour-driven systems)  
- **Game Loop:** State-driven interactions  
- **Separation of Concerns:**
  - World systems (customers, queue)  
  - UI systems (HUD, feedback)  
- **Scalability:** Systems designed to support future mechanics (animations, upgrades, difficulty scaling)  
- **Version Control:** Structured commits with milestone-based progress  

---

## Repository Structure
```
/
├── README.md
├── Assets/
│   ├── Scripts/
│   │   ├── Core/
│   │   ├── Customer/
│   │   ├── Queue/
│   │   └── UI/
│   ├── Prefabs/
│   ├── Scenes/
│   └── Resources/
├── ProjectSettings/
└── Packages/
```
*(Structure will evolve as systems expand.)*

---

## Current Progress  

- Core Unity project setup completed  
- Camera and canvas separation established  
- Queue system implemented and positioned in world space  
- Customer spawning and scaling system working  
- Customer state system (active/inactive) implemented  
- Improved queue readability with spacing and timing  

---

## Upcoming Milestones  

- Customer movement and animations  
- Order system implementation  
- Player interaction mechanics (serving system)  
- Scoring and feedback system  
- Difficulty scaling (faster queues, varied behaviours)  
- UI polish and visual clarity improvements  

---

## How to Run  

1. Clone the repository: 
git clone https://github.com/nickkohli/LebGrill-iOS.git
2. Open the project in Unity Hub  
3. Select the correct Unity version  
4. Open the main scene and press Play  

---

## Development Philosophy  

Leb Grill is being built as a **gameplay-first portfolio project**, with focus on:

- Building **core systems before polish**  
- Keeping gameplay **clear and readable**  
- Designing systems that are easy to extend  
- Iterating quickly and testing frequently  
- Treating the project as a **professional development artifact**  

---

## Contact  

**Developer:** Nick Kohli  
For questions or collaboration, feel free to connect via GitHub or LinkedIn.