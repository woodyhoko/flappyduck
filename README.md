# Flappy Duck — Unity WebGL

A **Flappy Bird-style** endless side-scroller built in Unity and compiled to WebGL for instant browser play, no install required.

**[▶ Play in Browser](https://woodyhoko.github.io/flappyduck)**

---

## Gameplay

One-button mechanic: tap/click to apply an upward impulse; gravity pulls the duck down between taps. Navigate a series of vertically offset pipe gaps that scroll toward the player. Each pipe pair cleared increments the score. The game ends on any collision — with a pipe or the ground — and the high score is persisted to `localStorage`.

---

## Technical Design

### Physics

Unity's 2D physics engine (`Rigidbody2D`) drives the duck:

```
OnFlap():
    rb.velocity = new Vector2(0, flapForce)   // instant vertical impulse
    
FixedUpdate():
    // gravity applied by Physics2D continuously (default −9.8 m/s² scaled)
```

The horizontal scroll is achieved by moving all pipes leftward at a fixed speed rather than moving the camera, keeping the duck's world-space X constant and simplifying collision detection.

### Pipe Generation

Pipes spawn off the right edge at randomized Y offsets within a configurable gap-height range:

```
gapY = Random.Range(minGapY, maxGapY)
Instantiate(pipePrefab, spawnPoint, Quaternion.identity)
```

Pipes are recycled (object pooling) once they pass the left edge, avoiding continuous allocation and garbage collection hitches.

### Collision & Scoring

`OnTriggerEnter2D` detects pipe collisions via box colliders tagged `Pipe`. A separate invisible trigger zone between the pipes fires `AddScore()` when the duck passes through.

### WebGL Build

Unity exports a WebGL build package (`index.html` + `Build/` + `TemplateData/`). The build uses **Brotli** compression for the WASM module. WebGL requires an HTTP server because the browser blocks `file://` CORS requests:

```bash
python -m http.server 8000
# open http://localhost:8000
```

---

## Controls

| Input | Action |
|---|---|
| Mouse click / Space | Flap |
| R | Restart after death |

---

## Built With

- **Unity** (2D, WebGL build target)
- **C#** game scripts
- Unity **Physics2D** (Rigidbody2D, BoxCollider2D)
- Unity **WebGL** output with Brotli WASM compression
