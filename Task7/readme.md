# Task 7 - Обработка CSV матрицы

## Задание
Сгенерируй CSV-файл InPutFileTask7V28.csv.
Файл должен содержать матрицу целых чисел (7 строк, 5 столбцов).
В седьмой строке должны быть как числа 13, так и числа, не равные 13.
Разделитель — запятая.

Загрузить через openFileDialog в объект dataGridViewIn.
Изменить в седьмой строке числа не равные 13 на 0.
Результат вывести в объект dataGridViewOut.
Сохранить результат в файл OutPutFileTask7.csv через saveFileDialog.

## Структура проекта
- **Tyuiu.RomanovskiiMP.Sprint6.Task7.V28.Lib** - библиотека с логикой обработки CSV
- **Tyuiu.RomanovskiiMP.Sprint6.Task7.V28.Test** - модульные тесты
- **Tyuiu.RomanovskiiMP.Sprint6.Task7.V28** - WinForms приложение

## Функциональность
- Загрузка CSV файла через OpenFileDialog
- Отображение исходной матрицы в dataGridViewIn
- Обработка 7-й строки (замена не-13 на 0)
- Отображение результата в dataGridViewOut
- Сохранение результата в CSV файл через SaveFileDialog