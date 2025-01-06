using Moq;
using System.Text.Json;

namespace XunitOrderApp.Tests
{
    public class OrderProcessorTests
    {
        private OrderProcessor _orderProcessor;

        public OrderProcessorTests()
        {
            _orderProcessor = new OrderProcessor();
        }

        [Fact]
        public void CalculateDiscount_ShouldReturn10PercentForOrdersAbove100()
        {
            var order = new Order { OrderId = 1, CustomerName = "John Doe", TotalAmount = 150 };
            var discount = _orderProcessor.CalculateDiscount(order);
            Assert.Equal(15, discount);
        }

        [Fact]
        public void IsHighValueCustomer_ShouldReturnTrueForOrdersAbove500()
        {
            var order = new Order { OrderId = 2, CustomerName = "Jane Doe", TotalAmount = 600 };
            var isHighValue = _orderProcessor.IsHighValueCustomer(order);
            Assert.True(isHighValue);
        }

        [Fact]
        public void FilterHighValueOrders_ShouldReturnOnlyHighValueOrders()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerName = "John", TotalAmount = 100 },
                new Order { OrderId = 2, CustomerName = "Jane", TotalAmount = 600 },
                new Order { OrderId = 3, CustomerName = "Alice", TotalAmount = 50 }
            };

            var highValueOrders = _orderProcessor.FilterHighValueOrders(orders);

            Assert.Single(highValueOrders);
            Assert.Equal("Jane", highValueOrders[0].CustomerName);
        }

        [Fact]
        public void FilterHighValueOrders_ComplexJsonData()
        {
            var jsonFilePath = "TestData/ComplexOrders.json";
            var jsonData = File.ReadAllText(jsonFilePath);
            var orders = JsonSerializer.Deserialize<List<Order>>(jsonData);

            var highValueOrders = _orderProcessor.FilterHighValueOrders(orders);

            Assert.NotNull(highValueOrders);
            Assert.Equal(1, highValueOrders.Count);
        }

        [Fact]
        public void CalculateDiscount_ManualMockingExample()
        {
            // Arrange
            var mockOrder = new Mock<Order>();
            mockOrder.Setup(o => o.TotalAmount).Returns(200);

            var orderProcessor = new OrderProcessor();

            // Act
            var discount = orderProcessor.CalculateDiscount(mockOrder.Object);

            // Assert
            Assert.Equal(20, discount);
        }

        [Fact]
        public void CalculateDiscount_ShouldReturnZeroForZeroAmount()
        {
            var order = new Order { OrderId = 3, CustomerName = "Test", TotalAmount = 0 };
            var discount = _orderProcessor.CalculateDiscount(order);
            Assert.Equal(0, discount);
        }

        [Fact]
        public void FilterHighValueOrders_ShouldReturnEmptyListForNoHighValueOrders()
        {
            var orders = new List<Order>
            {
                new Order { OrderId = 1, CustomerName = "John", TotalAmount = 100 },
                new Order { OrderId = 2, CustomerName = "Jane", TotalAmount = 200 }
            };

            var highValueOrders = _orderProcessor.FilterHighValueOrders(orders);

            Assert.Empty(highValueOrders);
        }

    }
}
