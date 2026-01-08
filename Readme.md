# QPoint Web Menu

A modern, offline web-based vertical menu for QPoint Robotic Solutions' supervisory application.

## Overview

This project replaces the existing flat, code-based left-hand menu with a clean, attractive, and operator-friendly web interface. The menu runs completely offline in a .NET WebView2 control (Chrome-based) on Windows, requiring no internet connection.

**Key Goals**
- Cleaner and more intuitive operator interaction
- Modern, professional appearance
- Full integration with the supervisory application via JavaScript messaging
- Support for dynamic menu population, favorites, and multi-level structure

## Current Delivery

This is a **static HTML mockup** demonstrating:
- Visual design and layout
- Use of provided icons from `_Graphics/`
- Proposed categorized, collapsible tree structure (to simplify the long list of Robo-Apps)
- Colored action buttons, subtext, checklist items, and favorites section

## Folder Structure

```
QPoint-Web-Menu/
├── index.html              # Main menu mockup (open in browser to preview)
├── README.md               # This file
└── _Graphics/              # All images/icons (exact filenames required)
```

## How to Preview

1. Open `index.html` in Google Chrome (recommended for accurate WebView2 preview)
2. Ensure the `_Graphics` folder is in the same directory as `index.html`
3. Scroll and review layout, colors, spacing, and hierarchy
