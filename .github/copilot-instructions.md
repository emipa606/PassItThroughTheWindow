# GitHub Copilot Instructions for "Pass It Through The Window! (Continued)"

## Mod Overview and Purpose
"Pass It Through The Window! (Continued)" is a mod that adds a functional and clever solution for item transfer between rooms in RimWorld. This mod introduces a two-sided pass-through window, allowing colonists to transfer items between adjacent rooms without the need to enter them. It helps maintain room climates, making it ideal for transferring temperature-sensitive items like food to the kitchen or cold storage efficiently.

## Key Features and Systems
- **Item Transfer Without Temperature Loss**: The mod enables items to be transferred between two rooms without affecting their temperature.
- **Automatic Wall Orientation**: The window automatically aligns either horizontally or vertically, based on the wall's orientation.
- **Storage Capacity**: The pass-through window can hold up to 3 item stacks.
- **In-Game Placement**: Once researched, the window can be found under the Furniture tab, or under the Storage tab if LWM’s Deep Storage mod is used.
- **Resource Cost**: Crafting the window requires 20 steel, 1 component, and 20 material units (wood, stone, etc.).
- **Item Restrictions**: Not suitable for transferring chunks, plants, or buildings. Perishable items left will decay over time.

### Research Progression
The pass-through window is unlocked after researching Complex Furniture.

### Compatibility and Credits
- **Game Version**: Compatible with RimWorld 1.5+.
- **Mod Conflicts**: No known conflicts. Users are encouraged to report issues.
- **Contributions**: Thanks to the RimWorld community for their suggestions.

## Coding Patterns and Conventions
- **C# and XML Usage**: The mod uses a combination of C# for logic implementation and XML for defining game objects and properties.
- **Naming Conventions**: Classes and members follow the `PascalCase` naming convention, ensuring clarity and consistency.
- **Def Files**: XML def files define object properties, utilizing structured tags to align with RimWorld's data parsing logic.

## XML Integration
- **ThingDef XML**: The mod includes `ThingDef` XML files to define the pass-through window's properties, such as its cost, category, and restrictions.
- **About.xml and Translation Templates**: Additional XML files for metadata and localization support are included.

## Harmony Patching
The mod uses Harmony to patch game methods to extend functionality without altering the original source code:
- **Building_PassThroughWindow.cs**: This file contains critical patches such as `alignQualityAgainst` and `SpawnSetup` to integrate the window's orientation and setup logic.

## Suggestions for Copilot
- **Code Assistance**: Utilize Copilot to generate repetitive XML structure, like defining multiple `ThingDefs`.
- **Pattern Recognition**: Copilot can assist by recognizing and suggesting boilerplate code for Harmony patches.
- **Localization Templates**: You could use Copilot to quickly generate localization templates based on existing entries.

By leveraging the strengths of GitHub Copilot, development can be streamlined, allowing you to focus on further improving the mod's features and compatibility. Always ensure generated suggestions comply with RimWorld's modding standards and thoroughly test each change.


This generated instruction file provides a comprehensive guide for mod developers on working with the "Pass It Through The Window!" mod, focusing on key systems, modding conventions, and potential uses for GitHub Copilot in the development process.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

