using CashMachineCore.Validations;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CashMachineTests
{
    [TestClass]
    public class ValidationTests
    {
        [TestMethod]
        public void AmountValidation_InvalidAmount_ReturnsFalse()
        {
            var amount = 0;

            var result = AmountValidator.IsValid(amount);

            result.Should().BeFalse();
        }

        [TestMethod]
        public void AmountValidation_ValidAmount_ReturnsTrue()
        {
            var amount = 5;

            var result = AmountValidator.IsValid(amount);

            result.Should().BeTrue();
        }

        [TestMethod]
        public void NoteValidation_InvalidAmount_ReturnsFalse()
        {
            var amount = 0;

            var result = NoteValidator.IsValid(amount);

            result.Should().BeFalse();
        }

        [TestMethod]
        public void NoteValidation_ValidAmount_ReturnsTrue()
        {
            var amount = 20;

            var result = NoteValidator.IsValid(amount);

            result.Should().BeTrue();
        }
    }
}