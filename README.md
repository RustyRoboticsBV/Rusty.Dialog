# Rusty.Dialog
A simple dialog system for the Godot game engine, implemented in C#.

## Summary
The system supports the following operations:
- Selecting a dialog window.
- Setting a dialog window's state (such as "open" or "closed"). States can be defined by the user.
- Pushing a line of dialog to the selected window.
- Pushing a dialog choice to the selected window.
- Pushing a line extension to the selected window.

A line of dialog consists of three elements: a speaker string, a mood string and a body string.
