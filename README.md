<h1 align="center">Alan</h1>

<p align="center">
A 2D local competitive tile-capture game developed with Unity and C#.<br>
Two players race across a 6x6 board, claim highlighted tiles, and compete for the highest score.
</p>

<p align="center">
  <img src="https://img.shields.io/badge/Engine-Unity%202022.3.7f1-black"/>
  <img src="https://img.shields.io/badge/Language-C%23-purple"/>
  <img src="https://img.shields.io/badge/UI-TextMeshPro-blue"/>
  <img src="https://img.shields.io/badge/UI-Unity%20UI-0E7FBF"/>
  <img src="https://img.shields.io/badge/Physics-Unity%20Physics-orange"/>
  <img src="https://img.shields.io/badge/Platform-PC-green"/>
  <img src="https://img.shields.io/badge/Platform-Android-brightgreen"/>
  <img src="https://img.shields.io/badge/Mode-2D%20Local%20Multiplayer-red"/>
  <img src="https://img.shields.io/badge/Status-Completed-brightgreen"/>
</p>

---

## Project Overview

**Alan** is a fast local multiplayer game where two players compete to capture tiles on a 6x6 grid.

The rules are simple:

- a random tile is highlighted during the match,
- both players try to reach the highlighted tile first,
- the first player to step on it captures the tile,
- each captured tile increases that player's score by 1,
- the match ends when all 36 tiles have been captured.

The player with the higher score wins. If both players capture the same number of tiles, the match ends in a draw.

<img width="1920" height="856" alt="alan" src="https://github.com/user-attachments/assets/12726f7a-7812-479f-9739-3f4fc7b6a30a" />

---

## Supported Platforms

Alan is organized as two Unity project variants:

- **PC Version** - keyboard-based local multiplayer for desktop play.
- **Android Version** - touch-control version with on-screen directional buttons.

Both versions share the same core gameplay idea, board layout, scoring rules, and win/draw conditions.

---

## Project Structure

```text
Alan/
|-- Alan(PC)/
|   |-- Game Files/
|   |   |-- Assets/
|   |   |   |-- Scenes/
|   |   |   |   |-- menu.unity
|   |   |   |   `-- game.unity
|   |   |   |-- scripts/
|   |   |   |   |-- playermove.cs
|   |   |   |   |-- player2move.cs
|   |   |   |   |-- plane.cs
|   |   |   |   `-- buttoncode.cs
|   |   |   |-- images/
|   |   |   |-- materials/
|   |   |   `-- musics/
|   |   |-- Packages/
|   |   `-- ProjectSettings/
|
|-- Alan(Android)/
|   |-- Game Files/
|   |   |-- Assets/
|   |   |   |-- Scenes/
|   |   |   |   |-- menu.unity
|   |   |   |   `-- game.unity
|   |   |   |-- scripts/
|   |   |   |   |-- playermove.cs
|   |   |   |   |-- player2move.cs
|   |   |   |   |-- plane.cs
|   |   |   |   `-- buttoncode.cs
|   |   |   |-- images/
|   |   |   |-- materials/
|   |   |   `-- musics/
|   |   |-- Packages/
|   |   `-- ProjectSettings/
|
|-- LICENSE
|-- README.md
`-- .gitignore
```

---

## Core Systems

### Player Movement

- Grid-based movement on a 6x6 board.
- Two-player local control.
- Player collision prevention to avoid occupying the same target tile.
- Edge wrapping behavior that keeps players inside the playable board.

### Tile Capture System

- 36 capture tiles are managed as individual materials.
- A random unclaimed tile is highlighted during gameplay.
- The first player to reach the highlighted tile captures it.
- Captured tiles change color based on the player who claimed them.

### Score and Match Flow

- Separate score counters for both players.
- Timer display during the match.
- Match completion when all 36 tiles are captured.
- Winner display for the leading player.
- Draw display when both players finish with equal scores.

### Menu and UI Flow

- Main menu with play and quit actions.
- In-game pause support.
- Restart/back navigation flow through Unity scenes.
- TextMeshPro-based score and timer UI.

---

## Features

### Competitive Local Gameplay

- Designed for two players on the same device.
- Quick decision-making around movement and positioning.
- Simple rules with direct player competition.

### Platform-Specific Controls

- PC version uses keyboard input for both players.
- Android version uses touch buttons for mobile play.
- Both versions preserve the same 6x6 capture-board rules.

### Complete Match Loop

- Start from the menu.
- Play until every tile is captured.
- Show winner or draw result.
- Return to menu or restart for another match.

---

## Game Mechanics

### Tile Selection

At timed intervals, the game selects a random tile from the board. If the tile has not been captured yet, it becomes active and can be claimed by either player.

### Capturing

When a player reaches the active tile, the tile changes to that player's color and the player's score increases by 1.

### Winning

The game checks the total number of captured tiles. Once all 36 tiles are captured, player movement is disabled and the result UI is shown.

---

## How to Play

1. Start the game from the main menu.
2. Watch for the highlighted tile on the board.
3. Move your player to the highlighted tile before your opponent.
4. Capture as many tiles as possible.
5. Win by having the highest score after all 36 tiles are captured.

---

## Controls

### PC

| Player | Controls |
|---|---|
| Black Player | `W`, `A`, `S`, `D` |
| Red Player | Arrow Keys |

### Android

- Black Player: on-screen directional buttons.
- Red Player: on-screen directional buttons.

---

## Technologies Used

- **Unity Engine 2022.3.7f1** - game development engine.
- **C#** - gameplay and UI logic.
- **TextMeshPro** - score, timer, and UI text rendering.
- **Unity UI (UGUI)** - menus, buttons, and on-screen controls.
- **Unity Physics** - Rigidbody-based player positioning and interaction.

---

## Assets and Audio

- UI Images: winner cup, draw cup, and in-game visual assets included in the Unity project.
- Materials: player materials and 36 board tile materials.
- Music: **Red Whine - Everet Almond** from the Fantasy Tavern Music Free Pack.

Audio source:

https://assetstore.unity.com/packages/audio/music/fantasy-tavern-music-free-pack-118847

---

## Installation and Play

1. Clone the repository:

```bash
git clone https://github.com/AFurkanOcel/Alan.git
```

2. Open one of the Unity project folders with Unity Hub:

```text
Alan(PC)/Game Files
Alan(Android)/Game Files
```

3. Use **Unity 2022.3.7f1** or a compatible Unity 2022.3 LTS version.

4. Open the scene:

```text
Assets/Scenes/menu.unity
```

5. Press **Play** in the Unity Editor.

### Builds

Compiled PC and Android builds are not stored in the source repository. Release builds should be distributed through GitHub Releases, itch.io, or another download page.

---

## Credits

### Game Development

**A. Furkan Ocel**

GitHub: https://github.com/AFurkanOcel

---

## License

This project is licensed under the terms included in the repository's `LICENSE` file.
