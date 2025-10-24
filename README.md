# Learn Unity — Flarpy Blorp

I am learning Unity using this video tutorial: [https://youtu.be/XtQMytORBmM?si=m3Wm-oR8OfWHwiH6](https://youtu.be/XtQMytORBmM?si=m3Wm-oR8OfWHwiH6)
Since I am using Unity 6000.2.8f1, there are a few differences from the tutorial.

---

## Differences

1. **Physics 2D API changes**
   Unity 6+ uses the new Physics 2D engine. Because of this, `Rigidbody2D.velocity` is deprecated.
   Replacement: `Rigidbody2D.linearVelocity`

2. **Input System update**
   The tutorial use the old Input Manager (`Input.GetKeyDown(KeyCode.Space)`).
   With the new Input System enabled, that method will not work.
   Replacement: `Keyboard.current.spaceKey.wasPressedThisFrame`

---
