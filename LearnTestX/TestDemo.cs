using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnTestX
{
	public class Calculator
	{
		public int Add(int a, int b)
		{
			return a + b;
		}
		public int Subtract(int a, int b)
		{
			return a - b;
		}
		public int Multiply(int a, int b)
		{
			return a * b;
		}
		public double Divide(int a, int b)
		{
			if (b == 0)
				throw new DivideByZeroException("Cannot divide by zero.");
			return (double)a / b;
		}
	}
	public class TestDemo
	{
		[Fact]
		public void Add_ReturnCorrectSum()
		{
			// Arrange
			var calculator = new Calculator();
			int a = 5;
			int b = 3;
			// Act
			int result = calculator.Add(a, b);
			// Assert
			Assert.Equal(8, result);
		}
		[Fact]
		public void Subtract_ReturnCorrectDifference()
		{
			// Arrange
			var calculator = new Calculator();
			int a = 5;
			int b = 3;
			// Act
			int result = calculator.Subtract(a, b);
			// Assert
			Assert.Equal(2, result);
		}
		[Fact]
		public void Subtract_ReturnCorrectDifference_Negative()
		{
			// Arrange
			var calculator = new Calculator();
			int a = 0;
			int b = 5;
			// Act
			int result = calculator.Subtract(a, b);
			// Assert
			Assert.Equal(-5, result);
		}
		[Theory]
		[InlineData(10, 2,20)]
		[InlineData(9, 3, 27 )]
		[InlineData(8, 4, 32)]
		public void Multiply_ReturnResult(int a,int b, int expceted)
		{
			// Arrange
			var calculator = new Calculator();
			// Act
			int result = calculator.Multiply(a, b);
			// Assert
			Assert.Equal(expceted, result);
		}

	}
}
