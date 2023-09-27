# Codility Exercise: Binary Gap

## Overview

A binary gap within a positive integer `N` is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of `N`.

- Number `9` has a binary representation of `1001` and contains a binary gap of length `2`.
- Number `529` has a binary representation of `1000010001` and contains two binary gaps: one of length `4` and one of length `3`.
- Number `20` has a binary representation of `10100` and contains one binary gap of length `1`.
- Number `15` has a binary representation of `1111` and has no binary gaps.

The goal is to write a function that, given a positive integer `N`, returns the length of its longest binary gap. If `N` doesn't contain a binary gap, the function should return `0`.

For the full problem description, visit [Codility's Binary Gap Exercise](https://app.codility.com/programmers/lessons/1-iterations/binary_gap/).

## Solution

This repository contains my proposed solution to the Binary Gap exercise implemented as a console application in C# using .NET 7.

### Running the Solution

1. Clone the repository.
2. Navigate to the project directory.
3. Use the `dotnet run` command to execute the console application.
4. Follow the on-screen prompts to input a number and get the length of its longest binary gap.
