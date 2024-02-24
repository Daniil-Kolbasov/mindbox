# Решение в техническому заданию Mindbox

Задание можно посмотреть [здесь](/TASK.md).

## Задание 1

Описание решения:

* **Площадь круга по радиусу и треугольника по трем сторонам** реализовано в проекте [mindbox.ShapeLibrary](/mindbox.ShapeLibrary) в классах [Circle](mindbox.ShapeLibrary/Circle.cs) и [Triangle](mindbox.ShapeLibrary/Triangle.cs)
* **Юнит-тесты** реализованны в [mindbox.ShapeLibrary.Test](/mindbox.ShapeLibrary.Test)
* **Легкость добавления других фигур** достигается через интерфейс [IShape](/mindbox.ShapeLibrary/IShape.cs)
* Вычисление площади фигуры **без знания типа фигуры** в compile-time реализованно в классе [ReguralPolygon](/mindbox.ShapeLibrary/ReguralPolygon.cs) **при условии, что фигура правильная.**
* **Проверку на то, является ли треугольник прямоугольным** реализованно в методе `IsRegtangular` класса [Triangle](mindbox.ShapeLibrary/Triangle.cs), плюсь ещё он упорядычевает на катеты (`A` и `B`) и гипотинузу (`C`)
