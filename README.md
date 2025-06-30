# Fuelled Client Tracker

A lightweight Blazor WebAssembly application built to streamline client onboarding and policy tracking for an insurance broker, aligning with their mission of bringing innovation and efficiency to the insurance sector.

---

##  Features

-  **Client Database Integration**
  - Fully functional MySQL backend via Entity Framework Core
  - Client records include email, onboarding stage, start/renewal dates, and policy types

-  **Full CRUD Functionality**
  - Create, update, delete and view clients through the Blazor UI
  - Conditional rendering and inline editing for clean UX

-  **Onboarding Workflow**
  - Tracking of onboarding stages
  - Colour-coded stage badges for visual clarity

- **Sorting & Filtering**
  - Sortable columns on the client table
  - Multi-policy filtering with checkboxes

-  **Data Insights Dashboard**
  - Dynamic pie charts (using ChartJS.Blazor)
  - View breakdowns by onboarding stage and policy type

-  **Theming & UI**
  - Colour scheme adapted to match Fuelled branding

---

## Tech Stack

- **Frontend:** Blazor WebAssembly (.NET 9)
- **Backend:** ASP.NET Core Web API 
- **Database:** MySQL with Entity Framework Core
- **Charting:** ChartJS.Blazor
- **Styling:** Bootstrap & CSS

---

## Possible Extensions

> These were considered and partially scaffolded or documented:

- **Supporting Document Upload**  
  File uploads (e.g., PDFs) stored in MySQL as BLOBs per client.

- **Eco Impact Tracker**  
  Track number of trees planted per client based on estimated revenue.

- **Authentication Placeholder**  
  Login UI entry point added, with future option for user-based document access and admin privileges.

---

## Reasoning Behind the Project

To integrate helpful technology into the insurance space inspired this focused internal tool. The app simulates a typical use case in a broker environment:
- Onboarding new clients
- Tracking policies
- Monitoring renewals
- Viewing operational metrics

My goal was to keep the app lean, extendable, and business-aligned — with clear growth paths if adopted more widely.

---

## Project Structure

- `Fuelled.ClientTracker` - Blazor WebAssembly frontend
- `Fuelled.ClientTracker.Api` - ASP.NET Core backend
- `MySQL` - Not included in this repository. Used to store clients

---

## About Me

Jacob Biggs  
Malvern-based developer  
Background in embedded systems, secure comms, and full-stack web  
[jacobbiggs.co.uk](https://jacobbiggs.co.uk)

---

## Built for Interview - July 2025

