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

- Changes X
- Changes Z

### Doom

(if he isn't directly on the X/Y axis)

- Changes X
- Changes Z

### Up/Down

- Changes Y

## known bugs

- Trigonometric operations are slightly different to matrix operations

## Changes by All

- create GUI, interfaces and classes
- create Code for all these functions and classes

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

## Toni Eckardt was here!!!
- *GERMAN* Hab auf kleine Tippfehler hingewiesen
- moralische unterstützung
- fragen gestellt

## Changes by Marcel Reuter

- add comments, for undefined code
- add radiant and degres for calculating Matrics
- change "drehwinkel" into rotationangle

## Changes by Mario Bost

- change translation for the first vector
- change float into double for axes results

## Changes by Holger Stertz

- Position of crane can be saved
- Crane can go way back to saved position (Inverse Kinematics)
