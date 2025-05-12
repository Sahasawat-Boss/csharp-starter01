# Structure

## obj folder
- It stores temporary files that are generated during the build process (e.g., object files, intermediate data).

- It helps with dependency management and speeds up subsequent builds by caching certain resources.

- Files in the obj folder are usually safe to delete, as they will be regenerated the next time the project is built.

- This folder is mainly for internal use by the build system and doesn't need to be manually modified.

## .csproj
- like npm package.json
- like setting, can add, delete, etc

## Program.cs
- run the program