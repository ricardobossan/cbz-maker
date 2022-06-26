# CBZ-Maker

Compresses files to `.cbz` format.

## How to Install

### Compile the source files

- Make sure you have [.Net 6.0][dotnet-6] installed.
- Open the terminal on the source code's root dir and run:
    ```bash
    dotnet publish --use-current-runtime
    ```
### Make the binaries globally available

#### Archlinux

- From the source files root folder, copy the binaries from `./bin/Debug/net6.0/arch-x64/publish/cbz-maker` to `~/.local/bin`:
    ```bash
    cp ./bin/Debug/net6.0/arch-x64/publish/cbz-maker  ~/.local/bin
    ```
#### Windows

Add `cbz-maker/bin/Debug/net6.0/arch-x64/publish/cbz-maker` to PATH.

## How to Use

- In the chapter/volume directory run `cbz-maker`

## References

[dotnet-6]:https://dotnet.microsoft.com/en-us/download/dotnet/6.0
