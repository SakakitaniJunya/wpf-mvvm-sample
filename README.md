# Sample3 - WPF To-Do List Application

This repository contains a beginner-friendly WPF application sample built using .NET Framework 4.7.2, CommunityToolkit.Mvvm, and WPF-UI. It demonstrates a simple To-Do list implementation following the MVVM pattern.

---

## Table of Contents

- [Overview](#overview)
- [Features](#features)
- [Project Structure](#project-structure)
- [Prerequisites](#prerequisites)
- [Getting Started](#getting-started)
- [Build Instructions](#build-instructions)
- [License](#license)

---

## Overview

- **Target Framework:** .NET Framework 4.7.2  
- **MVVM Support:** Uses CommunityToolkit.Mvvm to simplify the implementation of the MVVM pattern.  
- **Modern UI:** Leverages WPF-UI for attractive components like FluentWindow, TitleBar, and Card.  
- **Purpose:** Serves as an educational resource for beginners to learn WPF and MVVM through a practical To-Do list application.

---

## Features

- **MVVM Implementation:** Simplified with CommunityToolkit.Mvvm attributes and generated commands.  
- **Modern UI Components:** Utilizes WPF-UI for a visually appealing and functional interface.  
- **To-Do List Functionality:** Supports task addition, deletion, and toggling completion status.  
- **SDK-Style Project:** Clean project structure with efficient package management.

---

## Project Structure

```
Sample3/
├── App.xaml
├── App.xaml.cs
├── AssemblyInfo.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── Sample3.csproj
├── Models/
│   └── TaskModel.cs
└── ViewModels/
    └── MainViewModel.cs
```

- **Models:** Contains data models (e.g., TaskModel.cs).  
- **ViewModels:** Implements the MVVM logic (e.g., MainViewModel.cs).  
- **Views:** Defines the UI using XAML (e.g., MainWindow.xaml).

---

## Prerequisites

- Visual Studio 2019 (or later) with the .NET Desktop Development workload.  
- .NET Framework 4.7.2 installed on your machine.  
- Internet connection for restoring NuGet packages (CommunityToolkit.Mvvm and WPF-UI).

---

## Getting Started

1. **Clone the Repository:**

    ```bash
    git clone https://github.com/SakakitaniJunya/wpf-mvvm-sample.git
    ```

2. **Open the Project:**

    Open the `Sample3.csproj` file in Visual Studio.

3. **Restore NuGet Packages:**

    Allow Visual Studio to restore the required packages.

4. **Build and Run:**

    Build the solution and run the application using Visual Studio (F5) or your preferred method.

---

## Build Instructions

- **Using Visual Studio:**
  - Open the solution and press **F5** to build and run the application.
  
- **Using Command Line:**
  - Navigate to the project directory and run:
  
    ```bash
    msbuild Sample3.csproj
    ```

  - Then, run the generated executable.

---

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

# 日本語版

# Sample3 - WPF To-Do リストアプリケーション

このリポジトリは、.NET Framework 4.7.2、CommunityToolkit.Mvvm、WPF-UI を使用した初心者向け WPF アプリケーションのサンプルです。MVVM パターンに基づいたシンプルな To-Do リストアプリケーションを実装しています。

---

## 目次

- [概要](#概要)
- [特徴](#特徴)
- [プロジェクト構成](#プロジェクト構成)
- [前提条件](#前提条件)
- [はじめに](#はじめに)
- [ビルド手順](#ビルド手順)
- [ライセンス](#ライセンス)

---

## 概要

- **ターゲットフレームワーク:** .NET Framework 4.7.2  
- **MVVM サポート:** CommunityToolkit.Mvvm を使用して MVVM パターンの実装を簡略化。  
- **モダンな UI:** WPF-UI により FluentWindow、TitleBar、Card などの魅力的なコンポーネントを提供。  
- **目的:** 初心者が WPF と MVVM の基礎を実践的に学ぶための教材として機能します。

---

## 特徴

- **MVVM 実装:** CommunityToolkit.Mvvm の属性と自動生成されたコマンドにより、実装がシンプルに。  
- **モダンな UI コンポーネント:** WPF-UI を利用し、視認性の高いインターフェースを実現。  
- **To-Do リスト機能:** タスクの追加、削除、完了状態の切替が可能。  
- **SDK スタイルのプロジェクト:** クリーンな構成と効率的なパッケージ管理。

---

## プロジェクト構成

```
Sample3/
├── App.xaml
├── App.xaml.cs
├── AssemblyInfo.cs
├── MainWindow.xaml
├── MainWindow.xaml.cs
├── Sample3.csproj
├── Models/
│   └── TaskModel.cs
└── ViewModels/
    └── MainViewModel.cs
```

- **Models:** データモデル（例：TaskModel.cs）を格納。  
- **ViewModels:** MVVM ロジック（例：MainViewModel.cs）を実装。  
- **Views:** XAML による UI 定義（例：MainWindow.xaml）。

---

## 前提条件

- Visual Studio 2019 以降（.NET デスクトップ開発ワークロードを含む）。  
- .NET Framework 4.7.2 がインストールされていること。  
- NuGet パッケージの復元のためのインターネット接続（CommunityToolkit.Mvvm と WPF-UI）。

---

## はじめに

1. **リポジトリをクローン:**

    ```bash
    git clone https://github.com/SakakitaniJunya/wpf-mvvm-sample.git
    ```

2. **プロジェクトを開く:**

    Visual Studio で `Sample3.csproj` を開いてください。

3. **NuGet パッケージの復元:**

    Visual Studio によるパッケージの自動復元を許可してください。

4. **ビルドと実行:**

    ソリューションをビルドし、Visual Studio（F5）または他の方法でアプリケーションを実行します。

---

## ビルド手順

- **Visual Studio を使用する場合:**
  - ソリューションを開いて **F5** キーを押し、ビルドと実行を行います。
  
- **コマンドラインの場合:**
  - プロジェクトディレクトリに移動し、以下のコマンドを実行してください:
  
    ```bash
    msbuild Sample3.csproj
    ```
  
  - ビルド後、生成された実行ファイルを起動してください。

---

## ライセンス

本プロジェクトは MIT ライセンスの下で提供されています。詳細は [LICENSE](LICENSE) ファイルをご確認ください.

---

