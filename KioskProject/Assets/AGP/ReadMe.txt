Structure
**********

After you import the package you will find a folder named "AGP" in Project view. In AGP folder there are 18 prefabs and two folders named "Animators" & "Source".

>Assets
   >AGP
      1. Animators
      2. Source
      3. Prefabs x 18

1.)  Animators:- This folder contains 18 animation controllers used by the 18 prefabs.
2.)  Source:- This folder contains source files like Sprites, Scripts and Animations. Do not change anything in this folder unless you know what you are doing.
3.)  Prefabs:- Drag n Drop these 18 prefabs in Scene or Hierarchy to obtain the desired gesture animation.



How to use
***********

1.)  Drag n Drop one of the 18 Prefabs(inside AGP folder) in the Scene.
2.)  Adjust the Position, Rotation and Scale according to need.



Entity Renderer
***************

Each prefab has a component named 'Entity Renderer'. This component has 3 fields - Color, Material and Sorting Layer.

-> Changing Color, Material & Sorting Layer
   ----------------------------------------

1.)  Drag n Drop one of the 18 Prefabs into the Hierarchy.
2.)  In the Hierarchy select this GameObject and look in the Inspector for Entity Renderer(Script) component.
3.)  Now change the Color, Material or Sorting Layer inside Entity Renderer(Script) component.
4.)  To make changes permanent hit 'Apply' infront of Prefab option in Inspector. This will apply changes to your original Prefab.

or

4.)  Drop the GameObject into the Project View. This way you can make changes permanent without changing original Prefab and you will get a new prefab with different Color, Material & Sorting Layer.

