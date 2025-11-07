
# **Lighthouse Simulator**

# General Information
## Story/Setting
My game is about a lighthouse keeper protecting a town from pirates while also guiding helpful ships with the lighthouse beam. Rocks arise from the sea that can destroy boats, so you must collect treasure from pirates to get explosives to destroy these rock obstacles. There is also a patrol boat which picks up the pirate wreckage treasure.
## Player Objective
get a high score by killing pirates and guiding ships.
## Controls
Hover over boats within radius of lighthouse beam (circle that follows cursor) and interact within that range; click pirates and hover over boats. Also control the patrol boat with WASD to pick up pirate wreckage (dropped after they are destroyed on click) to recieve explosives.
## Challenge
Mouse accuracy, reaction time and multitasking.
## Inspirations
My game is inspired by aim trainers and asteroids atari.

## Issues
pirate collision, boat spawner and movement, hitbox with harbour glitching because too small. The boats and pirates would often glitch with the harbour, being stuck insdide of it, so to fix this I just made the hitbox larger which fixed the issue. Another issue I had was with the score, when it would increase greatly whilst hovering over pirates; this is because the part of the code increasing the score was meant to be part of the if statement with on destroy, but it wasn't. To fix it I made it only increase on destroy so score increased once boat pirate destroyed. I also had some other issues which copilot helped me diagnose and fix.

## Settings/public variables
Rock spawn rate, boat speed, pirate speed, pirate spawn rate, pirate spawn rate randomness.

# Code Snippets
## Player Boat
<img width="667" height="480" alt="image" src="https://github.com/user-attachments/assets/b0ace424-8d6c-4638-b497-1fdf75296b24" />
## Pirate
<img width="1113" height="493" alt="image" src="https://github.com/user-attachments/assets/2b50e0b9-27a2-4daa-bee6-4965710b4911" />
## Pirate
<img width="1210" height="671" alt="image" src="https://github.com/user-attachments/assets/16e47ac1-97fa-41a4-bc90-fe0f1480e678" />






* [Github md syntax](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
* [TempeHS Unity template](https://github.com/TempeHS/TempeHS_Unity_DevContainer)
