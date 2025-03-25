# Task Management App

Aplikacja do zarządzania zadaniami z interfejsem webowym, oparta na technologiach ASP.NET Core i MySQL. Umożliwia dodawanie użytkowników, przypisywanie zadań oraz zarządzanie ich statusem.

## Funkcje

- **Dodawanie użytkowników**: Możliwość dodawania nowych użytkowników do systemu.
- **Dodawanie zadań**: Tworzenie nowych zadań z tytułem, opisem i przypisanym użytkownikiem.
- **Przypisywanie zadań do użytkowników**: Zadania mogą być przypisane do konkretnych użytkowników.
- **Zarządzanie statusem zadań**: Oznaczanie zadań jako ukończone lub w toku.
- **Usuwanie zadań**: Możliwość usuwania istniejących zadań.

## Technologie

- **Backend**: ASP.NET Core
- **Baza danych**: MySQL
- **Frontend**: HTML, JavaScript

## Struktura projektu

- **Program.cs**: Główny plik konfiguracyjny aplikacji, zawierający konfigurację bazy danych, CORS oraz endpointów.
- **AppDbContext.cs**: Kontekst bazy danych, definiujący modele `TaskItem` i `User`.
- **TasksController.cs**: Kontroler API do zarządzania zadaniami.
- **TaskItem.cs**: Model danych dla zadania.
- **User.cs**: Model danych dla użytkownika.
- **index.html**: Interfejs użytkownika do zarządzania zadaniami i użytkownikami.

## Jak uruchomić projekt

1. **Sklonuj repozytorium**:
   ```bash
   git clone https://github.com/STBasht/task_manager.git
   cd task_manager
