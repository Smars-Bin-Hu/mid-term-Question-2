
using System.Diagnostics;

namespace LaptopDiscountTest;

public class Tests
{
    private EmployeeDiscount _employeeDiscount;

    [SetUp]
    public void Setup()
    {
        _employeeDiscount = new EmployeeDiscount();
    }

    // Test Cases for Property - EmployeeType
    [TestCase(EmployeeType.FullTime)]
    public void EmployeeType_Test(EmployeeType type)
    {
        // Assign
        // the value of this test case is already assigned in the ProductID_Test method argument

        // Act
        _employeeDiscount.EmployeeType = type;

        // Assert
        Assert.That(_employeeDiscount.EmployeeType, Is.EqualTo(type));
    }

    // Test Cases for Property - Price
    [TestCase(90)]
    public void Price_Test(decimal price)
    {
        // Assign
        // the value of this test case is already assigned in the ProductID_Test method argument

        // Act
        _employeeDiscount.Price = price;

        // Assert
        Assert.That(_employeeDiscount.Price, Is.EqualTo(price));
    }

    // Test Cases for CalculateDiscountedPrice()
    [TestCase(EmployeeType.FullTime, 90)] // Test Case I: For Full Time Employee Testing - 10% discount
    [TestCase(EmployeeType.PartTime, 100)] // Test Case II: For Part Time Employee Testing - No discount
    [TestCase(EmployeeType.PartialLoad, 95)] // Test Case III: For PartialLoad Employee Testing - 5% discount
    [TestCase(EmployeeType.CompanyPurchasing, 80)] // Test Case IV: For CompanyPurchasing Employee Testing - 20% discount
    public void Employee_Test(EmployeeType type, decimal fianlPrice)
    {
        // Assign
        _employeeDiscount.Price = 100;
        _employeeDiscount.EmployeeType = type;

        // Act
        _employeeDiscount.Price = _employeeDiscount.CalculateDiscountedPrice();

        // Assert
        Assert.That(_employeeDiscount.Price, Is.EqualTo(fianlPrice));
    }
}
