# Flappy Duck — Unity WebGL

A **Flappy Bird clone** built in Unity and exported as a WebGL build.

---

## About

Flappy Duck is a Unity project implementing the classic one-button arcade mechanic — tap to flap, avoid pipes, survive as long as possible. The project was compiled to WebGL for browser play.

---

## Run Locally

WebGL builds require an HTTP server to load asset bundles correctly:

```bash
python -m http.server 8000
# open http://localhost:8000
```

> Opening `index.html` directly from `file://` will fail due to CORS restrictions on WebGL asset loading.

---

## Built With

- **Unity** (WebGL build target)
- C# game logic
