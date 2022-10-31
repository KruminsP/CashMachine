using CashMachineCore.Exceptions;
using CashMachineCore.Models;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CashMachineTests
{
    [TestClass]
    public class CalculatorTests
    {
        private CashMachine _machine;
        private Client _client;

        [TestInitialize]
        public void Setup()
        {
            _client = new Client("John Deere");
            _machine = new CashMachine(_client);
        }

        [TestMethod]
        public void Insert_InvalidAmount_ThrowsException()
        {
            int[] amount = { 2, 7 };

            Action act = () => _machine.Insert(amount);

            act.Should().Throw<InvalidAmountException>();
        }

        [TestMethod]
        public void Insert_ValidAmount_AddsMoney()
        {
            int[] amount = { 5, 20 };

            _machine.Insert(amount);

            _client.Balance.Should().Be(25);
        }

        [TestMethod]
        public void Withdraw_NotEnoughMoney_ThrowsException()
        {
            _client.Balance = 5;
            int amount = 10;

            Action act = () => _machine.Withdraw(amount);

            act.Should().Throw<InvalidBalanceException>();
        }

        [TestMethod]
        public void Withdraw_ValidBalance_ReturnsAmountWithdrawn()
        {
            _client.Balance = 100;
            int amount = 10;

            var result = _machine.Withdraw(amount);

            result.Should().Be(10);
            _client.Balance.Should().Be(90);
        }
    }
}