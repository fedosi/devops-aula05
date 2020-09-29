using System;
using Xunit;
using conversaotemperatura.Controllers;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace conversaotemperaturateste
{
    public class TesteConversaoTemperatura
    {

        private conversaotemperatura.Controllers.conversao service;
        private const double dblFatorKelvin = 273.15;

        public TesteConversaoTemperatura()
        {
            service = new conversaotemperatura.Controllers.conversao();

        }
        [Fact]
        public void Get_WhenCalled_ReturnsZeroCelsiusToZeroKelvin()
        {
            // Act
            var okResult = service.Get("C","0","K");

            // Assert
            Assert.True(Math.Abs(Convert.ToDouble(okResult.ValorDestino)).Equals(dblFatorKelvin));
            
        }

        [Fact]
        public void Get_WhenCalled_ReturnsZeroCelsiusToZeroKelvinFailure()
        {
            // Act
            var okResult = service.Get("K", "-273,15", "C");
          
            // Assert
           Assert.False(Convert.ToDouble(okResult.ValorDestino).Equals(dblFatorKelvin));
        }


        [Theory]
        [InlineData("C","100","K")]
        // [InlineData("K","373,15","C")]
        [InlineData("C", "-1", "K")]
        public void Get_WhenCalled_ReturnsConversaoSucesso(string _unidadeorigem, string _valororigem, string _unidadedestino)
        {
            // Act
            var okResult = service.Get(_unidadeorigem, _valororigem, _unidadedestino);
 
            // Assert
           double resultado = Convert.ToDouble(okResult.ValorDestino) - Convert.ToDouble(okResult.ValorOrigem);
           Assert.True(Math.Abs(resultado).Equals(dblFatorKelvin));           
                  
        }
    }

}
