﻿# Crane project

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

x is y?
y is z?
z is x??

'turn left' turns it right
'turn right' turns it left

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