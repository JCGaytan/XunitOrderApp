# XunitOrderApp

## Overview

`XunitOrderApp` is a .NET Core application designed to demonstrate best practices in software development with unit testing using xUnit and Moq. The project focuses on processing orders with logic for calculating discounts, identifying high-value customers, and filtering high-value orders. It includes robust tests that validate the functionality and ensure code reliability.

![Alt Code Coverage](https://github.com/JCGaytan/XunitOrderApp/blob/master/SS%20CodeCoverage.png)

## Features

1. **Order Processing**: 
   - Calculate discounts for orders based on total amount.
   - Identify high-value customers.
   - Filter high-value orders from a list.

2. **Unit Testing**:
   - Uses xUnit for creating and running unit tests.
   - Includes both data-driven and mocked test cases.

3. **Code Coverage**:
   - Ensures all critical paths are tested, reducing bugs in production.

## Project Structure

```
XunitOrderApp/
    Order.cs
    OrderProcessor.cs
XunitOrderApp.Tests/
    OrderProcessorTests.cs
    TestData/ComplexOrders.json
```

### Key Files

- **Order.cs**: Defines the `Order` class with properties for `OrderId`, `CustomerName`, and `TotalAmount`.
- **OrderProcessor.cs**: Contains methods for business logic: `CalculateDiscount`, `IsHighValueCustomer`, and `FilterHighValueOrders`.
- **OrderProcessorTests.cs**: Includes unit tests to validate the functionality of `OrderProcessor`.
- **TestData/ComplexOrders.json**: Provides complex order data for testing.

## Advantages of Unit Testing and Code Coverage

### Unit Testing Benefits

1. **Improved Code Quality**: Ensures that all functionality behaves as expected.
2. **Catch Bugs Early**: Identifies issues during the development phase.
3. **Facilitates Refactoring**: Confidently refactor code without fear of breaking functionality.
4. **Documentation**: Serves as a live documentation of how the code is expected to behave.

### Code Coverage Benefits

1. **Visibility**: Shows which parts of the code are tested and which are not.
2. **Reduces Risk**: High coverage means fewer untested edge cases.
3. **Improves Maintainability**: Developers are aware of untested code areas.

### Code Example

#### Testing `CalculateDiscount`

```csharp
[Fact]
public void CalculateDiscount_ShouldReturn10PercentForOrdersAbove100()
{
    var order = new Order { OrderId = 1, CustomerName = "John Doe", TotalAmount = 150 };
    var discount = _orderProcessor.CalculateDiscount(order);
    Assert.Equal(15, discount);
}
```

#### Code Coverage Output

Aiming for **90% or higher coverage** ensures that all major code paths, such as `CalculateDiscount`, `IsHighValueCustomer`, and `FilterHighValueOrders`, are tested.

### Running Tests

Run the following command to execute tests:
```bash
dotnet test
```

---

# XunitOrderApp

## Resumen

`XunitOrderApp` es una aplicación en .NET Core diseñada para demostrar las mejores prácticas en desarrollo de software con pruebas unitarias utilizando xUnit y Moq. El proyecto se centra en procesar pedidos con lógica para calcular descuentos, identificar clientes valiosos y filtrar pedidos de alto valor. Incluye pruebas sólidas que validan la funcionalidad y garantizan la fiabilidad del código.

![Alt Code Coverage](https://github.com/JCGaytan/XunitOrderApp/blob/master/SS%20CodeCoverage.png)

## Características

1. **Procesamiento de Pedidos**:
   - Calcular descuentos en función del monto total.
   - Identificar clientes valiosos.
   - Filtrar pedidos de alto valor.

2. **Pruebas Unitarias**:
   - Uso de xUnit para crear y ejecutar pruebas unitarias.
   - Casos de prueba con datos y objetos simulados.

3. **Cobertura de Código**:
   - Garantiza que todas las rutas críticas sean probadas, reduciendo errores en producción.

## Estructura del Proyecto

```
XunitOrderApp/
    Order.cs
    OrderProcessor.cs
XunitOrderApp.Tests/
    OrderProcessorTests.cs
    TestData/ComplexOrders.json
```

### Archivos Clave

- **Order.cs**: Define la clase `Order` con propiedades para `OrderId`, `CustomerName` y `TotalAmount`.
- **OrderProcessor.cs**: Contiene los métodos para la lógica empresarial: `CalculateDiscount`, `IsHighValueCustomer` y `FilterHighValueOrders`.
- **OrderProcessorTests.cs**: Incluye pruebas unitarias para validar la funcionalidad de `OrderProcessor`.
- **TestData/ComplexOrders.json**: Proporciona datos complejos para pruebas.

## Ventajas de las Pruebas Unitarias y la Cobertura de Código

### Beneficios de las Pruebas Unitarias

1. **Mejora la Calidad del Código**: Garantiza que toda la funcionalidad se comporte como se espera.
2. **Detecta Errores Temprano**: Identifica problemas durante la fase de desarrollo.
3. **Facilita la Refactorización**: Refactoriza con confianza sin temor a romper la funcionalidad.
4. **Documentación**: Sirve como documentación viva de cómo debe comportarse el código.

### Beneficios de la Cobertura de Código

1. **Visibilidad**: Muestra qué partes del código están probadas y cuáles no.
2. **Reduce el Riesgo**: Una alta cobertura significa menos casos extremos sin probar.
3. **Mejora el Mantenimiento**: Los desarrolladores están conscientes de las áreas no probadas.

### Ejemplo de Código

#### Prueba de `CalculateDiscount`

```csharp
[Fact]
public void CalculateDiscount_ShouldReturn10PercentForOrdersAbove100()
{
    var order = new Order { OrderId = 1, CustomerName = "John Doe", TotalAmount = 150 };
    var discount = _orderProcessor.CalculateDiscount(order);
    Assert.Equal(15, discount);
}
```

#### Salida de Cobertura de Código

Apuntar a un **90% o más de cobertura** garantiza que todas las rutas principales del código, como `CalculateDiscount`, `IsHighValueCustomer` y `FilterHighValueOrders`, estén probadas.

### Ejecución de Pruebas

Ejecute el siguiente comando para ejecutar las pruebas:
```bash
dotnet test
```

---

# XunitOrderApp

## Aperçu

`XunitOrderApp` est une application .NET Core conçue pour démontrer les meilleures pratiques en développement logiciel avec des tests unitaires utilisant xUnit et Moq. Le projet se concentre sur le traitement des commandes avec une logique pour calculer les remises, identifier les clients importants et filtrer les commandes importantes. Il comprend des tests robustes qui valident la fonctionnalité et garantissent la fiabilité du code.

![Alt Code Coverage](https://github.com/JCGaytan/XunitOrderApp/blob/master/SS%20CodeCoverage.png)

## Fonctionnalités

1. **Traitement des Commandes** :
   - Calculer les remises en fonction du montant total.
   - Identifier les clients importants.
   - Filtrer les commandes importantes.

2. **Tests Unitaires** :
   - Utilise xUnit pour créer et exécuter des tests unitaires.
   - Inclut des cas de test basés sur des données et des objets simulés.

3. **Couverture du Code** :
   - Garantit que tous les chemins critiques sont testés, réduisant les bogues en production.

## Structure du Projet

```
XunitOrderApp/
    Order.cs
    OrderProcessor.cs
XunitOrderApp.Tests/
    OrderProcessorTests.cs
    TestData/ComplexOrders.json
```

### Fichiers Clés

- **Order.cs** : Définit la classe `Order` avec les propriétés `OrderId`, `CustomerName` et `TotalAmount`.
- **OrderProcessor.cs** : Contient les méthodes pour la logique métier : `CalculateDiscount`, `IsHighValueCustomer` et `FilterHighValueOrders`.
- **OrderProcessorTests.cs** : Comprend des tests unitaires pour valider les fonctionnalités de `OrderProcessor`.
- **TestData/ComplexOrders.json** : Fournit des données complexes pour les tests.

## Avantages des Tests Unitaires et de la Couverture de Code

### Avantages des Tests Unitaires

1. **Amélioration de la Qualité du Code** : Garantit que toutes les fonctionnalités se comportent comme prévu.
2. **Détection Précoce des Bogues** : Identifie les problèmes pendant la phase de développement.
3. **Facilite la Refactorisation** : Permet de refactoriser en toute confiance sans crainte de casser les fonctionnalités.
4. **Documentation** : Sert de documentation vivante sur le comportement attendu du code.

### Avantages de la Couverture du Code

1. **Visibilité** : Montre quelles parties du code sont testées et lesquelles ne le sont pas.
2. **Réduction des Risques** : Une couverture élevée signifie moins de cas non testés.
3. **Amélioration de la Maintenabilité** : Les développeurs sont conscients des zones de code non testées.

### Exemple de Code

#### Test de `CalculateDiscount`

```csharp
[Fact]
public void CalculateDiscount_ShouldReturn10PercentForOrdersAbove100()
{
    var order = new Order { OrderId = 1, CustomerName = "John Doe", TotalAmount = 150 };
    var discount = _orderProcessor.CalculateDiscount(order);
    Assert.Equal(15, discount);
}
```

#### Sortie de Couverture du Code

Un objectif de **90% ou plus de couverture** garantit que tous les principaux chemins du code, tels que `CalculateDiscount`, `IsHighValueCustomer` et `FilterHighValueOrders`, sont testés.

### Exécution des Tests

Exécutez la commande suivante pour exécuter les tests :
```bash
dotnet test
