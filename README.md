# Longest Increasing Subsequence (LIS)

![Build](https://github.com/hkaab/fff6cd48-d32a-4e09-a4be-dc74849eb894/actions/workflows/ci.yml/badge.svg)
![Unit Tests](https://github.com/hkaab/fff6cd48-d32a-4e09-a4be-dc74849eb894/actions/workflows/ut.yml/badge.svg)
![codecov](https://codecov.io/gh/hkaab/fff6cd48-d32a-4e09-a4be-dc74849eb894/branch/main/graph/badge.svg)

A small .NET console app that finds the longest run of consecutive, strictly increasing integers in a sequence.

Give it a list of numbers, it returns the longest ascending run:

```bash
$ dotnet run 6 1 5 9 2
Input      : 6 1 5 9 2
LIS Length : 3
LIS        : 1 5 9
```

## How it works

This implementation uses a **greedy, single-pass algorithm** (`O(n)` time, `O(n)` space): it walks the input once, extending a "current run" whenever the next number is larger than the last one, and starts a new run whenever it isn't. The longest run seen is kept and returned at the end.

> **Note:** this finds the longest *contiguous* increasing run, not the classic (non-contiguous) Longest Increasing Subsequence problem solved with dynamic programming or patience sorting (`O(n log n)`). For example, for `1 2 5 3 4`, this returns `1 2 5` (length 3), whereas a true non-contiguous LIS would find `1 2 3 4` (length 4). Keep this in mind if you're looking for a classic LIS/DP implementation.

## Prerequisites

Before running the application, ensure the following software is installed on your machine:

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- Git
- (Optional) Docker, if you'd rather run it in a container
- Visual Studio 2022 (17.14+) or Visual Studio Code, if you want an IDE

Verify your installation:

```bash
dotnet --version
```

### Recommended IDEs

- Visual Studio 2022/2026
- Visual Studio Code

## Project structure

```
.
├── src/LIS/LIS/                        # Console application
│   ├── Algorithms/
│   │   └── LongestIncreasingSubsequence.cs
│   ├── Program.cs                      # CLI entry point
│   └── Dockerfile
├── tests/UnitTests/                    # xUnit test suite
│   ├── LongestIncreasingSubsequenceTests.cs
│   └── input/                          # Large sample inputs used in tests
├── docker-compose.yml
└── LICENSE
```

## Running the app

```bash
cd src/LIS/LIS
dotnet restore
dotnet run 6 1 5 9 2
```

Numbers are passed as space-separated command-line arguments. Negative numbers, single values, and empty input are all handled.

## Running with Docker

```bash
docker compose run --rm consoleapp 6 1 5 9 2
```

This builds and runs the console app in a container (see `src/LIS/LIS/Dockerfile`). Since it's an interactive console app, `docker-compose.yml` keeps `stdin_open` and `tty` enabled so you can attach to it.

## Running tests

The test suite uses xUnit and covers empty input, single-element input, all-increasing/all-decreasing sequences, negative numbers, and several large fixture files under `tests/UnitTests/input/`.

```bash
cd tests/UnitTests
dotnet test
```

To generate a coverage report locally (as CI does via Codecov):

```bash
dotnet test --settings coverlet.runsettings --collect:"XPlat Code Coverage"
```

## CI/CD

GitHub Actions runs on every push and PR to `main`:

- **build** (`ci.yml`) — restores and builds the console project
- **unit tests** (`ut.yml`) — runs after a successful build, executes the test suite, generates a coverage report, and uploads results to Codecov

## Design decisions

- **Greedy over DP:** the algorithm favors simplicity and linear time over solving the classic non-contiguous LIS problem. See [How it works](#how-it-works) above for the trade-off.
- **String in/string out:** `Find` takes a space-separated string and returns a space-separated string, keeping the CLI wiring trivial.

## Contributing

Issues and pull requests are welcome. Please make sure `dotnet test` passes before opening a PR.

## License

[MIT](LICENSE)
