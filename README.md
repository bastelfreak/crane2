# Crane project

## How does this work (or at least, how should it work, maybe)

```
     /\Y
      |
      |_____>X
     /
   /
|/Z
```

### Rotate

- changes X
- changes Z

### Doom

(if he isn't directly on the X/Y axis)

- changes X
- changes Z

### Up/Down

- changes Y

## known bugs

- trigonometric operations are slightly different to matrix operations

## Changes by Lars Wallberg

- create GUI, interfaces and classes
- projectleader for the base of the code for most of these functions and classes

## Changes by Tim Meusel

- Replace labels with textboxes
- save current position in matrix class as doubles
- replace public attributes with private ones
- create suitable properties
- create UML
- assign data to attributes in ICrane properly in the constructor
- add Degree2Radiant method
- fix calculation of current position
- fix left/right rotation (it was twisted)
- move matrices into matrix class
- move startpoint into matrix class
- complete rewrite of matrix class
- complete rewrite of all matrix/vector operations
- Allow user to enter new vector, navigate to it (based on logic from Holger, I added the conversion from the vector to polar coordinates)
- simple validation for user input

## Toni Eckardt was here!!!
- *GERMAN* Hab auf kleine Tippfehler hingewiesen
- moralische unterstützung
- fragen gestellt

## Changes by Marcel Reuter

- add comments, for undefined code
- add radiant and degres for calculating Matrics
- change "drehwinkel" into rotationangle
- create first uml draft

## Changes by Mario Bost

- change translation for the first vector
- change float into double for axes results
- kamera startposition changed

## Changes by Holger Stertz

- position of crane can be saved
- crane can go way back to saved position (Inverse Kinematics)
- calculate the current vektor of the ball by using trigonometry

## Changes by Nikolai Luis

- professional support for git and code questions
- design thinking classes and functions
- single math functions