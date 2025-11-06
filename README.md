
# **Lighthouse Simulator**

## General Information

My game is about a lighthouse keeper protecting a town from pirates while also guiding helpful ships with the lighthouse beam. Rocks arise from the sea that can destroy boats, so you must collect treasure from pirates to get explosives to destroy these rock obstacles. There is also a patrol boat which picks up the pirate wreckage treasure.
## Player Objective
get a high score by killing pirates and guiding ships
## Controls
Hover over boats within radius of lighthouse beam (circle that follows cursor) and interact within that range; click pirates and hover over boats. Also control the patrol boat with WASD to pick up pirate wreckage (dropped after they are destroyed on click) to recieve explosives.
## Challenge
Mouse accuracy, reaction time and multitasking.

## Issues
pirate collision, boat spawner and movement, hitbox with harbour glitching because too small. The boats and pirates would often glitch with the harbour, being stuck insdide of it, so to fix this I just made the hitbox larger which fixed the issue. Another issue I had was with the score, when it would increase greatly whilst hovering over pirates; this is because the part of the code increasing the score was meant to be part of the if statement with on destroy, but it wasn't. To fix it I made it only increase on destroy so score increased once boat pirate destroyed. I also had some other issues which copilot helped me diagnose.

## Settings/public variables
Rock spawn rate, boat speed, pirate speed, pirate spawn rate, pirate spawn rate randomness.
## Getting Started


## Authors
audrey
fred
Contributors names and contact info

ex. Mr Jones
ex. [@benpaddlejones](https://github.com/benpaddlejones)

## Version History

* 0.2
    * Various bug fixes and optimizations
    * See [commit change]() or See [release history]() or see [branch]()
* 0.1
    * Initial Release

## License

This project is licensed under the [NAME HERE] License - see the LICENSE.md file for details

## Acknowledgments

Inspiration, code snippets, etc.
* [Github md syntax](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)
* [TempeHS Unity template](https://github.com/TempeHS/TempeHS_Unity_DevContainer)
