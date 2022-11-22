# CubeSurfer_UnityProject
Making Cube Surfers hypercasual game with unity game engine.

# THE CUBE SURFER
>UNITY VERSION: 2020.3

>SCREEN RESOLUTION: 9*16 ANDROID
##### CORE MECHANIC: 

- You can move the character to the right and left of the road by moving your finger to the left and right anywhere on the screen.
- The character moves forward at a constant speed. You want to be able to change this speed from the editor.
- The player starts the game with 1 cube and collects these cubes and, stacks them. The cubes are placed on the bottom floor, the other cubes go up one floor.
# 
>MENU SCENE

Buttons can be used to start the game directly or to get information before starting the game.

![MENU](https://user-images.githubusercontent.com/72701330/203378577-48802d9d-24bb-43fb-8c07-001a17f55ff5.gif)

>The game screen displays the number of cubes and diamonds that the user has collected.
At the same time, the user can observe the remaining distance to the level finish point thanks to the progress bar.

![ui](https://user-images.githubusercontent.com/72701330/203394616-68f7a8f6-b325-4373-864e-3fd937329f11.png)


>SUCCESS -> NEXT LEVEL -> WIN

If the 1st level is completed successfully, the user will receive a notification on the screen to be able to switch to the new level.                                   
Until a level is successfully completed, that level continues in a loop.When the 2nd level (last level) is completed, the game returns to the beginning.                                    

![SUCCESS](https://user-images.githubusercontent.com/72701330/203390091-0d2f7d50-abb2-4ce7-8777-424c0ba5f926.gif) 
![WIN](https://user-images.githubusercontent.com/72701330/203390172-1e3368dd-d2c9-439a-baa5-77893fdfb7d5.gif)


>FAIL

As long as the length of the stack of cubes the user collects is less than the size of the obstacle, the game will fail.

![FAIL](https://user-images.githubusercontent.com/72701330/203380935-aafea271-81ad-40e8-852d-0cfa5f452f77.gif) 
![FAIL2](https://user-images.githubusercontent.com/72701330/203387664-66a8cff5-2c48-4fec-89bf-92111d929c01.gif)


