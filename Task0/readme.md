# Задание Sprint 6 Task 0 Variant 15

## Описание задания
Дано выражение F(x) = x³ + 2x² + 5x + 4. Вычислить его значение при x = 3, результат вывести в TextBox. Округлить результат до трёх знаков после запятой.

## Структура проекта

### 1. Tyuiu.RomanovskiiMP.Sprint6.Task0.V15.Lib
Библиотека классов с методом Calculate для вычисления функции F(x) = x³ + 2x² + 5x + 4

### 2. Tyuiu.RomanovskiiMP.Sprint6.Task0.V15.Test  
Модуль тестирования с unit-тестами для проверки корректности вычислений

### 3. Tyuiu.RomanovskiiMP.Sprint6.Task0.V15
Основное WinForms приложение с графическим интерфейсом

## Как запустить

### Запуск тестов:
```bash
cd Task0/Tyuiu.RomanovskiiMP.Sprint6.Task0.V15.Test
dotnet test
```

### Запуск приложения:
```bash
cd Task0/Tyuiu.RomanovskiiMP.Sprint6.Task0.V15
dotnet run
```

### Сборка всего решения:
```bash
dotnet build Tyuiu.RomanovskiiMP.Sprint6.sln
```

## Результат вычисления
При x = 3: F(3) = 3³ + 2×3² + 5×3 + 4 = 27 + 18 + 15 + 4 = 64.000

Результат округляется до трёх знаков после запятой и выводится в TextBox.